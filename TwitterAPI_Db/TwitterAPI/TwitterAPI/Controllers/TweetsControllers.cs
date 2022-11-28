using Microsoft.AspNetCore.Mvc;
using TwitterAPI.Datos;
using TwitterAPI.Models;

namespace TwitterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsControllers : ControllerBase
    {
        private ApplicationDbContext _context;

        public TweetsControllers(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Tweets>> Get()
        {
            return Ok(_context.Tweets.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var tweet = _context.Tweets.Where(x => x.ID_Usuario == id).ToList();
            if (tweet == null)
            {
                return NotFound();
            }
            return Ok(tweet);
        }
        [HttpPost]
        public IActionResult Post(Tweets tweet)
        {
            var twit = _context.Tweets.Where(x => x.ID == tweet.ID).ToList();
            if(twit != null)
            {
                return NotFound();
            }
            _context.Tweets.Add(tweet);
            return Ok(tweet);
        }
    }
}