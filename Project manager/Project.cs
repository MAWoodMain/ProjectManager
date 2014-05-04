using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Project_manager
{
    [Serializable()]
    public class Project
    {
        private string projectName;

        
        private string projectDescription;
        private DateTime ProjectCreationTime;
        private DateTime ProjectLastEditTime;
        private string projectOwner;
        private List<string> projectContributors;
        private List<Change> projectChangeLog;


        public Project(string name, string description, string owner) // Main constructor. 
        {
            projectName = name;
            projectDescription = description;
            projectOwner = owner;
            ProjectCreationTime = DateTime.Now;
            ProjectLastEditTime = DateTime.Now;
            projectContributors = new List<string>();
            projectContributors.Add(owner);
            projectChangeLog = new List<Change>();
            projectChangeLog.Add(new Change("Project Created", owner, "The project " + name + " was created."));
        }

        public Project() // Blank constructor for serialization. 
        {
            ProjectCreationTime = DateTime.Now;
            ProjectLastEditTime = DateTime.Now;
            projectContributors = new List<string>();
            projectChangeLog = new List<Change>();
        }

        [System.ComponentModel.DisplayName("Project Name")]
        public string name //Project name property manager. 
        {
            get { return projectName; }
            set { projectName = value; }
        }

        
        [System.ComponentModel.DisplayName("Project Description")]
        public string description //Project description property manager. 
        {
            get { return projectDescription; }
            set { projectDescription = value; }
        }
        
        [System.ComponentModel.DisplayName("Created")]
        public DateTime timeCreated //Project time created property manager (readonly). 
        {
            get { return ProjectCreationTime; }
        }
        
        [System.ComponentModel.DisplayName("Edited")]
        public DateTime timeEdited //Project time edited property manager (readonly). 
        {
            get { return ProjectLastEditTime; }
        }
        
        [System.ComponentModel.DisplayName("Project Owner")]
        public string owner //Project owner property manager. 
        {
            get { return projectOwner; }
            set { projectOwner = value; }
        }
        
        public List<string> contributors //Project contributors property manager. 
        {
            get {
                return projectContributors;
            }
            set {
                projectContributors = value;
                }
        }

        [System.ComponentModel.DisplayName("Project Contributors")]
        [System.Xml.Serialization.XmlIgnore]
        public string displayedContributors // project contributors property for display purposes. 
        {
            get
            {
                if (projectContributors != null) { // if there are contributors.
                    string output = "";
                    foreach (string contributer in projectContributors) {
                        if (output == "") {
                            output += contributer; // adds the first one to the output.
                        }
                        else
                        {
                            output += ("," + Environment.NewLine + contributer); // adds all the following contributors onto the end formatted for DGV.
                        }
                    }
                    return output;
                }
                return "";
            }
            set
            {
                projectContributors.Clear(); // removes all contributors.
                foreach (string contributer in value.Split(new string[] { ("," + Environment.NewLine) }, StringSplitOptions.None)) // breaks up the contributors.
                {
                    projectContributors.Add(contributer); // repopulates the list of contributors.
                }
            }
        }

        [System.ComponentModel.DisplayName("Latest Change")]
        [System.Xml.Serialization.XmlIgnore]
        public string latestChange // project change property for display purposes. 
        {
            get {
                Change changes = new Change();
                foreach (Change chng in projectChangeLog)
                {
                    changes = chng;
                }
                return changes.title + ":" + Environment.NewLine + changes.description;
            }
        }

        public List<Change> changeLog //Project owner property manager. 
        {
            get { return projectChangeLog; }
            set { projectChangeLog = value; }
        }
        public void addContributer(string name) // Function that allows for adding single contributors. 
        {
            projectContributors.Add(name);
        }
    }

}
