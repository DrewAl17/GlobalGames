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
            var user = await this.userHelper.GetUserByEmailAsync("zeeber85hd@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Andre",
                    LastName = "Lajas",
                    Email = "zeeber85hd@gmail.com",
                    UserName = "zeeber85hd@gmail.com",
                };

                var result = await this.userHelper.AddUserAsync(user,"123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }
            if (!this.context.Inscricoes.Any())
            {
                this.AddInscricoes("Alberto",user);
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
