using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMDb_Scraper;
using TemaXP_DM71_Group1.ControllerLayer;
using System.Data.Odbc;
using System.Data.SqlClient;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class GUIMovie : UserControl
    {
        public GUIMovie()
        {
            InitializeComponent();
            BindComboBox();
            disableFields();
        }

        public void clearTextBoxes()
        {
            txtReleaseDate.Text = "";
            txtTitle.Text = "";
            txtDistributor.Text = "";
            txtArrivalDate.Text = "";
            txtReturnDate.Text = "";
            txtDuration.Text = "";
            txtDirector.Text = "";
            txtActors.Text = "";
            txtMovieDescription.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                IMDb imdb = new IMDb(txtTitle.Text, true);
                
                txtReleaseDate.Text = imdb.ReleaseDate;
                txtTitle.Text = imdb.Title;
                //textBox3.Text = imdb.
                string year = DateTime.Now.Year.ToString();
                string month = DateTime.Now.Month.ToString();
                string date = DateTime.Now.Day.ToString();
                String releaseDate = year + "-" + month + "-" + date;
                if (Convert.ToInt32(month) >= 9)
                {
                    txtArrivalDate.Text = year + "-" + month + "-" + date;
                }
                else
                {
                    txtArrivalDate.Text = year + "-0" + month + "-" + date;
                }
                txtDuration.Text = imdb.Runtime;
                List<string> directors = (from string d in imdb.Directors select d.ToString()).ToList();
                List<string> casts = (from string c in imdb.Cast select c.ToString()).ToList();
                txtDirector.Text = string.Join(", ", directors);
                txtActors.Text = string.Join(", ", casts);
                txtMovieDescription.Text = imdb.Storyline;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CtrMovie ctrMovie = new CtrMovie();
                String date = txtReleaseDate.Text;
                String title = txtTitle.Text;
                String distributor = txtDistributor.Text;
                String arrivalDate = txtArrivalDate.Text;
                String returnDate = txtReturnDate.Text;
                int imdbDuration = Convert.ToInt32(txtDuration.Text);
                int min = imdbDuration % 60;
                int hours = (imdbDuration - min) / 60;
                string duration = "0" + hours + ":" + min + ":" + "00";
                String director = txtDirector.Text;
                String actors = txtActors.Text;
                String movieDescription = txtMovieDescription.Text;
                ctrMovie.InsertMovie(date, title, distributor, arrivalDate, returnDate, duration, director, actors,
                                     movieDescription);
                clearTextBoxes();
                BindComboBox();
                MessageBox.Show("Filmen er oprettet", "Operationen lykkes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindComboBox()
        {
            CtrMovie ctrMovie = new CtrMovie();
            comboBox1.DataSource = ctrMovie.FindAllMovies();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindComboBox();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Movie m = (Movie)comboBox1.SelectedItem;
                clearTextBoxes();
                txtReleaseDate.Text = m.ReleaseDate;
                txtTitle.Text = m.Title;
                txtDistributor.Text = m.Distributor;
                txtArrivalDate.Text = m.ArrivalDate;
                txtReturnDate.Text = m.ReturnDate;
                txtDuration.Text = m.Duration;
                txtDirector.Text = m.Director;
                txtActors.Text = m.Actors;
                txtMovieDescription.Text = m.MovieDescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCreateManually.Checked.Equals(false)){
                disableFields();
            }
            else
            {
                enableFields();
            }
        }

        private void disableFields()
        {
            txtReleaseDate.Enabled = false;
            txtTitle.Enabled = true;
            txtDistributor.Enabled = true;
            txtArrivalDate.Enabled = false;
            txtReturnDate.Enabled = true;
            txtDuration.Enabled = false;
            txtDirector.Enabled = false;
            txtActors.Enabled = false;
            txtMovieDescription.Enabled = false;
        }

        private void enableFields()
        {
            txtReleaseDate.Enabled = true;
            txtTitle.Enabled = true;
            txtDistributor.Enabled = true;
            txtArrivalDate.Enabled = true;
            txtReturnDate.Enabled = true;
            txtDuration.Enabled = true;
            txtDirector.Enabled = true;
            txtActors.Enabled = true;
            txtMovieDescription.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            Movie m = (Movie)comboBox1.SelectedItem;
            CtrMovie ctrMovie = new CtrMovie();
            CtrShow ctrShow = new CtrShow();
            if (m.Id == ctrShow.FindShowByMovieId(m).Id)
            {
                ctrMovie.DeleteMovie(m);
            }
            else
            {
                MessageBox.Show(
                    "Filmen er stadigvæk aktiv i en forstilling, derfor kan den ikke slettes. For at slette filmen skal den først fjernes fra forestillinger.");
            }

        }
    }
}
