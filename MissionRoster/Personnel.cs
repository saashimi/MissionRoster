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
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Callsign { get; set; }
        public string Role { get; set; }
  
        public void PrintPersonnel()
        {
            foreach (PropertyInfo prop in GetType().GetProperties())
            {
                Console.WriteLine(
                    "{0} : {1}", 
                    prop.Name, 
                    prop.GetValue(this, null));
            }
        }
        
        public void SavePersonnel(StreamWriter file)
        {
            foreach (PropertyInfo prop in GetType().GetProperties())
            {
                file.WriteLine(
                    "{0} : {1}", 
                    prop.Name, 
                    prop.GetValue(this, null));
            }
        }

    }
}
