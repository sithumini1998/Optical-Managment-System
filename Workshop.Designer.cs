
namespace Wikramarachchi_Opticians
{
    partial class Workshop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workshop));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrameID = new System.Windows.Forms.TextBox();
            this.lblFrameID = new System.Windows.Forms.Label();
            this.txtRightEyePower = new System.Windows.Forms.TextBox();
            this.lblRightEyePower = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtLensID = new System.Windows.Forms.TextBox();
            this.txtLeftEyePower = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblLensID = new System.Windows.Forms.Label();
            this.lblLeftEyePower = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.dgvWorkshop = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblWorkID = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtWorkID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkshop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(852, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 83);
            this.label1.TabIndex = 29;
            this.label1.Text = "Workshop";
            // 
            // txtFrameID
            // 
            this.txtFrameID.BackColor = System.Drawing.SystemColors.Control;
            this.txtFrameID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrameID.Location = new System.Drawing.Point(565, 767);
            this.txtFrameID.Multiline = true;
            this.txtFrameID.Name = "txtFrameID";
            this.txtFrameID.Size = new System.Drawing.Size(327, 49);
            this.txtFrameID.TabIndex = 100;
            this.txtFrameID.Validating += new System.ComponentModel.CancelEventHandler(this.txtFrameID_Validating);
            // 
            // lblFrameID
            // 
            this.lblFrameID.AutoSize = true;
            this.lblFrameID.BackColor = System.Drawing.Color.Transparent;
            this.lblFrameID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrameID.Location = new System.Drawing.Point(187, 770);
            this.lblFrameID.Name = "lblFrameID";
            this.lblFrameID.Size = new System.Drawing.Size(120, 29);
            this.lblFrameID.TabIndex = 56;
            this.lblFrameID.Text = "Frame ID";
            this.lblFrameID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRightEyePower
            // 
            this.txtRightEyePower.BackColor = System.Drawing.SystemColors.Control;
            this.txtRightEyePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightEyePower.Location = new System.Drawing.Point(565, 492);
            this.txtRightEyePower.Multiline = true;
            this.txtRightEyePower.Name = "txtRightEyePower";
            this.txtRightEyePower.Size = new System.Drawing.Size(327, 49);
            this.txtRightEyePower.TabIndex = 55;
            this.txtRightEyePower.Validating += new System.ComponentModel.CancelEventHandler(this.txtRightEyePower_Validating);
            // 
            // lblRightEyePower
            // 
            this.lblRightEyePower.AutoSize = true;
            this.lblRightEyePower.BackColor = System.Drawing.Color.Transparent;
            this.lblRightEyePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightEyePower.Location = new System.Drawing.Point(186, 512);
            this.lblRightEyePower.Name = "lblRightEyePower";
            this.lblRightEyePower.Size = new System.Drawing.Size(207, 29);
            this.lblRightEyePower.TabIndex = 54;
            this.lblRightEyePower.Text = "Right Eye Power";
            this.lblRightEyePower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(187, 255);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(126, 29);
            this.lblPatientID.TabIndex = 53;
            this.lblPatientID.Text = "Patient ID";
            this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLensID
            // 
            this.txtLensID.BackColor = System.Drawing.SystemColors.Control;
            this.txtLensID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLensID.Location = new System.Drawing.Point(565, 676);
            this.txtLensID.Multiline = true;
            this.txtLensID.Name = "txtLensID";
            this.txtLensID.Size = new System.Drawing.Size(327, 49);
            this.txtLensID.TabIndex = 52;
            this.txtLensID.Validating += new System.ComponentModel.CancelEventHandler(this.txtLensID_Validating);
            // 
            // txtLeftEyePower
            // 
            this.txtLeftEyePower.BackColor = System.Drawing.SystemColors.Control;
            this.txtLeftEyePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftEyePower.Location = new System.Drawing.Point(565, 578);
            this.txtLeftEyePower.Multiline = true;
            this.txtLeftEyePower.Name = "txtLeftEyePower";
            this.txtLeftEyePower.Size = new System.Drawing.Size(327, 54);
            this.txtLeftEyePower.TabIndex = 51;
            this.txtLeftEyePower.Validating += new System.ComponentModel.CancelEventHandler(this.txtLeftEyePower_Validating);
            // 
            // txtPatientID
            // 
            this.txtPatientID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(565, 241);
            this.txtPatientID.Multiline = true;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(327, 52);
            this.txtPatientID.TabIndex = 50;
            this.txtPatientID.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatientID_Validating);
            // 
            // lblLensID
            // 
            this.lblLensID.AutoSize = true;
            this.lblLensID.BackColor = System.Drawing.Color.Transparent;
            this.lblLensID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLensID.Location = new System.Drawing.Point(187, 679);
            this.lblLensID.Name = "lblLensID";
            this.lblLensID.Size = new System.Drawing.Size(101, 29);
            this.lblLensID.TabIndex = 49;
            this.lblLensID.Text = "Lens ID";
            this.lblLensID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftEyePower
            // 
            this.lblLeftEyePower.AutoSize = true;
            this.lblLeftEyePower.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftEyePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftEyePower.Location = new System.Drawing.Point(187, 592);
            this.lblLeftEyePower.Name = "lblLeftEyePower";
            this.lblLeftEyePower.Size = new System.Drawing.Size(189, 29);
            this.lblLeftEyePower.TabIndex = 48;
            this.lblLeftEyePower.Text = "Left Eye Power";
            this.lblLeftEyePower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1437, 830);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(156, 59);
            this.btnLogout.TabIndex = 89;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDone.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDone.FlatAppearance.BorderSize = 2;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(540, 843);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(156, 59);
            this.btnDone.TabIndex = 88;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // dgvWorkshop
            // 
            this.dgvWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkshop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvWorkshop.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkshop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWorkshop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkshop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWorkshop.ColumnHeadersHeight = 40;
            this.dgvWorkshop.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkshop.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWorkshop.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkshop.Location = new System.Drawing.Point(1294, 168);
            this.dgvWorkshop.Name = "dgvWorkshop";
            this.dgvWorkshop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkshop.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvWorkshop.RowHeadersVisible = false;
            this.dgvWorkshop.RowHeadersWidth = 51;
            this.dgvWorkshop.RowTemplate.Height = 24;
            this.dgvWorkshop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkshop.Size = new System.Drawing.Size(313, 542);
            this.dgvWorkshop.TabIndex = 90;
            this.dgvWorkshop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkshop_CellClick);
            this.dgvWorkshop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkshop_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 804);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(651, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            // 
            // lblWorkID
            // 
            this.lblWorkID.AutoSize = true;
            this.lblWorkID.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkID.Location = new System.Drawing.Point(186, 188);
            this.lblWorkID.Name = "lblWorkID";
            this.lblWorkID.Size = new System.Drawing.Size(105, 29);
            this.lblWorkID.TabIndex = 94;
            this.lblWorkID.Text = "Work ID";
            this.lblWorkID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Control;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(565, 408);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(327, 49);
            this.txtAge.TabIndex = 98;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(186, 428);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(59, 29);
            this.lblAge.TabIndex = 97;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(187, 341);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(133, 29);
            this.lblFullName.TabIndex = 96;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(565, 328);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(327, 52);
            this.txtFullName.TabIndex = 95;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // txtWorkID
            // 
            this.txtWorkID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtWorkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkID.Location = new System.Drawing.Point(565, 163);
            this.txtWorkID.Multiline = true;
            this.txtWorkID.Name = "txtWorkID";
            this.txtWorkID.Size = new System.Drawing.Size(327, 54);
            this.txtWorkID.TabIndex = 99;
            this.txtWorkID.Validating += new System.ComponentModel.CancelEventHandler(this.txtWorkID_Validating);
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1799, 914);
            this.Controls.Add(this.txtWorkID);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblWorkID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvWorkshop);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtFrameID);
            this.Controls.Add(this.lblFrameID);
            this.Controls.Add(this.txtRightEyePower);
            this.Controls.Add(this.lblRightEyePower);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtLensID);
            this.Controls.Add(this.txtLeftEyePower);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblLensID);
            this.Controls.Add(this.lblLeftEyePower);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Workshop";
            this.Text = "Workshop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Workshop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkshop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrameID;
        private System.Windows.Forms.Label lblFrameID;
        private System.Windows.Forms.TextBox txtRightEyePower;
        private System.Windows.Forms.Label lblRightEyePower;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtLensID;
        private System.Windows.Forms.TextBox txtLeftEyePower;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblLensID;
        private System.Windows.Forms.Label lblLeftEyePower;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView dgvWorkshop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblWorkID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txtWorkID;
    }
}