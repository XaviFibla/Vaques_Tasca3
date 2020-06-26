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
            camio.EntraVaca(vaca.Object);
            var treure = camio.TreureVaca(vaca.Object);

            //assert
            Assert.True(treure);
        }

        [Fact]
        public void Control_Pes_Maxim_No_Entra()
        {
            // arrange
            var vaca_1 = new Mock<Vaca>("Vaca 1", 200, null);
            vaca_1.Setup(r => r.Pes).Returns(200);
            var vaca_2 = new Mock<Vaca>("Vaca 2", 300, null);
            vaca_2.Setup(r => r.Pes).Returns(300);
            var vaca_3 = new Mock<Vaca>("Vaca 3", 300, null);
            vaca_3.Setup(r => r.Pes).Returns(300);

            var camio = new Camio(500);

            //act
            var entra = camio.EntraVaca(vaca_1.Object);
            entra = camio.EntraVaca(vaca_2.Object);
            entra = camio.EntraVaca(vaca_3.Object);
            //assert
            Assert.False(entra);
        }


        [Fact]
        public void Control_Pes_Maxim_Entra()
        {
            // arrange
            var vaca_1 = new Mock<Vaca>("Vaca 1", 200, null);
            vaca_1.Setup(r => r.Pes).Returns(200);
            var vaca_2 = new Mock<Vaca>("Vaca 2", 300, null);
            vaca_2.Setup(r => r.Pes).Returns(300);
            
            var camio = new Camio(500);

            //act
            var entra = camio.EntraVaca(vaca_1.Object);
            entra = camio.EntraVaca(vaca_2.Object);
            
            //assert
            Assert.True(entra);
        }


        [Fact]
        public void Control_Pes_Maxim_Treu_Entra()
        {
            // arrange
            var vaca_1 = new Mock<Vaca>("Vaca 1", 200, null);
            vaca_1.Setup(r => r.Pes).Returns(200);
            var vaca_2 = new Mock<Vaca>("Vaca 2", 300, null);
            vaca_2.Setup(r => r.Pes).Returns(300);


            var camio = new Camio(500);

            //act
            var entra = camio.EntraVaca(vaca_1.Object);
            entra = camio.EntraVaca(vaca_2.Object);
            camio.TreureVaca(vaca_1.Object);
            entra = camio.EntraVaca(vaca_1.Object);

            //assert
            Assert.True(entra);
        }

        [Theory]
        [InlineData(200, 12)]
        [InlineData(100, 10)]
        public void Calcular_Litres_Vaca(double pes, double litres)
        {
            // arrange
            var raca = new Mock<Raca>("Vaca lola", 0);
            raca.Setup(r => r.LitresPerKg).Returns(litres);

            var sut = new Vaca("Vaca", pes, raca.Object);

            //act
            var resultat = sut.GetLitres();

            //assert
            Assert.Equal(pes * litres, resultat);
        }
    }
}
