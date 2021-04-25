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
    public partial class admin : Form
    {
        string userid1 = "";
        SqlConnection con = new SqlConnection("Data Source = INTEL; Database = questproj; Integrated Security = True");

        public admin(string uid1)
        {
            InitializeComponent();
            userid1 = uid1;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  administ  where user_id1 = '" + userid1 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr.GetValue(2).ToString();
                label5.Text = dr.GetValue(0).ToString();
                label9.Text = dr.GetValue(4).ToString();
                label10.Text = dr.GetValue(5).ToString();

            }
            con.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel2.Visible = true;
            statguna2Panel5.Visible = false;

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from supertask where user_id1 = '" + userid1 + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
            guna2Panel4.Visible = false;
            guna2Panel3.Visible = false;
            statguna2Panel5.Visible = false;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'questprojDataSet58.supertask' table. You can move, or remove it, as needed.
            this.supertaskTableAdapter3.Fill(this.questprojDataSet58.supertask);
            // TODO: This line of code loads data into the 'questprojDataSet57.supertask' table. You can move, or remove it, as needed.
            this.supertaskTableAdapter2.Fill(this.questprojDataSet57.supertask);
            // TODO: This line of code loads data into the 'questprojDataSet34.admanagestat' table. You can move, or remove it, as needed.
            this.admanagestatTableAdapter1.Fill(this.questprojDataSet34.admanagestat);
            // TODO: This line of code loads data into the 'questprojDataSet33.admanagestat' table. You can move, or remove it, as needed.
            this.admanagestatTableAdapter.Fill(this.questprojDataSet33.admanagestat);
            // TODO: This line of code loads data into the 'questprojDataSet32.tmanager' table. You can move, or remove it, as needed.
            this.tmanagerTableAdapter4.Fill(this.questprojDataSet32.tmanager);
            // TODO: This line of code loads data into the 'questprojDataSet31.tmanager' table. You can move, or remove it, as needed.
            this.tmanagerTableAdapter3.Fill(this.questprojDataSet31.tmanager);
            // TODO: This line of code loads data into the 'questprojDataSet30.supertask' table. You can move, or remove it, as needed.
            this.supertaskTableAdapter1.Fill(this.questprojDataSet30.supertask);
            // TODO: This line of code loads data into the 'questprojDataSet29.supertask' table. You can move, or remove it, as needed.
            this.supertaskTableAdapter.Fill(this.questprojDataSet29.supertask);
            // TODO: This line of code loads data into the 'questprojDataSet17.admintasks' table. You can move, or remove it, as needed.
            this.admintasksTableAdapter1.Fill(this.questprojDataSet17.admintasks);
            // TODO: This line of code loads data into the 'questprojDataSet16.admintasks' table. You can move, or remove it, as needed.
            this.admintasksTableAdapter.Fill(this.questprojDataSet16.admintasks);
            // TODO: This line of code loads data into the 'questprojDataSet9.tmanager' table. You can move, or remove it, as needed.
            this.tmanagerTableAdapter2.Fill(this.questprojDataSet9.tmanager);
            // TODO: This line of code loads data into the 'questprojDataSet8.tmanager' table. You can move, or remove it, as needed.
            this.tmanagerTableAdapter1.Fill(this.questprojDataSet8.tmanager);
            // TODO: This line of code loads data into the 'questprojDataSet7.tmanager' table. You can move, or remove it, as needed.
            this.tmanagerTableAdapter.Fill(this.questprojDataSet7.tmanager);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = true;
            guna2Panel2.Visible = false;
            guna2Panel4.Visible = false;
            statguna2Panel5.Visible = false;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into admintasks values('" +guna2ComboBox2.Text.ToString()+ "','"+guna2ComboBox1.Text.ToString()+ "','"+guna2TextBox1.Text+"','" +guna2TextBox2.Text + "' ,'"+richTextBox1.Text+ "','" +guna2TextBox3.Text+"','"+guna2TextBox4.Text +"','" +guna2DateTimePicker1.Value.ToString()+ "','"+guna2DateTimePicker2.Value.ToString()+ "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("assigned successfully");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = true;
            guna2Panel3.Visible = false;
            guna2Panel2.Visible = false;
            statguna2Panel5.Visible = false;


            con.Open();
            SqlCommand cmd = new SqlCommand("select * from admintasks where user_id2 = ' " +userid1+ " '  ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            con.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            statguna2Panel5.Visible = true;
            guna2Panel4.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel2.Visible = false;
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  administ  where user_id1 = '" + userid1 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label15.Text = dr.GetValue(0).ToString();
                label17.Text = dr.GetValue(2).ToString();
            }
            con.Close();
        }

        private void estguna2Button9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" insert into suadminstat values ('" + idguna2ComboBox3.Text.ToString() + "','" + namguna2ComboBox4.Text.ToString() + "' , '" + guna2TextBox5.Text + "' , ' " + levguna2ComboBox5.Text.ToString() + "' ) ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" status established ");
                
        }

        private void updguna2Button10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update suadminstat set progress1 = '" + guna2TextBox5.Text + "',statuslev = '" + levguna2ComboBox5.Text.ToString() + " where projID1 = '" + idguna2ComboBox3.Text.ToString()+"' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("status updated ");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from   admintasks  where user_id2=  '" + userid1 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                richTextBox2.Text = dr.GetValue(4).ToString();
            }
            con.Close();
        }

        private void VSguna2Button9_Click(object sender, EventArgs e)
        {
            label33.Visible = true;
            label23.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from admanagestat where taskid2 = '" + guna2ComboBox5.Text.ToString() + "' and taskname2 = '" + guna2ComboBox6.Text.ToString() + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label33.Text = dr.GetValue(3).ToString();

            }
            con.Close();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into adminsub values('" + guna2TextBox6.Text + "','" + guna2TextBox7.Text + "','" + guna2ComboBox9.Text.ToString() + "','" + guna2ComboBox10.Text.ToString() + "','" + richTextBox3.Text + "'  )",con );

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("submitted successfully");
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from managesub where user_id2 = ' " + userid1 + " '  ", con);
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
    }
}

