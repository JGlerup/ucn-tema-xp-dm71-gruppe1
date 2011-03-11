using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class GUIShow : UserControl
    {
        public GUIShow()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Show_Enter(object sender, EventArgs e)
        {
            CtrShow crtShow= new CtrShow();
            cmbShow.DataSource = ctrShow.FindAllShows();
            dtpMovieDate.MinDate = DateTime.Today;
            List<string> movieStartTime = new List<string>();
            for (int i = 0; i <= 23; i++)
            {
                if (i < 10)
                {
                    movieStartTime.add("0" + i + ":" + "00");
                    movieStartTime.add("0" + i + ":" + "30");
                }
                else
                {
                    movieStartTime.add(i + ":" + "00");
                    movieStartTime.add(i + ":" + "30");
                }


            }



            cmbMovieStartTime.DataSource = movieStartTime;
            CtrMovie crtMovie = new CtrMovie();
            cmbMovie.DataSource = ctrMovie.FindAllMovies();

            CtrCinema crtCinema = new CtrCinema();
            cmbCinema.DataSource = ctrCinema.FindAllCinemas();



        }

        private void dtpMovieDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
