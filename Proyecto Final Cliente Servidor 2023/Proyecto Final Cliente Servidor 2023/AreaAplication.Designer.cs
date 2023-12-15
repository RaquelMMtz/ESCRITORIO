namespace Proyecto_Final_Cliente_Servidor_2023
{
    partial class FmAreaAplication
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
            this.cmbIdEmployee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAreaAplication = new System.Windows.Forms.DataGridView();
            this.cmbIdClass = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtDescriptionAreaAplication = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.cmbIdArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdAuthorization = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateAreaAplication = new System.Windows.Forms.DateTimePicker();
            this.txtIdAreaAplication = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaAplication)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIdEmployee
            // 
            this.cmbIdEmployee.FormattingEnabled = true;
            this.cmbIdEmployee.Location = new System.Drawing.Point(471, 23);
            this.cmbIdEmployee.Name = "cmbIdEmployee";
            this.cmbIdEmployee.Size = new System.Drawing.Size(100, 21);
            this.cmbIdEmployee.TabIndex = 154;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 153;
            this.label5.Text = "idEmployee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAreaAplication);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 280);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            // 
            // dgvAreaAplication
            // 
            this.dgvAreaAplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreaAplication.Location = new System.Drawing.Point(16, 19);
            this.dgvAreaAplication.Name = "dgvAreaAplication";
            this.dgvAreaAplication.Size = new System.Drawing.Size(1151, 244);
            this.dgvAreaAplication.TabIndex = 0;
            // 
            // cmbIdClass
            // 
            this.cmbIdClass.FormattingEnabled = true;
            this.cmbIdClass.Location = new System.Drawing.Point(471, 60);
            this.cmbIdClass.Name = "cmbIdClass";
            this.cmbIdClass.Size = new System.Drawing.Size(100, 21);
            this.cmbIdClass.TabIndex = 151;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(430, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 150;
            this.label12.Text = "status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(423, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 149;
            this.label11.Text = "idClass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 148;
            this.label4.Text = "descriptionAreaAplication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "dateArea";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(471, 144);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 144;
            // 
            // txtDescriptionAreaAplication
            // 
            this.txtDescriptionAreaAplication.Location = new System.Drawing.Point(266, 102);
            this.txtDescriptionAreaAplication.Name = "txtDescriptionAreaAplication";
            this.txtDescriptionAreaAplication.Size = new System.Drawing.Size(100, 20);
            this.txtDescriptionAreaAplication.TabIndex = 142;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(633, 147);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 38);
            this.btnEliminar.TabIndex = 139;
            this.btnEliminar.Text = "Elminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(633, 79);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 38);
            this.btnModificar.TabIndex = 138;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(633, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 38);
            this.btnAgregar.TabIndex = 137;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(6, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 39);
            this.btnMenu.TabIndex = 136;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // cmbIdArea
            // 
            this.cmbIdArea.FormattingEnabled = true;
            this.cmbIdArea.Location = new System.Drawing.Point(266, 144);
            this.cmbIdArea.Name = "cmbIdArea";
            this.cmbIdArea.Size = new System.Drawing.Size(100, 21);
            this.cmbIdArea.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 155;
            this.label3.Text = "idArea";
            // 
            // cmbIdAuthorization
            // 
            this.cmbIdAuthorization.FormattingEnabled = true;
            this.cmbIdAuthorization.Location = new System.Drawing.Point(471, 101);
            this.cmbIdAuthorization.Name = "cmbIdAuthorization";
            this.cmbIdAuthorization.Size = new System.Drawing.Size(100, 21);
            this.cmbIdAuthorization.TabIndex = 158;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 157;
            this.label6.Text = "idAuthorization";
            // 
            // dtpDateAreaAplication
            // 
            this.dtpDateAreaAplication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAreaAplication.Location = new System.Drawing.Point(266, 60);
            this.dtpDateAreaAplication.Name = "dtpDateAreaAplication";
            this.dtpDateAreaAplication.Size = new System.Drawing.Size(100, 20);
            this.dtpDateAreaAplication.TabIndex = 159;
            // 
            // txtIdAreaAplication
            // 
            this.txtIdAreaAplication.Location = new System.Drawing.Point(266, 22);
            this.txtIdAreaAplication.Name = "txtIdAreaAplication";
            this.txtIdAreaAplication.Size = new System.Drawing.Size(100, 20);
            this.txtIdAreaAplication.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 145;
            this.label1.Text = "idAreaAplication";
            // 
            // FmAreaAplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 570);
            this.Controls.Add(this.dtpDateAreaAplication);
            this.Controls.Add(this.cmbIdAuthorization);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbIdArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIdEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbIdClass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIdAreaAplication);
            this.Controls.Add(this.txtDescriptionAreaAplication);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMenu);
            this.Name = "FmAreaAplication";
            this.Text = "AreaAplication";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaAplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAreaAplication;
        private System.Windows.Forms.ComboBox cmbIdClass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtDescriptionAreaAplication;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ComboBox cmbIdArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIdAuthorization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateAreaAplication;
        private System.Windows.Forms.TextBox txtIdAreaAplication;
        private System.Windows.Forms.Label label1;
    }
}