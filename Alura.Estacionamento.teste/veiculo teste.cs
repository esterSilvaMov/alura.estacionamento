using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.teste
{
    public class VeiculoTeste
    {
        [Fact]
        public void TestaVeiculoAcelera ()
        {
            var veiculo = new Veiculo();
            veiculo.Acelerar(10);
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }
    }
}