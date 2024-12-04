using new_project1;
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
using System.Runtime.Serialization.Formatters.Binary;
namespace new_project1
{
    public partial class MaccabiTelAviv : Form
    {
        public MaccabiTelAviv instance;
        Coach coachForm;
        
        public static Person maccbi;

        Coach chForm1 = new Coach();
        int curplase = -1;
        int count = 0;
        public MaccabiTelAviv()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(listmanager.saveperson);

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\97254\Desktop\new project1\Tables\ListPlayer1.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           panel4.Visible= true;
           
            populate();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel4.Visible = false;
            panel5.Visible = true;
            center2.Visible = true;
            shooter2.Visible = false;
            dataGridView1.DataSource = listmanager.Getspecificperson<playercenter>();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel4.Visible = false;
            panel5.Visible = true;
            center2.Visible = false;
            shooter2.Visible = true;
            dataGridView1.DataSource = listmanager.Getspecificperson<shootPlayer>();
        }

        public void UpdateBySql()
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void ADD_Click(object sender, EventArgs e)
        {
            shooter2.Visible = true;
            if (ids.Text != "" && names.Text != "" && cittizenships.Text != "" && professionals.Text != "" && avgdunks.Text != "")
            {
                if (professionals.Text != "true" && professionals.Text != "false")
                {
                    MessageBox.Show("you have a problem with professional");
                }
                else if (1 == listmanager.findperson1(ids.Text))
                {
                    MessageBox.Show("enter corect id");
                }
                 else if (1 == listmanager.findperson(float.Parse(ids.Text)))
                {
                    MessageBox.Show("user already exists");
                }
                else
                {
                    try
                    {
                        shootPlayer sp = new shootPlayer(float.Parse(ids.Text), names.Text, cittizenships.Text, professionals.Text, double.Parse(avgdunks.Text));
                        listmanager.Addperson(sp);
                        dataGridView1.DataSource = listmanager.Getspecificperson<shootPlayer>();

                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into shooterplayer values('" + ids.Text + "','" + names.Text + "','" + cittizenships.Text + "','" + professionals.Text + "','" + avgdunks.Text + "')", con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("shooter player successfuly added");

                        con.Close();

                        ids.Clear(); names.Clear(); cittizenships.Clear(); professionals.Clear(); avgdunks.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("fill all textbox");
            }
            }


       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cittizenshipc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            center2.Visible = true;
            if (idc.Text != "" && namec.Text != "" && cittizenshipc.Text != "" && professionalc.Text != "" && heightc.Text != "")
            {
                if (professionalc.Text != "true" && professionalc.Text != "false")
                {
                    MessageBox.Show("you have a problem with professional");
                }
                else if (1 == listmanager.findperson1(idc.Text))
                {
                    MessageBox.Show("enter corect id");
                }
                else if(1==listmanager.findperson(float.Parse(idc.Text)))
                {
                    MessageBox.Show("user already exists");
                }
                else
                {
                    try
                    {

                        //maccabi[maccabi.NextIndex] = new playercenter(float.Parse(idc.Text), namec.Text, cittizenshipc.Text, professionalc.Text, double.Parse(heightc.Text));
                        dataGridView1.DataSource = listmanager.Getspecificperson<playercenter>();
                        playercenter pl = new playercenter(float.Parse(idc.Text), namec.Text, cittizenshipc.Text, professionalc.Text, double.Parse(heightc.Text));
                        listmanager.Addperson(pl);
                        dataGridView1.DataSource = listmanager.Getspecificperson<playercenter>();
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("insert into playercenter values('" + idc.Text + "','" + namec.Text + "','" + cittizenshipc.Text + "','" + professionalc.Text + "','" + heightc.Text + "')", con);
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("center player successfuly added");


                        con.Close();
                        idc.Clear(); namec.Clear(); cittizenshipc.Clear(); professionalc.Clear(); heightc.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
           else
            {
                MessageBox.Show("fill all textbox");
            }
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
                coach12.DataSource = ds.Tables[0];
                con.Close();
            }
            catch { }
        }

       

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (idh1.Text != "" && nameh1.Text != "" && cittizenshiph1.Text != "" && seniorityh1.Text != "")
            {
                
                    try
                    {
                        coach ch = new coach(float.Parse(idh1.Text), nameh1.Text, cittizenshiph1.Text, int.Parse(seniorityh1.Text));
                        listmanager.Addperson(ch);
                        dataGridView1.DataSource = listmanager.Getspecificperson<coach>();
                        con.Open();

                        SqlCommand cmd = new SqlCommand("update Coach set idh1 = '" + idh1.Text + "',nameh1 ='" + nameh1.Text + "',cittizenshiph1 ='" + cittizenshiph1.Text + "',seniorityh1='" + seniorityh1.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Coach successfuly swap");
                        con.Close();
                        idh1.Clear(); nameh1.Clear(); cittizenshiph1.Clear(); seniorityh1.Clear();
                        populate();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
            }
        }

        private void coach12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            chForm1 =new Coach();
            try
            {
                chForm1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

       
        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel5.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int row =dataGridView1.CurrentRow.Index;
            
            if (dataGridView1.Rows.Count != 0 && dataGridView1.Rows[row].Selected == true)
            {
                listmanager.deleteperson(row);
                dataGridView1.DataSource = listmanager.Getperson();
                
            }
            else
                MessageBox.Show("please choose valid row");


        }
    }
    }