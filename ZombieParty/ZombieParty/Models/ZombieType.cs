using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Type Name")]
        [StringLength(10,MinimumLength =5,ErrorMessage ="Le {0} doit etre entre {2} et {1}.")]
        public string TypeName { get; set; }
        [Range(2,5,ErrorMessage ="Les {0} doit etre entre {1} et {2}.")]
        public string Point { get; set; }

        [ValidateNever]
        public List<Zombie> Zombies { get; set; }
    }
}
