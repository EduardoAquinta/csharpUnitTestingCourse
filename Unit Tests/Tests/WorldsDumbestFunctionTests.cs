using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tests.Tests {
    public class WorldsDumbestFunctionTests {
        public static void WorldsDumbestFunction_ReturnsPikaChuIfZero_ReturnsString() {
            try {
                //Arrange - Go get your variables, what you need, classes etc.
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act - execute the function
                string result = worldsDumbest.ReturnsPokemonIfZero(num);
                //Assert - whatever is returned, is it what you want?
                if (result == "PICKACHU!") {
                    Console.WriteLine("Passed : WorldsDumbestFunction_ReturnsPikachuIfZero_ResturnsString");
                } else {
                    Console.WriteLine("FAILED: WorldsDumbestFunction_ReturnsPikachuIfZero_ResturnsString");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}
