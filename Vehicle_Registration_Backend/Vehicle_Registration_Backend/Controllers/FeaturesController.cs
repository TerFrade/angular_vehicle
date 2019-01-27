using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vehicle_Registration_Backend.Controllers.Resources;
using Vehicle_Registration_Backend.Models;

namespace Vehicle_Registration_Backend.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VehicleRegistrationContext _context;
        private readonly IMapper mapper;
        public FeaturesController(VehicleRegistrationContext _context, IMapper mapper)
        {
            this.mapper = mapper;
            this._context = _context;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await _context.Feature.ToListAsync();

            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}
