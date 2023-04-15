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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server = LAPTOP-DI6H08K1; Database = WatchingList; Integrated Security = true;");

        public void Listele(string komutkod)
        {
            SqlDataAdapter da = new SqlDataAdapter(komutkod, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listb_Click(object sender, EventArgs e)
        {
            Listele("select * from movies");
        }

        private void addb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into movies(movieName, category, year, wdate, watchingStatus, score) " +
                "                           values(@movieName, @category, @year, @wdate, @watchingStatus, @score)", conn);
            cmd.Parameters.AddWithValue("@movieName", mnametxt.Text);
            cmd.Parameters.AddWithValue("@category", catcbx.Text);
            cmd.Parameters.AddWithValue("@year",yeartxt.Text);
            cmd.Parameters.AddWithValue("@wdate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@watchingStatus", wstcbx.Text);
            cmd.Parameters.AddWithValue("@score",trackBar1.Value);
            cmd.ExecuteNonQuery();

            conn.Close();
            Listele("select * from movies");
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update movies set movieName = '"+mnametxt.Text.ToString()+"'," +
                " category = '"+catcbx.Text.ToString()+"', year = '" +yeartxt.Text.ToString()+"' , wdate = '"+dateTimePicker1.Text.ToString()+"'," +
                "watchingStatus = '"+wstcbx.Text.ToString()+"', score ='"+trackBar1.Value+"' where movieID = @movieID", conn);
            cmd.Parameters.AddWithValue("@movieID",mnametxt.Tag);
            //cmd.Parameters.AddWithValue("@movieName", mnametxt.Text);
            //cmd.Parameters.AddWithValue("@category", catcbx.Text);
            //cmd.Parameters.AddWithValue("@year", yeartxt.Text);
            //cmd.Parameters.AddWithValue("@wdate", dateTimePicker1.Text);
            //cmd.Parameters.AddWithValue("@watchingStatus", wstcbx.Text);
            //cmd.Parameters.AddWithValue("@score", trackBar1.Value);
            cmd.ExecuteNonQuery();

            conn.Close();
            Listele("select * from movies");
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from movies where movieID = @movieID", conn);
            cmd.Parameters.AddWithValue("@movieID", mnametxt.Tag);
            cmd.ExecuteNonQuery();

            conn.Close();
            Listele("select * from movies");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            mnametxt.Text = satir.Cells["movieName"].Value.ToString();
            catcbx.Text = satir.Cells["category"].Value.ToString();
            yeartxt.Text = satir.Cells["year"].Value.ToString();
            dateTimePicker1.Text = satir.Cells["wdate"].Value.ToString();
            wstcbx.Text = satir.Cells["watchingStatus"].Value.ToString();
            
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            if (wstcbx.SelectedIndex == 0)
            {
                Listele("select * from movies where watchingStatus = 'Waiting to Watching'");
            }
            else if (wstcbx.SelectedIndex == 2)
            {
                Listele("select * from movies where watchingStatus = 'Still Watching'");
            }
            else if (wstcbx.SelectedIndex == 1)
            {
                Listele("select * from movies where watchingStatus = 'Just Starting'");
            }
            else
            {
                Listele("select * from movies where watchingStatus = 'Finished'");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (catcbx.SelectedIndex == 0)
            {
                Listele("select * from movies where Category = 'Romance'");
            }
            else if (catcbx.SelectedIndex == 1)
            {
                Listele("select * from movies where Category = 'Comedy'");
            }
            else if (catcbx.SelectedIndex == 2)
            {
                Listele("select * from movies where Category = 'Action'");
            }
            else
            {
                Listele("select * from movies where Category = 'Fantastic'");
            }
        }
    }
}
