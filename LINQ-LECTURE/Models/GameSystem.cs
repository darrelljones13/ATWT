using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerLinqDemoApp.Models
{
    public class GameSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string SystemName { get; set; }

        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
    }
}