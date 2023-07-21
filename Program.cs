
using C__DIO.Models;

 Stack <int>pilha  = new Stack<int> ();

pilha.Push(14); // no topo
pilha.Push(16);
pilha.Push(18);
foreach(int item in pilha){
    System.Console.WriteLine(item);
}

pilha.Pop();// removendo o 18