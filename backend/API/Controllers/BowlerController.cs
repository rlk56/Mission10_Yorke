using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private readonly IBowlerRepository _bowlerRepository;

        public BowlerController(IBowlerRepository bowlerRepository)
        {
            _bowlerRepository = bowlerRepository;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            // Fetch all bowlers
            var bowlerData = _bowlerRepository.Bowlers;


            return bowlerData;
        }
    }
}

