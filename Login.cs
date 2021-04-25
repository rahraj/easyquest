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
using System.Threading;

namespace quest_project
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source = INTEL; Database = questproj; Integrated Security = True");
        public Login()
        {
            InitializeComponent();
        }

      

        private void guna2Button1log_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;

        }
                      //speradmin
        private void guna2Button2_Click(object sender, EventArgs e)
        {
              if(guna2TextBox1.Text == "super" && guna2TextBox2.Text == "super")
            {
                MessageBox.Show("signed as superadmin");
                super sp = new super();
                sp.Show();
                this.Hide();
            }
        }
        //admin
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from administ where user_id1 = '" + guna2TextBox1.Text + "' and pass1 = '" + guna2TextBox2.Text + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("signed in as admin");
                admin ad = new admin(guna2TextBox1.Text);
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
            con.Close();




        }
                     //manager
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2= new SqlCommand("select * from tmanager where user_id2 = '" + guna2TextBox1.Text + "' and pass2= '" + guna2TextBox2.Text + "' ", con);
            SqlDataReader dr1 = cmd2.ExecuteReader();
            if (dr1.Read())
            {
                MessageBox.Show("signed in as manager");
                manager mg = new manager(guna2TextBox1.Text);
                mg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
            con.Close();

        }

                       //leader

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from tleader where user_id3  = '" + guna2TextBox1.Text + "' and pass3 = '" + guna2TextBox2.Text + "' ", con);
            SqlDataReader dr2 = cmd3.ExecuteReader();
            if (dr2.Read())
            {
                MessageBox.Show("signed in as leader");
                leader ld = new leader(guna2TextBox1.Text);
                ld.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
            con.Close();

        }
                             //developer
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select * from develop where user_id4  = '" + guna2TextBox1.Text + "' and pass4 = '" + guna2TextBox2.Text + "' ", con);
            SqlDataReader dr3 = cmd4.ExecuteReader();
            if (dr3.Read())
            {
                MessageBox.Show("signed in as developer");
                developer dp = new developer(guna2TextBox1.Text);
                dp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CONTACT SUPERADMIN");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            about ab = new about();
            ab.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            terms tr = new terms();
            tr.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            privacy pr = new privacy();
            pr.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
