namespace Proyecto_Final_Cliente_Servidor_2023
{
    partial class FmAuthorization
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
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtIdAuthorization = new System.Windows.Forms.TextBox();
            this.txtDescriptionAuthorization = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAuthorization = new System.Windows.Forms.DataGridView();
            this.cmbIdEmployee = new System.Windows.Forms.ComboBox();
            this.dtpAuthorizationDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorization)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 150;
            this.label12.Text = "status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 148;
            this.label4.Text = "idEmployee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 147;
            this.label3.Text = "descriptionAuthorization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "authorizationDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 145;
            this.label1.Text = "idAuthorization";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(276, 179);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 144;
            // 
            // txtIdAuthorization
            // 
            this.txtIdAuthorization.Location = new System.Drawing.Point(276, 22);
            this.txtIdAuthorization.Name = "txtIdAuthorization";
            this.txtIdAuthorization.Size = new System.Drawing.Size(100, 20);
            this.txtIdAuthorization.TabIndex = 143;
            // 
            // txtDescriptionAuthorization
            // 
            this.txtDescriptionAuthorization.Location = new System.Drawing.Point(276, 97);
            this.txtDescriptionAuthorization.Name = "txtDescriptionAuthorization";
            this.txtDescriptionAuthorization.Size = new System.Drawing.Size(100, 20);
            this.txtDescriptionAuthorization.TabIndex = 141;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(440, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 38);
            this.btnEliminar.TabIndex = 139;
            this.btnEliminar.Text = "Elminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(440, 87);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 38);
            this.btnModificar.TabIndex = 138;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(440, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 38);
            this.btnAgregar.TabIndex = 137;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(22, 28);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 39);
            this.btnMenu.TabIndex = 136;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAuthorization);
            this.groupBox1.Location = new System.Drawing.Point(12, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 280);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            // 
            // dgvAuthorization
            // 
            this.dgvAuthorization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthorization.Location = new System.Drawing.Point(10, 19);
            this.dgvAuthorization.Name = "dgvAuthorization";
            this.dgvAuthorization.Size = new System.Drawing.Size(886, 244);
            this.dgvAuthorization.TabIndex = 0;
            // 
            // cmbIdEmployee
            // 
            this.cmbIdEmployee.FormattingEnabled = true;
            this.cmbIdEmployee.Location = new System.Drawing.Point(276, 137);
            this.cmbIdEmployee.Name = "cmbIdEmployee";
            this.cmbIdEmployee.Size = new System.Drawing.Size(100, 21);
            this.cmbIdEmployee.TabIndex = 151;
            // 
            // dtpAuthorizationDate
            // 
            this.dtpAuthorizationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAuthorizationDate.Location = new System.Drawing.Point(276, 57);
            this.dtpAuthorizationDate.Name = "dtpAuthorizationDate";
            this.dtpAuthorizationDate.Size = new System.Drawing.Size(100, 20);
            this.dtpAuthorizationDate.TabIndex = 160;
            // 
            // FmAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 620);
            this.Controls.Add(this.dtpAuthorizationDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbIdEmployee);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIdAuthorization);
            this.Controls.Add(this.txtDescriptionAuthorization);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMenu);
            this.Name = "FmAuthorization";
            this.Text = "Authorization";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtIdAuthorization;
        private System.Windows.Forms.TextBox txtDescriptionAuthorization;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAuthorization;
        private System.Windows.Forms.ComboBox cmbIdEmployee;
        private System.Windows.Forms.DateTimePicker dtpAuthorizationDate;
    }
}