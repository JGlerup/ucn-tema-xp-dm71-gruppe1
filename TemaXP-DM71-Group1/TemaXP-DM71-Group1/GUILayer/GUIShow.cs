using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TemaXP_DM71_Group1.ControllerLayer;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class GUIShow : UserControl
    {
        public GUIShow()
        {
            InitializeComponent();
        }

        private void Show_Enter(object sender, EventArgs e)
        {
            CtrShow ctrShow= new CtrShow();
            try
            {
                cmbShow.DataSource = ctrShow.FindAllShows(true);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fejl: " + ex.Message, "Operationen mislykkedes");
            }
            dtpMovieDate.MinDate = DateTime.Today;
            List<string> movieStartTime = new List<string>();
            for (int i = 0; i <= 23; i++)
            {
                if (i < 10)
                {
                    movieStartTime.Add("0" + i + ":" + "00" + ":" + "00");
                    movieStartTime.Add("0" + i + ":" + "30" + ":" + "00");
                }
                else
                {
                    movieStartTime.Add(i + ":" + "00" + ":" + "00");
                    movieStartTime.Add(i + ":" + "30" + ":" + "00");
                }


            }
            cmbMovieStartTime.DataSource = movieStartTime;
            CtrMovie ctrMovie = new CtrMovie();
            cmbMovie.DataSource = ctrMovie.FindAllMovies();
            //CtrCinema ctrCinema = new CtrCinema();
            //cmbCinema.DataSource = ctrCinema.FindAllCinemas();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CtrShow ctrShow = new CtrShow();    
            try
            {
                if(cmbMovie.SelectedValue.ToString().Trim() == "" || cmbMovieStartTime.SelectedValue.ToString().Trim() == "" /*|| cmbCinema.SelectedValue.ToString().Trim() == "" */)
                {
                    MessageBox.Show("Fejl: Udfyld venligst alle felter", "Operationen mislykkedes");
                }
                else
                {
                    Movie m = (Movie) cmbMovie.SelectedItem;
                    string movieStartTime = cmbMovieStartTime.SelectedValue.ToString();
                    string year = dtpMovieDate.Value.Year.ToString();
                    string month = dtpMovieDate.Value.Month.ToString();
                    string day = dtpMovieDate.Value.Day.ToString();
                    String movieDate = year + "-" + month + "-" + day;
                    ctrShow.InsertShow(movieStartTime, movieDate, m);
                    MessageBox.Show("Forestillingen er oprettet", "Operationen lykkedes");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fejl: " + ex.Message, "Operationen mislykkedes");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CtrShow ctrShow = new CtrShow();
            Show s = (Show) cmbShow.SelectedItem;
            try
            {
                ctrShow.DeleteShow(s);
                MessageBox.Show("Forestillingen er slettet", "Operationen lykkedes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl: " + ex.Message, "Operationen mislykkedes");
            }
        }
    }
}
