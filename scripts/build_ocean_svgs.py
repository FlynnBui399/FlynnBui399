"""Build the deep-dive ocean SVGs used by the profile README.

Edit the CONTENT section, then run from the repo root:

    python scripts/build_ocean_svgs.py

Output goes to assets/ocean/, and the README alt text for the about panel is kept in sync.
Pushing a change to this file also runs it on GitHub (.github/workflows/build-svgs.yml). Fonts (Outfit and IBM Plex Mono, both OFL) are embedded
into every SVG because GitHub blocks external resources inside images. Text is measured
with fontTools so wrapping and pill widths follow the real glyph widths.
"""

import base64
import re
from html import escape
from pathlib import Path

from fontTools.ttLib import TTFont

ROOT = Path(__file__).resolve().parent.parent
OUT = ROOT / "assets" / "ocean"
FONTS = Path(__file__).resolve().parent / "fonts"

# ── Palette ──────────────────────────────────────────────────────────────────
# Each zone is darker than the one above it, so the page reads as a dive.
SKY, SURFACE, TWILIGHT, MIDNIGHT, ABYSS = "#0B1F33", "#0F4C75", "#0B3558", "#082640", "#04121F"
CARD, CARD_LINE = "#0B3050", "#16466B"
TEXT, SOFT, MUTED = "#E6F6FB", "#C9E6F0", "#9CC3D5"
AQUA, CORAL, SKYBLUE, INK = "#5EEAD4", "#FF9B85", "#7DD3FC", "#03282B"
W = 880

# ── CONTENT ──────────────────────────────────────────────────────────────────
# Outfit ships as its latin subset: Vietnamese letters beyond Latin-1 (ồ, ế, đ, ...)
# have no glyph, and the build stops if one slips in.
NAME = "Bui Tran Tan Phat"
TAGLINE = "AI Engineering student focused on computer vision, vision-language models and RAG."
SKY_NOTE = "Ho Chi Minh City, Vietnam"
DIVE_LOG = [("School", "HCMUTE"), ("Expected graduation", "08/2027")]
STATUS = "open to internships"

ABOUT = ("I build practical AI workflows, from data preparation and model training to evaluation "
         "and retrieval-based apps. Strongest in computer vision and medical image analysis, now "
         "going deeper into RAG, LLM integration and vision-language models.")
BUBBLES = [("3.42", "GPA / 4.0"), ("2027", "graduating"), ("B.E. IT", "AI track")]
STACK = ["Python", "PyTorch", "ChromaDB", "PostgreSQL", "AWS"]

# Section label shown on each panel.
ZONES = {
    "surface": "Profile",
    "twilight": "About me",
    "midnight": "Projects",
    "abyss": "GitHub activity",
}

PROJECTS = [
    {
        "slug": "vidruglens", "art": "drug", "caption": "VLM · RAG · drug packages", "title": "ViDrugLens",
        "desc": "OCR and Qwen2.5-VL read Vietnamese drug packages, then Qdrant RAG answers "
                "with sources and safety warnings.",
        "metrics": [("Qwen2.5-VL", "reads the package"), ("Qdrant", "grounds the answer")],
    },
    {
        "slug": "skin-lesion", "art": "lesion", "caption": "Classification · dermoscopy, HAM10000",
        "title": "Skin-lesion classification",
        "desc": "~30 handcrafted visual features fused with clinical metadata on imbalanced "
                "HAM10000, tuned LightGBM.",
        "metrics": [("0.946", "OvR ROC-AUC"), ("0.807", "accuracy")],
    },
    {
        "slug": "retina", "art": "fundus", "caption": "Segmentation · retinal fundus, HRF",
        "title": "Retinal vessel segmentation",
        "desc": "High-resolution micro-vessel segmentation on HRF with a UNet++ decoder and an "
                "EfficientNet-B4 encoder.",
        "metrics": [("0.771", "Dice"), ("0.964", "accuracy")],
    },
    {
        "slug": "vigoemotions", "art": "chat", "caption": "NLP · Vietnamese social text, EACL 2026",
        "title": "ViGoEmotions",
        "desc": "Reproduces and extends an EACL 2026 paper: ViSoBERT + Emoji2Vec fusion, "
                "trained on Modal A100.",
        "metrics": [("28", "emotion labels"), ("EACL'26", "reproduction")],
        # Two sample messages and the emotion the model tags them with.
        "chat": [("hôm nay vui quá", "joy"), ("lo quá", "nervousness")],
    },
]

