using DesafioApp.Domain.Seletores;
using System.Collections.Generic;

namespace DesafioApp.Domain.Service
{
    public interface IService<TDomain, TSeletor>
       where TDomain : DomainBase
       where TSeletor : SeletorBase
    {
        TDomain GetById(int id);
        TDomain Insert(TDomain obj);
        int Count(TSeletor seletor);
        IEnumerable<TDomain> GetList(TSeletor seletor);
        TDomain Update(TDomain solicitacaoAcompanhamentoDomain);
        void Delete(int id);
    }
}
