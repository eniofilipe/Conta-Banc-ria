using System;
namespace ContaBanco
{
    public class BankAccount
    {   
        //Atributos
        public static int NumAcc = 0;
        private float balance;
        private Cliente clienteConta;


        //Construtor zero
        public BankAccount()
        {
            NumAcc++;
        }

        //Construtor Cliente
        public BankAccount(Cliente clienteConta)
        {
            this.clienteConta = new Cliente(clienteConta);
            NumAcc++;
        }

        //Construtor cheio
        public BankAccount(Cliente clienteConta, float balance)
        {
            this.clienteConta = new Cliente(clienteConta);
            this.balance = balance;
            NumAcc++;
        }

        //Getters
        public int getNumAcc()
        {
            return NumAcc;
        }

        public float getBalance()
        {
            return balance;
        }

        public Cliente getCliente()
        {
            return clienteConta;
        }

        //Setters
        public void setBalance(float balance)
        {
            this.balance = balance;
        }
        public void setCliente(Cliente clienteConta)
        {
            this.clienteConta = clienteConta;
        }

        //ToString, equals e Hash
        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return clienteConta + "\nSaldo: R$ " + balance + "\n";
        }

    }
}
