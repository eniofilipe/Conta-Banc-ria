using System;
namespace ContaBanco
{
    public partial class Deposito : Gtk.Window
    {
        //Atributos classe
        private BankAccount conta;
        //Construtor vazio
        public Deposito() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        //Construtor que recebe conta que vai ser realizado o depósito
        public Deposito(BankAccount conta) :
                base(Gtk.WindowType.Toplevel)
        {
            this.conta = conta;
            this.Build();
            labelNome.Text = conta.getCliente().getNome();
        }

        //Evento encerrar tela botão 'sair'
        protected void OnBtnSairClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        //Evento confirmar depósito: realiza depósito na conta passada por parãmetro no construtor
        //Botão 'Confirmar Depósito"
        protected void OnBtnConfirmaClicked(object sender, EventArgs e)
        {


            float val = float.Parse(cmpValor.Text);
            Console.WriteLine("" + val);
            conta.setBalance(conta.getBalance() + val);
            this.Destroy();
        }
    }
}
