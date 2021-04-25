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
    public partial class manager : Form
    {

        string userid2 = "";
        SqlConnection con = new SqlConnection("Data Source = INTEL; Database = questproj; Integrated Security = True");
        public manager(string uid2)
        {

            InitializeComponent();
            userid2 = uid2;
        }

        private void manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'questprojDataSet56.admintasks' table. You can move, or remove it, as needed.
            this.admintasksTableAdapter5.Fill(this.questprojDataSet56.admintasks);
            // TODO: This line of code loads data into the 'questprojDataSet55.admintasks' table. You can move, or remove it, as needed.
            this.admintasksTableAdapter4.Fill(this.questprojDataSet55.admintasks);
            // TODO: This line of code loads data into the 'questprojDataSet54.administ' table. You can move, or remove it, as needed.
            this.administTableAdapter1.Fill(this.questprojDataSet54.administ);
            // TODO: This line of code loads data into the 'questprojDataSet53.administ' table. You can move, or remove it, as needed.
            this.administTableAdapter.Fill(this.questprojDataSet53.administ);
            // TODO: This line of code loads data into the 'questprojDataSet40.admintasks' table. You can move, or remove it, as needed.
            this.admintasksTableAdapter3.Fill(this.questprojDataSet40.admintasks);
            // TODO: This line of code loads data into the 'questprojDataSet39.admintasks' table. You can move, or remove it, as needed.
            this.admintasksTableAdapter2.Fill(this.questprojDataSet39.admintasks);
            // TODO: This line of code loads data into the 'questprojDataSet38.tleader' table. You can move, or remove it, as needed.
            this.tleaderTableAdapter3.Fill(this.questprojDataSet38.tleader);
            // TODO: This line of code loads data into the 'questprojDataSet37.tleader' table. You can move, or remove it, as needed.
            this.tleaderTableAdapter2.Fill(this.questprojDataSet37.tleader);
            // TODO: This line of code loads data into the 'questprojDataSet36.managetasks' table. You can move, or remove it, as needed.
            this.managetasksTableAdapter1.Fill(this.questprojDataSet36.managetasks);
            // TODO: This line of code loads data into the 'questprojDataSet35.managetasks' table. You can move, or remove it, as needed.
            this.managetasksTableAdapter.Fill(this.questprojDataSet35.managetasks);
            // TODO: This line of code loads data into the 'questprojDataSet14.tleader' table. You can move, or remove it, as needed.
            this.tleaderTableAdapter1.Fill(this.questprojDataSet14.tleader);
            // TODO: This line of code loads data into the 'questprojDataSet13.tleader' table. You can move, or remove it, as needed.
            this.tleaderTableAdapter.Fill(this.questprojDataSet13.tleader);
            // TODO: This line of code loads data into the 'questprojDataSet12.leadertask' table. You can move, or remove it, as needed.
            this.leadertaskTableAdapter.Fill(this.questprojDataSet12.leadertask);
            // TODO: This line of code loads data into the 'questprojDataSet11.admintasks' table. You can move, or remove it, as needed.
            this.admintasksTableAdapter1.Fill(this.questprojDataSet11.admintasks);
            // TODO: This line of code loads data into the 'questprojDataSet10.admintasks' table. You can move, or remove it, as needed.
            this.admintasksTableAdapter.Fill(this.questprojDataSet10.admintasks);
            // TODO: This line of code loads data into the 'questprojDataSet2.tmanager' table. You can move, or remove it, as needed.
            this.tmanagerTableAdapter.Fill(this.questprojDataSet2.tmanager);

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tmanager  where user_id2 = '" + userid2 + "'", con);
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel2.Visible = true;
            guna2Panel3.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  adwhere user_id2 = '" + userid2 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                richTextBox2.Text = dr.GetValue(4).ToString();
            }
            con.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from admintasks where user_id2 = '" + userid2 + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = true;
            guna2Panel2.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into managetasks values('" + guna2ComboBox1.Text.ToString() + "','" + guna2ComboBox2.Text.ToString() + "','" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "' ,'" + richTextBox1.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox4.Text + "','" + guna2DateTimePicker1.Value.ToString() + "','" + guna2DateTimePicker2.Value.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("assigned successfully");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = true;
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from managetasks where user_id3 = '" + userid2 + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            con.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tmanager where user_id2= '" + userid2 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label17.Text = dr.GetValue(2).ToString();
                label24.Text = dr.GetValue(0).ToString();
            }


        }

        private void estguna2Button9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" insert into  admanagestat values ('" + idguna2ComboBox3.Text.ToString() + "','" + namguna2ComboBox4.Text.ToString() + "' , '" + guna2TextBox5.Text + "' , ' " + levguna2ComboBox5.Text.ToString() + "' ) ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" status established ");
        }

        private void updguna2Button10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update   admanagestat   set progress2 = '" + guna2TextBox5.Text + "',statuslev2 = '" + levguna2ComboBox5.Text.ToString() + " where taskid2 = '" + idguna2ComboBox3.Text.ToString() + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("status updated ");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void VSguna2Button9_Click(object sender, EventArgs e)
        {
            label33.Visible = true;
            label34.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from mleaderstat where taskid3 = '" + guna2ComboBox5.Text.ToString() + "' and taskname3 = '" + guna2ComboBox6.Text.ToString() + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label33.Text = dr.GetValue(3).ToString();
                label34.Text = dr.GetValue(2).ToString();

            }
            con.Close();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

            label41.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from administ   where user_id1 = '" + userid2 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label41.Text = dr.GetValue(4).ToString();
            }
            con.Close();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into managesub values('" + guna2ComboBox7.Text.ToString() + "','" + guna2ComboBox8.Text.ToString() + "','" + guna2ComboBox9.Text.ToString() + "','" + guna2ComboBox10.Text.ToString() + "','" + richTextBox3.Text + "','" + label41.Text + "' ),con ");
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("submitted successfully");
        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from leadersub where user_id3 = '" + userid2 + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView3.DataSource = dt;
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

