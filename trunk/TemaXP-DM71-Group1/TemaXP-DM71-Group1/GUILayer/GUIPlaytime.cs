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
            //listView1.Dock = DockStyle.Fill;
            listView1.View = View.Details;
            listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            // Create and initialize column headers for myListView.
            ColumnHeader columnHeader0 = new ColumnHeader();
            columnHeader0.Text = "Dato";
            columnHeader0.Width = -1;
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Spilletider";
            columnHeader1.Width = -2;
            // Add the column headers to myListView.
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1 });

        }


        private void BindListBox()
        {
            listBox1.Items.Clear();
            CtrMovie ctrMovie = new CtrMovie();
            IList<Movie> movieList = ctrMovie.FindAllMovies();
            listBox1.DataSource = movieList;
            listBox1.DisplayMember = "Title";
            listBox1.ValueMember = "Title";
            //listBox1.SelectedValue.ToString();
        }

        private void BindListView()
        {
            listView1.Items.Clear();
            Movie m = (Movie)listBox1.SelectedItem;
            //int movieId = m.Id;
            CtrShow ctrShow = new CtrShow();
            Show s = ctrShow.FindShowByMovieId(m);
            //            listView1.Items.Add(s.MovieStartTime);
            //            listView1.Columns.Add(s.ShowDate);
            ListViewItem item0 = new ListViewItem(new string[] 
            {s.ShowDate, 
            s.MovieStartTime});
            listView1.Items.AddRange(new ListViewItem[] { item0 });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindListView();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.Visible == false)
            {
                listView1.Visible = true;
            }
        }
    }
}
