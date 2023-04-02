using Controle_de_estoque_MVC.Models;

namespace Controle_de_estoque_MVC.Repositorio
{
    public interface IProdutoRepositorio
    {
        ProdutoModel ListarPorId(int id);
        List<ProdutoModel> BuscarTodos();
        ProdutoModel Adicionar(ProdutoModel produto);

        ProdutoModel Atualizar(ProdutoModel produto);

        bool Apagar(int id);
    }
}
