using Controle_de_estoque_MVC.Models;
using Controle_de_estoque_MVC.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_estoque_MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio )
        {
            _produtoRepositorio = produtoRepositorio;
        }
        public IActionResult Index()
        {
           List<ProdutoModel> produtos = _produtoRepositorio.BuscarTodos();    
            return View(produtos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
           ProdutoModel produto = _produtoRepositorio.ListarPorId(id);    
            return View(produto);
        }

        public IActionResult ApagarConfirmacao(int Id)
        {
            
            ProdutoModel produto = _produtoRepositorio.ListarPorId(Id);
            return View(produto);
        }
        public IActionResult Apagar(int id)
        {
            _produtoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ProdutoModel _produto)
        {
          

            _produtoRepositorio.Adicionar(_produto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(ProdutoModel _produto)
        {


            _produtoRepositorio.Atualizar(_produto);
            return RedirectToAction("Index");
        }

    }
}
