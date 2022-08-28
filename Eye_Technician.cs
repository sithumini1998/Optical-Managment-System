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
    public partial class Eye_Technician : Form
    {
        static string connectionString = @"Data Source=LAPTOP-1EA7J3RA\MSSQLSERVERSITHU;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public Eye_Technician()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"insert into Eye_technician_tb(Job_id,P_id,P_fullName,P_age,Right_eye_power,Left_eye_power,L_id,F_id,Discription) values('" + txtJobID.Text + "','" + txtPatientID.Text + "','" + txtFullName.Text + "','" + txtAge.Text + "','" + txtRight.Text + "','" + txtLeft.Text + "','" + txtLensType.Text + "','" + txtFrameType.Text + "','" + txtDiscription.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");

                string sql = @"DELETE FROM Register_tb WHERE R_id='" + txtPatientID.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                //MessageBox.Show("deleted");



                string Sql = @"SELECT R_fullName,R_id,R_age,R_reg_date FROM  Register_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                dgvPatient.DataSource = dt;


                connection.Close();

                txtJobID.Text = "";
                txtPatientID.Text = "";
                txtFullName.Text = "";
                txtAge.Text = "";
                txtRegisterDate.Text = "";
                txtRight.Text = "";
                txtLeft.Text = "";
                txtLensType.Text = "";
                txtFrameType.Text = "";
                txtDiscription.Text = "";
                AutoGenerateID();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data not insert successfully");
            }
       

        }

        private void Eye_Technician_Load(object sender, EventArgs e)
        {
            AutoGenerateID();


            try
            {


                string Sql = @"SELECT R_fullName,R_id,R_age,R_reg_date FROM  Register_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                dgvPatient.DataSource = dt;
                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }


            try
            {


                string Sql = @"SELECT L_id,L_type FROM  Lens_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvLensType.DataSource = dt;
                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }


            try
            {


                string Sql = @"SELECT F_id,F_type FROM  Frame_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvFrameType.DataSource = dt;
                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        public void AutoGenerateID()
        {
            String jobid;
            String query = @"select Job_id from Eye_technician_tb order by Job_id  Desc";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                jobid = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                jobid = ("001");
            }
            else
            {
                jobid = ("001");
            }
            connection.Close();
            txtJobID.Text = jobid.ToString();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
          
        }

        

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPatient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtPatientID.Text = dgvPatient.Rows[e.RowIndex].Cells["R_id"].Value.ToString();
                txtFullName.Text = dgvPatient.Rows[e.RowIndex].Cells["R_fullName"].Value.ToString();
                txtAge.Text = dgvPatient.Rows[e.RowIndex].Cells["R_age"].Value.ToString();
                txtRegisterDate.Text = dgvPatient.Rows[e.RowIndex].Cells["R_reg_date"].Value.ToString();
                
            }
        }

        private void dgvFrameType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFrameType.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                txtFrameType.Text = dgvFrameType.Rows[e.RowIndex].Cells["F_id"].Value.ToString();
                

            }
        }

        private void dgvLensType_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvLensType.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                txtLensType.Text = dgvLensType.Rows[e.RowIndex].Cells["L_id"].Value.ToString();


            }
        }

        private void txtPatientID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                e.Cancel = true;
                txtPatientID.Focus();
                errorProvider1.SetError(txtPatientID, "Patient ID is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPatientID, null);
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                e.Cancel = true;
                txtFullName.Focus();
                errorProvider1.SetError(txtFullName, "Patient Name is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFullName, null);
            }
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                e.Cancel = true;
                txtAge.Focus();
                errorProvider1.SetError(txtAge, "Patient Age is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAge, null);
            }
        }

        private void txtRegisterDate_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtRegisterDate.Text))
            {
                e.Cancel = true;
                txtRegisterDate.Focus();
                errorProvider1.SetError(txtRegisterDate, "Register date is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRegisterDate, null);
            }
        }

        private void txtRight_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRight.Text))
            {
                e.Cancel = true;
                txtRight.Focus();
                errorProvider1.SetError(txtRight, "Patient right eye size is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRight, null);
            }
        }

        private void txtLeft_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLeft.Text))
            {
                e.Cancel = true;
                txtLeft.Focus();
                errorProvider1.SetError(txtLeft, "Patient left eye size is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLeft, null);
            }
        }

        private void txtFrameType_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFrameType.Text))
            {
                e.Cancel = true;
                txtFrameType.Focus();
                errorProvider1.SetError(txtFrameType, "Frame type is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFrameType, null);
            }
        }

        private void txtLensType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLensType.Text))
            {
                e.Cancel = true;
                txtLensType.Focus();
                errorProvider1.SetError(txtLensType, "Lens type is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLensType, null);
            }
        }
    }
}
