using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_14_05_2025
{
    public class Conta_Estudante : Conta
    {
        private int _cpf;
        private string _nome_inst_ensino;
        private double _ch_especial;
    }
    public override void Sacar(double valor)
        {
            if (valor > 0 && valor <= _saldo + _ch_especial)
            {
                _saldo -= valor;
            }
            else
            {
                throw new Exception(" Saldo Insuficiente ");
            }

     }
}   }
