using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kasino.Domain.Entities
{
    [Table("Bet")]
    public class Bet
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        [Required]
        public int UserId { get; set; }

        [Required]
        public string BetNumbers { get; set; }

        [Required]
        public int BetAmount { get; set; }

        [Required]
        public BetStatus Status { get; set; }


        public DateTime BetDate { get; set; }

    }

    public enum BetStatus
    {
        Pending,     
        Won,        
        Lost        
    }
}
