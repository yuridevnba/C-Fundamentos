using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Models
{
    public class LeituraArquivo
    {
       public (bool Sucesso, string [] Linhas, int QuantidadeLinhas) LerArquivo(string caminho) { // quero retornar 3 tipos de dados, dessa forma é preciso usar as tuplas.

       try{
        string [] linhas = File.ReadAllLines(caminho);
        return(true, linhas, linhas.Count());

        }catch(Exception ){
            return (false , new string [0], 0);
        }

       }
    }
}