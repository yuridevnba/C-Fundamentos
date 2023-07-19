using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Models
{
    public class Curso
    {
        public string Nome{ get; set;}

        public List<Pessoa> Alunos { get; set;}

        public void AdicionarAluno( Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunosMatriculados(){
             int quant = Alunos.Count;

             return quant;
        }

        public bool RemoverAluno(Pessoa aluno){
            Alunos.Remove(aluno);
            return true;
        }

        public void ListarAlunos(){
            System.Console.WriteLine($"Alunos do curso de:{Nome}");
            foreach (Pessoa aluno in Alunos){
                System.Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}