BUTTONS = [("linkedin", "LinkedIn", True), ("portfolio", "Portfolio", False), ("resume", "Resume", False)]
FOOTER = "Thanks for visiting."

# Section titles shown between panels: (file slug, ZONES key, note on the right).
HEADINGS = [("projects", "midnight", "Selected repositories"), ("activity", "abyss", "Updated every 12 hours")]


# ── Fonts and text ───────────────────────────────────────────────────────────
def _b64(path: Path) -> str:
    return base64.b64encode(path.read_bytes()).decode()


FACES = {
    ("o", w): f"@font-face{{font-family:'Outfit';font-weight:{w};"
              f"src:url(data:font/woff;base64,{_b64(FONTS / f'outfit-{w}.woff')}) format('woff')}}"
    for w in (400, 600, 700)
}
FACES[("p", 400)] = ("@font-face{font-family:'Plex';font-weight:400;"
                     f"src:url(data:font/woff2;base64,{_b64(FONTS / 'plex-mono-400.woff2')}) format('woff2')}}")


class Outfit:
    """Advance widths for one Outfit weight, used to wrap and size text."""

    def __init__(self, weight):
        font = TTFont(FONTS / f"outfit-{weight}.woff")
        self.cmap, self.hmtx, self.upm = font.getBestCmap(), font["hmtx"], font["head"].unitsPerEm

    def width(self, s, size):
        missing = sorted({c for c in s if ord(c) not in self.cmap})
        if missing:
            raise SystemExit(f"Outfit has no glyph for {missing} in {s!r}; reword the CONTENT section")
        return sum(self.hmtx[self.cmap[ord(c)]][0] for c in s) * size / self.upm


METRICS = {w: Outfit(w) for w in (400, 600, 700)}
_used = set()  # font faces referenced by the SVG being built; svg() embeds only these


def measure(s, size, weight=400, family="o", ls=0.0):
    base = len(s) * 0.6 * size if family == "p" else METRICS[weight].width(s, size)
    return base + ls * max(len(s) - 1, 0)


def wrap(text, size, width, weight=400):
    lines, line = [], ""
    for word in text.split():
        trial = f"{line} {word}".strip()
        if line and measure(trial, size, weight) > width:
            lines.append(line)
            line = word
        else:
            line = trial
    return lines + [line]


def t(x, y, s, size, fill=TEXT, weight=400, family="o", anchor="start", ls=0.0, extra=""):
    _used.add((family, 400 if family == "p" else weight))
    a = f' text-anchor="{anchor}"' if anchor != "start" else ""
    sp = f' letter-spacing="{ls}"' if ls else ""
    return (f'<text x="{x:.1f}" y="{y:.1f}" class="{family}" font-size="{size}" font-weight="{weight}" '
            f'fill="{fill}"{a}{sp}{extra}>{escape(s)}</text>')


BASE_CSS = (
    ".o{font-family:'Outfit',system-ui,sans-serif}.p{font-family:'Plex',ui-monospace,monospace}"
    "@keyframes drift{to{transform:translateX(-880px)}}"
    ".w1{animation:drift 14s linear infinite}.w2{animation:drift 9s linear infinite reverse}"
    "@keyframes twinkle{0%,100%{opacity:.25}50%{opacity:1}}.tw{animation:twinkle 2.6s ease-in-out infinite}"
    "@keyframes float{0%,100%{transform:translateY(0)}50%{transform:translateY(-7px)}}"
    ".fl{animation:float 4.4s ease-in-out infinite}"
    "@keyframes pulse{0%{transform:scale(1);opacity:.7}100%{transform:scale(2.6);opacity:0}}"
    ".pu{transform-box:fill-box;transform-origin:center;animation:pulse 1.8s ease-out infinite}"
    "@keyframes scan{from{transform:translateY(0)}to{transform:translateY(40px)}}"
    ".sc{animation:scan 2.2s ease-in-out infinite alternate}"
)


def svg(w, h, body, title):
    faces = "".join(FACES[k] for k in sorted(_used))
    _used.clear()
    return (f'<svg xmlns="http://www.w3.org/2000/svg" width="{w}" height="{h}" viewBox="0 0 {w} {h}" '
            f'role="img"><title>{escape(title)}</title><style>{faces}{BASE_CSS}</style>{body}</svg>')


