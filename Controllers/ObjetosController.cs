using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetosController : ControllerBase
    {
        private readonly IObjetosRepositorio _objetosRepositorio;

        public ObjetosController(IObjetosRepositorio objetosRepositorio)
        {
            _objetosRepositorio = objetosRepositorio;
        }

        [HttpGet("GetAllObjeto")]
        public async Task<ActionResult<List<ObjetosModel>>> GetAllObjetos()
        {
            List<ObjetosModel> objetos = await _objetosRepositorio.GetAll();
            return Ok(objetos);
        }

        [HttpGet("GetObjetoId/{id}")]
        public async Task<ActionResult<ObjetosModel>> GetObjetoId(int id)
        {
            ObjetosModel objeto = await _objetosRepositorio.GetById(id);
            return Ok(objeto);
        }


        [HttpPost("CreateObjeto")]
        public async Task<ActionResult<ObjetosModel>> InsertObjeto([FromBody] ObjetosModel objetoModel)
        {
            ObjetosModel objeto = await _objetosRepositorio.InsertObjeto(objetoModel);
            return Ok(objeto);
        }

        [HttpPut("UpdateObjeto/{id:int}")]
        public async Task<ActionResult<ObjetosModel>> UpdateObjeto(int id, [FromBody] ObjetosModel objetoModel)
        {
            objetoModel.ObjetoId = id;
            ObjetosModel objeto = await _objetosRepositorio.UpdateObjeto(objetoModel, id);
            return Ok(objeto);
        }

        [HttpDelete("DeleteObjeto/{id:int}")]
        public async Task<ActionResult<ObjetosModel>> DeleteObjeto(int id)
        {

            bool deleted = await _objetosRepositorio.DeleteObjeto(id);
            return Ok(deleted);
        }
    }
}