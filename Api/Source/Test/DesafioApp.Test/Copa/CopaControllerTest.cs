using DesafioApp.Application.Service;
using DesafioApp.Domain.Repository;
using DesafioApp.Domain.Seletores;
using DesafioApp.Domain.Service;
using DesafioApp.Presentation.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Xunit;

namespace DesafioApp.Test.Desafio
{
    public class DesafioControllerTest
    {
        //private readonly DesafioController _controller;
        //private readonly IDesafioService _desafioService;
        //private readonly IUsuarioService _equipeService;
        //private readonly IUsuarioRepository _equipeRepository;

        //public DesafioControllerTest()
        //{
        //    _equipeRepository = new EquipeRepositotyFake();
        //    _equipeService = new UsuarioService(_equipeRepository);
        //    _desafioService = new DesafioService(_equipeService);
        //    _controller = new DesafioController(_desafioService);
        //}

        //[Fact]
        //public void Post_processar()
        //{
        //    var list = _equipeRepository.GetList(new UsuarioSeletor()).Take(8);
        //    var okResult = _controller.Processar(list);
           
        //    Assert.IsType<OkObjectResult>(okResult);
        //}
    }
}
