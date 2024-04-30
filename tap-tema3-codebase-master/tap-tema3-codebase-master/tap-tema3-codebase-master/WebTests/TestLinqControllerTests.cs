using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4Web.Services.Linq;
using Moq;
using Lab4Web.Controllers;

namespace WebTests
{
    [TestFixture]
    public class TestLinqControllerTests
    {
        public void GetMethod_ShouldcallService_Once()
        {
            //arrange
            var mockLinqService = new Mock<ILinqService>();
            var testLinqController = new TestLinqController(mockLinqService.Object);

            //act
            testLinqController.Get(1);

            //assert
            mockLinqService.Verify(m => m.Test1(1), Times.Once);

        }
        [Test]

    public void GetMethod_ShouldReturn_NumerOfPersons()
        {
            //arrange
            var mockLinqService = new Mock<ILinqService>();
            
            var testLinqController = new TestLinqController(mockLinqService.Object);
           

        }
    }
}
