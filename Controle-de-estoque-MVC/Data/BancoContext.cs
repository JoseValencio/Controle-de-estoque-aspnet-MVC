using Controle_de_estoque_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controle_de_estoque_MVC.Data
{
    public class BancoContext : DbContext
    {
        public  DbSet<ProdutoModel> Produtos { get; set; }
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

       
     

       
    }
}
