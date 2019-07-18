﻿public class ContaCorrente
{
    public string nome;
    public int agencia;
    public int numero;
    public double saldo = 1000;

    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        
        this.saldo -= valor;
        return true;
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}