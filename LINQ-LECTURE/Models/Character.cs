using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace GamerLinqDemoApp.Models
{
    public class Character
    {
    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsHuman { get; set; }

        public DateTime Birthday { get; set; }

        public int GameId { get; set; }
        public virtual Game Game { get; set; }

    }
}