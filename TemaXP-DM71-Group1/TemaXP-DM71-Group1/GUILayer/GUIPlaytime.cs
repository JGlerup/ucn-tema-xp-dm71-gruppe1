using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TemaXP_DM71_Group1.ControllerLayer;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class GUIPlaytime : UserControl
    {
        public GUIPlaytime()
        {
            InitializeComponent();
            BindListBox();
        }


        private void BindListBox()
        {
            listBox1.Items.Clear();
            //string connString = "Data Source=balder.ucn.dk;initial catalog=DM71_2;User Id=DM71_2; Password=MaaGodt;";
            //string query = "SELECT Title FROM Movie";
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString);
            //DataTable source = new DataTable();
            //dataAdapter.Fill(source);
            CtrMovie ctrMovie = new CtrMovie();
            IList<Movie> movieList = ctrMovie.FindAllMovies();
            listBox1.DataSource = movieList;
            listBox1.DisplayMember = "Title";
            listBox1.ValueMember = "Title";
            listBox1.SelectedValue.ToString();
        }

        private void BindListView()
        {
            listView1.Items.Clear();
            string title = listBox1.SelectedItem.ToString();
            string connString = "Data Source=balder.ucn.dk;initial catalog=DM71_2;User Id=DM71_2; Password=MaaGodt;";
            Movie m = (Movie) listBox1.SelectedItem;
            int movieId = m.Id;
            //string query = "SELECT moviestarttime FROM Show WHERE movieid =" + movieId;
            CtrShow ctrShow = new CtrShow();
            Show s = ctrShow.FindShowByMovieId(m.Id);
            listView1.Items.Add(s.MovieStartTime);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindListView();
        }
    }
}
