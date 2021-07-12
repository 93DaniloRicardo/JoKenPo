using System;

namespace JoKenPo
{
    class Program
    {
        static void Main(string[] args)
        {
           int jogador1Escolha;
           int pedra = 1;
           int papel = 0;
           int tesoura = 2;

           Random numAleatorio = new Random();
           int jogador2Escolha = numAleatorio.Next(2);

           Console.WriteLine("");
           Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
           Console.WriteLine("X=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=X");
           Console.WriteLine("X=-=-=-=-=-=-Bem-Vindo=-=-=-=-=-=-X");
           Console.WriteLine("X=-=-=-==-=--=-=AO-=-=-=-=-=-=-=-=X");
           Console.WriteLine("X=-=-=-=-=-=-JoKenPo!-=-=-=-=-=-=-X");
           Console.WriteLine("X=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-X");
           Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
           Console.WriteLine("");

           Console.Write("Por favor, escolha umas das opçoes (numeros): (0) - Papel, (1) - Pedra ou (2) - Tesoura: ");
           jogador1Escolha = int.Parse(Console.ReadLine());

            if (jogador1Escolha == 0)
            {
                Console.WriteLine("Jogador escolheu: Papel");
            }
            else if (jogador1Escolha == 1)
            {
                Console.WriteLine("Jogador escolheu: Pedra ");
            }
           else if (jogador1Escolha == 2)
           {
                Console.WriteLine("Jogador escolheu: Tesoura");
           }
            else
            
            {
                Console.WriteLine("Programa fechado");
                Environment.Exit(0);
            }

                
                
            if (jogador2Escolha == 0)
            {
                Console.WriteLine("Computador escolheu: Papel");
            }
            else if (jogador2Escolha == 1)
            {
                Console.WriteLine("Computador escolheu: Pedra");
            }
            else
            {
                Console.WriteLine("Computador escolheu: Tesoura");
            }

            if(jogador1Escolha == jogador2Escolha){
                Console.WriteLine("Empate");
            }else
            {
                if(jogador1Escolha == papel && jogador2Escolha == pedra){
                    Console.WriteLine("Jogador 1 ganhou!");
                }
                else if(jogador1Escolha == papel && jogador2Escolha == tesoura)
                {
                    Console.WriteLine("jogador 2 ganhou!");
                }
                else if(jogador1Escolha == pedra && jogador2Escolha == tesoura)
                {
                    Console.WriteLine("Jogador 1 ganhou!");
                }
                else if (jogador1Escolha == pedra && jogador2Escolha == papel)
                {
                    Console.WriteLine("Jogador 2 ganhou!");
                }
                else if (jogador1Escolha == tesoura && jogador2Escolha == papel)
                {
                    Console.WriteLine("Jogador 1 ganhou!");
                }
                else if(jogador1Escolha == tesoura && jogador2Escolha == pedra)
                {
                    Console.WriteLine("Jogador 2 ganhou!");
                }
            }
        }
    }
}
