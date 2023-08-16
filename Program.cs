
using C__DIO.Models;

int numero = 10;
bool ehPar = false;


// IF Ternário
ehPar = numero % 2 ==0;

System.Console.WriteLine($"o número{numero} é"+(ehPar?"par":"impar"));