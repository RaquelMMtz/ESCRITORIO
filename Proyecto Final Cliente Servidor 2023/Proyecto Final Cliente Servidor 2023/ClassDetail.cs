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
    public partial class FmClassDetail : Form
    {
        string connectionString = "Data Source=DESKTOP-7NQK83I\\SQLEXPRESS;Initial Catalog=AreaServices;Integrated Security=True;";
        private SqlConnection connection;
        public FmClassDetail()
        {
            InitializeComponent();
            LlenarComboBoxClass();
            MostrarDatos();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FmMenu Menu = new FmMenu();
            Menu.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        public void LlenarComboBoxClass()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT idClass FROM Class";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdClass.DataSource = dataTable;
                        cmbIdClass.DisplayMember = "idClass";
                        cmbIdClass.ValueMember = "idClass";
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

            string consulta = "SELECT * FROM ClassDetail Where status=1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(consulta, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                dgvClassDetail.DataSource = dataTable;
            }
        }

        private void Limpiar()
        {
            txtIdClassDetail.Text = "";
            //txtDateClassDetail.Text = "";
            txtQuantityStudent.Text = "";
            cmbIdClass.Text = "";
            txtStatus.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar campos obligatorios antes de la inserción
                if (string.IsNullOrEmpty(txtQuantityStudent.Text) || string.IsNullOrEmpty(txtQuantityStudent.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta de inserción
                    string query = "INSERT INTO ClassDetail (startTime, endTime, dateClassDetail, quantityStudent, idClass, status)" +
                                   "VALUES (@startTime, @endTime, @dateClassDetail, @quantityStudent, @idClass, @status)";

                    DateTime selectedDate = dtpDateClassDetail.Value;
                    DateTime SelectStartTime = dtpStartTime.Value;
                    DateTime SelectEndTime = dtpEndTime.Value;


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetros de la consulta de inserción
                        command.Parameters.AddWithValue("@startTime", SelectStartTime);
                        command.Parameters.AddWithValue("@endTime", SelectEndTime);
                        command.Parameters.AddWithValue("@dateClassDetail", selectedDate);
                        command.Parameters.AddWithValue("@quantityStudent", txtQuantityStudent.Text);
                        command.Parameters.AddWithValue("@idClass", cmbIdClass.SelectedValue);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            //string startTime = txtStartTime.Text;
            //string endTime = txtEndTime.Text;
           // string dateClassDetail = txtDateClassDetail.Text;
            string quantityStudent = txtQuantityStudent.Text;
       

            try
            {
                if (dgvClassDetail.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvClassDetail.SelectedRows[0].Cells["idClassDetail"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE ClassDetail SET startTime = @StartTime, endTime = @EndTime, dateClassDetail = @DateClassDetail, quantityStudent = @QuantityStudent " +
                         
                          "WHERE idClassDetail = @idClassDetail"; // Reemplaza "TuTabla" por el nombre de tu tabla y ajusta el WHERE según tus necesidades



                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar parámetros para la consulta UPDATE
                           // command.Parameters.AddWithValue("@StartTime", startTime);
                           // command.Parameters.AddWithValue("@EndTime", endTime);
                            //command.Parameters.AddWithValue("@DateClassDetail", dateClassDetail);
                            command.Parameters.AddWithValue("@QuantityStudent", quantityStudent);
                    
                            // Agregar el parámetro para el ID de la fila que se va a actualizar
                            command.Parameters.AddWithValue("@idClassDetail", idToDelete);

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
                if (dgvClassDetail.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvClassDetail.SelectedRows[0].Cells["idClassDetail"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE ClassDetail SET status = 0 WHERE idClassDetail = @IdParaActualizar";

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
