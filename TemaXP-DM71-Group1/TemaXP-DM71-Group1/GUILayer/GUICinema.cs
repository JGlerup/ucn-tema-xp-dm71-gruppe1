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
    public partial class GUICinema : UserControl
    {
        public GUICinema()
        {
            InitializeComponent();
            //listView1.Dock = DockStyle.Fill;
            listView1.View = View.Details;
            listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            // Create and initialize column headers for myListView.
            ColumnHeader columnHeader0 = new ColumnHeader();
            columnHeader0.Text = "Rækker";
            columnHeader0.Width = -2;
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Antal Sæder";
            columnHeader1.Width = -2;
            // Add the column headers to myListView.
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1 });
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
                Cinema c = (Cinema)comboBox4.SelectedItem;
                int index = 0;
                ListViewItem listViewItem = new ListViewItem("Rows");
                while(index < c.Rows.Count)
                {
                    listViewItem.SubItems.Add(c.Rows.ElementAt(index).RowNo.ToString());
                    
                }
                index++;
                listView1.Items.Add(listViewItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public void clearTextBoxes()
        //{
        //    dtpReleaseDate.Text = "";
        //    txtTitle.Text = "";
        //    txtDistributor.Text = "";
        //    dtpArrivalDate.Text = "";
        //    dtpReturnDate.Text = "";
        //    mtxtDuration.Text = "";
        //    txtDirector.Text = "";
        //    txtActors.Text = "";
        //    txtMovieDescription.Text = "";
        //}
    }
}
