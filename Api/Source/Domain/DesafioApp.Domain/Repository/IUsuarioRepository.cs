using DesafioApp.Domain.Repository.Abstract;
using DesafioApp.Domain.Seletores;
using System.Collections.Generic;

namespace DesafioApp.Domain.Repository
{
    public interface IUsuarioRepository : IRepositorySeletorBase<UsuarioDomain, UsuarioSeletor>
    {
        IEnumerable<UsuarioDomain> GetListDelete(UsuarioSeletor usuario);
    }
}
