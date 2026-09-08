using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieParty.Models
{
    public class Zombie
    {
        public int Id { get; set; }
        [StringLength(20,MinimumLength = 5,ErrorMessage ="Le {0} doit etre entre {2} et {1}.")]
        public string Name { get; set; }

        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [Display(Name = "Zombie Type")]
        [ForeignKey("ZombieType")]
        public int ZombieTypeId { get; set; }
        public ZombieType ZombieType { get; set; }

        [Range(1,10,ErrorMessage ="Les {0} doit etre entre {1} et {2}.")]
        public int Point { get; set; }
        [MaxLength(255,ErrorMessage ="{Le {0} ne peut pas depasser {1}.")]
        public string ShortDesc { get; set; }
    }
}
