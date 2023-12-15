namespace Proyecto_Final_Cliente_Servidor_2023
{
    partial class FmStudent
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnEliminarStudent = new System.Windows.Forms.Button();
            this.btnModificarStudent = new System.Windows.Forms.Button();
            this.btnAgregarStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.txtLastNameStudent = new System.Windows.Forms.TextBox();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.txtNss = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddressStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 39);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnEliminarStudent
            // 
            this.btnEliminarStudent.Location = new System.Drawing.Point(688, 145);
            this.btnEliminarStudent.Name = "btnEliminarStudent";
            this.btnEliminarStudent.Size = new System.Drawing.Size(87, 38);
            this.btnEliminarStudent.TabIndex = 76;
            this.btnEliminarStudent.Text = "Elminar";
            this.btnEliminarStudent.UseVisualStyleBackColor = true;
            this.btnEliminarStudent.Click += new System.EventHandler(this.btnEliminarStudent_Click);
            // 
            // btnModificarStudent
            // 
            this.btnModificarStudent.Location = new System.Drawing.Point(688, 77);
            this.btnModificarStudent.Name = "btnModificarStudent";
            this.btnModificarStudent.Size = new System.Drawing.Size(87, 38);
            this.btnModificarStudent.TabIndex = 75;
            this.btnModificarStudent.Text = "Modificar";
            this.btnModificarStudent.UseVisualStyleBackColor = true;
            this.btnModificarStudent.Click += new System.EventHandler(this.btnModificarStudent_Click);
            // 
            // btnAgregarStudent
            // 
            this.btnAgregarStudent.Location = new System.Drawing.Point(688, 13);
            this.btnAgregarStudent.Name = "btnAgregarStudent";
            this.btnAgregarStudent.Size = new System.Drawing.Size(87, 38);
            this.btnAgregarStudent.TabIndex = 74;
            this.btnAgregarStudent.Text = "Agregar";
            this.btnAgregarStudent.UseVisualStyleBackColor = true;
            this.btnAgregarStudent.Click += new System.EventHandler(this.btnAgregarStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStudent);
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1233, 280);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(6, 32);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(1199, 222);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Location = new System.Drawing.Point(206, 50);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(100, 20);
            this.txtNameStudent.TabIndex = 78;
            // 
            // txtLastNameStudent
            // 
            this.txtLastNameStudent.Location = new System.Drawing.Point(206, 87);
            this.txtLastNameStudent.Name = "txtLastNameStudent";
            this.txtLastNameStudent.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameStudent.TabIndex = 79;
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(206, 124);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationNumber.TabIndex = 80;
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(206, 163);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(100, 20);
            this.txtRfc.TabIndex = 81;
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(206, 204);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(100, 20);
            this.txtCurp.TabIndex = 82;
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(206, 12);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(100, 20);
            this.txtIdStudent.TabIndex = 83;
            // 
            // txtNss
            // 
            this.txtNss.Location = new System.Drawing.Point(494, 12);
            this.txtNss.Name = "txtNss";
            this.txtNss.Size = new System.Drawing.Size(100, 20);
            this.txtNss.TabIndex = 89;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(494, 204);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 88;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Location = new System.Drawing.Point(494, 124);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(100, 20);
            this.txtNumberPhone.TabIndex = 86;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(494, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 85;
            // 
            // txtAddressStudent
            // 
            this.txtAddressStudent.Location = new System.Drawing.Point(494, 50);
            this.txtAddressStudent.Name = "txtAddressStudent";
            this.txtAddressStudent.Size = new System.Drawing.Size(100, 20);
            this.txtAddressStudent.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "idStudent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "nameStudent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "lastNameStudent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "registrationNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "rfc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "curp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "nss";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "addressStudent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "numberPhone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 100;
            this.label11.Text = "idStudyPlan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(441, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 101;
            this.label12.Text = "status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(494, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 104;
            // 
            // FmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 643);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNss);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtNumberPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddressStudent);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.txtRegistrationNumber);
            this.Controls.Add(this.txtLastNameStudent);
            this.Controls.Add(this.txtNameStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarStudent);
            this.Controls.Add(this.btnModificarStudent);
            this.Controls.Add(this.btnAgregarStudent);
            this.Controls.Add(this.btnMenu);
            this.Name = "FmStudent";
            this.Text = "Student";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnEliminarStudent;
        private System.Windows.Forms.Button btnModificarStudent;
        private System.Windows.Forms.Button btnAgregarStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.TextBox txtLastNameStudent;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.TextBox txtNss;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddressStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}