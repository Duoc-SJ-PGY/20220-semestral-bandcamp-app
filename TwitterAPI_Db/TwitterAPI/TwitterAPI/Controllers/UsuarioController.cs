using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterAPI.Datos;
using TwitterAPI.Models;

namespace TwitterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private ApplicationDbContext _context;
        
        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return _context.Usuario.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
            var usuario = _context.Usuario.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            return usuario;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            if (usuario.Nick == "" || usuario.Password == "")
            {
                return BadRequest();
            }
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return Ok();

        }
        [HttpPost("login")]
        public ActionResult Login(string nick, string pass)
        {
            var usuario = _context.Usuario.FirstOrDefault(x => x.Nick == nick && x.Password == pass);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
            
        }
        

    }
}
