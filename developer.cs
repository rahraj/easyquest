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
using System.IO;


namespace quest_project
{
    public partial class developer : Form
    {
        string userid4 = "";
        SqlConnection con = new SqlConnection("Data Source = INTEL; Database = questproj; Integrated Security = True");
        public developer(string uid4)
        {
            InitializeComponent();
            userid4 = uid4;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  develop  where user_id4 = '" + userid4 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr.GetValue(2).ToString();
                label10.Text = dr.GetValue(0).ToString();
                label11.Text = dr.GetValue(6).ToString();
                label12.Text = dr.GetValue(4).ToString();
                label13.Text = dr.GetValue(5).ToString();

            }
            con.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from leadertask  where user_id4 = '" + userid4 + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  leadertask where user_id4 = '" + userid4 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                richTextBox1.Text = dr.GetValue(4).ToString();
            }
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel2.Visible = true;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = true;
            guna2Panel2.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  develop  where user_id4 = '" + userid4 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label17.Text = dr.GetValue(2).ToString();
                label24.Text = dr.GetValue(0).ToString();
            }
            con.Close();
        }

        private void estguna2Button9_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand(" insert into  leadevelopestat values ('" + idguna2ComboBox3.Text.ToString() + "','" + namguna2ComboBox4.Text.ToString() + "' , '" + guna2TextBox5.Text + "' , ' " + levguna2ComboBox5.Text.ToString() + "' ) ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" status established ");
        }

        private void updguna2Button10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update   leadevelopestat  set progress4 = '" + guna2TextBox5.Text + "',statuslev3 = '" + levguna2ComboBox5.Text.ToString() + " where taskid3 = '" + idguna2ComboBox3.Text.ToString() + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("status updated ");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = true;
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
        }

        private void developer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'questprojDataSet46.leadertask' table. You can move, or remove it, as needed.
            this.leadertaskTableAdapter4.Fill(this.questprojDataSet46.leadertask);
            // TODO: This line of code loads data into the 'questprojDataSet45.leadertask' table. You can move, or remove it, as needed.
            this.leadertaskTableAdapter3.Fill(this.questprojDataSet45.leadertask);
            // TODO: This line of code loads data into the 'questprojDataSet44.tleader' table. You can move, or remove it, as needed.
            this.tleaderTableAdapter1.Fill(this.questprojDataSet44.tleader);
            // TODO: This line of code loads data into the 'questprojDataSet43.tleader' table. You can move, or remove it, as needed.
            this.tleaderTableAdapter.Fill(this.questprojDataSet43.tleader);
            // TODO: This line of code loads data into the 'questprojDataSet26.leadertask' table. You can move, or remove it, as needed.
            this.leadertaskTableAdapter2.Fill(this.questprojDataSet26.leadertask);
            // TODO: This line of code loads data into the 'questprojDataSet25.leadertask' table. You can move, or remove it, as needed.
            this.leadertaskTableAdapter1.Fill(this.questprojDataSet25.leadertask);
            // TODO: This line of code loads data into the 'questprojDataSet24.leadertask' table. You can move, or remove it, as needed.
            this.leadertaskTableAdapter.Fill(this.questprojDataSet24.leadertask);
            // TODO: This line of code loads data into the 'questprojDataSet23.leadevelopestat' table. You can move, or remove it, as needed.
            this.leadevelopestatTableAdapter1.Fill(this.questprojDataSet23.leadevelopestat);
            // TODO: This line of code loads data into the 'questprojDataSet22.leadevelopestat' table. You can move, or remove it, as needed.
            this.leadevelopestatTableAdapter.Fill(this.questprojDataSet22.leadevelopestat);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

       
    
        

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into developesub values('" + guna2ComboBox1.Text.ToString() + "','" + guna2ComboBox2.Text.ToString() + "','" + guna2ComboBox3.Text.ToString() + "','" + guna2ComboBox4.Text.ToString() + "','" + richTextBox2.Text + "','" + label31.Text + "' ),con ");
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("submitted successfully");

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            label31.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tleader  where user_id3 = '" + userid4 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label31.Text = dr.GetValue(4).ToString();
            }
            con.Close();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
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
