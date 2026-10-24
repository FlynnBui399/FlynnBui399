"""Build the X-ray / DICOM themed SVGs used by the profile README.

Edit the CONTENT section, then run from the repo root:

    python scripts/build_svgs.py

Output goes to assets/xray/. contrib.svg pulls your contribution calendar through
the GitHub CLI (`gh auth login` first); rerun the script to refresh it. Fonts (IBM Plex Mono, OFL) are embedded into every
SVG because GitHub blocks external resources inside images.
"""

import base64
import io
import json
import math
import random
import subprocess
from datetime import date
from html import escape
from pathlib import Path

from PIL import Image, ImageOps

ROOT = Path(__file__).resolve().parent.parent
OUT = ROOT / "assets" / "xray"
FONTS = Path(__file__).resolve().parent / "fonts"

# ── Palette ──────────────────────────────────────────────────────────────────
FILM, PANEL, LINE = "#0A0F14", "#0F161D", "#1D2A33"
TEXT, MUTED, AMBER = "#D8E6EE", "#7F98A6", "#FFB000"

# ── CONTENT ──────────────────────────────────────────────────────────────────
# Keep to ASCII + latin punctuation (· — – • ›): the embedded font is the latin subset.
NAME = "BUI TRAN TAN PHAT"
DICOM_NAME = "BUI^TRAN TAN PHAT"
PATIENT_ID = "FLYNNBUI399"  # shown as PT ID / REF; keep it non-personal
TAGLINE = "AI ENGINEERING STUDENT — VISION · RETRIEVAL · MEDICAL IMAGING"
STATUS = "STATUS  OPEN TO INTERNSHIPS"

REPORT = {
    "CLINICAL INFO": [
        "AI Engineering student at HCMUTE (B.E. IT, AI specialization).",
        "GPA 3.42 / 4.0 · expected graduation 08/2027.",
    ],
    "FINDINGS": [
        "• Strong signal in computer vision and medical image analysis.",
        "• Active development in GenAI: RAG systems, LLM APIs, VLMs.",
        "• Works end to end: data prep › training › evaluation › apps.",
    ],
    "IMPRESSION": [
        "Curious, practical engineer. Open to AI / GenAI internships.",
    ],
}
FOOTER = "END OF STUDY · 4 SERIES · THANK YOU FOR VIEWING"
QUOTE = '"Instead of artificial intelligence, we\'ll augment our intelligence."'

STACK = [
    ("(0010,0010)", "LO", "LANGUAGES", "Python · C++ · C# · Java"),
    ("(0018,0015)", "LO", "ML / DL", "PyTorch · scikit-learn · LightGBM · Transformers"),
    ("(0018,1030)", "LO", "VISION", "OpenCV · UNet++ · EfficientNet · Qwen2.5-VL"),
    ("(0020,000D)", "UI", "RETRIEVAL", "Qdrant · ChromaDB · pgvector · bge-m3"),
    ("(0028,0030)", "DS", "DATA", "Pandas · NumPy · Matplotlib · Seaborn"),
    ("(0040,0254)", "LO", "INFRA", "Modal · AWS · PostgreSQL · MySQL · Git"),
]

PROJECTS = [
    {
        "slug": "vidruglens", "title": "VIDRUGLENS", "motif": "blister",
        "desc": ["Vietnamese drug-package understanding:",
                 "OCR + Qwen2.5-VL extraction with an agreement",
                 "check, grounded answers via Qdrant RAG."],
        "metrics": [("OCR->VLM->RAG", "PIPELINE")],
        "tags": ["PYTHON", "VLM", "RAG"],
    },
    {
        "slug": "ham10000", "title": "SKIN-LESION CLS", "motif": "lesion",
        "desc": ["~30 handcrafted visual features fused with",
                 "clinical metadata on heavily imbalanced",
                 "HAM10000, tuned LightGBM."],
        "metrics": [("0.946", "OVR ROC-AUC"), ("0.807", "ACCURACY")],
        "tags": ["LIGHTGBM", "OPENCV"],
    },
    {
        "slug": "retina", "title": "RETINAL VESSEL SEG", "motif": "vessels",
        "desc": ["High-resolution micro-vessel segmentation",
                 "on HRF: UNet++ decoder with an",
                 "EfficientNet-B4 encoder."],
        "metrics": [("0.964", "ACCURACY"), ("0.771", "DICE")],
        "tags": ["PYTORCH", "SEGMENTATION"],
    },
    {
        "slug": "vigoemotions", "title": "VIGOEMOTIONS", "motif": "wave",
        "desc": ["Reproduces and extends an EACL 2026 paper:",
                 "ViSoBERT multi-label baseline + Emoji2Vec",
                 "dual-encoder fusion, trained on Modal A100."],
        "metrics": [("28", "EMOTION LABELS"), ("EACL'26", "REPRODUCTION")],
        "tags": ["TRANSFORMERS", "PYTORCH"],
    },
]

