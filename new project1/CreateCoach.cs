using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace new_project1
{
    public partial class CreateCoach : Form
    {
        public CreateCoach()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\97254\Desktop\new project1\Tables\ListPlayer1.mdf"";Integrated Security=True;Connect Timeout=30");

        private void ADD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Coach set idh = '" + idh.Text + "',nameh ='" + nameh.Text + "',cittizenshiph ='" + cittizenshiph.Text + "',seniorityh='" + seniorityh.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Coach successfuly swap");
            con.Close();
            populate();
        }
        void populate()
        {
            try
            {
                con.Open();
                string Coach2 = "select * from Coach";
                SqlDataAdapter DA = new SqlDataAdapter(Coach2, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(DA);
                var ds = new DataSet();
                DA.Fill(ds);
                Coach1.DataSource = ds.Tables[0];

                
                con.Close();
            }
            catch { }
        }

        private void idh_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameh_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void CreateCoach_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
