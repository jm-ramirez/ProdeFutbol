﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdeFutbol.Web.Data;
using ProdeFutbol.Web.Data.Entities;
using ProdeFutbol.Web.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProdeFutbol.Web.Controllers.API
{
    [ApiController]
    [Route("api/[controller]")]

    public class TournamentsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConverterHelper _converterHelper;

        public TournamentsController(DataContext context, IConverterHelper converterHelper)
        {
            _context = context;
            _converterHelper = converterHelper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTournaments()
        {
            List<TournamentEntity> tournaments = await _context.Tournaments
                .Include(t => t.Groups)
                .ThenInclude(g => g.GroupDetails)
                .ThenInclude(gd => gd.Team)
                .Include(t => t.Groups)
                .ThenInclude(g => g.Matches)
                .ThenInclude(m => m.Local)
                .Include(t => t.Groups)
                .ThenInclude(g => g.Matches)
                .ThenInclude(m => m.Visitor)
                .ToListAsync();
            return Ok(_converterHelper.ToTournamentResponse(tournaments));

        }

    }
}