SECTIONS = [
    ("01", "ABOUT", "RADIOLOGY REPORT"),
    ("02", "TECH STACK", "DICOM TAG DUMP"),
    ("03", "PROJECTS", "4 IMAGES"),
    ("04", "ACTIVITY", "LONGITUDINAL STUDY"),
]

BUTTONS = [
    ("linkedin", "LINKEDIN", False),
    ("portfolio", "PORTFOLIO", False),
    ("resume", "RESUME", True),
]


# ── Helpers ──────────────────────────────────────────────────────────────────
def _b64(path: Path) -> str:
    return base64.b64encode(path.read_bytes()).decode()


FONT_CSS = (
    "@font-face{font-family:'Plex';font-weight:400;"
    f"src:url(data:font/woff2;base64,{_b64(FONTS / 'plex-mono-400.woff2')}) format('woff2')}}"
    "@font-face{font-family:'Plex';font-weight:500;"
    f"src:url(data:font/woff2;base64,{_b64(FONTS / 'plex-mono-500.woff2')}) format('woff2')}}"
)

BASE_CSS = (
    f"text{{font-family:'Plex',ui-monospace,Menlo,Consolas,monospace;fill:{TEXT}}}"
    f".m{{fill:{MUTED}}}.a{{fill:{AMBER}}}.b{{font-weight:500}}"
    "@keyframes blink{50%{opacity:0}}.blink{animation:blink 1.1s steps(1) infinite}"
    "@keyframes march{to{stroke-dashoffset:-24}}.ants{animation:march 1.2s linear infinite}"
)


def svg(w, h, body, title, extra_css=""):
    return (
        f'<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" '
        f'width="{w}" height="{h}" viewBox="0 0 {w} {h}" role="img">'
        f"<title>{escape(title)}</title>"
        f"<style>{FONT_CSS}{BASE_CSS}{extra_css}</style>{body}</svg>"
    )


def t(x, y, s, size=16, cls="", anchor="start", extra=""):
    c = f' class="{cls}"' if cls else ""
    a = f' text-anchor="{anchor}"' if anchor != "start" else ""
    return f'<text x="{x}" y="{y}" font-size="{size}"{c}{a}{extra}>{escape(s)}</text>'


def brackets(x, y, w, h, n=16, color=AMBER, sw=2):
    """Viewfinder corner brackets around a box."""
    p = (f"M{x},{y+n}V{y}H{x+n} M{x+w-n},{y}H{x+w}V{y+n} "
         f"M{x+w},{y+h-n}V{y+h}H{x+w-n} M{x+n},{y+h}H{x}V{y+h-n}")
    return f'<path d="{p}" fill="none" stroke="{color}" stroke-width="{sw}"/>'


def ruler(x0, x1, y, up=True):
    d = -1 if up else 1
    parts = []
    for i, x in enumerate(range(x0, x1 + 1, 10)):
        ln = 12 if i % 10 == 0 else (7 if i % 5 == 0 else 4)
        parts.append(f"M{x},{y}v{d*ln}")
    return f'<path d="{" ".join(parts)}" stroke="{LINE}" stroke-width="1"/>'


def frame(w, h):
    return (f'<rect width="{w}" height="{h}" fill="{FILM}"/>'
            f'<rect x="0.5" y="0.5" width="{w-1}" height="{h-1}" fill="none" stroke="{LINE}"/>')


