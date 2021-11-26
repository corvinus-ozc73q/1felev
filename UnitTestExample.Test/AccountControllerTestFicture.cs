using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFicture
    {
      //Attribútum
     [test,
            TestCase("abcd1234",false),
            TestCase("irf@uni-corvinus.hu", false)
            TestCase("irf@uni-corvinus.hu", true)



            ]
     [test,
            TestCase("Abcdefgh", false)
            TestCase("ABCD1234", false)
            Testcase("abcd1234", false)

            
            
            ]
     //Assert
     Assert.AreEqual(expected Result, actualresult);
    }
}
