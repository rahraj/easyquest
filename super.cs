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


namespace quest_project
{
    public partial class super : Form
    {
        SqlConnection con = new SqlConnection("Data Source = INTEL; Database = questproj; Integrated Security = True");
        public super()
        {
            InitializeComponent();
        }
                  
        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedItem.ToString() == "ADMIN")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into administ values('" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox4.Text + "','" + guna2TextBox5.Text + "','" + guna2TextBox6.Text + "','" +guna2TextBox7.Text+ "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("registered as admin");
            }
            else if (guna2ComboBox1.SelectedItem.ToString() == "TEAM MANAGER")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tmanager  values('" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox4.Text + "','" + guna2TextBox5.Text + "','" + guna2TextBox6.Text + "','" + guna2TextBox7.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("registered as team manager");
            }
            else if (guna2ComboBox1.SelectedItem.ToString() == "TEAM LEADER")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tleader  values('" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox4.Text + "','" + guna2TextBox5.Text + "','" + guna2TextBox6.Text + "','" + guna2TextBox7.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("registered as team leader");
            }
            else if (guna2ComboBox1.SelectedItem.ToString() == "DEVELOPER")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tleader  values('" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox4.Text + "','" + guna2TextBox5.Text + "','" + guna2TextBox6.Text + "','" + guna2TextBox7.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("registered as developer");
            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void clearButton1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();
            guna2TextBox5.Clear();
            guna2TextBox6.Clear();
            guna2TextBox7.Clear();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void super_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'questprojDataSet68.mleaderstat' table. You can move, or remove it, as needed.
            this.mleaderstatTableAdapter1.Fill(this.questprojDataSet68.mleaderstat);
            // TODO: This line of code loads data into the 'questprojDataSet67.leadevelopestat' table. You can move, or remove it, as needed.
            this.leadevelopestatTableAdapter.Fill(this.questprojDataSet67.leadevelopestat);
            // TODO: This line of code loads data into the 'questprojDataSet66.develop' table. You can move, or remove it, as needed.
            this.developTableAdapter.Fill(this.questprojDataSet66.develop);
            // TODO: This line of code loads data into the 'questprojDataSet65.mleaderstat' table. You can move, or remove it, as needed.
            this.mleaderstatTableAdapter.Fill(this.questprojDataSet65.mleaderstat);
            // TODO: This line of code loads data into the 'questprojDataSet64.tleader' table. You can move, or remove it, as needed.
            this.tleaderTableAdapter.Fill(this.questprojDataSet64.tleader);
            // TODO: This line of code loads data into the 'questprojDataSet63.tmanager' table. You can move, or remove it, as needed.
            this.tmanagerTableAdapter.Fill(this.questprojDataSet63.tmanager);
            // TODO: This line of code loads data into the 'questprojDataSet62.admanagestat' table. You can move, or remove it, as needed.
            this.admanagestatTableAdapter1.Fill(this.questprojDataSet62.admanagestat);
            // TODO: This line of code loads data into the 'questprojDataSet61.suadminstat' table. You can move, or remove it, as needed.
            this.suadminstatTableAdapter.Fill(this.questprojDataSet61.suadminstat);
            // TODO: This line of code loads data into the 'questprojDataSet60.admanagestat' table. You can move, or remove it, as needed.
            this.admanagestatTableAdapter.Fill(this.questprojDataSet60.admanagestat);
            // TODO: This line of code loads data into the 'questprojDataSet59.administ' table. You can move, or remove it, as needed.
            this.administTableAdapter3.Fill(this.questprojDataSet59.administ);
            // TODO: This line of code loads data into the 'questprojDataSet6.supertask' table. You can move, or remove it, as needed.
            this.supertaskTableAdapter2.Fill(this.questprojDataSet6.supertask);
            // TODO: This line of code loads data into the 'questprojDataSet5.supertask' table. You can move, or remove it, as needed.
            this.supertaskTableAdapter1.Fill(this.questprojDataSet5.supertask);
            // TODO: This line of code loads data into the 'questprojDataSet4.supertask' table. You can move, or remove it, as needed.
            this.supertaskTableAdapter.Fill(this.questprojDataSet4.supertask);
            // TODO: This line of code loads data into the 'questprojDataSet3.administ' table. You can move, or remove it, as needed.
            this.administTableAdapter2.Fill(this.questprojDataSet3.administ);
            // TODO: This line of code loads data into the 'questprojDataSet1.administ' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'questprojDataSet.administ' table. You can move, or remove it, as needed.


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2aTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void assguna2Button7_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into supertask values('" + comboBox1.Text.ToString() + "','" + asstxt1.Text + "','" + asstxt2.Text + "','" + richTextBox1.Text + "','" + asstxt3.Text + "','" + guna2DateTimePicker1.Value.ToString() + "','" + guna2DateTimePicker2.Value.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Assigned successfully");
        }

       private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            guna2Panel2.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel3.Visible = false;
            viewpanel.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            guna2Panel3.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel2.Visible = false;
            viewpanel.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            viewpanel.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
            viewpanel.Visible = false;
            guna2Panel4.Visible = false;
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
            viewpanel.Visible = false;
            guna2Panel4.Visible = true;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            label20.Visible = true;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from suadminstat where projID1  = '" + guna2ComboBox8.Text.ToString() + "'  ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label19.Text = dr.GetValue(2).ToString();
                label20.Text = dr.GetValue(3).ToString();
            }
            con.Close();
        }

        private void MVSguna2Button9_Click(object sender, EventArgs e)
        {
            label23.Visible = true;
            label33.Visible = true;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from admanagestat where taskid2  = '" + guna2ComboBox5.Text.ToString() + "'  ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label23.Text = dr.GetValue(2).ToString();
                label33.Text = dr.GetValue(3).ToString();
            }
            con.Close();
        }

        private void LVSguna2Button7_Click(object sender, EventArgs e)
        {
            label34.Visible = true;
            label4.Visible = true;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from mleaderstat where taskid3  = '" + guna2ComboBox2.Text.ToString() + "'  ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label34.Text = dr.GetValue(2).ToString();
                label4.Text = dr.GetValue(3).ToString();
            }
            con.Close();
        }

        private void DVSguna2Button8_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label10.Visible = true;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from leadevelopestat  where taskid4  = '" + guna2ComboBox4.Text.ToString() + "'  ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label9.Text = dr.GetValue(2).ToString();
                label10.Text = dr.GetValue(3).ToString();
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