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
        }

        public void clearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IMDb imdb = new IMDb(textBox2.Text, true);
            textBox1.Text = imdb.ReleaseDate;
            textBox2.Text = imdb.Title;
            //textBox3.Text = imdb.
            textBox4.Text = Convert.ToString(DateTime.Now);
            textBox6.Text = imdb.Runtime;
            List<string> directors = (from string d in imdb.Directors select d.ToString()).ToList();
            List<string> casts = (from string c in imdb.Cast select c.ToString()).ToList();
            textBox7.Text = string.Join(", ", directors);
            textBox8.Text = string.Join(", ", casts);
            textBox9.Text = imdb.Storyline;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CtrMovie ctrMovie = new CtrMovie();
                String date = textBox1.Text;
                String title = textBox2.Text;
                String distributor = textBox3.Text;
                String arrivalDate = textBox4.Text;
                String returnDate = textBox5.Text;
                int imdbDuration = Convert.ToInt32(textBox6.Text);
                int min = imdbDuration % 60;
                int hours = (imdbDuration - min) / 60;
                string duration = "0" + hours + ":" + min + ":" + "00";
                String director = textBox7.Text;
                String actors = textBox8.Text;
                String movieDescription = textBox9.Text;
                ctrMovie.InsertMovie(date, title, distributor, arrivalDate, returnDate, duration, director, actors,
                                     movieDescription);
                BindComboBox();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Movie m = (Movie)comboBox1.SelectedItem;
            //textBox1.Text = m.ReleaseDate;
            //textBox2.Text = m.Title;
            //textBox3.Text = m.Distributor;
            //textBox4.Text = m.ArrivalDate;
            //textBox5.Text = m.ReturnDate;
            //textBox6.Text = m.Duration;
            //textBox7.Text = m.Director;
            //textBox8.Text = m.Actors;
            //textBox9.Text = m.MovieDescription;
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
            Movie m = (Movie)comboBox1.SelectedItem;
            clearTextBoxes();
            textBox1.Text = m.ReleaseDate;
            textBox2.Text = m.Title;
            textBox3.Text = m.Distributor;
            textBox4.Text = m.ArrivalDate;
            textBox5.Text = m.ReturnDate;
            textBox6.Text = m.Duration;
            textBox7.Text = m.Director;
            textBox8.Text = m.Actors;
            textBox9.Text = m.MovieDescription;
        }
    }
}
