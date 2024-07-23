using System;
using System.Diagnostics;
namespace controleclientes
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    class Program
    {
        private static object pj;

        static void Main(string[] args)

        {
            float Val_pag;
            Console.WriteLine("Informar Nome");
            string Var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string Var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string Var_tipo = Console.ReadLine();
            if (Var_tipo == "f")
            {
                // --- Pessoa Física ----
                Pessoa_Fisica pf = new()
                {
                    Nome = Var_nome,
                    Endereco = Var_endereco
                };
                Console.WriteLine("Informar CPF:");
                pf.Cpf = Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.Rg = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                Val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(Val_pag);
                Console.WriteLine("-------- Pessoa Física ---------");
                Console.WriteLine("Nome ..........: " + pf.Nome);
                Console.WriteLine("Endereço ......: " + pf.Endereco);
                Console.WriteLine("CPF ...........: " + pf.Cpf);
                Console.WriteLine("RG ............: " + pf.Rg);
                Console.WriteLine("Valor de Compra: " +
                pf.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " +
                pf.Valor_Imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " +
                pf.Total.ToString("C"));
            }
            if (Var_tipo == "j")
                // Pessoa Jurídica
                Pessoa_Juridica pj = new()
                {
                    Nome = Var_nome,
                    Endereco = Var_endereco
                };
            Console.WriteLine("Informar CNPJ:");
            pj.Cnpj = Console.ReadLine();
            Console.WriteLine("Informar IE:");
            pj.Ie = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            Val_pag = float.Parse(Console.ReadLine());
            pj.Pagar_Imposto(Val_pag);
            Console.WriteLine("-------- Pessoa Jurídica ---------");
            Console.WriteLine("Nome ..........: " + pj.Nome);
            Console.WriteLine("Endereço ......: " + pj.Endereco);
            Console.WriteLine("CNPJ ..........: " + pj.Cnpj);
            Console.WriteLine("IE ............: " + pj.Ie);
            Console.WriteLine("Valor de Compra: " + pj.Valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + pj.Valor_Imposto.ToString("C"));
            Console.WriteLine("Total a Pagar : " + pj.Total.ToString("C"));
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}




