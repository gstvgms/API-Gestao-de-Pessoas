using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModels.Comands
{
    public class RegistrarPessoaDTO
    {
        public class Requisito
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
        }

        public class Resultado
        {
            public GerenciamentoPessoas Pessoa { get; set; }
            public Resultado(GerenciamentoPessoas pessoa)
            {
                Pessoa = pessoa;
            }
            
        }
    }
}
