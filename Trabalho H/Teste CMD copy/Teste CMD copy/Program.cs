using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_CMD_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomev = string.Empty;
            int i = 0;
            Console.WriteLine("Digite um arquivo para copiar: ");
            string nome = Console.ReadLine();
            nome = nome + ".jpg";
            string sourcePath = @"C:\Users\samhi\Dropbox\D&D\Personagens\Lilliana\Imagens\Lilliana";
            string targetPath = @"C:\Users\samhi\Desktop";
            string sourceFile = System.IO.Path.Combine(sourcePath, nome);
            string destFile = System.IO.Path.Combine(targetPath, nome);
            do
            {
                if (System.IO.File.Exists(@"C:\Users\samhi\Desktop\" + nome))
                {
                    nomev = (i).ToString() + ".jpg";
                    destFile = System.IO.Path.Combine(targetPath, nomev);
                }
                i++;
            } while (System.IO.File.Exists(@"C:\Users\samhi\Desktop\" + nomev));
            System.IO.File.Copy(sourceFile, destFile, true);

        }
    }
}
