using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudoAPI.Models
{
    public class Costumer
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }

        public Costumer(String nome, String email) {
            this.Id = 0;
            this.Nome = nome;
            this.Email = email;
        }
    }
}