using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SublerW32
{
    public partial class TVSpecificConfig : UserControl
    {
        public String tvShow = "";
        public String seasonNum = "";
        public String episodeNum = "";
        public String rating = "";
        public String genre = "";
        public String tvNetwork = "";

        public TVSpecificConfig()
        {
            InitializeComponent();
        }

        public TVSpecificConfig( MetaXMLHandler.MetaDataModel mdm )
        {
            InitializeComponent();

            tbTVShow.Text = mdm.tvShow;
            tbTVNetwork.Text= mdm.tvNetwork;
            tbTVSeason.Text = mdm.seasonNum;
            tbEpisodeNum.Text = mdm.episodeNum;

            if (mdm.mediaType == "电视剧")
            {
                cbGenre.Text = mdm.genre;
                cbRating.Text = mdm.rating;
            }
        }

        private void tbTVShow_Leave(object sender, EventArgs e)
        {
            tvShow = tbTVShow.Text;
        }

        private void tbTVSeason_Leave(object sender, EventArgs e)
        {
            seasonNum = tbTVSeason.Text;
        }

        private void tbEpisodeNum_Leave(object sender, EventArgs e)
        {
            episodeNum = tbEpisodeNum.Text;
        }

        private void tbTVNetwork_Leave(object sender, EventArgs e)
        {
            tvNetwork = tbTVNetwork.Text;
        }

        private void cbRating_SelectedValueChanged(object sender, EventArgs e)
        {
            rating = cbRating.Text;
        }

        private void cbGenre_SelectedValueChanged(object sender, EventArgs e)
        {
            genre = cbGenre.Text;
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
