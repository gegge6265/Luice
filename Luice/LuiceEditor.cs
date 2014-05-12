using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Luice
{
    public partial class LuiceEditor : Form
    {
        
        public LuiceEditor()
        {
            InitializeComponent();
                        
        }
        private readonly Form1 connform;
        public LuiceEditor(Form1 form1)
        {
            InitializeComponent();
            connform = form1;
        }
        private void findCreatureBtn_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn1 = new MySqlConnection("Server="+ connform.GetHost() + ";Database="+ connform.GetWorld()+";UID="+connform.GetUser() + ";Password="+connform.GetPsw()+";");
            conn1.Open();

            MySqlCommand cmd = new MySqlCommand("select entry, name, subname from creature_template where entry = "+npcEntryTxt.Text+"; ", conn1);
            MySqlDataReader read = cmd.ExecuteReader();
            int pos = -1;
            while(read.Read())
            {
                pos = creatureSearchDgv.Rows.Add();
                creatureSearchDgv.Rows[pos].Cells["entry"].Value = Convert.ToString(read["entry"]);
                creatureSearchDgv.Rows[pos].Cells["name"].Value = Convert.ToString(read["name"]);
                creatureSearchDgv.Rows[pos].Cells["subname"].Value = Convert.ToString(read["subname"]);
            }
            conn1.Close();
        }
    }
}
