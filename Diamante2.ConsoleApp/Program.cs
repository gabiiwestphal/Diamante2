using System;

namespace Diamante2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imprimir = "";
            int MeioDiamante, Espacos, letra;
            int TabelaAsc = 65;
            int quantidadeLetras = 1;

            //dividi o diamante em tres partes: superior, meio e inferior.
            Console.WriteLine("Informe uma letra: ");
            letra = Convert.ToInt32(Convert.ToChar(Console.ReadLine().ToUpper()));

            Espacos = (letra + 1) - TabelaAsc;
            MeioDiamante = (letra + 1) - TabelaAsc;

            for (int superiorDiamante = TabelaAsc; superiorDiamante < letra; superiorDiamante++)
            {
                for (int i = 1; i < Espacos; i++)
                    imprimir += " ";

                if (quantidadeLetras != 1)
                    imprimir += Convert.ToChar(superiorDiamante).ToString();

                for (int impressaoX = 0; impressaoX < (quantidadeLetras - 2); impressaoX++)
                    imprimir += " ";

                imprimir += Convert.ToChar(superiorDiamante).ToString();
                imprimir += "\n";
                quantidadeLetras += 2;
                Espacos--;
            }

            quantidadeLetras -= 2;
            imprimir += Convert.ToChar(letra);
            for (int meioDiamante = 0; meioDiamante < quantidadeLetras; meioDiamante++)
            {
                imprimir += " ";
            }
            imprimir += Convert.ToChar(letra);
            imprimir += "\n";

            Espacos++;
            for (int inferiorDiamante = (letra - 1); inferiorDiamante >= TabelaAsc; inferiorDiamante--)
            {
                for (int i = 1; i < Espacos; i++)
                    imprimir += " ";

                if (quantidadeLetras != 1)
                    imprimir += Convert.ToChar(inferiorDiamante).ToString();

                for (int impressaoX = 0; impressaoX < (quantidadeLetras - 2); impressaoX++)
                    imprimir += " ";

                imprimir += Convert.ToChar(inferiorDiamante).ToString();
                imprimir += "\n";
                quantidadeLetras -= 2;
                Espacos++;
            }
            Console.WriteLine("Diamante \n{0}", imprimir);
            Console.ReadKey();

        }
    }
}
