using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMDb_Scraper;
using TemaXP_DM71_Group1.ControllerLayer;

namespace TemaXP_DM71_Group1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _TextBrush;

            // Get the item from the collection.
            TabPage _TabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _TabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _TextBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _TextBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font. Because we CAN.
            Font _TabFont = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _StringFlags = new StringFormat();
            _StringFlags.Alignment = StringAlignment.Center;
            _StringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_TabPage.Text, _TabFont, _TextBrush,
                         _TabBounds, new StringFormat(_StringFlags));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            IMDb imdb = new IMDb(textBox2.Text,true);
            textBox1.Text = imdb.Year;
            textBox2.Text = imdb.Title;
            textBox6.Text = imdb.Runtime;
            string directors;
            foreach (string d in imdb.Directors)
            {
                directors = String.Join(", ", d.ToString());
                
            }
            IEnumerable<string> = string.Join(", ", (from d in imdb.Directors select d.ToString()).ToArray());
            textBox7.Text = string.Join(", ", (from d in imdb.Directors select d.ToString().).ToArray());
            textBox8.Text = cast;
            //textBox7.Text = imdb.Directors;
            textBox9.Text = imdb.Storyline;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowsTab_Enter(object sender, EventArgs e)
        {
            CtrMovie ctrM = new CtrMovie();
            CtrCinema ctrC = new CtrCinema();
            CtrShow ctrS = new CtrShow();
            comboBox3.DataSource = ctrM.FindAllMovies();
            comboBox4.DataSource = CtrCinema.FindAllCinemas();
            comboBox1.DataSource = CtrShow.FindAllShows();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
