using System;

public class Conta
{
    private string _numero_conta;
    private string _numero_agencia;
    private string _nome_titular;   
    protected double _saldo;

    /*public Conta ()
    {
         _numero_agencia = numero_agencia;
         _nome = nome;
         _deposito = deposito;
         _saque = saque;
         _saldo = saldo;
    }*/
    public string GetNumeroConta()
    {
        return _numero_conta;
    }
    public string GetNumeroAgencia()
    {
        return _numero_agencia;
    }
    public double GetSaldo()
    {
        return _saldo;
    }
    public virtual void Depositar(double valor)
    {
        if(valor > 0)
        {
            throw new Exception(" Valor Inválido ");
        }
        _saldo += valor;    }

    public virtual void Sacar(double valor)
    {
        if (valor >= _saldo && valor >0)
        {
            _saldo += valor;           
        }
        else
        {
            throw new Exception(" Saldo Insuficiente ");
        }

    }
}