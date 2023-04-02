using Controle_de_estoque_MVC.Data;
using Controle_de_estoque_MVC.Models;

namespace Controle_de_estoque_MVC.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ProdutoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ProdutoModel ListarPorId(int id)
        {
            return _bancoContext.Produtos.FirstOrDefault(x => x.Id == id);
        }
        public List<ProdutoModel> BuscarTodos()
        {
            return _bancoContext.Produtos.ToList();
        }

        public ProdutoModel Adicionar(ProdutoModel produto)
        {
           _bancoContext.Produtos.Add(produto);
            _bancoContext.SaveChanges();

            return produto;
        }

        public ProdutoModel Atualizar(ProdutoModel produto)
        {
            ProdutoModel produtoDb = ListarPorId(produto.Id);

            if (produtoDb == null) throw new Exception("Erro ao atualizar o contato");
           
            produtoDb.Produto = produto.Produto;
            produtoDb.Serial = produto.Serial;

            _bancoContext.Produtos.Update(produtoDb);
            _bancoContext.SaveChanges();
            return produtoDb;
        }

        public bool Apagar(int id)
        {
            ProdutoModel produtoDb = ListarPorId(id);

            if (produtoDb == null) throw new Exception("Erro ao atualizar o contato");
            _bancoContext.Produtos.Remove(produtoDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