def vessel_tree(cx, cy, r, seed, start=None, opacity=0.55):
    """Procedural retina-like vessel branches, clipped by the caller."""
    rnd = random.Random(seed)
    paths = []

    def grow(x, y, ang, length, width, depth):
        if depth == 0 or width < 0.6:
            return
        nx = x + math.cos(ang) * length
        ny = y + math.sin(ang) * length
        bend = rnd.uniform(-0.5, 0.5)
        mx = (x + nx) / 2 + math.cos(ang + math.pi / 2) * length * bend * 0.3
        my = (y + ny) / 2 + math.sin(ang + math.pi / 2) * length * bend * 0.3
        paths.append(
            f'<path d="M{x:.1f},{y:.1f}Q{mx:.1f},{my:.1f} {nx:.1f},{ny:.1f}" '
            f'stroke-width="{width:.2f}"/>')
        for da in (rnd.uniform(0.25, 0.6), -rnd.uniform(0.25, 0.6)):
            grow(nx, ny, ang + da, length * rnd.uniform(0.62, 0.8), width * 0.7, depth - 1)

    sx, sy = start or (cx + r * 0.32, cy - r * 0.08)
    for k in range(6):
        grow(sx, sy, k * math.pi / 3 + rnd.uniform(-0.3, 0.3), r * 0.42, 3.2, 6)
    return (f'<g fill="none" stroke="{MUTED}" stroke-linecap="round" opacity="{opacity}">'
            f'{"".join(paths)}</g>'), (sx, sy)


# ── Pieces ───────────────────────────────────────────────────────────────────
def build_header():
    W, H = 1200, 420
    cx, cy, r = 905, 236, 122
    vessels, (dx, dy) = vessel_tree(cx, cy, r, seed=399)
    grid = "".join(f'<path d="M{x},24V{H-24}" />' for x in range(60, W, 60)) + \
           "".join(f'<path d="M24,{y}H{W-24}" />' for y in range(60, H, 60))
    css = ("@keyframes scan{from{transform:translateY(28px)}to{transform:translateY(392px)}}"
           ".scan{animation:scan 6s linear infinite}")
    body = [
        frame(W, H),
        f'<g stroke="{PANEL}" stroke-width="1">{grid}</g>',
        # fundus
        f'<defs><clipPath id="eye"><circle cx="{cx}" cy="{cy}" r="{r}"/></clipPath></defs>',
        f'<circle cx="{cx}" cy="{cy}" r="{r}" fill="{PANEL}" stroke="{LINE}" stroke-width="2"/>',
        f'<g clip-path="url(#eye)">{vessels}'
        f'<circle cx="{dx}" cy="{dy}" r="20" fill="{FILM}" stroke="{MUTED}" stroke-width="1.5" opacity=".9"/></g>',
        f'<circle cx="{cx - 40}" cy="{cy + 10}" r="9" fill="none" stroke="{LINE}" stroke-width="2"/>',
        f'<rect x="{cx - 120}" y="{cy + 18}" width="92" height="72" fill="none" stroke="{AMBER}" '
        f'stroke-width="1.5" stroke-dasharray="6 6" class="ants"/>',
        t(cx - 120, cy + 108, "ROI 01 · DICE .771", 13, "a"),
        # crosshair on fundus
        f'<path d="M{cx},{cy - r - 14}v10 M{cx},{cy + r + 4}v10 M{cx - r - 14},{cy}h10 M{cx + r + 4},{cy}h10" '
        f'stroke="{AMBER}" stroke-width="1.5"/>',
        # corner overlays
        t(44, 58, "PT NAME", 14, "m") + t(150, 58, DICOM_NAME, 14),
        t(44, 80, "PT ID", 14, "m") + t(150, 80, PATIENT_ID, 14),
        t(44, 102, "STUDY", 14, "m") + t(150, 102, "AI ENGINEERING · HCMUTE", 14),
        t(W - 44, 58, "HO CHI MINH CITY · VN", 14, "m", "end"),
        t(W - 44, 80, "SERIES 2026 · IMG 001/399", 14, "m", "end"),
        t(W - 44, 102, "MODALITY CV / VLM / RAG", 14, "m", "end"),
        t(44, H - 64, "W:1600  L:400", 14, "m"),
        t(44, H - 42, "512 x 512 · 1.0 mm", 14, "m"),
        t(W - 44, H - 42, STATUS, 14, anchor="end"),
        f'<circle cx="{W - 44 - len(STATUS) * 8.4 - 14:.0f}" cy="{H - 47}" r="5" fill="{AMBER}" class="blink"/>',
        # name block
        brackets(56, 152, 640, 128, 18),
        t(84, 222, NAME, 52, "b"),
        t(86, 256, TAGLINE, 14, "m"),
        f'<rect x="{86 + len(TAGLINE) * 8.4 + 6}" y="244" width="9" height="15" fill="{AMBER}" class="blink"/>',
        # scale bar
        f'<path d="M44,{H - 96}h120 M44,{H - 101}v10 M164,{H - 101}v10" stroke="{AMBER}" stroke-width="1.5"/>',
        t(172, H - 92, "10 mm", 12, "a"),
        # scanline
        f'<g class="scan"><rect x="12" y="0" width="{W - 24}" height="2" fill="{AMBER}" opacity=".35"/>'
        f'<rect x="12" y="-18" width="{W - 24}" height="18" fill="{AMBER}" opacity=".05"/></g>',
    ]
    return svg(W, H, "".join(body), f"{NAME} — {TAGLINE}", css)