# ── Shared pieces ────────────────────────────────────────────────────────────
def wave(amp, mid, bottom):
    """Seamless wave 1760 px wide; drifting it by 880 px loops without a seam."""
    d = f"M0 {mid} Q55 {mid - amp} 110 {mid}"
    for x in range(220, 1761, 110):
        d += f" T{x} {mid}"
    return f"{d} V{bottom} H0 Z"


def depth_row(y, zone, line):
    label = ZONES[zone]
    lend = 40 + measure(label, 12, family="p") + 14
    return (t(40, y + 1, label, 12, AQUA, family="p")
            + f'<path d="M{lend:.1f} {y - 3}H{W - 40}" stroke="{line}"/>')


def plankton(points):
    return "".join(f'<circle cx="{x}" cy="{y}" r="{r}" fill="{AQUA}" class="tw" style="animation-delay:{d}s"/>'
                   for x, y, r, d in points)


def bubble_path(x, y, w, h, radii):
    """Rounded rect with per-corner radii (tl, tr, br, bl): a chat bubble with one tight corner."""
    tl, tr, br, bl = radii
    return (f"M{x + tl:.1f} {y}H{x + w - tr:.1f}A{tr} {tr} 0 0 1 {x + w:.1f} {y + tr}"
            f"V{y + h - br}A{br} {br} 0 0 1 {x + w - br:.1f} {y + h}H{x + bl:.1f}"
            f"A{bl} {bl} 0 0 1 {x:.1f} {y + h - bl}V{y + tl}A{tl} {tl} 0 0 1 {x + tl:.1f} {y}Z")


# ── Panels ───────────────────────────────────────────────────────────────────
def build_hero():
    H = 384
    stars = [(120, 30, 1.6, 0), (262, 62, 1.2, .6), (430, 26, 1.6, 1.2), (590, 66, 1.2, .3), (700, 96, 1.2, .9)]
    tag = wrap(TAGLINE, 17, 520)
    card = [f'<rect x="600.5" y="222.5" width="239" height="123" rx="18" fill="#0B3E62" stroke="#2A6890"/>',
            t(620, 248, "at a glance", 11, MUTED, family="p")]
    for k, (label, value) in enumerate(DIVE_LOG):
        card += [t(620, 278 + 26 * k, label, 13, MUTED), t(820, 278 + 26 * k, value, 13, TEXT, 600, anchor="end")]
    dot_x = 820 - measure(STATUS, 13, 600) - 12
    card += [t(620, 330, "Status", 13, MUTED), t(820, 330, STATUS, 13, AQUA, 600, anchor="end"),
             f'<circle cx="{dot_x:.1f}" cy="326" r="4" fill="{AQUA}" class="pu"/>',
             f'<circle cx="{dot_x:.1f}" cy="326" r="4" fill="{AQUA}"/>']
    body = [
        f'<defs><clipPath id="hero"><rect width="{W}" height="{H}" rx="24"/></clipPath></defs>',
        '<g clip-path="url(#hero)">',
        f'<rect width="{W}" height="{H}" fill="{SURFACE}"/><rect width="{W}" height="150" fill="{SKY}"/>',
        t(40, 44, SKY_NOTE, 12, MUTED, family="p"),
        "".join(f'<circle cx="{x}" cy="{y}" r="{r}" fill="{TEXT}" class="tw" style="animation-delay:{d}s"/>'
                for x, y, r, d in stars),
        f'<circle cx="776" cy="54" r="19" fill="{TEXT}"/><circle cx="786" cy="48" r="19" fill="{SKY}"/>',
        f'<g class="w1"><path d="{wave(9, 118, 170)}" fill="#1A6A9A"/></g>',
        f'<g class="w2"><path d="{wave(7, 128, 170)}" fill="{SURFACE}"/></g>',
        depth_row(196, "surface", "#2A6890"),
        t(40, 268, NAME, 54, TEXT, 700, ls=-1.2),
        "".join(t(40, 304 + 26 * k, line, 17, SOFT) for k, line in enumerate(tag)),
        "".join(card),
        "</g>",
    ]
    return svg(W, H, "".join(body), f"{NAME}: {TAGLINE} Status: {STATUS}.")


