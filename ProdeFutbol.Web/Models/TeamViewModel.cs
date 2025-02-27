﻿using Microsoft.AspNetCore.Http;
using ProdeFutbol.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProdeFutbol.Web.Models
{
    public class TeamViewModel : TeamEntity
    {
        [Display(Name = "Logo")]
        public IFormFile LogoFile { get; set; }

    }
}
