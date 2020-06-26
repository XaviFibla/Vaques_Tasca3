using Moq;
using System;
using Vaques.Model;
using Xunit;

namespace Vaques.Tests
{
    public class CamioTest
    {
        [Theory]
        [InlineData(400.0)]
        [InlineData(340.0)]
        [InlineData(365.0)]
        public void EntrarVaca(double pes)
        {
            // arrange
            var vaca = new Mock<Vaca>();
            vaca.Setup(r => r.Pes).Returns(pes);

            var camio = new Camio();

            //act

            //assert
            Assert.True(camio.EntraVaca(vaca));
        }
    }
}
