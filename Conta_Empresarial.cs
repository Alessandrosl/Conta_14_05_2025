using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_14_05_2025
{
    public class Conta_Empresarial:Conta
    {
        private double _tx_anuidade;
        private double _limite_emprestimo;       
        private double _total_Emprestimo;
        public void Fazer_Emprestimo(double valor)
        {
            if (valor >= _limite_emprestimo - _total_Emprestimo)
            {
                _total_Emprestimo += valor;
                _saldo = _saldo += valor;
            }
            else
            {
                throw new Exception(" Valor de Emprestimo não pode ser concedida ");
            }

        }
        public override void Sacar(double valor)
        {
            if (valor > 5000 && valor <= _saldo - 5)
            {
                _saldo -= valor;
                _saldo = -5;
            }
            else if (valor < 5000)
            {
                base.Sacar(valor);
            }
            else
            {
                throw new Exception(" Saldo Insuficiente ");
            }
        }
    }
}