def build_section(no, name, note):
    # Film-strip bar with its own background so it reads on light and dark GitHub themes
    W, H = 1200, 64
    body = [
        f'<rect width="{W}" height="{H}" fill="{FILM}"/>',
        t(24, 32, f"SE {no}", 20, "a b"),
        t(102, 32, f"/ {name}", 20, "b"),
        t(W - 24, 32, note, 14, "m", "end"),
        f'<path d="M0,46H{W}" stroke="{LINE}"/>',
        ruler(0, W, 46, up=False),
    ]
    return svg(W, H, "".join(body), f"Series {no}: {name}")


def avatar_b64(w, h):
    src = ROOT / "assets" / "avt.jpg"
    img = Image.open(src).convert("L")
    img = ImageOps.fit(img, (w * 2, h * 2), centering=(0.5, 0.35))
    img = ImageOps.autocontrast(img, cutoff=1)
    # film tint: map black→film, white→pale blue-grey
    img = ImageOps.colorize(img, black=FILM, white="#E6F0F5")
    buf = io.BytesIO()
    img.save(buf, "JPEG", quality=78, optimize=True)
    return base64.b64encode(buf.getvalue()).decode()


def build_report():
    W, H = 1200, 470
    ax, ay, aw, ah = 44, 92, 250, 300
    body = [
        frame(W, H),
        f'<rect x="1" y="1" width="{W - 2}" height="52" fill="{PANEL}"/>',
        f'<path d="M0,53H{W}" stroke="{LINE}"/>',
        t(44, 34, "RADIOLOGY REPORT", 16, "a b"),
        t(250, 34, f"REF {PATIENT_ID} · {DICOM_NAME}", 14, "m"),
        t(W - 44, 34, "SIGNED  B.T.T. PHAT", 14, "m", "end"),
        f'<image x="{ax}" y="{ay}" width="{aw}" height="{ah}" '
        f'xlink:href="data:image/jpeg;base64,{avatar_b64(aw, ah)}" preserveAspectRatio="xMidYMid slice"/>',
        brackets(ax - 8, ay - 8, aw + 16, ah + 16, 18),
        t(ax, ay + ah + 34, "FIG.1  SUBJECT · AP VIEW", 13, "m"),
    ]
    x, y = 350, 104
    for label, lines in REPORT.items():
        body.append(t(x, y, label, 15, "a b"))
        y += 30
        for ln in lines:
            body.append(t(x, y, ln, 18))
            y += 28
        y += 18
    body.append(f'<rect x="{x + len(REPORT["IMPRESSION"][-1]) * 10.8 + 8}" y="{y - 64}" '
                f'width="10" height="20" fill="{AMBER}" class="blink"/>')
    body.append(f'<path d="M{x},{H - 58}H{W - 44}" stroke="{LINE}"/>')
    body.append(t(x, H - 30, QUOTE, 14, "m"))
    return svg(W, H, "".join(body), "About: " + " ".join(sum(REPORT.values(), [])))


