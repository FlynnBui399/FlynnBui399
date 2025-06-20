using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using WIPR_FinalTermProject.BS_layer;
using WIPR_FinalTermProject.RDLC_layer;

namespace WIPR_FinalTermProject.Forms_layer
{
    public partial class FormStatistics : Form
    {
        private StatisticsBLL statsBLL = new StatisticsBLL();

        public FormStatistics()
        {
            InitializeComponent();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            LoadArtistStats();
            LoadGenreStats();
            LoadPlaylistStats();
            LoadAlbumStats();
            LoadArtistReport();
            LoadGenreReport();
            LoadPlaylistReport();
            LoadAlbumReport();
            this.reportViewerArtist.RefreshReport();
        }

        private void LoadArtistStats()
        {
            dgvStatsArtists.DataSource = statsBLL.GetSongsCountByArtist();
            dgvStatsArtists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadGenreStats()
        {
            dgvStatsGenres.DataSource = statsBLL.GetSongsCountByGenre();
            dgvStatsGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadPlaylistStats()
        {
            var table = statsBLL.GetPlaylistDurations();
            table.Columns.Add("FormattedDuration", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                int seconds = Convert.ToInt32(row["TotalDuration"]);
                row["FormattedDuration"] = FormatDuration(seconds);
            }

            dgvStatsPlaylists.DataSource = table;
            dgvStatsPlaylists.Columns["TotalDuration"].Visible = false;
            dgvStatsPlaylists.Columns["FormattedDuration"].HeaderText = "Total Duration";
            dgvStatsPlaylists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAlbumStats()
        {
            var table = statsBLL.GetAlbumStatistics();
            table.Columns.Add("FormattedDuration", typeof(string));
            table.Columns.Add("FormattedAvgDuration", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                if (!row.IsNull("TotalDuration"))
                {
                    int totalSeconds = Convert.ToInt32(row["TotalDuration"]);
                    row["FormattedDuration"] = FormatDuration(totalSeconds);
                }
                else
                {
                    row["FormattedDuration"] = "0m 00s";
                }
                
                if (!row.IsNull("AverageDuration"))
                {
                    int avgSeconds = Convert.ToInt32(row["AverageDuration"]);
                    row["FormattedAvgDuration"] = FormatDuration(avgSeconds);
                }
                else
                {
                    row["FormattedAvgDuration"] = "0m 00s";
                }
            }

            dgvStatsAlbums.DataSource = table;
            dgvStatsAlbums.Columns["TotalDuration"].Visible = false;
            dgvStatsAlbums.Columns["AverageDuration"].Visible = false;
            
            if (dgvStatsAlbums.Columns.Contains("FormattedDuration"))
                dgvStatsAlbums.Columns["FormattedDuration"].HeaderText = "Total Duration";
            if (dgvStatsAlbums.Columns.Contains("FormattedAvgDuration"))
                dgvStatsAlbums.Columns["FormattedAvgDuration"].HeaderText = "Avg Duration";
            if (dgvStatsAlbums.Columns.Contains("TotalSongs"))
                dgvStatsAlbums.Columns["TotalSongs"].HeaderText = "Song Count";
            
            dgvStatsAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private string FormatDuration(int seconds)
        {
            int mins = seconds / 60;
            int secs = seconds % 60;
            return $"{mins}m {secs:D2}s";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadArtistReport()
        {
            var table = statsBLL.GetArtistStatistics();
            
            // Create a new DataTable with appropriate structure
            DataTable reportTable = new DataTable("ArtistReport");
            reportTable.Columns.Add("Artist", typeof(string));
            reportTable.Columns.Add("Nationality", typeof(string));
            reportTable.Columns.Add("Birthdate", typeof(DateTime));
            reportTable.Columns.Add("TotalSongs", typeof(int));
            reportTable.Columns.Add("TotalAlbums", typeof(int));
            reportTable.Columns.Add("TotalDuration", typeof(int));
            reportTable.Columns.Add("TopRatedSong", typeof(string));
            reportTable.Columns.Add("FormattedDuration", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                DataRow newRow = reportTable.NewRow();
                newRow["Artist"] = row["Artist"];
                newRow["Nationality"] = row["Nationality"] == DBNull.Value ? "Unknown" : row["Nationality"];
                newRow["Birthdate"] = row["Birthdate"] == DBNull.Value ? DBNull.Value : row["Birthdate"];
                newRow["TotalSongs"] = row["TotalSongs"];
                newRow["TotalAlbums"] = row["TotalAlbums"];
                newRow["TotalDuration"] = row["TotalDuration"];
                newRow["TopRatedSong"] = row["TopRatedSong"] == DBNull.Value ? "None" : row["TopRatedSong"];
                
                int duration = Convert.ToInt32(row["TotalDuration"]);
                newRow["FormattedDuration"] = FormatDuration(duration);
                
                reportTable.Rows.Add(newRow);
            }

            reportViewerArtist.LocalReport.DataSources.Clear();
            reportViewerArtist.LocalReport.DataSources.Add(
                new ReportDataSource("StatisticsDataSet", reportTable)
            );
            reportViewerArtist.LocalReport.ReportPath = @"RDLC layer\ArtistReport.rdlc";
            reportViewerArtist.RefreshReport();
        }

        private void LoadGenreReport()
        {
            var table = statsBLL.GetGenreStatistics();
            
            
            
            DataTable reportTable = new DataTable("GenreReport");
            reportTable.Columns.Add("Genre", typeof(string));
            reportTable.Columns.Add("TotalSongs", typeof(int));
            reportTable.Columns.Add("AverageDuration", typeof(int));
            reportTable.Columns.Add("PopularArtist", typeof(string));
            reportTable.Columns.Add("PopularYear", typeof(int));
            reportTable.Columns.Add("FormattedAvgDuration", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                DataRow newRow = reportTable.NewRow();
                newRow["Genre"] = row["Genre"];
                newRow["TotalSongs"] = row["TotalSongs"];
                newRow["AverageDuration"] = Convert.ToInt32(row["AverageDuration"]);
                newRow["PopularArtist"] = row["PopularArtist"] == DBNull.Value ? "Unknown" : row["PopularArtist"];
                newRow["PopularYear"] = row["PopularYear"] == DBNull.Value ? DBNull.Value : row["PopularYear"];
                
                int avgDuration = Convert.ToInt32(row["AverageDuration"]);
                newRow["FormattedAvgDuration"] = FormatDuration(avgDuration);
                
                reportTable.Rows.Add(newRow);
            }

            reportViewerGenre.LocalReport.DataSources.Clear();
            reportViewerGenre.LocalReport.DataSources.Add(
                new ReportDataSource("StatisticsDataSet", reportTable)
            );
            reportViewerGenre.LocalReport.ReportPath = @"RDLC layer\GenreReport.rdlc";
            reportViewerGenre.RefreshReport();
        }

        private void LoadPlaylistReport()
        {
            var table = statsBLL.GetPlaylistStatistics();
            
            // Create a new DataTable with appropriate structure
            DataTable reportTable = new DataTable("PlaylistReport");
            reportTable.Columns.Add("PlaylistID", typeof(int));
            reportTable.Columns.Add("Playlist", typeof(string));
            reportTable.Columns.Add("CreatedDate", typeof(DateTime));
            reportTable.Columns.Add("TotalSongs", typeof(int));
            reportTable.Columns.Add("TotalDuration", typeof(int));
            reportTable.Columns.Add("AverageDuration", typeof(int));
            reportTable.Columns.Add("PopularGenre", typeof(string));
            reportTable.Columns.Add("FormattedDuration", typeof(string));
            reportTable.Columns.Add("FormattedAvgDuration", typeof(string));
            reportTable.Columns.Add("MostRatedSong", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                DataRow newRow = reportTable.NewRow();
                newRow["PlaylistID"] = row["PlaylistID"];
                newRow["Playlist"] = row["Playlist"];
                newRow["CreatedDate"] = row["CreatedDate"] == DBNull.Value ? DBNull.Value : row["CreatedDate"];
                newRow["TotalSongs"] = row["TotalSongs"];
                newRow["TotalDuration"] = row["TotalDuration"];
                newRow["AverageDuration"] = row["AverageDuration"];
                newRow["PopularGenre"] = row["PopularGenre"] == DBNull.Value ? "None" : row["PopularGenre"];
                newRow["MostRatedSong"] = row["MostRatedSong"] == DBNull.Value ? "None" : row["MostRatedSong"];

                int totalSec = Convert.ToInt32(row["TotalDuration"]);
                newRow["FormattedDuration"] = FormatDuration(totalSec);

                int avgSec = Convert.ToInt32(row["AverageDuration"]);
                newRow["FormattedAvgDuration"] = FormatDuration(avgSec);

                reportTable.Rows.Add(newRow);
            }

            reportViewerPlaylist.LocalReport.ReportPath = Path.Combine(Application.StartupPath, @"RDLC layer\PlaylistReport.rdlc");

            reportViewerPlaylist.LocalReport.DataSources.Clear();
            reportViewerPlaylist.LocalReport.DataSources.Add(
                new ReportDataSource("StatisticsDataSet", reportTable)
            );

            reportViewerPlaylist.LocalReport.SubreportProcessing += ReportViewerPlaylist_SubreportProcessing;
            reportViewerPlaylist.RefreshReport();
        }

        private void LoadAlbumReport()
        {
            var table = statsBLL.GetAlbumStatistics();
            
            // Create a new DataTable with appropriate structure for the report
            DataTable reportTable = new DataTable("SongsByAlbum");
            reportTable.Columns.Add("AlbumID", typeof(int));
            reportTable.Columns.Add("Album", typeof(string));
            reportTable.Columns.Add("Year", typeof(int));
            reportTable.Columns.Add("Artist", typeof(string));
            reportTable.Columns.Add("TotalSongs", typeof(int));
            reportTable.Columns.Add("TotalDuration", typeof(int));
            reportTable.Columns.Add("AverageDuration", typeof(int));
            reportTable.Columns.Add("PrimaryGenre", typeof(string));
            reportTable.Columns.Add("MostRatedSong", typeof(string));
            reportTable.Columns.Add("AvgRating", typeof(decimal));
            reportTable.Columns.Add("FormattedDuration", typeof(string));
            reportTable.Columns.Add("FormattedAvgDuration", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                DataRow newRow = reportTable.NewRow();
                newRow["AlbumID"] = row["AlbumID"];
                newRow["Album"] = row["Album"];
                newRow["Year"] = row["Year"];
                newRow["Artist"] = row["Artist"] == DBNull.Value ? "Unknown" : row["Artist"];
                newRow["TotalSongs"] = row["TotalSongs"];
                newRow["TotalDuration"] = row["TotalDuration"];
                newRow["AverageDuration"] = Convert.ToInt32(row["AverageDuration"]);
                newRow["PrimaryGenre"] = row["PrimaryGenre"] == DBNull.Value ? "Unknown" : row["PrimaryGenre"];
                newRow["MostRatedSong"] = row["MostRatedSong"] == DBNull.Value ? "None" : row["MostRatedSong"];
                newRow["AvgRating"] = row["AvgRating"];
                
                int totalDuration = Convert.ToInt32(row["TotalDuration"]);
                newRow["FormattedDuration"] = FormatDuration(totalDuration);
                
                int avgDuration = Convert.ToInt32(row["AverageDuration"]);
                newRow["FormattedAvgDuration"] = FormatDuration(avgDuration);
                
                reportTable.Rows.Add(newRow);
            }

            reportViewerAlbum.LocalReport.DataSources.Clear();
            reportViewerAlbum.LocalReport.DataSources.Add(
                new ReportDataSource("StatisticsDataSet", reportTable)
            );
            reportViewerAlbum.LocalReport.ReportPath = Path.Combine(Application.StartupPath, @"RDLC layer\AlbumReport.rdlc");
            reportViewerAlbum.RefreshReport();
        }

        private void ReportViewerPlaylist_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            int playlistId = Convert.ToInt32(e.Parameters["PlaylistID"].Values[0]);
            DataTable songsTable = statsBLL.GetSongsInPlaylist(playlistId);

            if (!songsTable.Columns.Contains("FormattedDuration"))
                songsTable.Columns.Add("FormattedDuration", typeof(string));

            foreach (DataRow row in songsTable.Rows)
            {
                int duration = Convert.ToInt32(row["Duration"]);
                row["FormattedDuration"] = FormatDuration(duration);
            }

            e.DataSources.Add(new ReportDataSource("PlaylistSongsDataSet", songsTable));
        }
    }
}
