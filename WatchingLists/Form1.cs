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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server = LAPTOP-DI6H08K1; Database = WatchingList; Integrated Security = true;");


        private void loginb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from users where username=@username and password =@password",conn);
            cmd.Parameters.AddWithValue("@username", unametxt.Text);
            cmd.Parameters.AddWithValue("@password", pswtxt.Text);

            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read()) 
            {
                MessageBox.Show("Login Successful!");
                HomePage hpage = new HomePage();
                this.Hide();
                hpage.Show();
            }
            else 
            {
                MessageBox.Show("Login Failed! Try Again!");
                unametxt.Clear();
                pswtxt.Clear();
            }
            conn.Close();
        }
    }
}
