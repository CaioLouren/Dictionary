using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Candidatos
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Candidatos(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
