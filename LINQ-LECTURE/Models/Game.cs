using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GamerLinqDemoApp.Models
{
    public class Game

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameId { get; set; }

        public string Name { get; set; }

        public GameSystem GameSystem { get; set; }

        public virtual ICollection<Character> Characters { get; set; } = new List<Character>();

        public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}