def build_button(label, filled):
    w, h = round(measure(label, 16, 600)) + 48, 48
    fill, stroke, ink = (AQUA, AQUA, INK) if filled else (SURFACE, "#5FA3CC", TEXT)
    body = (f'<rect x="1" y="1" width="{w - 2}" height="{h - 2}" rx="23" fill="{fill}" stroke="{stroke}" stroke-width="1.5"/>'
            + t(w / 2, 30, label, 16, ink, 600, anchor="middle"))
    return svg(w, h, body, label)


def build_twilight():
    lines = wrap(ABOUT, 17, 470)
    text_bottom = 104 + 29 * (len(lines) - 1)
    bubbles = []
    for k, ((value, label), (cx, cy)) in enumerate(zip(BUBBLES, [(586, 120), (688, 146), (790, 120)])):
        size = 22 if len(value) <= 4 else 18
        bubbles.append(
            f'<g class="fl" style="animation-duration:{4 + .6 * k}s;animation-delay:{.8 * k}s">'
            f'<circle cx="{cx}" cy="{cy}" r="46" fill="#0F426B" stroke="#3A85B5" stroke-width="1.5"/>'
            + t(cx, cy + 4, value, size, AQUA if k == 0 else TEXT, 700, anchor="middle")
            + t(cx, cy + 22, label, 11, MUTED, anchor="middle") + "</g>")
    label_y = max(text_bottom, 192) + 46
    chips, x, y = [], 40, label_y + 16
    for name in STACK:
        cw = measure(name, 14) + 28
        if x + cw > W - 40:
            x, y = 40, y + 40
        chips.append(f'<rect x="{x + .5:.1f}" y="{y + .5}" width="{cw - 1:.1f}" height="31" rx="15.5" '
                     f'fill="#0F426B" stroke="#1D5A85"/>' + t(x + cw / 2, y + 21, name, 14, TEXT, anchor="middle"))
        x += cw + 8
    H = y + 32 + 40
    body = [
        f'<rect width="{W}" height="{H}" rx="24" fill="{TWILIGHT}"/>',
        depth_row(46, "twilight", "#2B6A8F"),
        "".join(t(40, 104 + 29 * k, line, 17, "#D5ECF4") for k, line in enumerate(lines)),
        "".join(bubbles),
        t(40, label_y, "Tools I use", 13, MUTED, 600),
        "".join(chips),
    ]
    return svg(W, H, "".join(body), about_alt())


# Section titles sit straight on the GitHub page, so they come in a dark and a light version
# and the README picks one with <picture> to match the viewer's theme.
HEADING_THEMES = {
    "dark": {"title": TEXT, "meta": MUTED, "line": "#1F3B52", "wave": AQUA},
    "light": {"title": "#0B2A42", "meta": "#4A6A80", "line": "#C9DCE6", "wave": "#0F9E8E"},
}


def build_heading(zone, meta, theme):
    H = 56
    c = HEADING_THEMES[theme]
    title = ZONES[zone]
    tx = 40 + 40
    line_from = tx + measure(title, 24, 700) + 18
    line_to = W - 40 - measure(meta, 13) - 18
    body = (f'<path d="M40 30 q5 -8 10 0 t10 0 t10 0" fill="none" stroke="{c["wave"]}" stroke-width="2.5" '
            f'stroke-linecap="round"/>'
            + t(tx, 37, title, 24, c["title"], 700)
            + f'<path d="M{line_from:.1f} 29H{line_to:.1f}" stroke="{c["line"]}"/>'
            + t(W - 40, 34, meta, 13, c["meta"], anchor="end"))
    return svg(W, H, body, f"{title}: {meta}")


def build_footer():
    H = 96
    body = (f'<rect x=".5" y=".5" width="{W - 1}" height="{H - 1}" rx="24" fill="{ABYSS}" stroke="#10324D"/>'
            + plankton([(90, 30, 1.6, 0), (210, 66, 1.2, 1), (680, 28, 1.6, .5), (800, 62, 1.2, 1.4)])
            + t(W / 2, 54, FOOTER, 15, MUTED, anchor="middle"))
    return svg(W, H, body, FOOTER)


# ── Project cards ────────────────────────────────────────────────────────────
CW = 430


