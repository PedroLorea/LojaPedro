using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaPedro.Domain.Validacao
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string erro) : base(erro)
        { }

        public static void Quando(bool temErro, string erro)
        {
            if (temErro)
                throw new DomainExceptionValidation(erro);
        }
    }
}
