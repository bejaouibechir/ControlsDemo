using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsDemo
{
    public class AnimalGroup : List<Animal>
    {
        //Using a private set is to compell the user to define group name just once 
        public string Name { get; private set; }

        
        public AnimalGroup(string name, List<Animal> animals) : base(animals)
        {
            Name = name;
        }
    }
}
