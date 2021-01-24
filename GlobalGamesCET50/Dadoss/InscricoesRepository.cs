using GlobalGamesCET50.Dadoss.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.Dadoss
{
    public class InscricoesRepository : GenericRepository<Inscricoes>, IInscricoesRepository
    {
        public InscricoesRepository(DataContext context) : base(context)
        {

        }
    }
}
