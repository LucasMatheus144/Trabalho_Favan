using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace PetcoApp.Models{

    public class Tipo{

        public int Id{get;set;}

        [Display(Name ="Tipo")]
        public string Nome{get;set;}

        public virtual List<Pets> Pets {get;set;}
    }
}