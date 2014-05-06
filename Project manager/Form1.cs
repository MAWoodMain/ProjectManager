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
        public Form1()
        {
            InitializeComponent();
            Project test = new Project("Test", "This is a test.", "Matthew Wood");
            test.description += " This was added.";
            test.addContributer("Liam Allan");
            Program.Projects.Add(test);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            INIT_dataGridView();
        }

        private void INIT_dataGridView()
        {
            dgv_projects.DataSource = null;
            dgv_projects.DataSource = Program.Projects;
            dgv_projects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_projects.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_projects.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_projects.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_projects.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_projects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_projects.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_projects.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
        private void btn_addProject_Click(object sender, EventArgs e)
        {

        }

        private void btn_editProject_Click(object sender, EventArgs e)
        {

        }

        private void btn_removeProject_Click(object sender, EventArgs e)
        {
            if (dgv_projects.SelectedRows.Count > 0) {
                //MessageBox.Show(Program.Projects[(dgv_projects.SelectedRows[0].Index)].name);
                Project target = new Project();
                foreach (DataGridViewRow row in dgv_projects.SelectedRows) {
                    target = Program.Projects[row.Index];
                    Program.Projects.Remove(target);
                }
                MessageBox.Show(Program.Projects.Count.ToString());
                INIT_dataGridView();
            }
            else
            {
                MessageBox.Show("Please select one row");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(Program.Projects.GetType());
            System.IO.StreamWriter file = new System.IO.StreamWriter("test.pmd");
            writer.Serialize(file, Program.Projects);
            file.Close();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(Program.Projects.GetType());
            System.IO.StreamReader reader = new System.IO.StreamReader("test.pmd");
            Program.Projects = (List<Project>)serializer.Deserialize(reader);
            reader.Close();
            INIT_dataGridView();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(Program.Projects.GetType());
            System.IO.StreamReader reader = new System.IO.StreamReader("test.pmd");
            Program.Projects.AddRange((List<Project>)serializer.Deserialize(reader));
            INIT_dataGridView();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Change c = new Change("Test", "Matthew Wood", "This is a value test.");
            c.oldValue = 6;
            c.newValue = 10;
            Program.Projects[0].addChange(c);
            Int32 test = (int)Program.Projects[0].changeLog[1].newValue;
            INIT_dataGridView();
        }
    }
}
