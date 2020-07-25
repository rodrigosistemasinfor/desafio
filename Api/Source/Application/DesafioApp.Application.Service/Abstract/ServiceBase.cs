using DesafioApp.Domain;
using DesafioApp.Domain.Repository.Abstract;
using DesafioApp.Domain.Seletores;
using System.Collections.Generic;

namespace DesafioApp.Application.Service.Abstract
{
    public abstract class ServiceBase<TRepository, TDomain, TSeletor>
    where TRepository : IRepositorySeletorBase<TDomain, TSeletor>
    where TDomain : DomainBase
    where TSeletor : SeletorBase
    {
        protected readonly TRepository _repository;

        public ServiceBase(TRepository repository)
        {
            _repository = repository;
        }

        public virtual void Delete(TDomain obj) 
                => _repository.Delete(obj); 

        public virtual IEnumerable<TDomain> GetList(TSeletor seletor) 
                => _repository.GetList(seletor);

        public virtual TDomain GetById(int id) 
                => _repository.GetById(id);

        public int Count(TSeletor seletor) 
                => _repository.Count(seletor);

        public virtual TDomain Insert(TDomain obj)
                => _repository.InsertWithReturningObject(obj);

        public abstract TDomain Update(TDomain domain);
    }
}
