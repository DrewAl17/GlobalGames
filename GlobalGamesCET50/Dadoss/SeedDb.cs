using GlobalGamesCET50.Dadoss.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.Dadoss
{
    public class SeedDb
    {
        private readonly DataContext context;

        private Random random;


        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }
        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();
            if (!this.context.Inscricoes.Any())
            {
                this.AddInscricoes("André Lajas");
                this.AddInscricoes("Rogerio");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddInscricoes(string name)
        {
            this.context.Inscricoes.Add(new Inscricoes
            {
                Nome = name,
                Apelido = name,
                CC = this.random.Next(30000000),
            });
        }
    }
}
