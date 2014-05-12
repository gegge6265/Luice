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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string GetHost()
        {
            string host = hostTxt.Text;
            return host;
        }
        public string GetUser()
        {
            string user = uidTxt.Text;
            return user;
        }
        public string GetPsw()
        {
            string psw = passwordTxt.Text;
            return psw;
        }
        public string GetAuth()
        {
            string auth = authTxt.Text;
            return auth;
        }
        public string GetChar()
        {
            string characters = charTxt.Text;
            return characters;
        }
        public string GetWorld()
        {
            string world = worldTxt.Text;
            return world;
        }

        private void connBtn_Click(object sender, EventArgs e)
        {
            string connection1 = "Server=" + hostTxt.Text + ";Database=" + authTxt.Text + ";UID=" + uidTxt.Text + ";Password=" + passwordTxt.Text + ";";
            string connection2 = "Server=" + hostTxt.Text + ";Database=" + charTxt.Text + ";UID=" + uidTxt.Text + ";Password=" + passwordTxt.Text + ";";
            string connection3 = "Server=" + hostTxt.Text + ";Database=" + worldTxt.Text + ";UID=" + uidTxt.Text + ";Password=" + passwordTxt.Text + ";";
            MySqlConnection conn1 = new MySqlConnection(connection1);
            MySqlConnection conn2 = new MySqlConnection(connection2);
            MySqlConnection conn3 = new MySqlConnection(connection3);

            try
            {
                conn1.Open();
                conn2.Open();
                conn3.Open();
            }
            catch
            {
                MessageBox.Show("error: check again the data that you inserted and retry.");
            }
            finally
            {
                string host = GetHost();
                MessageBox.Show("Connection Open!");
                LuiceEditor editor = new LuiceEditor(this);
                editor.Show();
                                
            }
            
            
        }
    }
}
