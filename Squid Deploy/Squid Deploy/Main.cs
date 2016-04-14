using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squid_Deploy
{
    public partial class Main : Form
    {
        TentacleService.TentacleServiceClient Client;

        string Folder = "resources";
        string Enviroment = "DEV";
        string User = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        // If you need to give user priviledges add the user to the following array
        //-------------------------------------------------------------------------
        string[] AllowedUser = new string[] { "hp\\user" };

        public Main()
        {
            InitializeComponent();
            Client = new TentacleService.TentacleServiceClient();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AllowedUser.Contains(User))
            {
                string result = "";


                if (optFolder1.Checked == true)
                {
                    Folder = "resources";
                }
                else
                {
                    Folder = "tools";
                }


                if (optEnv1.Checked == true)
                {
                    Enviroment = "DEV";
                }
                else if (optEnv2.Checked == true)
                {
                    Enviroment = "UAT";
                }
                else
                {
                    Enviroment = "PROD";
                }


                try
                {
                    result = Client.RunTfsToEnv(Folder, Enviroment);
                    if (string.Compare(result, "1") == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Code promtoed from folder " + Folder + " to " + Enviroment + " successful!");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Error returned: " + result);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("User '" + User + "' has no privileges for code promotion." + System.Environment.NewLine + "Please, add this user to the AllowedUser array into Main.cs.", "Squid Deploy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
 
        private void optFolder1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optFolder2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optEnv1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void optEnv2_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void optEnv3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
