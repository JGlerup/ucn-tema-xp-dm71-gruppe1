using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TemaXP_DM71_Group1.ModelLayer;
using System.Collections;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class GUICinema : UserControl
    {
        private ServiceReference1.IService1 service;
        public GUICinema()
        {
            service = new ServiceReference1.Service1Client();
            InitializeComponent();
            //listView1.Dock = DockStyle.Fill;
            listView1.View = View.Details;
            listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            // Create and initialize column headers for myListView.
            ColumnHeader header1, header2;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();
            header1.Text = "Række";
            header2.Text = "Sæder";
            header1.Width = -2;
            header2.Width = -2;
            // Add the column headers to myListView.
            listView1.Columns.Add(header1);
            listView1.Columns.Add(header2);
            BindComboBox();
            
        }

        private void BindComboBox()
        {
            
            comboBox4.DataSource = service.FindAllCinemas(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                service.InsertCinema(textBox1.Text, comboBox1.SelectedIndex);
                BindComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindComboBox();
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
//                listView1.Items.Clear();
//                Cinema c = (Cinema)comboBox4.SelectedItem;
//                c = service.FindCinemaByName(c.CinemaName, true);
//                foreach (Row r in c.Rows)
//                {
//                    ListViewItem item0 = new ListViewItem(new string[] { r.RowNo.ToString() });
//                    ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem(item0, r.NoOfSeats.ToString());
//                    listView1.Items.AddRange(new ListViewItem[] { item0 });
//                    item0.SubItems.Add(item1);
//                    listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
//                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                ((ListViewItem)y).SubItems[col].Text);
                return returnVal;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text.Equals("Rediger"))
            {
                button5.Text = "Redigering slut";
                button3.Enabled = true;
                comboBox1.Enabled = true;
                comboBox3.Enabled = true;
                comboBox2.Enabled = true;
                button4.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button5.Text = "Rediger";
                button3.Enabled = false;
                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Enabled = false;
                button4.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cinema c = (Cinema)comboBox4.SelectedItem;
            //CtrShow ctrShow = new CtrShow();
            if (c.Id == service.FindCinemaByName(c.CinemaName, true).Id)
            {
                service.DeleteCinema(service.FindCinemaByName(c.CinemaName, true));
                BindComboBox();
            }
            else
            {
                MessageBox.Show("Biografen er lame og er der derfor stadigvæk, hvilket er super lame, så prøv igen.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
//                Cinema c = (Cinema)comboBox4.SelectedItem;
//                service.InsertRow(c, Convert.ToInt32(comboBox2.SelectedItem.ToString()), Convert.ToInt32(comboBox3.SelectedItem.ToString()));
                BindListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindListView()
        {
            listView1.Items.Clear();
            Cinema c = (Cinema)comboBox4.SelectedItem;
//            c = service.FindCinemaByName(c.CinemaName, true);
            foreach (Row r in c.Rows)
            {
                ListViewItem item0 = new ListViewItem(new string[] { r.RowNo.ToString() });
                ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem(item0, r.NoOfSeats.ToString());
                listView1.Items.AddRange(new ListViewItem[] { item0 });
                item0.SubItems.Add(item1);
                listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
