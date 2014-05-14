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
using Renci.SshNet;

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
            creatureSearchDgv.Rows.Clear(); //if a search already exist, this will clear the data grid view
            if (!connform.GetSsh())
            {

                MySqlConnection conn1 = new MySqlConnection("Server=" + connform.GetHost() + ";Port="+ connform.GetPort() +";Database=" + connform.GetWorld() + ";UID=" + connform.GetUser() + ";Password=" + connform.GetPsw() + ";");
                conn1.Open();

                MySqlCommand cmd = new MySqlCommand("", conn1);
                if (locNumberTxt.Text != "")
                    cmd.CommandText = "select creature_template.entry, name, subname, npcflag, minlevel, maxlevel, name_loc" + locNumberTxt.Text + ", subname_loc" + locNumberTxt.Text + " from creature_template join locales_creature on creature_template.entry = locales_creature.entry where creature_template.entry = " + npcEntryTxt.Text + "; ";
                else
                    cmd.CommandText = "select creature_template.entry, name, subname, npcflag, minlevel, maxlevel from creature_template where creature_template.entry = " + npcEntryTxt.Text + "; ";
                MySqlDataReader read = cmd.ExecuteReader();
                int pos = -1;
                while (read.Read())
                {
                    pos = creatureSearchDgv.Rows.Add();
                    creatureSearchDgv.Rows[pos].Cells["entry"].Value = Convert.ToString(read["entry"]);
                    creatureSearchDgv.Rows[pos].Cells["name"].Value = Convert.ToString(read["name"]);
                    creatureSearchDgv.Rows[pos].Cells["subname"].Value = Convert.ToString(read["subname"]);
                    creatureSearchDgv.Rows[pos].Cells["npcflag"].Value = Convert.ToString(read["npcflag"]);
                    creatureSearchDgv.Rows[pos].Cells["minlevel"].Value = Convert.ToString(read["minlevel"]);
                    creatureSearchDgv.Rows[pos].Cells["maxlevel"].Value = Convert.ToString(read["maxlevel"]);
                    if(locNumberTxt.Text != "")
                    {
                        creatureSearchDgv.Rows[pos].Cells["name_loc"].Value = Convert.ToString(read["name_loc"+locNumberTxt.Text]);
                        creatureSearchDgv.Rows[pos].Cells["subname_loc"].Value = Convert.ToString(read["subname_loc"+locNumberTxt.Text]);
                    }
                }
                conn1.Close();
            }
            else
            {
                MessageBox.Show("mysql ssh connection not yet supported");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
