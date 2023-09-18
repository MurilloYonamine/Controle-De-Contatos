using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        ContatoModel Adicionar(ContatoModel contato);
        List<ContatoModel> BuscarTodos(int id);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
