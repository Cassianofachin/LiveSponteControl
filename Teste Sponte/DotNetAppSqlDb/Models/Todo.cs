using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{
    public class Todo
    {
       

        public int ID { get; set; }
        public string Description { get; set; }

        public string Nome_instrutor { get; set; }
        public string Email_instrutor { get; set; }
        public string Nome_espectador { get; set; }
        public string Email_espectador { get; set; }
        public string End_instagram { get; set; }
        public string Nome_live { get; set; }
        public string Desc_live { get; set; }
        public string Instrutor_live { get; set; }
        public int Tempo_live { get; set; }
        public decimal Valor_live { get; set; }

        public bool Pago { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
     

    }
}