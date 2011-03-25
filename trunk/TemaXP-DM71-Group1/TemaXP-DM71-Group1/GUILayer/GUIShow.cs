using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class GUIShow : UserControl
    {
        private ServiceReference1.IService1 service;


        public GUIShow()
        {
            service = new ServiceReference1.Service1Client();
            InitializeComponent();
            
        }

        private void Show_Enter(object sender, EventArgs e)
        {
          
            try
            {
                cmbShow.DataSource = service.FindAllShows(true);
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

            cmbMovie.DataSource = service.FindAllMovies(false);
            //CtrCinema ctrCinema = new CtrCinema();
            //cmbCinema.DataSource = ctrCinema.FindAllCinemas();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
            try
            {
                if(cmbMovie.SelectedValue.ToString().Trim() == "" || cmbMovieStartTime.SelectedValue.ToString().Trim() == "" /*|| cmbCinema.SelectedValue.ToString().Trim() == "" */)
                {
                    MessageBox.Show("Fejl: Udfyld venligst alle felter", "Operationen mislykkedes");
                }
                else
                {
//                    Movie m = (Movie) cmbMovie.SelectedItem;
//                    string movieStartTime = cmbMovieStartTime.SelectedValue.ToString();
//                    string year = dtpMovieDate.Value.Year.ToString();
//                    string month = dtpMovieDate.Value.Month.ToString();
//                    string day = dtpMovieDate.Value.Day.ToString();
//                    String movieDate = year + "-" + month + "-" + day;
//                    service.InsertShow(movieStartTime, movieDate, m);
//                    MessageBox.Show("Forestillingen er oprettet", "Operationen lykkedes");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fejl: " + ex.Message, "Operationen mislykkedes");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
//            Show s = (Show) cmbShow.SelectedItem;
//            try
//            {
//                service.DeleteShow(s);
//                MessageBox.Show("Forestillingen er slettet", "Operationen lykkedes");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Fejl: " + ex.Message, "Operationen mislykkedes");
//            }
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
