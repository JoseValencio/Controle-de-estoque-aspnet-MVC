
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_de_estoque_MVC.Models
{
    
    public class ProdutoModel
    {
       
        
        
        public int Id { get; set; }

       
        public string Produto { get; set; }

        public string Serial { get; set; }

     
    }
}
