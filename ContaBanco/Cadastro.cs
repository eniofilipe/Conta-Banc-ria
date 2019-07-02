using System;
using Gtk;

namespace ContaBanco
{
    public partial class Cadastro : Gtk.Window
    {
        //Atributos classe
        private MainWindow win;
        //Construtor vazio
        public Cadastro() :
                base(Gtk.WindowType.Toplevel)
        {
            Build();
        }
        //Contrutor recebe por parâmetro objeto da classe onde será cadastrada a nova conta
        public Cadastro(MainWindow win) :
                base(Gtk.WindowType.Toplevel)
        {
            this.win = win;
            Build();

        }

        //Evento Salvar conta: salva uma nova conta com os atributos específicados
        //Botão 'Salvar'
        private void OnBtnSalvarClicked(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.setNome(cmpNome.Text);
            cli.setCpf(cmpCpf.Text);
            cli.setUserCode(cmpCodigo.Text);
            Console.WriteLine("opa");
            BankAccount conta = new BankAccount(cli);

            win.addConta(conta);
            this.Destroy();
        }

        //Evento encerrar janela
        protected void OnBtnSairClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
