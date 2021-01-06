using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                         Console.Writeline("Informe o nome do aluno:")
                         Aluno aluno = new Aluno();
                         aluno.Nome = Console.ReadLine();

                         Console.Writeline("Informe a nota do aluno:")
                         
                         if (decimal.TryParse(Console.ReadLine(), out decimal nota));
                         { 

                         aluno.Nota = nota;

                         }
                         else
                         {
                            throw new ArgumentExcepition("Valor da nota deve ser decimal");
                         }

                         alunos[indiceAluno] = aluno;
                         indiceAluno++
                         break;
                    case "2":
                         foreach (var a item in alunos)
                         {
                             
                         
                         if(string.IsNullOrEmpty(a.Nome))
                         {
                             Console.Writeline($"ALUNO: {a.Nome} - Nota: {a.Nota}");
                         }

                         }
                         break;
                    case "3":
                         var notaTotal = 0;
                         var nrAlunos = 0;

                         for (int i=0; i < alunos.Length; i++)
                         {
                              if (!string.IsNullOrEmpty(alunos[i].Nome))
                              {
                                 notaTotal = notaTotal + alunos[i].Nota;
                              }
                         }

                         var mediaGeral = notaTotal/nrAlunos;
                         Conceito conceitoGeral;

                         if (mediaGeral < 2)
                         {
                             conceitoGeral = Conceito.E;
                         }

                         else if (mediaGeral < 4)
                         {
                             conceitoGeral = Conceito.D;
                         }
                          else if (mediaGeral < 6)
                         {
                             conceitoGeral = Conceito.C;
                         }
                           else if (mediaGeral < 8)
                         {
                             conceitoGeral = Conceito.B;
                         }
                           else
                         {
                             conceitoGeral = Conceito.A;
                         }


                         Console.Writeline($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}")


                         break;          
                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }


        private static string ObterOpcaoUsuario()
        {
            Console.Writeline();
            Console.Writeline("Informe a opção desejada:");
            Console.Writeline("1- Inserir nova aluno");
            Console.Writeline("2- Listar alunos");
            Console.Writeline("3- Calcular média geral");
            Console.Writeline("X- Sair");
            Console.Writeline();

            string opcaoUsuario = Console.ReadLine();
            Console.Writeline();
            return opcaoUsuario;
    }
}
