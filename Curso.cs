using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propreiedades
{
    internal class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Aluno{ get; set; }
        public void AdcionarAluno(Pessoa aluno)
        {
            Aluno.Add(aluno);

        }
        public int obterQyuantidadedeAlunosMatriculados()
        {
            int quantidade = Aluno.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Aluno.Remove(aluno);

        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Lista de alunos {Nome}");
            foreach(Pessoa aluno in Aluno)
            {

                Console.WriteLine(aluno.NomeCompleto);
            }
        }

    }
}
