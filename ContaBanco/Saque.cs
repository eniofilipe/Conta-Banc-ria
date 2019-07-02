using System;
namespace ContaBanco
{
    public partial class Saque : Gtk.Window
    {
        //Atributos classe
        private BankAccount conta;
        private float novoValor;

        //Construtor vazio
        public Saque() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        //Construtor que recebe por parâmetro conta que será efetuado o saque
        public Saque(BankAccount conta) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.conta = conta;
            lblNome.Text = conta.getCliente().getNome();
            lblAtual.Text = "R$ "+conta.getBalance();
            lblDepois.Text = "R$ 0,00";
        }

        //Evento compara valor: desativa botão de confirmação de saque se o valor a sacar for maior que 
        //o valor disponível em conta
        protected void OnCmpValorTextInserted(object o, Gtk.TextInsertedArgs args)
        {
            novoValor = float.Parse(cmpValor.Text);
            novoValor = conta.getBalance() - novoValor;

            lblDepois.Text = "R$ " + novoValor;
            if (novoValor < 0)
            {
                btnConfirma.CanFocus = false;
                btnConfirma.Sensitive = false;
            }
            else
            {
                btnConfirma.CanFocus = true;
                btnConfirma.Sensitive = true;
            }
        }

        //Evento confirma saque: salva na conta o novo saldo
        //Botão 'Confirma Saque'
        protected void OnBtnConfirmaClicked(object sender, EventArgs e)
        {
            conta.setBalance(novoValor);
            this.Destroy();
        }

        //Evento encerra janela
        protected void OnBtnSairClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }


    }
}
