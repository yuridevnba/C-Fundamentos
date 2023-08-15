
using C__DIO.Models;

 Dictionary<string,string> estados = new Dictionary<string, string>();

 estados.Add("SP","São Paulo");
 estados.Add("BA","Bahia");

 foreach(/*KeyValuePair<string,string>*/ var item in estados){

System.Console.WriteLine($"Chave:{item.Key}, Valor:{item.Value}");

 }
 estados.Add("BA2","Bahia"); // a chave não pode ser repetida, mas o valor pode.

 estados.Remove("BA");

 estados["SP"] = "Sao Paulo - valor alterado";

 string chave = "BA";

 if(estados.ContainsKey(chave)){
    System.Console.WriteLine("Valor existente"+chave);
    System.Console.WriteLine(estados["BA"]); // obtendo o valor.
 }
 else{
    System.Console.WriteLine("Valor não existente");
 }