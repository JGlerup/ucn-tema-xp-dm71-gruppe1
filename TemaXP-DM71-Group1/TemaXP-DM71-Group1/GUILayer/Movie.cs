using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TemaXP_DM71_Group1.ControllerLayer;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class Movie : UserControl
    {
        public Movie()
        {
            InitializeComponent();
            BindComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
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
                String duration = textBox6.Text;
                String director = textBox7.Text;
                String actors = textBox8.Text;
                String movieDescription = textBox9.Text;
                ctrMovie.InsertMovie(date, title, distributor, arrivalDate, returnDate, duration, director, actors,
                                     movieDescription);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BindComboBox()
        {
            string connString = "Data Source=balder.ucn.dk;initial catalog=DM71_2;User Id=DM71_2; Password=MaaGodt;";
            string query = "SELECT Title FROM Movie";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString);
            DataTable source = new DataTable();
            dataAdapter.Fill(source);
            comboBox1.DataSource = source;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Title";
            comboBox1.SelectedValue.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindComboBox();
        }
    }
}
