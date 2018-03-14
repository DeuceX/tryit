using System.Collections.Generic;
using BLL.Services.Interfaces;
using Domain.Card;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CardSetController : Controller
    {
        private ICardSetService cardSetService;

        public CardSetController(ICardSetService csService)
        {
            cardSetService = csService;
        }

        [HttpGet("[action]")]
        public IEnumerable<CardSet> GetAll()
        {
            return cardSetService.GetAll();
        }

        [HttpGet("[action]/{id}")]
        public CardSet Get(int id)
        {
            return cardSetService.GetById(id);
        }
    }
}
