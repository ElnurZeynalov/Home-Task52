using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class Actor
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhotoUrl { get; set; }
    }
}
