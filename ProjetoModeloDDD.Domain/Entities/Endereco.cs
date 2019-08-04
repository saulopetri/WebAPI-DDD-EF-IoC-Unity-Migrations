using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
