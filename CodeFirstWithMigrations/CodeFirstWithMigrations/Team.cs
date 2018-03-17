using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstWithMigrations
{
    class Team
    {
        public Team()
        {
            Players = new List<Player>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Coath { get; set; }
        public string Country { get; set; }
       
        public virtual ICollection<Player> Players { get; set; }
        public virtual  ICollection<Partner> Partners { get; set; }
    }
}