def build_stack():
    W = 1200
    row_h, top = 40, 92
    H = top + row_h * len(STACK) + 36
    cols = (44, 210, 280, 470)
    body = [
        frame(W, H),
        t(cols[0], 52, "TAG", 14, "m"), t(cols[1], 52, "VR", 14, "m"),
        t(cols[2], 52, "ATTRIBUTE", 14, "m"), t(cols[3], 52, "VALUE", 14, "m"),
        f'<path d="M44,66H{W - 44}" stroke="{LINE}"/>',
    ]
    for i, (tag, vr, attr, val) in enumerate(STACK):
        y = top + i * row_h
        if i % 2 == 0:
            body.append(f'<rect x="32" y="{y - 26}" width="{W - 64}" height="{row_h}" fill="{PANEL}"/>')
        body += [t(cols[0], y, tag, 17, "m"), t(cols[1], y, vr, 17, "a"),
                 t(cols[2], y, attr, 17, "b"), t(cols[3], y, val, 17)]
    return svg(W, H, "".join(body),
               "Tech stack: " + "; ".join(f"{a}: {v}" for _, _, a, v in STACK))


def motif(kind, x, y, w, h, seed):
    """Faint background illustration on the right side of a project card."""
    if kind == "vessels":
        cx, cy, r = x + w / 2, y + h / 2, min(w, h) / 2
        v, _ = vessel_tree(cx, cy, r, seed, start=(cx, cy), opacity=0.35)
        return (f'<clipPath id="c{seed}"><circle cx="{cx}" cy="{cy}" r="{r}"/></clipPath>'
                f'<circle cx="{cx}" cy="{cy}" r="{r}" fill="none" stroke="{LINE}" stroke-width="2"/>'
                f'<g clip-path="url(#c{seed})">{v}</g>')
    if kind == "lesion":
        rnd = random.Random(seed)
        cx, cy, r = x + w / 2, y + h / 2, min(w, h) * 0.36
        pts = []
        for k in range(28):
            a = k / 28 * 2 * math.pi
            rr = r * (1 + 0.18 * math.sin(3 * a + 1) + rnd.uniform(-0.07, 0.07))
            pts.append(f"{cx + rr * math.cos(a):.1f},{cy + rr * math.sin(a):.1f}")
        inner = [f"{cx + 0.45 * (float(p.split(',')[0]) - cx):.1f},"
                 f"{cy + 0.45 * (float(p.split(',')[1]) - cy):.1f}" for p in pts]
        return (f'<polygon points="{" ".join(pts)}" fill="none" stroke="{MUTED}" stroke-width="1.5" opacity=".45"/>'
                f'<polygon points="{" ".join(inner)}" fill="{MUTED}" opacity=".12"/>'
                f'<rect x="{cx - r * 1.3:.0f}" y="{cy - r * 1.3:.0f}" width="{r * 2.6:.0f}" height="{r * 2.6:.0f}" '
                f'fill="none" stroke="{AMBER}" stroke-width="1.2" stroke-dasharray="6 6" class="ants" opacity=".8"/>')
    if kind == "blister":
        cells = []
        for i in range(2):
            for j in range(4):
                cx, cy = x + 30 + i * 70, y + 22 + j * 46
                cells.append(f'<rect x="{cx}" y="{cy}" width="52" height="30" rx="15" fill="none" '
                             f'stroke="{MUTED}" stroke-width="1.5" opacity=".4"/>')
        return (f'<rect x="{x + 10}" y="{y + 4}" width="160" height="196" rx="10" fill="none" '
                f'stroke="{LINE}" stroke-width="2"/>' + "".join(cells) +
                f'<rect x="{x + 24}" y="{y + 62}" width="132" height="44" fill="none" stroke="{AMBER}" '
                f'stroke-width="1.2" stroke-dasharray="6 6" class="ants" opacity=".8"/>')
    if kind == "wave":
        rnd = random.Random(seed)
        bars = []
        for k in range(28):
            bh = 8 + abs(math.sin(k * 0.55)) * 70 * rnd.uniform(0.5, 1)
            bx = x + 8 + k * 6.4
            bars.append(f'<rect x="{bx:.1f}" y="{y + h / 2 - bh / 2:.1f}" width="3" height="{bh:.1f}" '
                        f'fill="{AMBER if k in (9, 10, 11) else MUTED}" opacity="{.9 if k in (9, 10, 11) else .35}"/>')
        return "".join(bars)
    return ""


