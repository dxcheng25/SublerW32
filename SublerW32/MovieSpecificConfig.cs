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
    public partial class MovieSpecificConfig : UserControl
    {
        public String genre = "";
        public String rating = "";

        public MovieSpecificConfig()
        {
            InitializeComponent();
        }

        public MovieSpecificConfig(MetaXMLHandler.MetaDataModel mdm)
        {
            InitializeComponent();

            if (mdm.mediaType == "电影")
            {
                cbGenre.Text = mdm.genre;
                cbRating.Text = mdm.rating;
            }
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            genre = cbGenre.Text;
        }

        private void cbRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            rating = cbRating.Text;
        }

        private void cbGenre_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
