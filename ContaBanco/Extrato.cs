using System;
namespace ContaBanco
{
    public partial class Extrato : Gtk.Window
    {
        //Atributos classe
        private BankAccount conta;
        //Construtor vazio
        public Extrato() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        //Construtor recebe por parâmetro a conta que será mostrado o extrato
        public Extrato(BankAccount conta) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.conta = conta;

            lblNome.Text = conta.getCliente().getNome();
            lblCpf.Text = conta.getCliente().getCpf();
            lblCodigo.Text = conta.getCliente().getUserCode();
            lblSaldo.Text = "R$ "+conta.getBalance();
        }

        //Evento encerra janela
        protected void OnBtnSairClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
