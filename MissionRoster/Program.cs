using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnel person = new Personnel
            {
                Surname = "Misaki",
                FirstName = "Shin",
                Callsign = "Cheezit",
                Role = "Pilot"
            };
            AirCrew aircrew = new AirCrew();
            aircrew.AddCrew(person);
            aircrew.SaveCrew();
            
            /*
            PersonnelRoster person2 = new PersonnelRoster();
            person2.AddSurname("Chang");
            person2.AddFirstName("Kara");
            person2.AddCallsign("Flucky");
            person2.AddRole("WSO");
            AirCrew aircrew = new AirCrew();
            aircrew.AddCrew("111A", person);
            aircrew.AddCrew("111B", person2);
            aircrew.PrintCrew();
            aircrew.SaveCrew();
            */
        }
    }
}