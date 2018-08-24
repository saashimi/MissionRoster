using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MissionRoster
{
    class Personnel
    {
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _callsign;
        public string Callsign
        {
            get { return _callsign; }
            set { _callsign = value; }
        }

        private string _role;
        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }
  
        public void PrintPersonnel()
        {
            foreach (PropertyInfo prop in GetType().GetProperties())
            {
                Console.WriteLine("{0} : {1}", prop.Name, prop.GetValue(this, null));
            }
        }
        
        public void SavePersonnel(StreamWriter file)
        {
            foreach (PropertyInfo prop in GetType().GetProperties())
            {
                file.WriteLine("{0} : {1}", prop.Name, prop.GetValue(this, null));
            }
        }

    }
}
