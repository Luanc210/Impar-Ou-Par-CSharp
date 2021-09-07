/*
Joguinho impar ou par
*/

using System;

class Program {
  public static void Main (string[] args) {
    
    
            // Jogadores: Usuario e PC, respectivamente
            int player1, player2;

            // Escolha Par ou Impar
            string choose1;

            // Numero aleatorio que o PC vai escolher!
            Random randNum = new Random();

            Console.WriteLine("Vamos jogar um jogo! Vão ser 3 tentativas.\n");
            Console.WriteLine("Escolha entre ímpar ou par");

            choose1 = Console.ReadLine();

            //Inicio do Jogo
            if (choose1 == "impar" || choose1 == "ímpar")
            {
                Console.WriteLine("\nOk! O computador escolheu par!\n");
            }
            else
            {
                Console.WriteLine("Ok! O computador escolheu impar\n");
            }

            // Variaveis de Controle
            int controle = 0;
            int contador1 = 0, contador2 = 0;


            
            // Caso a escolha tenha sido PAR    
            if (choose1 == "par")
            {
                // 3 Tentativas
                while (controle < 3)
                {

                    Console.WriteLine("Escolha um número:");

                    player1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nSua escolha foi: " + player1 + "\n");

                    // Ira gerar um numero randomico
                    player2 = randNum.Next(0, 10);
                    Console.WriteLine("O PC escolheu " + player2 + "\n");

                    if (player1 % 2 == 0 && player2 % 2 == 0)
                    {
                        contador1++;
                    }
                    else if (player1 % 2 == 0 && player2 % 2 != 0)
                    {
                        contador2++;
                    }
                    else if (player1 % 2 != 0 && player2 % 2 == 0)
                    {
                        contador2++;
                    }
                    else
                    {
                        contador1++;
                    }

                    controle++;
                }
            }

            // Caso a escolha tenha sido IMPAR    
            if (choose1 == "impar")
            {
                // 3 Tentativas
                while (controle < 3)
                {

                    Console.WriteLine("Escolha um número:");

                    player1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nSua escolha foi: " + player1 + "\n");

                    // Ira gerar um numero randomico
                    player2 = randNum.Next(0, 10);
                    Console.WriteLine("O PC escolheu " + player2 + "\n");

                    if (player1 % 2 == 0 && player2 % 2 == 0)
                    {
                        contador2++;
                    }
                    else if (player1 % 2 == 0 && player2 % 2 != 0)
                    {
                        contador1++;
                    }
                    else if (player1 % 2 != 0 && player2 % 2 == 0)
                    {
                        contador1++;
                    }
                    else
                    {
                        contador2++;
                    }

                    controle++;
                }
            }

            //Placar
            if (contador1 > contador2)
            {
                Console.WriteLine("\nParabéns, você acaba de ganhar!\n");
                Console.WriteLine("Placar: \nUsuario: " + contador1 + " | PC: " + contador2 + "\n");
            }
            else
            {
                Console.WriteLine("Que pena você perdeu!");
                Console.WriteLine("Placar: \nUsuario: " + contador1 + " | PC: " + contador2 + "\n" );
            }

  }
}