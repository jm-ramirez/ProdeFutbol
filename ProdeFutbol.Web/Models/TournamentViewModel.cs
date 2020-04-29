using Microsoft.AspNetCore.Http;
using ProdeFutbol.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace ProdeFutbol.Web.Models
{
    public class TournamentViewModel : TournamentEntity
    {
        [Display(Name = "Logo")]
        public IFormFile LogoFile { get; set; }
    }
}
