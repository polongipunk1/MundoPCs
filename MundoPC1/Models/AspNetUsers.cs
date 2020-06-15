using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MundoPC1.Models
{
    public class AspNetUsers
    {        
        public string Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public int AccessFailedCount { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Colonia { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string CP { get; set; }
        [Required]
        public string Telefono { get; set; }
    }
}