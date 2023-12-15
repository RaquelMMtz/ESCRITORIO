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
    public partial class FmArea : Form
    {
        string connectionString = "Data Source=DESKTOP-7NQK83I\\SQLEXPRESS;Initial Catalog=AreaServices;Integrated Security=True;";
        private SqlConnection connection;
        public FmArea()
        {
            InitializeComponent();
            MostrarDatos();
            LlenarComboBoxAreaType();
            LlenarComboBoxBuilding();
        }
        public void LlenarComboBoxAreaType()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT IdAreaType FROM AreaType";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdAreaType.DataSource = dataTable;
                        cmbIdAreaType.DisplayMember = "IdAreaType";
                        cmbIdAreaType.ValueMember = "IdAreaType";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }
        public void LlenarComboBoxBuilding()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Query para obtener los IDs de la tabla foránea
                    string query = "SELECT IdBuilding FROM Building";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un objeto SqlDataAdapter para obtener los datos
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dataTable);

                        // Asignar los IDs al ComboBox
                        cmbIdBuilding.DataSource = dataTable;
                        cmbIdBuilding.DisplayMember = "IdBuilding";
                        cmbIdBuilding.ValueMember = "IdBuilding";
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

            string consulta = "SELECT * FROM Area Where status=1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(consulta, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                dgvArea.DataSource = dataTable;
            }
        }

        private void Limpiar()
        {
           
            txtNameArea.Text = "";
            txtNumber.Text = "";
            txtDescriptionArea.Text = "";
            cmbIdAreaType.Text = "";
            cmbIdBuilding.Text = "";
            txtStatus.Text = "";
                  
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar campos obligatorios antes de la inserción
                if (string.IsNullOrEmpty(txtNameArea.Text) || string.IsNullOrEmpty(txtNumber.Text))//aqui no se que va chendo (area)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta de inserción
                    string query = "INSERT INTO Area (nameArea, number, descriptionArea, idAreaType, idBuilding,status)" +
                                   "VALUES (@nameArea, @number, @descriptionArea, @idAreaType, @idBuilding, @status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetros de la consulta de inserción
                        command.Parameters.AddWithValue("@nameArea", txtNameArea.Text);
                        command.Parameters.AddWithValue("@number", txtNumber.Text);
                        command.Parameters.AddWithValue("@descriptionArea", txtDescriptionArea.Text);
                        command.Parameters.AddWithValue("@idAreaType", cmbIdAreaType.Text);
                        command.Parameters.AddWithValue("@idBuilding", cmbIdBuilding.Text);
                        command.Parameters.AddWithValue("@status", 1);
        
                     // Suponiendo que obtienes el ID del ComboBox
              

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
            string nameArea = txtNameArea.Text;
            string number = txtNumber.Text;
            string  descriptionArea= txtDescriptionArea.Text;
            string AreaType= cmbIdAreaType.SelectedValue.ToString();
            string  Building= cmbIdBuilding.SelectedValue.ToString();
          
           

            try
            {
                if (dgvArea.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvArea.SelectedRows[0].Cells["idArea"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Area SET nameArea = @NameArea, number = @Number, descriptionArea = @DescriptionArea ,idAreaType = @idAreaType,idBuilding = @idBuilding   " +
                          "WHERE idArea = @idArea"; 



                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar parámetros para la consulta UPDATE
                            command.Parameters.AddWithValue("@NameArea", nameArea);
                            command.Parameters.AddWithValue("@Number", number);
                            command.Parameters.AddWithValue("@DescriptionArea", descriptionArea);
                            command.Parameters.AddWithValue("@idAreaType", AreaType);
                            command.Parameters.AddWithValue("@idBuilding", Building);
                            // Agregar el parámetro para el ID de la fila que se va a actualizar
                            command.Parameters.AddWithValue("@idArea", idToDelete);

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
                if (dgvArea.SelectedRows.Count > 0)
                {
                    int idToDelete = Convert.ToInt32(dgvArea.SelectedRows[0].Cells["idArea"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Area SET status = 0 WHERE idArea = @IdParaActualizar";

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

        private void dgvArea_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArea.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvArea.SelectedRows[0];

                string nombre = selectedRow.Cells["IdArea"].Value.ToString();

                txtIdArea.Text = nombre;

                string NameArea = selectedRow.Cells["NameArea"].Value.ToString();
                string Number = selectedRow.Cells["Number"].Value.ToString();
                string DescriptionArea = selectedRow.Cells["DescriptionArea"].Value.ToString();
                string Status = selectedRow.Cells["Status"].Value.ToString();
               

                txtNameArea.Text = NameArea;
                txtNumber.Text = Number;
                txtDescriptionArea.Text = DescriptionArea;
                txtStatus.Text = Status;
               
            }
            else
            {

            }
        }
    }
}
