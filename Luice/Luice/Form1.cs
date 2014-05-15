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
        public string GetPort()
        {
            return portTxt.Text;
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

        bool sshconn = false;
        private void connBtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sshconn = true;
                try
                {
                    using (var client = new SshClient(hostTxt.Text, uidTxt.Text, passwordTxt.Text))
                    {
                        client.Connect();
                        client.Disconnect();
                        MessageBox.Show("logged in!");
                    }
                    LuiceEditor editor = new LuiceEditor(this);
                    editor.Show();
                }
                catch
                {
                    MessageBox.Show("error: check again the data that you inserted and retry.");
                }
            }
            else
            {
                sshconn = false;
                string connection1 = "Server=" + hostTxt.Text + ";Port=" + portTxt.Text + ";Database=" + authTxt.Text + ";UID=" + uidTxt.Text + ";Password=" + passwordTxt.Text + ";";
                string connection2 = "Server=" + hostTxt.Text + ";Port=" + portTxt.Text + ";Database=" + charTxt.Text + ";UID=" + uidTxt.Text + ";Password=" + passwordTxt.Text + ";";
                string connection3 = "Server=" + hostTxt.Text + ";Port=" + portTxt.Text + ";Database=" + worldTxt.Text + ";UID=" + uidTxt.Text + ";Password=" + passwordTxt.Text + ";";
                MySqlConnection conn1 = new MySqlConnection(connection1);
                MySqlConnection conn2 = new MySqlConnection(connection2);
                MySqlConnection conn3 = new MySqlConnection(connection3);

                try
                {
                    //this is needed only to check if inserted data is correct
                    conn1.Open();
                    conn2.Open();
                    conn3.Open();
                    //closing test connections
                    conn1.Close();
                    conn2.Close();
                    conn3.Close();
                    MessageBox.Show("logged in!");
                    //passing method from form1 to LuiceEditor Form
                    LuiceEditor editor = new LuiceEditor(this);
                    editor.Show();
                }
                catch
                {
                    MessageBox.Show("error: check again the data that you inserted and retry.");
                }
                
            }
            
        }
        public bool GetSsh()
        {
            return sshconn;
        }
    }
}
