using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_manager
{
    public class Change
    {
        private string changeTitle;
        private string changeCreator;
        private string changeDescription;


        public Change(string title, string creator, string description) // Main constructor.
        {
            changeTitle = title;
            changeCreator = creator;
            changeDescription = description;
        }
        public Change()
        {

        }


        public string title // Change title property manager.
        {
            get { return changeTitle; }
            set { changeTitle = value; }
        }

        public string creator // Change creator property manager.
        {
            get { return changeCreator; }
            set { changeCreator = value; }
        }

        public string description
        {
            get { return changeDescription; }
            set { changeDescription = value; }
        }
        
    }
}
