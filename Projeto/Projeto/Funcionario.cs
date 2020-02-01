using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Funcionario
    {
        public int id{ get; set; }
        public String nome { get; set; }
        public String cpf { get; set; }
        public DateTime dt_nascimento { get; set; }
        public String sexo { get; set; }
        public String estado_civil { get; set; }
        public String endereço { get; set; }
        public DateTime dt_admissao { get; set; }
        public int id_setor { get; set; }
    }
}
