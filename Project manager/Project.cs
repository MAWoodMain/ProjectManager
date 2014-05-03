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
        private List<string> projectContributors;

        public Project(string name, string description, string owner)
        {
            projectName = name;
            projectDescription = description;
            projectOwner = owner;
            ProjectCreationTime = DateTime.Now;
            ProjectLastEditTime = DateTime.Now;
            projectContributors = new List<string>();
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
        
        [System.ComponentModel.DisplayName("Project Contributors")]
        public string contributors
        {
            get {
                if (projectContributors != null) { 
                    string output = "";
                    foreach (string contributer in projectContributors) {
                        if (output == "") {
                            output += contributer;
                        }
                        else
                        {
                            output += ("," + Environment.NewLine + contributer);
                        }
                    }
                    return output;
                }
                return "";
            }
            set {
                projectContributors.Clear();
                foreach (string contributer in value.Split(new string[] { ("," + Environment.NewLine) }, StringSplitOptions.None))
                {
                    projectContributors.Add(contributer);
                }
            }
        }

        public void addContributer(string name)
        {
            projectContributors.Add(name);
        }
    }

}
