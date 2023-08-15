
using C__DIO.Models;

/*(int, string , string) tupla = (1,"YUri","Henrique"); // tupla tem 3 tipos de dados e 3 tipos de valores. apenas com uma única variável foi representado 3 valores de diferentes tipos.
//ValueTuple <int, string> outrosexemplostupla = (1,"ana");
//var outroexemplotuplacreate = Tuple.Create(1,"eu"); // já identifica, mas os dados não ficam genéricos.




System.Console.WriteLine($"SobreNome:{tupla.Item3}");*/


/*LeituraArquivo arquivo = new LeituraArquivo();

var(sucesso,linhasArquivo, /*QuantidadeLinhas_)= arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");// _ fiz o descarte, visto que essa informação não estou usando na prática.

if(sucesso){

   System.Console.WriteLine("Quantidade linhas do arquivo");

   foreach(string linha in linhasArquivo){
   System.Console.WriteLine(linha);
   }
}
   else{
      System.Console.WriteLine("Nao foi possível ler o arquivo");
   }*/

   Pessoa p1 = new Pessoa("Yuri","Silva");

   (string nome, string sobrenome) = p1; // um densconstrutor é parecido com uma tupla, separando em variáveis separáveis.


   System.Console.WriteLine($"{nome}{sobrenome}");