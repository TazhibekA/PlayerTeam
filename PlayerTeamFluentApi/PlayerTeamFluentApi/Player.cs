using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayerTeamFluentApi
{
    public class Player
    {
        [Column ("Id")]
        [Required]
        [Key]
        public int Id { get; set; }
        [MinLength(3,ErrorMessage ="Minlength 3 symbols")]
        public string Name { get; set; }
        public int Number { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
