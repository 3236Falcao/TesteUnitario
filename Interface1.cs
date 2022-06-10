using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitario
{
    public interface Interface1
    {
        ICollection<int> Saque(int valor);
        bool ValidaCedulasDisponiveis(int valor);
    }
}

