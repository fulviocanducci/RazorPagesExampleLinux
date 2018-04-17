using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("People")]
    public class People
    {   
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;} 

        [Required(ErrorMessage = "Digite o nome")]
        public string Name {get;set;}
        public People()
        {
            
        }
    }
}
