using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class Team
    {
        public string TeamName { get; set; }
        public List<Driver> Drivers { get; set; }

        public Team(string teamName)
        {
            TeamName = teamName;
            Drivers = new List<Driver>();
        }

        public void AddDriver(Driver driver)
        {
            Drivers.Add(driver);
        }

 



    }
}
