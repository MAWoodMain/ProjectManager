using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_manager
{
    public partial class Form1 : Form
    {
        List<Project> mainProjects = new List<Project>();
        public Form1()
        {
            InitializeComponent();
            Project test = new Project("Test", "This is a test.", "Matthew Wood");
            test.description += " This was added.";
            MessageBox.Show(test.description);
            mainProjects.Add(test);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_projects.DataSource = mainProjects;
            dgv_projects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_projects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_projects.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btn_addProject_Click(object sender, EventArgs e)
        {

        }

        private void btn_editProject_Click(object sender, EventArgs e)
        {

        }

        private void btn_removeProject_Click(object sender, EventArgs e)
        {

        }
    }
}
