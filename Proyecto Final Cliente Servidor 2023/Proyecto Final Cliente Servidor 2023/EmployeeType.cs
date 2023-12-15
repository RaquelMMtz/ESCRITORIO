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

namespace Proyecto_Final_Cliente_Servidor_2023
{
    public partial class FmEmployeeType : Form
    {

        string connectionString = "Data Source=DESKTOP-7NQK83I\\SQLEXPRESS;Initial Catalog=AreaServices;Integrated Security=True;";
        private SqlConnection connection;
        public FmEmployeeType()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FmMenu Menu = new FmMenu();
            Menu.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void MostrarDatos()
        {
            string connectionString = "Data Source=DESKTOP-OTK3IQJ;Initial Catalog=AreaServices;Integrated Security=True;";
            string consulta = "SELECT * FROM EmployeeType Where status= 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(consulta, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                dgvEmployeeType.DataSource = dataTable;
            }
        }

        private void Limpiar()
        {
            txtNameEmployeeType.Text = "";
            txtBaseSalary.Text = "";
            //txtHoursEmployeeType.Text = "";
            txtStatus.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ///
            try
            {
                // Validar campos obligatorios antes de la inserción
                if (string.IsNullOrEmpty(txtNameEmployeeType.Text) || string.IsNullOrEmpty(txtBaseSalary.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta de inserción
                    string query = "INSERT INTO EmployeeType (nameEmployeeType, baseSalary, hoursEmployeeType, status) " +
                           "VALUES (@nameEmployeeType, @baseSalary, @hoursEmployeeType, @status)";

                    DateTime TimeEmployee = dtpHoursEmployee.Value;


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetros de la consulta de inserción
                        // Agregar los parámetros para la inserción
                        command.Parameters.AddWithValue("@nameEmployeeType", txtNameEmployeeType.Text);
                        command.Parameters.AddWithValue("@baseSalary", txtBaseSalary.Text);
                        command.Parameters.AddWithValue("@hoursEmployeeType",TimeEmployee);
                        command.Parameters.AddWithValue("@status", 1);
                        // Ejecutar el comando INSERT INTO
                        command.ExecuteNonQuery();


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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Crear el comando UPDATE
            string query = "UPDATE EmployeeType SET nameEmployeeType = @EmployeeType, baseSalary = @baseSalary, " +
                           "hoursEmployee = @hoursEmployeeType, status = @status "; 
                   //aqui no se que poner  "WHERE CustomerID = @CustomerID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Establecer los parámetros para la actualización
                command.Parameters.AddWithValue("@nameEmployeeType", txtNameEmployeeType.Text);
                command.Parameters.AddWithValue("@baseSalary", txtBaseSalary.Text);
                //command.Parameters.AddWithValue("@hoursEmployeeType", txtHoursEmployeeType.Text);
                command.Parameters.AddWithValue("@status", 1);

                connection.Open();

                // Ejecutar el comando UPDATE
                command.ExecuteNonQuery();
            }

            MostrarDatos();
            Limpiar();
            MessageBox.Show("Registro Modificado Correctamente");
        }

        private void FmEmployeeType_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployeeType.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvEmployeeType.SelectedRows[0].Cells["idEmployeeType"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE EmployeeType SET status = 0 WHERE idEmployeeType = @IdParaActualizar";

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
