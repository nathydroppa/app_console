using System;

namespace app_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu RG");
            pessoa.rg = Console.ReadLine(); 
              
            Console.WriteLine("Digite seu CPF");
            pessoa.cpf = Console.ReadLine();
             
            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("RG: {0}", pessoa.rg);
            Console.WriteLine("CPF: {0}", pessoa.cpf);
             
            Pessoa pessoaSilvia = new Pessoa();
            pessoaSilvia.nome = "Silvia";
            pessoaSilvia.idade = 20;
            pessoaSilvia.rg  = "00000";
            pessoaSilvia.cpf = "00000";
              
            Console.WriteLine("Nome: {0}", pessoaSilvia.nome);
            Console.WriteLine("Idade: {0}", pessoaSilvia.idade);
            Console.WriteLine("RG: {0}", pessoaSilvia.rg);
            Console.WriteLine("CPF: {0}", pessoaSilvia.cpf);
             
            pessoa.Acenar (pessoaSilvia);
            pessoa.PerguntaIdade(pessoaSilvia);
        } 
    }
}
