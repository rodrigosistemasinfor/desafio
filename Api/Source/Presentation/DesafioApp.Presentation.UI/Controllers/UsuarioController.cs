﻿using DesafioApp.Domain;
using DesafioApp.Domain.Seletores;
using DesafioApp.Domain.Service;
using DesafioApp.Presentation.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;

namespace DesafioApp.Presentation.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UsuarioDomain), 200)]
        public ActionResult<UsuarioDomain> Get(int id)
        {
            var user = _service.GetById(id);

            if (user == null)
                return NotFound();

            return user;
        }

        [HttpPost("list")]
        [ProducesResponseType(typeof(IEnumerable<UsuarioDomain>), 200)]
        public ActionResult List([FromBody] UsuarioSeletor seletor)
        {
            try
            {
                if (seletor == null)
                    throw new Exception("Filtro inválido");

                return Ok(new ResponseViewModel
                {
                    Data = _service.GetList(seletor),
                    Count = _service.Count(seletor)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(UsuarioDomain), 200)]
        public ActionResult Insert([FromBody] UsuarioDomain domain)
        {
            try
            {
              return StatusCode((int)HttpStatusCode.Created, _service.Insert(domain));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("delete")]
        public ActionResult Delete([FromBody] UsuarioSeletor seletor)
        {
            try
            {
                _service.Delete(seletor);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
