using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Models
{
    public class ExemploExcecao
    {

        public void Metodo1(){
        Metodo2();
    }

    public void Metodo2(){
        Metodo3();
    }

    public void Metodo3(){

        try{
        Metodo4();
        } catch(Exception ex){
            System.Console.WriteLine("Excecao Tratada"+ex.StackTrace);// rastro da stack
        }
    }

    public void Metodo4(){
        throw new Exception("Ocorreu uma exceção"); // throw é jogando a exceção para cima, para alguém tratar.
    }

        
    }

    
}