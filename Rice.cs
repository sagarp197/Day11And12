using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONInventoryManagement
{
    public class Rice
    {
        public List<TypesOfRice> typesOfRice;
    }
    
    public class TypesOfRice
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

    }

    public class Pulses
    {
        public List<TypesOfPulses> typesOfPulses;
    }

    public class TypesOfPulses
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

    }

    public class Wheats
    {
        public List<TypesOfWheats> typesOfWheats;
    }
    public class TypesOfWheats
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

    }
}
