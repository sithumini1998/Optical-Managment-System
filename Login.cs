using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wikramarachchi_Opticians
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username=="man" && password=="1234")
            {
                this.Close();
                Manager manager = new Manager();
                manager.Show();
                
            }

            else if (username == "rec" && password == "1234")
            {
                this.Close();
                Receptionist receptionist = new Receptionist();
                receptionist.Show();
                
            }

            else if (username == "eye" && password == "1234")
            {
                this.Close();
                Eye_Technician eye_Technician = new Eye_Technician();
                eye_Technician.Show();

            }
            else if (username == "wor" && password == "1234")
            {
                this.Close();
                Workshop workshop = new Workshop();
                workshop.Show();
            }
            else
            {
                MessageBox.Show("Wrong User name 'OR' Password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
