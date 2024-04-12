using System;
using System.Diagnostics.Contracts;

class ContaBancaria{
    // Tipo por valor
    public string Titular;
    // Tipo por valor
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
        // Tipo por referencia:
        ContaBancaria contaJoao = new ContaBancaria("Jão da Silva", 0);

        // Tipo por referencia:
        ContaBancaria contaMaria = new ContaBancaria("Maria", 2000);

        // Tipo por valor:
        double valor = 300;

        contaJoao.Depositar(valor);
        contaMaria.ExibirSaldo();
        contaJoao.ExibirSaldo();
    }
}