using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceStudioManagementSystem
{
    public partial class Authorization : Form
    {
        
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "Admin" && txtUserPassword.Text == "1234")
                {
                    new HomePage().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The username or password you entered is incorrect, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtUserPassword.Clear();
                    txtUserName.Focus();
                }
            }
            catch
            {
                    throw;     
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
