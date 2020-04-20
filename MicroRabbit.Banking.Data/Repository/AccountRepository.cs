using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _bankingDbContext;

        public AccountRepository(BankingDbContext bankingDbContext)
        {
            _bankingDbContext = bankingDbContext;
        }
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await Task.FromResult(_bankingDbContext.Accounts);
        }
    }
}
