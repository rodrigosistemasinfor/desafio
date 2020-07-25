using DesafioApp.Application.Service;
using DesafioApp.Domain;
using DesafioApp.Domain.Repository;
using DesafioApp.Domain.Seletores;
using DesafioApp.Domain.Service;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DesafioApp.Test.Desafio
{
    public class DesafioServiceTest
    {
    //    private readonly IDesafioService _desafioService;
    //    private readonly IUsuarioService _equipeService;
    //    private readonly IUsuarioRepository _equipeRepository;

    //    public DesafioServiceTest()
    //    {
    //        _equipeRepository = new EquipeRepositotyFake();
    //        _equipeService = new UsuarioService(_equipeRepository);
    //        _desafioService = new DesafioService(_equipeService);
    //    }

    //    [Fact]
    //    public void Post_processar()
    //    {
    //        var list = _equipeRepository.GetList(new UsuarioSeletor()).Take(8);
    //        var result = _desafioService.ProcessarDesafio(list);
    //        var resultOk = new List<string>() {"Equipe 2", "Equipe 13"};

    //        Assert.Equal(result.Select(x=> x.Nome), resultOk);
    //    }
  }
}
