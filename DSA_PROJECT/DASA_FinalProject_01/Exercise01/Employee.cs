using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASA_FinalProject_01
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(int id, string name, string position)
        {
            ID = id;
            Name = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"{ID}: {Name} - {Position}";
        }
    }
}
