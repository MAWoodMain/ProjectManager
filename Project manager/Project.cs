using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_manager
{
    class Project
    {
        private string projectName;

        
        private string projectDescription;
        private DateTime ProjectCreationTime;
        private DateTime ProjectLastEditTime;
        private string projectOwner;
        private List<string> projectContributers;

        public Project(string name, string description, string owner)
        {
            projectName = name;
            projectDescription = description;
            projectOwner = owner;
            ProjectCreationTime = DateTime.Now;
            ProjectLastEditTime = DateTime.Now;
        }

        [System.ComponentModel.DisplayName("Project Name")]
        public string name
        {
            get { return projectName; }
            set { projectName = value; }
        }

        [System.ComponentModel.DisplayName("Project Description")]
        public string description
        {
            get { return projectDescription; }
            set { projectDescription = value; }
        }
        [System.ComponentModel.DisplayName("Created")]
        public DateTime timeCreated
        {
            get { return ProjectCreationTime; }
        }
        [System.ComponentModel.DisplayName("Edited")]
        public DateTime timeEdited
        {
            get { return ProjectLastEditTime; }
        }
        [System.ComponentModel.DisplayName("Project Owner")]
        public string owner
        {
            get { return projectOwner; }
            set { projectOwner = value; }
        }
    }

}
