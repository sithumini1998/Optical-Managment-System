using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wikramarachchi_Opticians
{
    public partial class Workshop : Form
    {

        static string connectionString = @"Data Source=LAPTOP-1EA7J3RA\MSSQLSERVERSITHU;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection conne = new SqlConnection(connectionString);

        public Workshop()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvWorkshop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
             try
            {

                if (conne.State == ConnectionState.Closed)
                    conne.Open();
                SqlCommand cmd = conne.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"insert into Workshop_tb(W_id,P_id,P_fullName,P_age,Right_eye_power,Left_eye_power,L_id,F_id) values('" + txtWorkID.Text + "','" + txtPatientID.Text + "','" + txtFullName.Text + "','" + txtAge.Text + "','" + txtRightEyePower.Text + "','" + txtLeftEyePower.Text + "','" + txtLensID.Text + "','" + txtFrameID.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");


                string sql = @"DELETE FROM Eye_technician_tb WHERE P_id='" + txtPatientID.Text + "'";
                SqlCommand command = new SqlCommand(sql, conne);
                command.ExecuteNonQuery();
                //MessageBox.Show("deleted");


                string Sql = @"SELECT * FROM  Eye_technician_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, conne);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                dgvWorkshop.DataSource = dt;

                conne.Close();

                txtWorkID.Text = "";
                txtPatientID.Text = "";
                txtFullName.Text = "";
                txtAge.Text = "";
                txtRightEyePower.Text = "";
                txtLeftEyePower.Text = "";
                txtLensID.Text = "";
                txtFrameID.Text = "";


                AutoGenerateID();

            }
             
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data not insert successfully");
            }
           
           


            
        }



     

        private void Workshop_Load(object sender, EventArgs e)
        {

            AutoGenerateID();

            try
            {


                string Sql = @"SELECT * FROM  Eye_technician_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, conne);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                dgvWorkshop.DataSource = dt;
                conne.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }


        }


        public void AutoGenerateID()
        {
            String workid;
            String query = @"select W_id from Workshop_tb order by W_id  Desc";
            conne.Open();
            SqlCommand command = new SqlCommand(query, conne);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                workid = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                workid = ("001");
            }
            else
            {
                workid = ("001");
            }
            conne.Close();
            txtWorkID.Text = workid.ToString();
        }
    
        private void txtWorkID_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtRightEyePower_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtRightEyePower.Text))
            {
                e.Cancel = true;
                txtRightEyePower.Focus();
                errorProvider2.SetError(txtRightEyePower, "Patient right eye power is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtRightEyePower, null);
            }
        }

        private void txtLeftEyePower_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtRightEyePower.Text))
            {
                e.Cancel = true;
                txtRightEyePower.Focus();
                errorProvider2.SetError(txtRightEyePower, "Patient right eye power is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtRightEyePower, null);
            }
        }

        private void txtLensID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLensID.Text))
            {
                e.Cancel = true;
                txtLensID.Focus();
                errorProvider2.SetError(txtLensID, "Lense ID is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtLensID, null);
            }

        }

        private void txtFrameID_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFrameID.Text))
            {
                e.Cancel = true;
                txtFrameID.Focus();
                errorProvider2.SetError(txtFrameID, "Frame ID is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtFrameID, null);
            }
          }

        private void txtPatientID_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                e.Cancel = true;
                txtPatientID.Focus();
                errorProvider2.SetError(txtPatientID, "Patient ID is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtPatientID, null);
            }
        }

        private void dgvWorkshop_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvWorkshop.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtPatientID.Text = dgvWorkshop.Rows[e.RowIndex].Cells["P_id"].Value.ToString();
                txtFullName.Text = dgvWorkshop.Rows[e.RowIndex].Cells["P_fullName"].Value.ToString();

                txtAge.Text = dgvWorkshop.Rows[e.RowIndex].Cells["P_age"].Value.ToString();
                txtRightEyePower.Text = dgvWorkshop.Rows[e.RowIndex].Cells["Right_eye_power"].Value.ToString();
                txtLeftEyePower.Text = dgvWorkshop.Rows[e.RowIndex].Cells["Left_eye_power"].Value.ToString();
                txtLensID.Text = dgvWorkshop.Rows[e.RowIndex].Cells["L_id"].Value.ToString();
                txtFrameID.Text = dgvWorkshop.Rows[e.RowIndex].Cells["F_id"].Value.ToString();
            }
        }
    }
}
    
    

