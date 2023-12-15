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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_Cliente_Servidor_2023
{
    public partial class FmEmployee : Form
    {
        string connectionString = "Data Source=DESKTOP-7NQK83I\\SQLEXPRESS;Initial Catalog=AreaServices;Integrated Security=True;";
        private SqlConnection connection;
        public FmEmployee()
        {
            InitializeComponent();
            LlenarComboBoxEmployeeType();
            MostrarDatos(); 
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FmMenu Menu = new FmMenu();
            Menu.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        public void LlenarComboBoxEmployeeType()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT idEmployeeType FROM EmployeeType";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdEmployeeType.DataSource = dataTable;
                        cmbIdEmployeeType.DisplayMember = "idEmployeeType";
                        cmbIdEmployeeType.ValueMember = "idEmployeeType";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }

        private void MostrarDatos()
        {

            string consulta = "SELECT * FROM Employee Where status=1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(consulta, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                dgvEmployee.DataSource = dataTable;
            }
        }

        private void Limpiar()
        {
            txtNameEmployee.Text = "";
            txtLastNameEmployee.Text = "";
            txtSalary.Text = "";
            txtNss.Text = "";
            txtZipCode.Text = "";
            txtRfc.Text = "";
            txtNumberPhone.Text = "";
            txtEmail.Text = "";
            txtAddressEmployee.Text = "";
            cmbIdEmployeeType.Text = "";
            txtStatus.Text = "";
        }


        private void btnAgregarStudent_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar campos obligatorios antes de la inserción
                if (string.IsNullOrEmpty(txtNameEmployee.Text) || string.IsNullOrEmpty(txtLastNameEmployee.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta de inserción
                    string query = "INSERT INTO Employee (nameEmployee,lastNameEmployee,salary,nss,zipCode,rfc,numberPhone, email, addressEmployee, idEmployeeType, status)" +
                                   "VALUES (@nameEmployee, @lastNameEmployee, @salary, @nss, @zipCode, @rfc, @numberPhone,@email,@addressEmployee,@idEmployeeType,@status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetros de la consulta de inserción
                        command.Parameters.AddWithValue("@nameEmployee", txtNameEmployee.Text);
                        command.Parameters.AddWithValue("@lastNameEmployee", txtLastNameEmployee.Text);
                        command.Parameters.AddWithValue("@salary", txtSalary.Text);
                        command.Parameters.AddWithValue("@nss", txtNss.Text);
                        command.Parameters.AddWithValue("@zipCode", txtZipCode.Text);
                        command.Parameters.AddWithValue("@rfc", txtRfc.Text);
                        command.Parameters.AddWithValue("@numberPhone", txtNumberPhone.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@addressEmployee", txtAddressEmployee.Text);
                        command.Parameters.AddWithValue("@idEmployeeType", cmbIdEmployeeType.SelectedValue); // Suponiendo que obtienes el ID del ComboBox
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

        private void btnModificarStudent_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nameEmployee = txtNameEmployee.Text;
            string lastNameEmployee = txtLastNameEmployee.Text;
            string salary = txtSalary.Text;
            string nss = txtNss.Text;
            string zipCode = txtZipCode.Text;
            string rfc = txtRfc.Text;
            string numberPhone = txtNumberPhone.Text;
            string email = txtEmail.Text;
            string addressEmployee = txtAddressEmployee.Text;

            try
            {
                if (dgvEmployee.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["idEmployee"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Employee SET nameEmployee = @NameEmployee, lastNameEmployee = @LastNameEmployee, salary = @Salary, nss = @Nss , zipCode = ZipCode , rfc = @Rfc , numberPhone = @NumberPhone , email = @Email, addressEmployee = @AddressEmployee" +
                         
                          "WHERE idEmployee = @idEmployee"; // Reemplaza "TuTabla" por el nombre de tu tabla y ajusta el WHERE según tus necesidades



                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar parámetros para la consulta UPDATE
                            command.Parameters.AddWithValue("@NameEmployee", nameEmployee);
                            command.Parameters.AddWithValue("@LastNameEmployee", lastNameEmployee);
                            command.Parameters.AddWithValue("@Salary", salary);
                            command.Parameters.AddWithValue("@Nss", nss);
                            command.Parameters.AddWithValue("@ZipCode", zipCode);
                            command.Parameters.AddWithValue("@Rfc", rfc);
                            command.Parameters.AddWithValue("@NumberPhone", numberPhone);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@AddressEmployee", addressEmployee);
                            // Agregar el parámetro para el ID de la fila que se va a actualizar
                            command.Parameters.AddWithValue("@idEmployee", idToDelete);

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

        private void btnEliminarStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["idEmployee"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Employee SET status = 0 WHERE idEmployee = @IdParaActualizar";

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
    }
}