def art(kind):
    """Line drawing for a project, in a 160 x 100 box placed at the top of the card."""
    a = AQUA
    if kind == "drug":
        return (f'<rect x="14" y="12" width="64" height="78" rx="6" fill="#0B3E62" stroke="{a}" stroke-width="1.6"/>'
                f'<path d="M14 28H78" stroke="{a}" stroke-width="1.2"/>'
                f'<rect x="22" y="17" width="26" height="6" rx="3" fill="{CORAL}"/>'
                f'<path d="M24 42H68M24 52H62M24 62H66M24 72H54" stroke="{MUTED}" stroke-width="3" stroke-linecap="round"/>'
                f'<rect x="18" y="36" width="56" height="2" fill="{CORAL}" class="sc"/>'
                f'<path d="M84 50H92M89 46L93 50L89 54" fill="none" stroke="{MUTED}" stroke-width="1.6" stroke-linecap="round"/>'
                f'<rect x="98" y="26" width="56" height="42" rx="10" fill="#0B3E62" stroke="{a}" stroke-width="1.6"/>'
                f'<path d="M106 68L103 78L114 68" fill="#0B3E62" stroke="{a}" stroke-width="1.6" stroke-linejoin="round"/>'
                f'<path d="M106 40H144M106 50H134" stroke="{TEXT}" stroke-width="3" stroke-linecap="round"/>'
                f'<rect x="106" y="57" width="22" height="5" rx="2.5" fill="{CORAL}"/>')
    if kind == "lesion":
        blob = ("M80 20C97 18 112 29 113 44C115 59 106 75 89 79C74 83 56 78 50 63"
                "C44 49 51 34 62 26C68 22 74 20 80 20Z")
        return (f'<circle cx="80" cy="50" r="46" fill="#0B3E62" stroke="#1D5A85" stroke-width="1.5"/>'
                f'<path d="{blob}" fill="{a}" opacity=".2"/>'
                f'<path d="{blob}" fill="none" stroke="{a}" stroke-width="1.8"/>'
                f'<circle cx="76" cy="46" r="7" fill="{a}" opacity=".55"/><circle cx="93" cy="59" r="4" fill="{a}" opacity=".45"/>'
                f'<path d="M50 63L113 44" stroke="{CORAL}" stroke-width="1.2" stroke-dasharray="3 3"/>'
                f'<circle cx="50" cy="63" r="3" fill="{CORAL}"/><circle cx="113" cy="44" r="3" fill="{CORAL}"/>'
                f'<circle cx="62" cy="26" r="2.5" fill="{CORAL}" class="tw"/>'
                f'<circle cx="89" cy="79" r="2.5" fill="{CORAL}" class="tw" style="animation-delay:1.2s"/>')
    if kind == "fundus":
        vessels = ("M100 50C86 38 68 30 46 30M100 50C86 62 68 70 46 72M72 34C64 27 58 22 52 16"
                   "M66 68C60 74 54 79 48 84M100 50C106 38 110 28 112 14M100 50C106 62 110 74 112 86"
                   "M58 31C52 36 46 38 38 38M58 69C52 64 46 62 38 62")
        return (f'<circle cx="80" cy="50" r="46" fill="#0B3E62" stroke="#1D5A85" stroke-width="1.5"/>'
                f'<circle cx="64" cy="52" r="6" fill="{MIDNIGHT}"/>'
                f'<path d="{vessels}" fill="none" stroke="{a}" stroke-width="1.6" stroke-linecap="round"/>'
                f'<circle cx="100" cy="50" r="8" fill="{CORAL}" opacity=".85"/>'
                f'<rect x="34" y="24" width="30" height="30" fill="none" stroke="{TEXT}" stroke-dasharray="3 3" opacity=".6"/>')
    raise ValueError(kind)


