using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitario
{
    //Existem situações onde o valor de entrada pode ter valor mutável.
    //E neste caso para evitar escrever vários Assert ou vários métodos de teste
    //para testar a mesma função alterando somente o valor de entrada temos o atributo Theory.

    //Para informar o valor de entrada utilizado no teste utilizamos o atributo InlineData e passamos os valores necessários.
    public class TheoriesTest
    {
        private readonly Caixa caixa = new Caixa();

        [Theory(DisplayName = "Saque contém número de cedulas solicitado correto")]
        [InlineData(3, 80)]
        [InlineData(3, 300)]
        [InlineData(5, 500)]
        public void Saque_Contem_Numero_De_Cedulas_Correto(int quantidadeDeCedulas, int valorDoSaque)
        {
            var resultadoCedulas = caixa.Saque(valorDoSaque);
            Assert.Equal(quantidadeDeCedulas, resultadoCedulas.Count);
        }
    }
}

