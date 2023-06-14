using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PetcoApp.Models{
    public class Cadastro{
        public int Id{get;set;}

        public string login{get;set;}

        public string senha{get;set;}

    }
}