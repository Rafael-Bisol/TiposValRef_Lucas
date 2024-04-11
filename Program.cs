using System;
using System.Diagnostics.Contracts;

class ContaBancaria{
    public string Titular;
    public double Saldo;
    public ContaBancaria(string titular, double saldo){
        Titular = titular;
        Saldo = saldo;
    }
    
    public void Depositar(double valor) {
        Saldo += valor;
        Console.WriteLine($"Depósito de {valor:c} realizado com sucesso!\nNovo saldo: {Saldo:c}");
    }

    public void Sacar(double valor) {
        if (valor > Saldo) {
            Console.WriteLine("Saldo insuficiente.");
            return;
        }
        Saldo -= valor;
        Console.WriteLine($"Saque de {valor:c} realizado com sucesso!\nNovo saldo: {Saldo:c}");
    }

    public void ExibirSaldo() {
        Console.WriteLine($"Senhor(a) {Titular}, sua conta tem {Saldo:c}");
    }
}

class Program {
    static void Main(string[] args) {
        ContaBancaria contaJoao = new ContaBancaria("Jão da Silva", 0);
        /*contaJoao.Saldo = 10;
        contaJoao.Depositar(400);
        contaJoao.Sacar(100);
        contaJoao.ExibirSaldo();*/

        ContaBancaria contaMaria = new ContaBancaria("Maria", 2000);
        double valor = 300;
        contaMaria.Sacar(valor);
        contaJoao.Depositar(valor);
        contaMaria.ExibirSaldo();
        contaJoao.ExibirSaldo();
    }
}