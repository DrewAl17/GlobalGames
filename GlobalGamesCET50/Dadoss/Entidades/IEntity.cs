using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.Dadoss.Entidades
{
    public interface IEntity
    {
        int Id  { get; set; }

        string Nome { get; set; }
    }
}
