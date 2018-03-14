using System.Collections.Generic;
using BLL.Dto;
using Microsoft.AspNetCore.Mvc;
using BLL.Services.Interfaces;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CardApiController : Controller
    {
        private ICardService cardService;
        private IHttpContextAccessor _userContext;

        public CardApiController(ICardService cardService,
            IHttpContextAccessor userContext)
        {
            this.cardService = cardService;
            _userContext = userContext;
        }

        [HttpGet("[action]")]
        public IEnumerable<CardDto> GetAll()
        {
            return cardService.GetAll();
        }

        [HttpGet("[action]/{id}")]
        public CardDto Get(int id)
        {
            return cardService.GetById(id);
        }
    }
}
