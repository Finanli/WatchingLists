using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WatchingLists
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server = LAPTOP-DI6H08K1; Database = WatchingList; Integrated Security = true;");

        private void movieb_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Movies mov = new Movies();
            mov.TopLevel = false;
            scpanel.Controls.Add(mov);
            mov.Show();
            mov.Dock= DockStyle.Fill;
            mov.BringToFront();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void movieb_Click_1(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Movies mov = new Movies();
            mov.TopLevel = false;
            scpanel.Controls.Add(mov);
            mov.Show();
            mov.Dock = DockStyle.Fill;
            mov.BringToFront();
        }

        private void seriesb_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Series ser = new Series();
            ser.TopLevel = false;
            scpanel.Controls.Add(ser);
            ser.Show();
            ser.Dock = DockStyle.Fill;
            ser.BringToFront();
        }

        private void animeb_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Anime anime = new Anime();
            anime.TopLevel = false;
            scpanel.Controls.Add(anime);
            anime.Show();
            anime.Dock = DockStyle.Fill;
            anime.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Summary wsum = new Summary();
            wsum.TopLevel = false;
            scpanel.Controls.Add(wsum);
            wsum.Show();
            wsum.Dock = DockStyle.Fill;
            wsum.BringToFront();
        }
    }
}
