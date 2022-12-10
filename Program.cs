Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("EXIBE A TABUADA");
Thread.Sleep(800);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Digite um número:");
string um = Console.ReadLine()!;
int resposta1 = Convert.ToInt32(um);

int n1 = 1, n2 = 2, n3 = 3, n4 = 4, n5 = 5, n6 = 6, n7 = 7, n8 = 8, n9 = 9, n10 = 10;

int resultado1 = resposta1 * n1;
int resultado2 = resposta1 * n2;
int resultado3 = resposta1 * n3;
int resultado4 = resposta1 * n4;
int resultado5 = resposta1 * n5;
int resultado6 = resposta1 * n6;
int resultado7 = resposta1 * n7;
int resultado8 = resposta1 * n8;
int resultado9 = resposta1 * n9;
int resultado10 = resposta1 * n10;

Console.ForegroundColor = ConsoleColor.Blue;
Console.Beep(1320, 1000);
Console.WriteLine("Tabuada");
Console.WriteLine(resultado1);
Console.WriteLine(resultado2);
Console.WriteLine(resultado3);
Console.WriteLine(resultado4);
Console.WriteLine(resultado5);
Console.WriteLine(resultado6);
Console.WriteLine(resultado7);
Console.WriteLine(resultado8);
Console.WriteLine(resultado9);
Console.WriteLine(resultado10);