
/*
///////////// LISTAS ///////////////
////////////////////////////////////
List<string> listaString = new List<string>();
listaString.Add("PE");
listaString.Add("SP");
listaString.Add("RJ");

for(int contador =0; contador < listaString.Count;contador++){
    System.Console.WriteLine($"Posição Nº{contador} - {listaString[contador]}");
}*/


/*

///////////////// ARRAY //////////////////////
/////////////////////////////////////////////

int [] array = new int [4];
Console.WriteLine("Pecorrendo um array com o FOR");

array[0]= 14;
array[1]= 24;
array[2]= 34;
array[3]= 44;

Array.Resize(ref array, array.Length*2);// redimensionar um tamanho de um array, cria uma cópia do array.
int [] arrayCopiado = new int [array.Length*2];
Array.Copy(array,arrayCopiado,array.Length); 

int contador = 0;
foreach(int valor in array){
    System.Console.WriteLine($"Posição nº {contador}-{valor}");
    contador++;
}*/

//////////////// PROPRIEDADES E MÉTODOS//////////////////////////
/////////////////////////////////////////////////////////////////


using C__DIO.Models;

Pessoa p1 = new Pessoa(

);

p1.Nome= "Ana";
p1.Idade= 23;
p1.Sobrenome= "Maria";


Pessoa p2 = new Pessoa();

p2.Nome= "Yuri";
p2.Idade= 27;
p2.Sobrenome= "Henrique";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome= "Ingles";
cursoDeIngles.Alunos = new List<Pessoa> ();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
p1.Apresentar();
//p1._nome="Amor"; // não pega só se for pela Propriedade Nome.