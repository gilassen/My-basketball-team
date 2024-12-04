using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace new_project1
{
    using System;
    using System.Collections;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;

    //public void Page_Load(object sender, EventArgs s)
    //{
    //    List<shootPlayer> listsh = new List<shootPlayer>();
    //    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\97254\\Desktop\\new project1\\Tables\\ListPlayer1.mdf\";Integrated Security=True;Connect Timeout=30");
    //    string sql = "select * from Shooterplayer";
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand(sql, con);
    //    SqlDataReader dr = cmd.ExecuteReader();
    //    while (dr.Read())
    //    {
    //        shootPlayer sh1 = new shootPlayer();
    //        sh1.ID = Convert.ToInt64(dr["Ids"]);
    //        sh1.NAME = dr["names"].ToString();
    //        sh1.CIttizenship = dr["cittizenships"].ToString();
    //        sh1.PRofessional = dr["professionals"].ToString();
    //        sh1.AVgdunk = Convert.ToInt32(dr["avgdunks"]);
    //        listsh.Add(sh1);
    //    }

    //}
    [Serializable]
    public class Person
    {
        public
        float id;
        public
        string name;
        public
        string cittizenship;
    


        public  Person(float id, string name, string cittizenship)
        {
            this.id = id;
            this.name = name;
            this.cittizenship = cittizenship;
           
        }
        public float ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public string CIttizenship
        {
            get { return cittizenship; }
            set { cittizenship = value; }
        }
       
        
    }
    [Serializable]
    public  class coach : Person
    {
        public
        int seniority;
        
        

        public coach(float id, string name, string cittizenship, int seniority) : base(id, name, cittizenship)
        {
            this.id=id;
            this.name = name;
            this.cittizenship = cittizenship;
            this.seniority = seniority;

            
        }

        public int SEniority
        {
            get { return seniority; }
            set { seniority = value; }
        }

      

    }
    [Serializable]
    public  class players : Person
    {
        public
        string professional;
        

        public players(float id, string name,  string cittizenship, string professional) : base(id, name, cittizenship)
        {
            this.id = id;
            this.name = name;
            this.cittizenship = cittizenship;
            this.professional = professional;
        }

        public string PRofessional
        {
            get { return professional; }
            set { professional = value; }
        }


    }
    [Serializable]
    public class playercenter : players
    {
       
        double height;
      

        public playercenter(float id, string name, string cittizenship, string professional, double height) : base(id, name,  cittizenship, professional)
        {
            this.id = id;
            this.name = name;
            this.cittizenship = cittizenship;
            this.professional = professional;
            this.height = height;
            
        }
        public double HEight
        {
            get { return height; }
            set { height = value; }
        }

    }
    [Serializable]
    public class shootPlayer : players
    {
        
        double avgdunk;
        

        public shootPlayer(float id, string name, string cittizenship, string professional, double avgdunk) : base(id, name, cittizenship, professional)
        {
            this.id = id;
            this.name = name;
            this.cittizenship = cittizenship;
            this.professional = professional;
            this.avgdunk = avgdunk;
        }

        public double Avgdunk
        {
            get { return avgdunk; }
            set { avgdunk = value; }
        }

    }

    
}



