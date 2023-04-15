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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server = LAPTOP-DI6H08K1; Database = WatchingList; Integrated Security = true;");

        public void Komut(string komutkod)
        {
            SqlDataAdapter da = new SqlDataAdapter(komutkod, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Summary_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                
                Komut("select * from Anime where watchingStatus = 'Finished' order by wStartD desc");
            }
            else if (radioButton2.Checked)
            {
                Komut("select * from Movies where watchingStatus = 'Finished' order by wDate desc");
            }
            else if (radioButton3.Checked)
            {
                Komut("select * from Series where watchingStatus = 'Finished' order by wStartD desc");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                Komut("select Category, count(Category) as NumberOfAnime from Anime where watchingStatus = 'Finished' group by Category");
            }
            else if (radioButton2.Checked)
            {
                Komut("select Category, count(Category) as NumberOfMovies from Movies where watchingStatus = 'Finished' group by Category");
            }
            else if (radioButton3.Checked)
            {
                Komut("select Category, count(Category) as NumberOfSeries from Series where watchingStatus = 'Finished' group by Category");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                Komut("select *  from Anime where score >= 7 order by watchingStatus");
            }
            else if (radioButton2.Checked)
            {
                Komut("select * from Movies where score >= 7 order by watchingStatus");
            }
            else if (radioButton3.Checked)
            {
                Komut("select * from Series where score >= 7 order by watchingStatus");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {

                Komut("select *  from Anime where score <= 4 and score<7 order by watchingStatus");
            }
            else if (radioButton2.Checked)
            {
                Komut("select * from Movies where score <= 4 and score<7 order by watchingStatus");
            }
            else if (radioButton3.Checked)
            {
                Komut("select * from Series where score <= 4 and score<7  order by watchingStatus");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                Komut("select *  from Anime where score >=0  and score<4 order by watchingStatus");
            }
            else if (radioButton2.Checked)
            {
                Komut("select * from Movies where score >=0  and score<4 order by watchingStatus");
            }
            else if (radioButton3.Checked)
            {
                Komut("select * from Series where score >=0  and score<4  order by watchingStatus");
            }
        }
    }
}
