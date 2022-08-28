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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void btnPatientReg_Click(object sender, EventArgs e)
        {
            this.Close();

            Patient_Register patient_Register = new Patient_Register();
            patient_Register.Show();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            this.Close();

            Patient_View patient_View = new Patient_View();
            patient_View.Show();
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Checkout checkout = new Checkout();
            checkout.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
