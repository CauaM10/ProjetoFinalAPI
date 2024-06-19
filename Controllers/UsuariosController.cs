using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosRepositorio _usersRepositorio;

        public UsuariosController(IUsuariosRepositorio usersRepositorio)
        {
            _usersRepositorio = usersRepositorio;
        }

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<List<UsuariosModel>>> GetAllUsers()
        {
            List<UsuariosModel> users = await _usersRepositorio.GetAll();
            return Ok(users);
        }

        [HttpGet("GetUserId/{id}")]
        public async Task<ActionResult<UsuariosModel>> GetUserId(int id)
        {
            UsuariosModel usuario = await _usersRepositorio.GetById(id);
            return Ok(usuario);
        }

        [HttpGet("Login/{email}/{senha}")]
        public async Task<ActionResult<UsuariosModel>> Login(string senha, string email)
        {
            UsuariosModel usuario = await _usersRepositorio.Login(senha,email);
            return Ok(usuario);
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<UsuariosModel>> InsertUser([FromBody] UsuariosModel userModel)
        {
            UsuariosModel user = await _usersRepositorio.InsertUser(userModel);
            return Ok(user);
        }

        [HttpPut("UpdateUser/{id:int}")]
        public async Task<ActionResult<UsuariosModel>> UpdateUser(int id, [FromBody] UsuariosModel userModel)
        {
            userModel.UsuarioId = id;
            UsuariosModel user = await _usersRepositorio.UpdateUser(userModel, id);
            return Ok(user);
        }

        [HttpDelete("DeleteUser/{id:int}")]
        public async Task<ActionResult<UsuariosModel>> DeleteUser(int id)
        {

            bool deleted = await _usersRepositorio.DeleteUser(id);
            return Ok(deleted);
        }
    }
}