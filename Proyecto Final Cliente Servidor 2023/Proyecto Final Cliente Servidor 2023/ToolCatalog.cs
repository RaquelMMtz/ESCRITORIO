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
    public partial class FmToolCatalog : Form
    {

        string connectionString = "Data Source=DESKTOP-7NQK83I\\SQLEXPRESS;Initial Catalog=AreaServices;Integrated Security=True;";
        private SqlConnection connection;
        public FmToolCatalog()
        {
            InitializeComponent();
            LlenarComboBoxArea();
            MostrarDatos();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FmMenu Menu = new FmMenu();
            Menu.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        public void LlenarComboBoxArea()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT IdArea FROM Area";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdArea.DataSource = dataTable;
                        cmbIdArea.DisplayMember = "IdArea";
                        cmbIdArea.ValueMember = "IdArea";
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
            string connectionString = "Data Source=DESKTOP-OTK3IQJ;Initial Catalog=AreaServices;Integrated Security=True;";
            string consulta = "SELECT * FROM ToolCatalog Where status= 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(consulta, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                dgvToolCatalog.DataSource = dataTable;
            }
        }

        private void Limpiar()
        {
            txtNameToolCatalog.Text = "";
            txtBrand.Text = "";
            txtModel.Text = "";
            txtQuantityExistence.Text = "";
            txtDescriptionToolCatalog.Text = "";
            txtStatus.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
    
            ///
            try
            {
                // Validar campos obligatorios antes de la inserción
                if (string.IsNullOrEmpty(txtNameToolCatalog.Text) || string.IsNullOrEmpty(txtDescriptionToolCatalog.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta de inserción
                    string query = "INSERT INTO ToolCatalog (nameToolCatalog, brand, model, quantityExistence, descriptionToolCatalog, idArea, status)" +
                                   "VALUES (@nameToolCatalog, @brand, @model, @quantityExistence, @descriptionToolCatalog, @idArea,@status)";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros para la inserción
                        command.Parameters.AddWithValue("@nameToolCatalog", txtNameToolCatalog.Text);
                        command.Parameters.AddWithValue("@brand", txtBrand.Text);
                        command.Parameters.AddWithValue("@model", txtModel.Text);
                        command.Parameters.AddWithValue("@quantityExistence", txtQuantityExistence.Text);
                        command.Parameters.AddWithValue("@descriptionToolCatalog", txtDescriptionToolCatalog.Text);
                        command.Parameters.AddWithValue("@idArea", cmbIdArea.SelectedValue);
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
            string nameToolCatalog = txtNameToolCatalog.Text;
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string quantityExistence = txtQuantityExistence.Text;
            string descriptionToolCatalog = txtDescriptionToolCatalog.Text;
     

            try
            {
                if (dgvToolCatalog.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvToolCatalog.SelectedRows[0].Cells["idToolCatalog"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE ToolCatalog SET nameToolCatalog = @NameToolCatalog, brand = @Brand, model = @Model, quantityExistence = @QuantityExistence , descriptionToolCatalog = @DescriptionToolCatalog " +
                         
                          "WHERE idToolCatalog = @idToolCatalog"; // Reemplaza "TuTabla" por el nombre de tu tabla y ajusta el WHERE según tus necesidades



                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar parámetros para la consulta UPDATE
                            command.Parameters.AddWithValue("@NameToolCatalog", txtNameToolCatalog);
                            command.Parameters.AddWithValue("@Brand", txtBrand);
                            command.Parameters.AddWithValue("@Model", txtModel);
                            command.Parameters.AddWithValue("@QuantityExistence", txtQuantityExistence);
                            command.Parameters.AddWithValue("@DescriptionToolCatalog", txtDescriptionToolCatalog);
                        
                            // Agregar el parámetro para el ID de la fila que se va a actualizar
                            command.Parameters.AddWithValue("@idToolCatalog", idToDelete);

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
                if (dgvToolCatalog.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvToolCatalog.SelectedRows[0].Cells["idToolCatalog"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE ToolCatalog SET status = 0 WHERE idToolCatalog = @IdParaActualizar";

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
