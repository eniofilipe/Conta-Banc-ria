using System;
using System.Collections.Generic;
using ContaBanco;
using Gtk;


//Tela principal
public partial class MainWindow : Gtk.Window
{
    //Atributos tela principal
    private static int cont = 0;
    private ListStore store;
    private List<BankAccount> contas = new List<BankAccount>();
    //Construtor da tela
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {

        Build();
        InicializaTabela();
    }


    //Inicializa tabela que lista contas cadastradas
    public void InicializaTabela()
    {
        store = new ListStore(typeof(int), typeof(string), typeof(string), typeof(string));

        viewContas.Selection.Mode = SelectionMode.Single;
        viewContas.Model = store;
        viewContas.AppendColumn("#", new Gtk.CellRendererText(), "text", 0);
        viewContas.AppendColumn("Nome", new Gtk.CellRendererText(), "text", 1);
        viewContas.AppendColumn("CPF", new Gtk.CellRendererText(), "text", 2);
        viewContas.AppendColumn("Código", new Gtk.CellRendererText(), "text", 3);
        viewContas.ShowAll();
    }

    // Método de cadastro de nova conta
    public void addConta(BankAccount conta)
    {
        Console.WriteLine("adicionou");
        contas.Add(conta);
        string nome = conta.getCliente().getNome();
        string cpf = conta.getCliente().getCpf();
        string codigo = conta.getCliente().getUserCode();
        Console.WriteLine("adicionou: "+nome+","+cpf+","+codigo);
        store.AppendValues(cont, nome , cpf, codigo);
        cont++;
    }

    //Evento encerrar aplicação
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    // Evento excluir conta cadastrada
    protected void OnBtnExcluirClicked(object sender, EventArgs e)
    {
        TreeIter selectedConta;
        TreeModel model;

        int pos = 0;
        if (viewContas.Selection.CountSelectedRows() > 0)
        {
            viewContas.Selection.GetSelected(out model, out selectedConta);
            pos = (int)model.GetValue(selectedConta, 0);
            Console.WriteLine("" + pos);
            contas.RemoveAt(pos);

            cont = 0;
            store.Clear();
            foreach (BankAccount conta in contas)
            {
                Console.WriteLine(conta.getCliente().getNome() + "");
                store.AppendValues(cont, conta.getCliente().getNome(), conta.getCliente().getCpf(), conta.getCliente().getUserCode());
                cont++;
            }
        }

    }

    // Retorna objeto do tipo conta de acordo com o index especificado
    public BankAccount getConta(int index)
    {
        return contas[index];
    }

    //Abre tela cadastro
    protected void OnBtnCadastroClicked(object sender, EventArgs e)
    {
        Cadastro cad = new Cadastro(this);
        cad.Show();
    }

    // Abre tela de Depósito de acordo com conta selecionada
    protected void OnBtnDepositoClicked(object sender, EventArgs e)
    {
        if (viewContas.Selection.CountSelectedRows() > 0)
        {
            TreeIter selectedConta;
            TreeModel model;

            viewContas.Selection.GetSelected(out model, out selectedConta);
            int pos = (int)model.GetValue(selectedConta, 0);

            Deposito dep = new Deposito(contas[pos]);
            dep.Show();
        }
    }

    // Abre tela de extrato de acordo com conta selecionada
    protected void OnBtnExtratoClicked(object sender, EventArgs e)
    {
        if (viewContas.Selection.CountSelectedRows() > 0)
        {
            TreeIter selectedConta;
            TreeModel model;

            viewContas.Selection.GetSelected(out model, out selectedConta);
            int pos = (int)model.GetValue(selectedConta, 0);

            Extrato ext = new Extrato(contas[pos]);
            ext.Show();
        }
    }

    //Abre tela de saque de acordo com conta selecionada
    protected void OnBtnSaqueClicked(object sender, EventArgs e)
    {
        if (viewContas.Selection.CountSelectedRows() > 0)
        {
            TreeIter selectedConta;
            TreeModel model;

            viewContas.Selection.GetSelected(out model, out selectedConta);
            int pos = (int)model.GetValue(selectedConta, 0);

            Saque saq = new Saque(contas[pos]);
            saq.Show();
        }
    }
}
