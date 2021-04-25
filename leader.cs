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

    public partial class leader : Form
    {
        string userid3 = "";
        SqlConnection con = new SqlConnection("Data Source = INTEL; Database = questproj; Integrated Security = True");
        public leader(string uid3)
        {
            InitializeComponent();
            userid3 = uid3;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tleader  where user_id3 = '" + userid3 + "'", con);
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
            guna2Panel4.Visible = false;
            guna2Panel5.Visible = false;
        }

        private void leader_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'questprojDataSet52.managetasks' table. You can move, or remove it, as needed.
            this.managetasksTableAdapter5.Fill(this.questprojDataSet52.managetasks);
            // TODO: This line of code loads data into the 'questprojDataSet51.managetasks' table. You can move, or remove it, as needed.
            this.managetasksTableAdapter4.Fill(this.questprojDataSet51.managetasks);
            // TODO: This line of code loads data into the 'questprojDataSet50.tmanager' table. You can move, or remove it, as needed.
            this.tmanagerTableAdapter1.Fill(this.questprojDataSet50.tmanager);
            // TODO: This line of code loads data into the 'questprojDataSet49.tmanager' table. You can move, or remove it, as needed.
            this.tmanagerTableAdapter.Fill(this.questprojDataSet49.tmanager);
            // TODO: This line of code loads data into the 'questprojDataSet48.tleader' table. You can move, or remove it, as needed.
            this.tleaderTableAdapter.Fill(this.questprojDataSet48.tleader);
            // TODO: This line of code loads data into the 'questprojDataSet47.managetasks' table. You can move, or remove it, as needed.
            this.managetasksTableAdapter3.Fill(this.questprojDataSet47.managetasks);
            // TODO: This line of code loads data into the 'questprojDataSet42.managetasks' table. You can move, or remove it, as needed.
            this.managetasksTableAdapter2.Fill(this.questprojDataSet42.managetasks);
            // TODO: This line of code loads data into the 'questprojDataSet41.managetasks' table. You can move, or remove it, as needed.
            this.managetasksTableAdapter1.Fill(this.questprojDataSet41.managetasks);
            // TODO: This line of code loads data into the 'questprojDataSet28.leadevelopestat' table. You can move, or remove it, as needed.
            this.leadevelopestatTableAdapter1.Fill(this.questprojDataSet28.leadevelopestat);
            // TODO: This line of code loads data into the 'questprojDataSet27.leadevelopestat' table. You can move, or remove it, as needed.
            this.leadevelopestatTableAdapter.Fill(this.questprojDataSet27.leadevelopestat);
            // TODO: This line of code loads data into the 'questprojDataSet21.develop' table. You can move, or remove it, as needed.
            this.developTableAdapter3.Fill(this.questprojDataSet21.develop);
            // TODO: This line of code loads data into the 'questprojDataSet20.develop' table. You can move, or remove it, as needed.
            this.developTableAdapter2.Fill(this.questprojDataSet20.develop);
            // TODO: This line of code loads data into the 'questprojDataSet19.develop' table. You can move, or remove it, as needed.
            this.developTableAdapter1.Fill(this.questprojDataSet19.develop);
            // TODO: This line of code loads data into the 'questprojDataSet18.develop' table. You can move, or remove it, as needed.
            this.developTableAdapter.Fill(this.questprojDataSet18.develop);
            // TODO: This line of code loads data into the 'questprojDataSet15.managetasks' table. You can move, or remove it, as needed.
            this.managetasksTableAdapter.Fill(this.questprojDataSet15.managetasks);

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into leadertask values('" + guna2ComboBox1.Text.ToString() + "','" + guna2ComboBox2.Text.ToString() + "','" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "' ,'" + richTextBox1.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox4.Text + "','" + guna2DateTimePicker1.Value.ToString() + "','" + guna2DateTimePicker2.Value.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("assigned successfully");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  managetasks  where user_id3 = '" + userid3 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                richTextBox2.Text = dr.GetValue(4).ToString();
            }
            con.Close();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            guna2DataGridView1.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from managetasks where user_id3 = '" + userid3 + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = true;
            guna2Panel3.Visible = false;
            guna2Panel2.Visible = false;
            guna2Panel5.Visible = false;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from leadertask where user_id4 = '" + userid3 + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            con.Close();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = true;
            guna2Panel4.Visible = false;
            guna2Panel2.Visible = false;
            guna2Panel5.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
            guna2Panel2.Visible = false;
            guna2Panel5.Visible = false;
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tleader  where user_id3 = '" +userid3+ "'", con);
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
            SqlCommand cmd = new SqlCommand(" insert into  mleaderstat values ('" + idguna2ComboBox3.Text.ToString() + "','" + namguna2ComboBox4.Text.ToString() + "' , '" + guna2TextBox5.Text + "' , ' " + levguna2ComboBox5.Text.ToString() + "' ) ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" status established ");
        }

        private void updguna2Button10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update   mleaderstat  set progress3 = '" + guna2TextBox5.Text + "',statuslev3 = '" + levguna2ComboBox5.Text.ToString() + " where taskid3 = '" + idguna2ComboBox3.Text.ToString() + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("status updated ");
        }

        private void VSguna2Button9_Click(object sender, EventArgs e)
        {
            label33.Visible = true;
            label34.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from leadevelopestat where taskid4 = '" + guna2ComboBox5.Text.ToString() + "' and taskname4 = '" + guna2ComboBox6.Text.ToString() + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            
                if(dr.Read())
                {
                    label33.Text = dr.GetValue(3).ToString();
                    label34.Text = dr.GetValue(2).ToString();
                
                }
            con.Close();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
            guna2Panel2.Visible = false;
        }

        private void guna2ComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            label41.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tmanager  where user_id2 = '" + userid3 + "'", con);
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
            SqlCommand cmd = new SqlCommand("insert into leadersub values('" + guna2ComboBox7.Text.ToString() + "','" + guna2ComboBox8.Text.ToString() + "','" + guna2ComboBox9.Text.ToString() + "','" + guna2ComboBox10.Text.ToString() + "','" + richTextBox3.Text + "','" + label41.Text + "' ),con ");
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("submitted successfully");
        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from developesub  where user_id4 = '" + userid3 + "'", con);
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
