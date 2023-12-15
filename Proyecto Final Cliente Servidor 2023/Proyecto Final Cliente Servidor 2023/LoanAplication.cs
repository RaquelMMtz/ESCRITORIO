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
    public partial class FmLoanAplication : Form
    {
        private SqlConnection connection;
        string connectionString = "Data Source=DESKTOP-7NQK83I\\SQLEXPRESS;Initial Catalog=AreaServices;Integrated Security=True;";
        public FmLoanAplication()
        {
            InitializeComponent();
            LlenarComboBoxBookCatalog();
            LlenarComboBoxStudent();
            LlenarComboBoxAuthorization();
            LlenarComboBoxEmployee();
            LlenarComboBoxToolCatalog();
            MostrarDatos();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FmMenu Menu = new FmMenu();
            Menu.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        public void LlenarComboBoxBookCatalog()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT idBookCatalog FROM BookCatalog";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdBookCatalog.DataSource = dataTable;
                        cmbIdBookCatalog.DisplayMember = "idBookCatalog";
                        cmbIdBookCatalog.ValueMember = "idBookCatalog";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }

        public void LlenarComboBoxStudent()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT idStudent FROM Student";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdStudent.DataSource = dataTable;
                        cmbIdStudent.DisplayMember = "idStudent";
                        cmbIdStudent.ValueMember = "idStudent";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }

        public void LlenarComboBoxAuthorization()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT idAuthorization FROM Authorization_";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdAuthorization.DataSource = dataTable;
                        cmbIdAuthorization.DisplayMember = "idAuthorization";
                        cmbIdAuthorization.ValueMember = "idAuthorization";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }

        public void LlenarComboBoxEmployee()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT idEmployee FROM Employee";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdEmployee.DataSource = dataTable;
                        cmbIdEmployee.DisplayMember = "idEmployee";
                        cmbIdEmployee.ValueMember = "idEmployee";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }

        public void LlenarComboBoxToolCatalog()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT idToolCatalog FROM ToolCatalog";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdToolCatalog.DataSource = dataTable;
                        cmbIdToolCatalog.DisplayMember = "idToolCatalog";
                        cmbIdToolCatalog.ValueMember = "idToolCatalog";
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
        
            string consulta = "SELECT * FROM LoanAplication Where status= 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(consulta, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                dgvLoanAplication.DataSource = dataTable;
            }
        }

        private void Limpiar()
        {
            txtNumberLoan.Text = "";
            txtDescriptionLoanAplication.Text = "";
            //txtDeliveryDate.Text = "";
            //txtDepartureDate.Text = "";
            txtQuantity.Text = "";
            txtStatus.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            ////
            try
            {
                // Validar campos obligatorios antes de la inserción
                if (string.IsNullOrEmpty(txtNumberLoan.Text) || string.IsNullOrEmpty(txtDescriptionLoanAplication.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta de inserción
                    string query = "INSERT INTO LoanAplication (numberLoan, descriptionLoanAplication, deliveryDate, departureDate, quantity, idBookCatalog, idStudent, idAuthorization, idEmployee, idToolCatalog, status) " +
                           "VALUES (@numberLoan, @descriptionLoanAplication, @deliveryDate, @departureDate, @quantity, @idBookCatalog, @idStudent, @idAuthorization, @idEmployee, @idToolCatalog, @status)";

                    DateTime selectedDate = dtpDeliveryDate.Value;
                    DateTime selectedDateDeparture = dtpDepartureDate.Value;


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros para la inserción
                        command.Parameters.AddWithValue("@numberLoan", txtNumberLoan.Text);
                        command.Parameters.AddWithValue("@descriptionLoanAplication", txtDescriptionLoanAplication.Text);
                        command.Parameters.AddWithValue("@deliveryDate", selectedDate);
                        command.Parameters.AddWithValue("@departureDate", selectedDateDeparture);
                        command.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                        command.Parameters.AddWithValue("@idBookCatalog", cmbIdBookCatalog.SelectedValue);
                        command.Parameters.AddWithValue("@idStudent", cmbIdStudent.SelectedValue);
                        command.Parameters.AddWithValue("@idAuthorization", cmbIdAuthorization.SelectedValue);
                        command.Parameters.AddWithValue("@idEmployee", cmbIdEmployee.SelectedValue);
                        command.Parameters.AddWithValue("@idToolCatalog", cmbIdToolCatalog.SelectedValue);
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

        private void FmLoanAplication_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string numberLoan = txtNumberLoan.Text;
            string descriptionLoanAplication = txtDescriptionLoanAplication.Text;
            //string deliveryDate = txtDeliveryDate.Text;
            //string departureDate = txtDepartureDate.Text;
            string quantity = txtQuantity.Text;


            try
            {
                if (dgvLoanAplication.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvLoanAplication.SelectedRows[0].Cells["idLoanAplication"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE LoanAplication SET numberLoan = @NumberLoan, descriptionLoanAplication = @DescriptionLoanAplication, deliveryDate = @DeliveryDate, departureDate = @DepartureDate , quantity = @Quantity" +
                        
                          "WHERE idLoanAplication = @idLoanAplication"; // Reemplaza "TuTabla" por el nombre de tu tabla y ajusta el WHERE según tus necesidades



                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar parámetros para la consulta UPDATE
                            command.Parameters.AddWithValue("@NumberLoan", numberLoan);
                            command.Parameters.AddWithValue("@DescriptionLoanAplication", descriptionLoanAplication);
                            //command.Parameters.AddWithValue("@DeliveryDate", deliveryDate);
                            //command.Parameters.AddWithValue("@DepartureDate", departureDate);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                 
                            // Agregar el parámetro para el ID de la fila que se va a actualizar
                            command.Parameters.AddWithValue("@idLoanAplication", idToDelete);

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLoanAplication.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvLoanAplication.SelectedRows[0].Cells["idLoanAplication"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE LoanAplication SET status = 0 WHERE idLoanAplication = @IdParaActualizar";

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