def build_card(i, p):
    W, H = 600, 340
    body = [
        frame(W, H),
        t(28, 40, f"IMG {i + 1:02d}/{len(PROJECTS):02d}", 14, "a b"),
        t(W - 28, 40, "SE 03 · PROJECTS", 13, "m", "end"),
        f'<path d="M28,54H{W - 28}" stroke="{LINE}"/>',
        motif(p["motif"], 404, 76, 172, 190, seed=i + 7),
        t(28, 98, p["title"], 26, "b"),
    ]
    y = 132
    for ln in p["desc"]:
        body.append(t(28, y, ln, 13, "m"))
        y += 22
    mx = 28
    for val, label in p["metrics"]:
        size = 34 if len(val) <= 7 else 22
        body.append(t(mx, 262, val, size, "a b"))
        body.append(t(mx, 284, label, 12, "m"))
        mx += max(len(val) * size * 0.62, len(label) * 7.4) + 34
    tx = 28
    for tag in p["tags"]:
        tw = len(tag) * 7.6 + 18
        body.append(f'<rect x="{tx}" y="{H - 38}" width="{tw:.0f}" height="22" fill="none" stroke="{LINE}"/>')
        body.append(t(tx + 9, H - 22, tag, 12))
        tx += tw + 8
    body.append(t(W - 28, H - 22, "OPEN ›", 13, "a", "end"))
    return svg(W, H, "".join(body), f'{p["title"]}: {" ".join(p["desc"])}')


def build_button(label, filled):
    W, H = 200, 44
    fg = FILM if filled else TEXT
    body = [
        f'<rect x="0.5" y="0.5" width="{W - 1}" height="{H - 1}" fill="{AMBER if filled else FILM}" stroke="{AMBER if filled else LINE}"/>',
        t(W / 2, 28, f"[ {label} ]", 15, "b", "middle", f' style="fill:{fg}"'),
    ]
    if not filled:
        body.append(f'<rect x="14" y="19" width="6" height="6" fill="{AMBER}"/>')
    return svg(W, H, "".join(body), label)


def build_footer():
    W, H = 1200, 90
    body = [
        f'<rect width="{W}" height="{H}" fill="{FILM}"/>',
        f'<path d="M0,20H{W}" stroke="{LINE}"/>', ruler(0, W, 20, up=False),
        t(W / 2, 64, FOOTER, 15, "m", "middle"),
        f'<rect x="{W / 2 + len(FOOTER) * 4.5 + 6:.0f}" y="52" width="9" height="15" fill="{AMBER}" class="blink"/>',
    ]
    return svg(W, H, "".join(body), "End of study — thank you for viewing")


GITHUB_LOGIN = "FlynnBui399"
CONTRIB_QUERY = """query($login:String!){user(login:$login){contributionsCollection{
contributionCalendar{totalContributions weeks{contributionDays{date contributionCount contributionLevel}}}}}}"""
LEVEL_FILL = {"NONE": PANEL, "FIRST_QUARTILE": "#3D2E06", "SECOND_QUARTILE": "#7A5800",
              "THIRD_QUARTILE": "#C08600", "FOURTH_QUARTILE": AMBER}


def fetch_contributions():
    """Last-year contribution calendar via the GitHub CLI (needs `gh auth login`)."""
    res = subprocess.run(
        ["gh", "api", "graphql", "-f", f"query={CONTRIB_QUERY}", "-F", f"login={GITHUB_LOGIN}"],
        capture_output=True, text=True, check=True, encoding="utf-8")
    cal = json.loads(res.stdout)["data"]["user"]["contributionsCollection"]["contributionCalendar"]
    return cal["totalContributions"], [w["contributionDays"] for w in cal["weeks"]]


