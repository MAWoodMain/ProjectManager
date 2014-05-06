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
        private DateTime changeTime;
        private object changeOldValue;
        private object changeNewValue;


        public Change(string title, string creator, string description) // Main constructor.
        {
            changeTitle = title;
            changeCreator = creator;
            changeDescription = description;
            changeTime = DateTime.Now;
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

        public DateTime time
        {
            get { return changeTime; }
            set { changeTime = value; }
        }

        public object oldValue
        {
            get { return changeOldValue; }
            set { changeOldValue = value; }
        }

        public object newValue
        {
            get { return changeNewValue; }
            set { changeNewValue = value; }
        }
    }
}
