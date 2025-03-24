using barbearia.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace barbearia.Data
{
    public class BarberShopContext : DbContext
    {
        public BarberShopContext(DbContextOptions<BarberShopContext> options) : base(options) { }

        public DbSet<AgendamentoModel> Agendamentos { get; set; }
    }
}

//O que é?
//É a classe que gerencia o acesso ao banco de dados usando Entity Framework Core. 
//    O DbSet<Agendamento> representa a tabela de agendamentos no banco.

//Como funciona?
//Quando chamamos métodos como AddAsync ou FindAsync no repositório, o BarberShopContext traduz essas
//operações para comandos SQL e executa no banco.