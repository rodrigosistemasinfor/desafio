using DesafioApp.Domain.Seletores;

namespace DesafioApp.Domain.Service
{
    public interface IUsuarioService : IService<UsuarioDomain, UsuarioSeletor>
    {
        void Delete(UsuarioSeletor seletor);
    }
}
