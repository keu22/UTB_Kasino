using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kasino.Domain.Entities
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        [Required]
        public int UserId { get; set; }

        [Required]
        public int Money { get; set; }

        [Required]
        public bool Status { get; set; } // 1 = uspěšný, 0 = neuspěšný

        public TransactionType Type { get; set; }

        public DateTime Date {  get; set; }

    }

    public enum TransactionType
    {
        Deposit = 0,
        Withdraw = 1,
    }
}
