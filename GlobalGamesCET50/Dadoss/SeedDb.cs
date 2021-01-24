using GlobalGamesCET50.Dadoss.Entidades;
using GlobalGamesCET50.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.Dadoss
{
    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;


        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }
        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();
            var user = await this.userHelper.GetUserByEmailAsync("andre.lajas@hotmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "André",
                    LastName = "Lajas",
                    Email = "andre.lajas@hotmail.com",
                    UserName = "DrewAl17",
                };

                var result = await this.userHelper.AddUserAsync(user, "123321");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }
            if (!this.context.Inscricoes.Any())
            {
                this.AddInscricoes("André Lajas",user);
                this.AddInscricoes("Rogerio",user);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddInscricoes(string name, User user)
        {
            this.context.Inscricoes.Add(new Inscricoes
            {
                Nome = name,
                Apelido = name,
                CC = this.random.Next(30000000),
                User = user
            });
        }
    }
}
