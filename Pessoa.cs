using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propreiedades
{
    internal class Pessoa
    {
        //o private vai progetger a propriedade nome
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;

        }

        private string _nome;
        private int _idade;
        private string _sobrenome;

        // abaixo esta a propriedade Nome da classe pessoa
        public string Nome
        {
            get
            {//Upper deixar a letra maiscula
                return _nome.ToUpper();
            }
            set
            {//validaco de propriedades, tratamentos de erros
                if (value == "")
                {//essa verificacao torna obrigatorio um valor na propriedade nome;
                    throw new ArgumentException("o nome nao pode estar vazio");
                }
                //retorna o valor
                _nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {//Upper deixar a letra maiscula
                return _nome.ToUpper();
            }
            set
            {//validaco de propriedades, tratamentos de erros
                if (value == "")
                {//essa verificacao torna obrigatorio um valor na propriedade nome;
                    throw new ArgumentException("o sobrenome nao pode estar vazio");
                }
                //retorna o valor
                _sobrenome = value;
            }
        }
        public int Idade { get => _idade;
            set { 
            if(value < 0)
                {
                    throw new ArgumentException("idade nao pode ser menor que zero");
                }
            _idade = value;
            } 
        }
        //nomecompleto e uma propriedade de somente leitura, so pode ser lida;
        public string NomeCompleto{ get => $"{_nome} {_sobrenome}".ToUpper(); }
        public void Apresentar()
        {
            Console.WriteLine($"Prazer meu nome e {NomeCompleto} e tenho {Idade} anos de idade");
        }
    }
}
