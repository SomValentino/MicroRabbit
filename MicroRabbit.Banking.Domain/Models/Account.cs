using System;
using MicroRabbit.Banking.Domain.Enums;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public AccountType AccountType { get; set; }
        public Decimal AccountBalance { get; set; }
    }
}
