using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace GroupProject
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void Registeration_Load(object sender, EventArgs e)
        {
            

        }
        OleDbConnection con1 = new OleDbConnection("provider=MSDAORA;Data Source=XE;User ID=baqer1;Password=qawsedrf;Unicode=True");

        private void button1_Click(object sender, EventArgs e)
        {
          

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void displaybu_Click(object sender, EventArgs e)
        {

        }
        DataTable dt1 = new DataTable();
        private void displaybu_Click_1(object sender, EventArgs e)
        {
            con1.Open();
            OleDbDataAdapter od = new OleDbDataAdapter("select *from register ORDER BY id ASC", con1);
            
            od.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con1.Close();
        }
        spic sp = new spic();
        private void Insertbu_Click(object sender, EventArgs e)
        {

            
            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into register  values( null ,'" + nametxt.Text + "','" + dobtxt.Text + "','" + pobtxt.Text + "','" + comboBox1.Text + "'," + ncntxt.Text + ",'" + natiotxt.Text + "','" + reli.Text + "','" + comboBox2.Text + "', " + noctxt.Text + ",'" + comboBox3.Text + "', '" + doatxt.Text + "','" + qualitxt.Text + "','" + doqtxt.Text + "','" + comboBox4.Text+ "', " + pntxt.Text + ",'" + emailtxt.Text + "','"+comboBox3.Text+"')", con1);
                con1.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("data not inserted" + ex.Message);
            }
            finally
            {

                con1.Close();
            }
            string var;
            var = comboBox3.Text;
            if (var == "temporary")
            {
                this.Hide();
                sp.Show();

            }
            }
      
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con1.Open();
            OleDbDataAdapter od = new OleDbDataAdapter("select *from register where fullname LIKE'"+textBox2.Text+"%'", con1);
            DataTable dt1 = new DataTable();
            od.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con1.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        
        
        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dISPLAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con1.Open();
            OleDbDataAdapter od = new OleDbDataAdapter("SELECT  nightshift.Doctor_ID,register.fullname,nightshift. Reservist_doctor, nightshift.shift_date FROM nightshift INNER JOIN register ON register.id = nightshift.Doctor_ID ", con1);
            DataTable dt1 = new DataTable();
            od.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con1.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        _ِAdvisory addv = new _ِAdvisory();
        private void advisoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addv.Show();
        }
    }
}
