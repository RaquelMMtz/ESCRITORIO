namespace Proyecto_Final_Cliente_Servidor_2023
{
    partial class FmLoanAplication
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtIdLoanAplication = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDescriptionLoanAplication = new System.Windows.Forms.TextBox();
            this.txtNumberLoan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoanAplication = new System.Windows.Forms.DataGridView();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.cmbIdBookCatalog = new System.Windows.Forms.ComboBox();
            this.cmbIdStudent = new System.Windows.Forms.ComboBox();
            this.cmbIdAuthorization = new System.Windows.Forms.ComboBox();
            this.cmbIdEmployee = new System.Windows.Forms.ComboBox();
            this.cmbIdToolCatalog = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanAplication)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 39);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(678, 145);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 38);
            this.btnEliminar.TabIndex = 82;
            this.btnEliminar.Text = "Elminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(678, 77);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 38);
            this.btnModificar.TabIndex = 81;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(678, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 38);
            this.btnAgregar.TabIndex = 80;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(486, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 125;
            this.label12.Text = "status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(449, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 124;
            this.label11.Text = "idToolCatalog";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 123;
            this.label10.Text = "idEmployee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "deliveryDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "descriptionLoanAplication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "departureDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 122;
            this.label9.Text = "idAuthorization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "numberLoan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 121;
            this.label8.Text = "idStudent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 119;
            this.label6.Text = "quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "idBookCatalog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "idLoanAplication";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(527, 218);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 112;
            // 
            // txtIdLoanAplication
            // 
            this.txtIdLoanAplication.Location = new System.Drawing.Point(239, 26);
            this.txtIdLoanAplication.Name = "txtIdLoanAplication";
            this.txtIdLoanAplication.Size = new System.Drawing.Size(100, 20);
            this.txtIdLoanAplication.TabIndex = 107;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(239, 218);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 106;
            // 
            // txtDescriptionLoanAplication
            // 
            this.txtDescriptionLoanAplication.Location = new System.Drawing.Point(239, 101);
            this.txtDescriptionLoanAplication.Name = "txtDescriptionLoanAplication";
            this.txtDescriptionLoanAplication.Size = new System.Drawing.Size(100, 20);
            this.txtDescriptionLoanAplication.TabIndex = 103;
            // 
            // txtNumberLoan
            // 
            this.txtNumberLoan.Location = new System.Drawing.Point(239, 64);
            this.txtNumberLoan.Name = "txtNumberLoan";
            this.txtNumberLoan.Size = new System.Drawing.Size(100, 20);
            this.txtNumberLoan.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLoanAplication);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1276, 236);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            // 
            // dgvLoanAplication
            // 
            this.dgvLoanAplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanAplication.Location = new System.Drawing.Point(18, 34);
            this.dgvLoanAplication.Name = "dgvLoanAplication";
            this.dgvLoanAplication.Size = new System.Drawing.Size(1226, 150);
            this.dgvLoanAplication.TabIndex = 0;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(239, 138);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDeliveryDate.TabIndex = 160;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDate.Location = new System.Drawing.Point(239, 177);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDepartureDate.TabIndex = 161;
            // 
            // cmbIdBookCatalog
            // 
            this.cmbIdBookCatalog.FormattingEnabled = true;
            this.cmbIdBookCatalog.Location = new System.Drawing.Point(527, 26);
            this.cmbIdBookCatalog.Name = "cmbIdBookCatalog";
            this.cmbIdBookCatalog.Size = new System.Drawing.Size(100, 21);
            this.cmbIdBookCatalog.TabIndex = 162;
            // 
            // cmbIdStudent
            // 
            this.cmbIdStudent.FormattingEnabled = true;
            this.cmbIdStudent.Location = new System.Drawing.Point(527, 66);
            this.cmbIdStudent.Name = "cmbIdStudent";
            this.cmbIdStudent.Size = new System.Drawing.Size(100, 21);
            this.cmbIdStudent.TabIndex = 163;
            // 
            // cmbIdAuthorization
            // 
            this.cmbIdAuthorization.FormattingEnabled = true;
            this.cmbIdAuthorization.Location = new System.Drawing.Point(527, 104);
            this.cmbIdAuthorization.Name = "cmbIdAuthorization";
            this.cmbIdAuthorization.Size = new System.Drawing.Size(100, 21);
            this.cmbIdAuthorization.TabIndex = 164;
            // 
            // cmbIdEmployee
            // 
            this.cmbIdEmployee.FormattingEnabled = true;
            this.cmbIdEmployee.Location = new System.Drawing.Point(527, 141);
            this.cmbIdEmployee.Name = "cmbIdEmployee";
            this.cmbIdEmployee.Size = new System.Drawing.Size(100, 21);
            this.cmbIdEmployee.TabIndex = 165;
            // 
            // cmbIdToolCatalog
            // 
            this.cmbIdToolCatalog.FormattingEnabled = true;
            this.cmbIdToolCatalog.Location = new System.Drawing.Point(527, 180);
            this.cmbIdToolCatalog.Name = "cmbIdToolCatalog";
            this.cmbIdToolCatalog.Size = new System.Drawing.Size(100, 21);
            this.cmbIdToolCatalog.TabIndex = 166;
            // 
            // FmLoanAplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 662);
            this.Controls.Add(this.cmbIdToolCatalog);
            this.Controls.Add(this.cmbIdEmployee);
            this.Controls.Add(this.cmbIdAuthorization);
            this.Controls.Add(this.cmbIdStudent);
            this.Controls.Add(this.cmbIdBookCatalog);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIdLoanAplication);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDescriptionLoanAplication);
            this.Controls.Add(this.txtNumberLoan);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMenu);
            this.Name = "FmLoanAplication";
            this.Text = "LoanAplication";
            this.Load += new System.EventHandler(this.FmLoanAplication_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanAplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtIdLoanAplication;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDescriptionLoanAplication;
        private System.Windows.Forms.TextBox txtNumberLoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLoanAplication;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.ComboBox cmbIdBookCatalog;
        private System.Windows.Forms.ComboBox cmbIdStudent;
        private System.Windows.Forms.ComboBox cmbIdAuthorization;
        private System.Windows.Forms.ComboBox cmbIdEmployee;
        private System.Windows.Forms.ComboBox cmbIdToolCatalog;
    }
}