namespace Project_manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_projects = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.lbl_IO = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_removeProject = new System.Windows.Forms.Button();
            this.btn_editProject = new System.Windows.Forms.Button();
            this.btn_addProject = new System.Windows.Forms.Button();
            this.lbl_projectsManagement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_projects
            // 
            this.dgv_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_projects.Location = new System.Drawing.Point(12, 12);
            this.dgv_projects.Name = "dgv_projects";
            this.dgv_projects.Size = new System.Drawing.Size(714, 445);
            this.dgv_projects.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_import);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_open);
            this.panel1.Controls.Add(this.lbl_IO);
            this.panel1.Location = new System.Drawing.Point(732, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 96);
            this.panel1.TabIndex = 1;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(3, 62);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(135, 23);
            this.btn_import.TabIndex = 3;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(3, 39);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(135, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(3, 16);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(135, 23);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // lbl_IO
            // 
            this.lbl_IO.AutoSize = true;
            this.lbl_IO.Location = new System.Drawing.Point(3, 0);
            this.lbl_IO.Name = "lbl_IO";
            this.lbl_IO.Size = new System.Drawing.Size(140, 13);
            this.lbl_IO.TabIndex = 0;
            this.lbl_IO.Text = "File IO for project collections";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_removeProject);
            this.panel2.Controls.Add(this.btn_editProject);
            this.panel2.Controls.Add(this.btn_addProject);
            this.panel2.Controls.Add(this.lbl_projectsManagement);
            this.panel2.Location = new System.Drawing.Point(732, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 96);
            this.panel2.TabIndex = 4;
            // 
            // btn_removeProject
            // 
            this.btn_removeProject.Location = new System.Drawing.Point(3, 62);
            this.btn_removeProject.Name = "btn_removeProject";
            this.btn_removeProject.Size = new System.Drawing.Size(135, 23);
            this.btn_removeProject.TabIndex = 3;
            this.btn_removeProject.Text = "Remove";
            this.btn_removeProject.UseVisualStyleBackColor = true;
            this.btn_removeProject.Click += new System.EventHandler(this.btn_removeProject_Click);
            // 
            // btn_editProject
            // 
            this.btn_editProject.Location = new System.Drawing.Point(3, 39);
            this.btn_editProject.Name = "btn_editProject";
            this.btn_editProject.Size = new System.Drawing.Size(135, 23);
            this.btn_editProject.TabIndex = 2;
            this.btn_editProject.Text = "Edit";
            this.btn_editProject.UseVisualStyleBackColor = true;
            this.btn_editProject.Click += new System.EventHandler(this.btn_editProject_Click);
            // 
            // btn_addProject
            // 
            this.btn_addProject.Location = new System.Drawing.Point(3, 16);
            this.btn_addProject.Name = "btn_addProject";
            this.btn_addProject.Size = new System.Drawing.Size(135, 23);
            this.btn_addProject.TabIndex = 1;
            this.btn_addProject.Text = "Add";
            this.btn_addProject.UseVisualStyleBackColor = true;
            this.btn_addProject.Click += new System.EventHandler(this.btn_addProject_Click);
            // 
            // lbl_projectsManagement
            // 
            this.lbl_projectsManagement.AutoSize = true;
            this.lbl_projectsManagement.Location = new System.Drawing.Point(17, 0);
            this.lbl_projectsManagement.Name = "lbl_projectsManagement";
            this.lbl_projectsManagement.Size = new System.Drawing.Size(104, 13);
            this.lbl_projectsManagement.TabIndex = 0;
            this.lbl_projectsManagement.Text = "Project management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_projects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(905, 507);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(905, 507);
            this.Name = "Form1";
            this.Text = "Project Manager - Matthew Wood";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_projects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label lbl_IO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_removeProject;
        private System.Windows.Forms.Button btn_editProject;
        private System.Windows.Forms.Button btn_addProject;
        private System.Windows.Forms.Label lbl_projectsManagement;
    }
}

