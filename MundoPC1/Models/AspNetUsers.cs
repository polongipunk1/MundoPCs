using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundoPC1.Models
{
    public class AspNetUsers
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public byte EmailConfirmed{ get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public byte PhoneNumberConfirmed { get; set; }
        public byte TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDateUtc { get; set; }
        public byte LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string Region { get; set; }
        public string CP { get; set; }
        public string Telefono { get; set; }
    }
}