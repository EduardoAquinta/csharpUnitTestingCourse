using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tests {
    public class WorldsDumbestFunction 
    {
        public string ReturnsPokemonIfZero(int num) 
        {
            if(num == 0) {
                return "PICKACHU!";
            } else {
                return "Squirtle";
            }
        }
    }
}