def chat_art(chat):
    """Two tagged chat bubbles and one dot per emotion label, drawn in card coordinates."""
    (msg1, tag1), (msg2, tag2) = chat
    parts = []
    b1 = measure(msg1, 13) + 24
    parts.append(f'<path d="{bubble_path(48, 28, b1, 30, (14, 14, 14, 4))}" fill="#0F426B" stroke="#1D5A85"/>'
                 + t(60, 48, msg1, 13))
    c1 = measure(tag1, 11, 600) + 18
    parts.append(f'<rect x="{48 + b1 + 8:.1f}" y="33" width="{c1:.1f}" height="20" rx="10" fill="{AQUA}"/>'
                 + t(48 + b1 + 8 + c1 / 2, 47, tag1, 11, INK, 600, anchor="middle"))
    b2 = measure(msg2, 13) + 24
    x2 = 382 - b2
    parts.append(f'<path d="{bubble_path(x2, 66, b2, 30, (14, 14, 4, 14))}" fill="#0F426B" stroke="#1D5A85"/>'
                 + t(x2 + 12, 86, msg2, 13))
    c2 = measure(tag2, 11, 600) + 18
    parts.append(f'<rect x="{x2 - 8 - c2:.1f}" y="71" width="{c2:.1f}" height="20" rx="10" fill="{CORAL}"/>'
                 + t(x2 - 8 - c2 / 2, 85, tag2, 11, "#3A1208", 600, anchor="middle"))
    colors = [AQUA, SKYBLUE, CORAL, "#3A85B5"]
    x0 = (CW - 27 * 9) / 2
    parts.append("".join(f'<circle cx="{x0 + 9 * i:.1f}" cy="116" r="2.6" fill="{colors[(i * 3) % 4]}" class="tw" '
                         f'style="animation-delay:{(i * 7) % 28 * .1:.1f}s"/>' for i in range(28)))
    return "".join(parts)


def build_card(p, desc_lines):
    lines = wrap(p["desc"], 14, CW - 48)
    metric_y = 212 + 21 * (desc_lines - 1) + 46
    H = metric_y + 46
    illo = (chat_art(p["chat"]) if p["art"] == "chat"
            else f'<g transform="translate({(CW - 176) / 2:.1f} 18) scale(1.1)">{art(p["art"])}</g>')
    metrics, x = [], 24
    for k, (value, label) in enumerate(p["metrics"]):
        metrics.append(t(x, metric_y, value, 26, AQUA if k == 0 else TEXT, 700)
                       + t(x, metric_y + 20, label, 12, MUTED))
        x += max(measure(value, 26, 700), measure(label, 12)) + 28
    body = [
        f'<rect x=".5" y=".5" width="{CW - 1}" height="{H - 1}" rx="20" fill="{CARD}" stroke="{CARD_LINE}"/>',
        illo,
        t(24, 158, p["caption"], 12, CORAL, 600),
        t(24, 186, p["title"], 21, TEXT, 700),
        "".join(t(24, 212 + 21 * k, line, 14, MUTED) for k, line in enumerate(lines)),
        "".join(metrics),
    ]
    stats = ", ".join(f"{v} {lab}" for v, lab in p["metrics"])
    return svg(CW, H, "".join(body), f"{p['title']}: {p['desc']} {stats}.")


def about_alt():
    facts = ", ".join(f"{value} {label}" for value, label in BUBBLES)
    return f"About me: {ABOUT} {facts}. Tools: {', '.join(STACK)}."


def sync_readme_alt():
    """Rewrite the about panel's alt text in README.md so screen readers get the current tools."""
    readme = ROOT / "README.md"
    text = readme.read_text(encoding="utf-8")
    alt = escape(about_alt(), quote=True)
    new, n = re.subn(r'(src="\./assets/ocean/twilight\.svg"[^>]*?alt=")[^"]*(")',
                     lambda m: m.group(1) + alt + m.group(2), text)
    if n != 1:
        raise SystemExit("README.md has no twilight.svg image with an alt attribute to update")
    if new != text:
        readme.write_text(new, encoding="utf-8")
        print("updated README.md alt text")


# ── Main ─────────────────────────────────────────────────────────────────────
def main():
    OUT.mkdir(parents=True, exist_ok=True)
    desc_lines = max(len(wrap(p["desc"], 14, CW - 48)) for p in PROJECTS)
    files = {
        "hero.svg": build_hero(),
        "twilight.svg": build_twilight(),
        **{f"heading-{slug}-{theme}.svg": build_heading(zone, meta, theme)
           for slug, zone, meta in HEADINGS for theme in HEADING_THEMES},
        "footer.svg": build_footer(),
    }
    for slug, label, filled in BUTTONS:
        files[f"btn-{slug}.svg"] = build_button(label, filled)
    for p in PROJECTS:
        files[f"card-{p['slug']}.svg"] = build_card(p, desc_lines)
    for name, content in files.items():
        (OUT / name).write_text(content, encoding="utf-8")
        print(f"wrote assets/ocean/{name} ({len(content) // 1024} KB)")
    sync_readme_alt()


if __name__ == "__main__":
    main()