def build_contrib(total, weeks):
    days = [d for w in weeks for d in w]
    longest = run = 0
    for d in days:
        run = run + 1 if d["contributionCount"] else 0
        longest = max(longest, run)
    peak = max(days, key=lambda d: d["contributionCount"])
    peak_col = next(i for i, w in enumerate(weeks) if peak in w)

    W, H = 1200, 300
    gx, gy, pitch, cell = 300, 112, 16, 12
    grid_w = len(weeks) * pitch
    css = (f"@keyframes sweep{{from{{transform:translateX(0)}}to{{transform:translateX({grid_w}px)}}}}"
           ".sweep{animation:sweep 7s linear infinite}")
    body = [
        frame(W, H),
        f'<rect x="1" y="1" width="{W - 2}" height="52" fill="{PANEL}"/>',
        f'<path d="M0,53H{W}" stroke="{LINE}"/>',
        t(44, 34, "CONTRIBUTION SCAN", 16, "a b"),
        t(260, 34, f"{days[0]['date']} – {days[-1]['date']} · {len(weeks)} WEEKS", 14, "m"),
        t(W - 44, 34, f"SOURCE GITHUB GRAPHQL · BUILT {date.today().isoformat()}", 14, "m", "end"),
        # readouts
        t(44, 136, str(total), 44, "a b"),
        t(44, 158, "CONTRIBUTIONS / 12 MO", 12, "m"),
        t(44, 204, f"{longest} D", 26, "b"),
        t(44, 224, "LONGEST STREAK", 12, "m"),
        t(44, 266, f"{peak['contributionCount']} · {peak['date']}", 15, "b"),
        t(44, 284, "PEAK DAY", 12, "m"),
    ]
    for label, row in (("MON", 1), ("WED", 3), ("FRI", 5)):
        body.append(t(gx - 12, gy + row * pitch + 10, label, 11, "m", "end"))
    last_month, last_label = None, -9
    for i, w in enumerate(weeks):
        month = w[-1]["date"][5:7]  # label a week by the month it ends in
        if month != last_month:
            if i - last_label >= 3 and i < len(weeks) - 2:
                body.append(t(gx + i * pitch, gy - 12,
                              date.fromisoformat(w[-1]["date"]).strftime("%b").upper(), 11, "m"))
                last_label = i
            last_month = month
        for d in w:
            row = date.fromisoformat(d["date"]).isoweekday() % 7  # Sunday = 0, like GitHub
            fill = LEVEL_FILL[d["contributionLevel"]]
            stroke = f' stroke="{LINE}"' if d["contributionLevel"] == "NONE" else ""
            body.append(f'<rect x="{gx + i * pitch}" y="{gy + row * pitch}" width="{cell}" height="{cell}" '
                        f'fill="{fill}"{stroke}/>')
    # ROI around the peak week, then the sweeping scan line
    rx = gx + peak_col * pitch - 4
    body += [
        f'<rect x="{rx}" y="{gy - 4}" width="{cell + 8}" height="{7 * pitch + 4}" fill="none" '
        f'stroke="{AMBER}" stroke-width="1.5" stroke-dasharray="6 6" class="ants"/>',
        t(min(rx, gx + grid_w - 110), gy + 7 * pitch + 22, "ROI · PEAK WEEK", 12, "a"),
        f'<g class="sweep"><rect x="{gx - 2}" y="{gy - 8}" width="2" height="{7 * pitch + 12}" '
        f'fill="{AMBER}" opacity=".55"/></g>',
    ]
    lx = gx + grid_w - 5 * pitch
    body.append(t(lx - 10, H - 22, "LESS", 11, "m", "end"))
    for k, fill in enumerate(LEVEL_FILL.values()):
        body.append(f'<rect x="{lx + k * pitch}" y="{H - 33}" width="{cell}" height="{cell}" fill="{fill}" '
                    f'stroke="{LINE}"/>')
    body.append(t(lx + 5 * pitch + 4, H - 22, "MORE", 11, "m"))
    return svg(W, H, "".join(body),
               f"{total} contributions in the last year; longest streak {longest} days; "
               f"peak {peak['contributionCount']} on {peak['date']}", css)


def main():
    OUT.mkdir(parents=True, exist_ok=True)
    files = {"header.svg": build_header(), "report.svg": build_report(),
             "stack.svg": build_stack(), "footer.svg": build_footer()}
    try:
        files["contrib.svg"] = build_contrib(*fetch_contributions())
    except (OSError, subprocess.CalledProcessError, KeyError) as e:
        print(f"! contrib.svg skipped (gh not available or not logged in): {e}")
    for no, name, note in SECTIONS:
        files[f"se{no}.svg"] = build_section(no, name, note)
    for i, p in enumerate(PROJECTS):
        files[f"card-{p['slug']}.svg"] = build_card(i, p)
    for slug, label, filled in BUTTONS:
        files[f"btn-{slug}.svg"] = build_button(label, filled)
    for name, content in files.items():
        (OUT / name).write_text(content, encoding="utf-8")
        print(f"{name:28s} {len(content) / 1024:6.1f} KB")


if __name__ == "__main__":
    main()
