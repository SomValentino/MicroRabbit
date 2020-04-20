using System;
using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransferModel
    {
        /// <summary>
        /// Source account
        /// </summary>
        [Required]
        public int ToAccount { get; set; }
        /// <summary>
        /// Destination account
        /// </summary>
        [Required]
        public int FromAccount { get; set; }
        /// <summary>
        /// Amount to Transfer
        /// </summary>
        [Required]
        public decimal TransferAmount { get; set; }
    }
}
