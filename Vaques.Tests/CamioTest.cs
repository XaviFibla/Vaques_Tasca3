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
        public void Entrar_Vaca(double pes)
        {
            // arrange
            var vaca = new Mock<Vaca>("No importa", 0,null);
            vaca.Setup(r => r.Pes).Returns(pes);

            var camio = new Camio(4000);

            //act
            var entra = camio.EntraVaca(vaca.Object);

            //assert
            Assert.True(entra);
        }

        [Theory]
        [InlineData(400.0)]     
        public void No_Entrar_Vaca(double pes)
        {
            // arrange
            var vaca = new Mock<Vaca>("No importa", 0, null);
            vaca.Setup(r => r.Pes).Returns(pes);

            var camio = new Camio(100);

            //act
            var entra = camio.EntraVaca(vaca.Object);

            //assert
            Assert.False(entra);
        }

        [Fact]
        public void Treure_vaca()
        {
            // arrange
            var vaca = new Mock<Vaca>("Wapa",200.0, null);
            var camio = new Camio(1000);

            //act
            var treure = camio.TreureVaca(vaca.Object);

            //assert
            Assert.True(treure);
        }

    }
}
