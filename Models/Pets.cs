using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PetcoApp.Models{

    public class Pets{
        public int Id {get; set;}

        [Display(Name="Nome do Animal")]
        public string apelido_Animal{get; set;}

        public int tipoId{get;set;}
        
        public string tipo {get;set;}

        [Display(Name="Serviço")]
        public string servico{get;set;}

        [DataType(DataType.Date)]
        public DateTime dia_chegada {get; set;}

        public virtual Tipo Tipo {get;set;}
    }
}