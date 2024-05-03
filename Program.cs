
using Propreiedades;
//fazendo assim eu substitui o codigo de baixo pelo de cima, ajuda a organizar econoizar linhas de codigo.
/*p1.Nome = "pedrinho";
p1.Sobrenome ="weber";
p1.Idade = 20;
p1.Apresentar();*/

Pessoa p1 = new Pessoa(nome:"Pedro",sobrenome:"Coelho",22);
p1.Apresentar();
Pessoa p2 = new Pessoa(nome: "machado", sobrenome: "Assis", 26);
p2.Apresentar();
Pessoa p3 = new Pessoa(nome: "Max", sobrenome: "Weber", 30);
p3.Apresentar();
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Aluno = new List<Pessoa>();
cursoDeIngles.AdcionarAluno(p1);
cursoDeIngles.AdcionarAluno(p2);
cursoDeIngles.AdcionarAluno(p3);

cursoDeIngles.ListarAlunos();