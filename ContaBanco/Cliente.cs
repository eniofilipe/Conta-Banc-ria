using System;

namespace ContaBanco
{
    public class Cliente
    {
        //Atributos
        private String nome;
        private String cpf;
        private String userCode;

        //Construtor vazio
        public Cliente()
        {
        }
        //Construtor cópia
        public Cliente(Cliente cli)
        {
            nome = cli.getNome();
            cpf = cli.getCpf();
            userCode = cli.getUserCode();
        }
        //Construtor cheio
        public Cliente(string nome, string cpf, string userCode)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.userCode = userCode;
        }



        //Getters
        public String getNome()
        {
            return nome;
        }

        public String getCpf()
        {
            return cpf;
        }

        public String getUserCode()
        {
            return userCode;
        }

        //Setters
        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public void setUserCode(String code)
        {
            this.userCode = code;
        }

        //ToString, equals e hash
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
            return "Nome: "+nome+"\nCPF: "+cpf+"\nCódigo: "+userCode+"\n";
        }
    }
}
