using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemaXP_DM71_Group1.GUILayer
{
    public partial class Movie : UserControl
    {
        public Movie()
        {
            InitializeComponent();
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
            textBox1.Text = imdb.Year;
            textBox2.Text = imdb.Title;
            textBox6.Text = imdb.Runtime;
            List<string> directors = (from string d in imdb.Directors select d.ToString()).ToList();
            List<string> casts = (from string c in imdb.Cast select c.ToString()).ToList();
            textBox7.Text = string.Join(", ", directors);
            textBox8.Text = string.Join(", ", casts);
            textBox9.Text = imdb.Storyline;
        }
    }
}
