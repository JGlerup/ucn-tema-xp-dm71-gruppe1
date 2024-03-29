﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TemaXP_DM71_Group1.ModelLayer;
using System.Web;


namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class GUIPlaytime : UserControl
    {
        private ServiceReference1.IService1 service;
        public GUIPlaytime()
        {
            service = new ServiceReference1.Service1Client();
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

            listBox1.DataSource = service.FindAllMovies(false);
            listBox1.DisplayMember = "Title";
            listBox1.ValueMember = "Title";
            //listBox1.SelectedValue.ToString();
        }

        private void BindListView()
        {
//            listView1.Items.Clear();
//            Movie m = (Movie)listBox1.SelectedItem;
//
//            service.FindShowByMovieId(m);
//            ListViewItem item0 = new ListViewItem(new string[] {s.ShowDate, s.MovieStartTime});
//            listView1.Items.AddRange(new ListViewItem[] { item0 });
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
