using System;
using Gtk;

namespace ContaBanco
{
    //Classe de inicialização da aplicação
    class MainClass
    {
        //Método Main: inicializa aplicação e abre tela principal
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
