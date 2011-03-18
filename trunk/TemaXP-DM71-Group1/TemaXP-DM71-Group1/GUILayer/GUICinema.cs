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
using System.Collections;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class GUICinema : UserControl
    {
        public GUICinema()
        {
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
            CtrCinema ctrCinema = new CtrCinema();
            comboBox4.DataSource = ctrCinema.FindAllCinemas(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindComboBox();
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Cinema c = (Cinema)comboBox4.SelectedItem;
                CtrCinema cc = new CtrCinema();
                c = cc.FindCinemaByName(c.CinemaName, true);
                foreach (Row r in c.Rows)
                {
                    ListViewItem item0 = new ListViewItem(new string[] {r.RowNo.ToString()});
                    ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem(item0, r.NoOfSeats.ToString());
                    listView1.Items.AddRange(new ListViewItem[] {item0});
                    item0.SubItems.Add(item1);
                    //listView1.Items.AddRange(new ListViewItem[] {item1});
                    listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
                }
                //foreach (Seat s in c.Seats)
                //{
                //    ListViewItem item1 = new ListViewItem(new string[] {s.SeatNo.ToString()});
                //    listView1.Items.AddRange(new ListViewItem[] {item1});
                //}
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
    }
}
