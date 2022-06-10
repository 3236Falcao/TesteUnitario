using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitario
{
    //Para assegurar que o teste deve obedecer algum resultado esperado utilizamos a class Assert.
    //Na classe Assert temos uma grande lista de possibilidades, como verificar se resultado é falso,
    //verdadeiro, igual, maior, menor, nulo e até se deve esperar alguma exceção.
    public class NormalAssertsTest
    {
        private readonly Caixa caixa = new Caixa();

        [Fact]
        public void Saque_Valido()
        {
            int valorDoSaque = 510;
            bool saqueEhValido = caixa.ValidaCedulasDisponiveis(valorDoSaque);
            Assert.True(saqueEhValido);//verifica se resultado esperado é verdadeiro
        }

        [Fact]
        public void Deve_Gerar_Excecao()
        {
            int valorDoSaque = 5;
            Assert.Throws<Exception>(() => caixa.Saque(valorDoSaque));//verifica se método lança exceção
        }
    }
}

