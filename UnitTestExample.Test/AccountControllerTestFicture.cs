﻿using System;
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
    // Arrange
    var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
    accountServiceMock
        .Setup(m => m.CreateAccount(It.IsAny<Account>()))
    .Returns<Account>(a => a);
var accountController = new AccountController();
    accountController.AccountManager = accountServiceMock.Object;

// Act
var actualResult = accountController.Register(email, password);

    // Assert
    Assert.AreEqual(email, actualResult.Email);
Assert.AreEqual(password, actualResult.Password);
Assert.AreNotEqual(Guid.Empty, actualResult.ID);
accountServiceMock.Verify(m => m.CreateAccount(actualResult), Times.Once);

        [
    Test,
    TestCase("irf@uni-corvinus.hu", "Abcd1234")
]
    public void TestRegisterApplicationException(string newEmail, string newPassword)
    {
        // Arrange
        var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
        accountServiceMock
            .Setup(m => m.CreateAccount(It.IsAny<Account>()))
            .Throws<ApplicationException>();
        var accountController = new AccountController();
        accountController.AccountManager = accountServiceMock.Object;

        // Act
        try
        {
            var actualResult = accountController.Register(newEmail, newPassword);
            Assert.Fail();
        }
        catch (Exception ex)
        {
            Assert.IsInstanceOf<ApplicationException>(ex);
        }

        // Assert
    }
}
