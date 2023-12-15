using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Cliente_Servidor_2023
{
    public partial class FmMenu : Form
    {
        public FmMenu()
        {
            InitializeComponent();
        }

        private void btnEmployeeType_Click(object sender, EventArgs e)
        {
            FmEmployeeType EmployeeType = new FmEmployeeType();
            EmployeeType.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnToolCatalog_Click(object sender, EventArgs e)
        {
            FmToolCatalog ToolCatalog = new FmToolCatalog();
            ToolCatalog.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnLoanAplication_Click(object sender, EventArgs e)
        {
            FmLoanAplication LoanAplication = new FmLoanAplication();
            LoanAplication.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FmStudent Student = new FmStudent();
            Student.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            FmCourse Course = new FmCourse();
            Course.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            FmArea Area = new FmArea();
            Area.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnAreaAplication_Click(object sender, EventArgs e)
        {
            FmAreaAplication AreaAplication = new FmAreaAplication();
            AreaAplication.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            FmAuthorization Authorization = new FmAuthorization();
            Authorization.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnAreaType_Click(object sender, EventArgs e)
        {
            FmAreaType AreaType = new FmAreaType();
            AreaType.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnBookCatalog_Click(object sender, EventArgs e)
        {
            FmBookCatalog BookCatalog = new FmBookCatalog();
            BookCatalog.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            FmBuilding Building = new FmBuilding();
            Building.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnCareer_Click(object sender, EventArgs e)
        {
            FmCareer Career = new FmCareer();
            Career.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            FmClass Class = new FmClass();
            Class.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnClassDetail_Click(object sender, EventArgs e)
        {
            FmClassDetail ClassDetail = new FmClassDetail();
            ClassDetail.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FmEmployee Employee = new FmEmployee();
            Employee.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }

        private void btnStudyPlan_Click(object sender, EventArgs e)
        {
            FmStudyPlan StudyPlan = new FmStudyPlan();
            StudyPlan.Show();
            this.Hide(); // Opcional: oculta el formulario actual si no lo necesitas más
        }
    }
}
