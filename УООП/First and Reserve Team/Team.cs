using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_Reserve_Team
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team (string _name)
        {
            name = _name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public List<Person> FirstTeam { get; set; }
        public List<Person> ReserveTeam { get; set; }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }
    }
}
