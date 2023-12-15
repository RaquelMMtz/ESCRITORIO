using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_Final_Cliente_Servidor_2023
{
    public partial class FmStudent : Form
    {
        string connectionString = "Data Source=DESKTOP-7NQK83I\\SQLEXPRESS;Initial Catalog=AreaServices;Integrated Security=True;";
        private SqlConnection connection;
        public FmStudent()
        {
            InitializeComponent();
            //Cargar mi select que muestra los registros de mi bas de datos.
            LlenarComboBox();
            MostrarDatos();
            dgvStudent.SelectionChanged += dgvStudent_SelectionChanged;
        }
        public void LlenarComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT idStudyPlan FROM StudyPlan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        comboBox1.DataSource = dataTable;
                        comboBox1.DisplayMember = "idStudyPlan";
                        comboBox1.ValueMember = "idStudyPlan";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            FmMenu Menu = new FmMenu();
            Menu.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
          
        }

        private void MostrarDatos()
        {

            string consulta = "SELECT * FROM Student Where status=1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(consulta, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                dgvStudent.DataSource = dataTable;
            }
        }

        private void Limpiar()
        {
            txtNameStudent.Text = "";
            txtLastNameStudent.Text = "";
            txtRegistrationNumber.Text = "";
            txtRfc.Text = "";
            txtCurp.Text = "";
            txtNss.Text = "";
            txtAddressStudent.Text = "";
            txtEmail.Text = "";
            txtNumberPhone.Text = "";
            txtStatus.Text = "";
        }

        private void btnAgregarStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios antes de la inserción
                if (string.IsNullOrEmpty(txtLastNameStudent.Text) || string.IsNullOrEmpty(txtRegistrationNumber.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta de inserción
                    string query = "INSERT INTO Student (nameStudent, lastNameStudent, registrationNumber, rfc, curp, nss, addressStudent, email, numberPhone, idStudyPlan, status)" +
                                   "VALUES (@nameStudent, @lastNameStudent, @registrationNumber, @rfc, @curp, @nss, @addressStudent,@email,@numberPhone,@idStudyPlan,@status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetros de la consulta de inserción
                        command.Parameters.AddWithValue("@nameStudent", txtNameStudent.Text);
                        command.Parameters.AddWithValue("@lastNameStudent", txtLastNameStudent.Text);
                        command.Parameters.AddWithValue("@registrationNumber", txtRegistrationNumber.Text);
                        command.Parameters.AddWithValue("@rfc", txtRfc.Text);
                        command.Parameters.AddWithValue("@curp", txtCurp.Text);
                        command.Parameters.AddWithValue("@nss", txtNss.Text);
                        command.Parameters.AddWithValue("@addressStudent", txtAddressStudent.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@numberPhone", txtNumberPhone.Text);
                        command.Parameters.AddWithValue("@idStudyPlan", comboBox1.SelectedValue); // Suponiendo que obtienes el ID del ComboBox
                        command.Parameters.AddWithValue("@status", 1);

                        // Ejecutar la consulta de inserción
                        command.ExecuteNonQuery();

                        MessageBox.Show("Inserción exitosa.");
                        MostrarDatos(); // Función para actualizar la vista con los nuevos datos
                        Limpiar(); // Función para limpiar los campos después de la inserción
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en la base de datos: " + ex.Message);
            }
        }

        private void btnEliminarStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudent.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells["idStudent"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Student SET status = 0 WHERE idStudent = @IdParaActualizar";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdParaActualizar", idToDelete);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Se elimino de la forma correcta");
                                MostrarDatos();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro para eliminar.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila para actualizar el estado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar actualizar el estado: " + ex.Message);
            }

        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudent.SelectedRows[0];

                string nombre = selectedRow.Cells["idStudent"].Value.ToString();

                txtIdStudent.Text = nombre;
               
                string nameStudent = selectedRow.Cells["nameStudent"].Value.ToString();
                string lastNameStudent = selectedRow.Cells["lastNameStudent"].Value.ToString();
                string registrationNumber = selectedRow.Cells["registrationNumber"].Value.ToString();
                string rfc = selectedRow.Cells["rfc"].Value.ToString();
                string curp = selectedRow.Cells["curp"].Value.ToString();
                string nss = selectedRow.Cells["nss"].Value.ToString();
                string addressStudent = selectedRow.Cells["addressStudent"].Value.ToString();
                string email = selectedRow.Cells["email"].Value.ToString();
                string numberPhone = selectedRow.Cells["numberPhone"].Value.ToString();
               
                txtNameStudent.Text = nameStudent;
                txtLastNameStudent.Text = lastNameStudent;
                txtRegistrationNumber.Text = registrationNumber;
                txtRfc.Text = rfc;
                txtCurp.Text= curp;
                txtNss.Text = nss;
                txtAddressStudent.Text = addressStudent;
                txtEmail.Text = email;
                txtNumberPhone.Text = numberPhone;                                                 
            }
            else
            {
              
            }
        }

        private void btnModificarStudent_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nameStudent = txtNameStudent.Text;
            string lastNameStudent = txtLastNameStudent.Text;
            string registrationNumber = txtRegistrationNumber.Text;
            string rfc = txtRfc.Text;
            string curp = txtCurp.Text;
            string nss = txtNss.Text;
            string addressStudent = txtAddressStudent.Text;
            string email = txtEmail.Text;
            string numberPhone = txtNumberPhone.Text;

            try
            {
                if (dgvStudent.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells["idStudent"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Student SET nameStudent = @Name, lastNameStudent = @LastName, registrationNumber = @RegNumber, " +
                          "rfc = @RFC, curp = @CURP, nss = @NSS, addressStudent = @Address, email = @Email, numberPhone = @Phone " +
                          "WHERE idStudent = @idStudent"; 



                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar parámetros para la consulta UPDATE
                            command.Parameters.AddWithValue("@Name", nameStudent);
                            command.Parameters.AddWithValue("@LastName", lastNameStudent);
                            command.Parameters.AddWithValue("@RegNumber", registrationNumber);
                            command.Parameters.AddWithValue("@RFC", rfc);
                            command.Parameters.AddWithValue("@CURP", curp);
                            command.Parameters.AddWithValue("@NSS", nss);
                            command.Parameters.AddWithValue("@Address", addressStudent);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Phone", numberPhone);
                            // Agregar el parámetro para el ID de la fila que se va a actualizar
                            command.Parameters.AddWithValue("@idStudent",idToDelete);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Actualización exitosa.");
                                MostrarDatos();
                                // Aquí podrías agregar más lógica si es necesario después de la actualización
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro para actualizar.");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar actualizar: " + ex.Message);
            }
        }
    }
}

