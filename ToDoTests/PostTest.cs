
using Microsoft.AspNetCore.Http;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace ToDoTests
{
    [TestFixture]
    public class PostTest
    {
        [Test]
        public void CreateNewListReturnTwoHundredAndOneResponseWithUrl()
        {
            //Arange
            var expectedStatusCode = StatusCodes.Status201Created;
            var expectedUrl = "local";
            //Act
            var actualStatusCode = StatusCodes.Status200OK;
            var actualUrl = "do";
            //Assert
            Assert.AreEqual(expectedStatusCode, actualStatusCode);
            Assert.AreEqual(expectedUrl, actualUrl);
        }
    }
}
