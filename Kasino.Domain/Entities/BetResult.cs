using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kasino.Domain.Entities
{
    [Table("BetResult")]
    public class BetResult
    {
        [Key]
        [Required]
        public int Id {  get; set; }

        [ForeignKey(nameof(Bet))]
        [Required]
        public int BetId { get; set; }

        [Required]
        public string WinningNumbers { get; set; }

        public int WinningAmount { get; set; }

        public DateTime ResultsDate { get; set; }
    }
}
