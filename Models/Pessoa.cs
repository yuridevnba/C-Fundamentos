using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Models
{

   
    public class Pessoa
    {
        
        public Pessoa(){
            
        }
        public Pessoa(string nome, string sobrenome){

        }


         private string _nome;  // campo
        public string Nome // propriedade para nome, o private não pode ser usada fora do código, só a propriedade que é public.
        {
            get =>   _nome.ToUpper(); //body expressions
                 

            

            set{
                if(value == ""){
                    throw new ArgumentException(" O nomw n pode ser vazio");
                }
                _nome = value;
            }

            }

            public string Sobrenome {get;set;}

            public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade {get;set;}

        public void Apresentar(){
            System.Console.WriteLine($"{NomeCompleto},{Idade}");
        }
    }
}