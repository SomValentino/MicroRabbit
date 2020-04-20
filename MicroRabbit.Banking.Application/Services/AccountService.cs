using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _accountRepository.GetAccounts();
        }

        public async Task TransferFunds(AccountTransferModel accountTransferModel)
        {
            var createTransferCommand = new CreateTransferCommand(accountTransferModel.ToAccount,
                accountTransferModel.FromAccount, accountTransferModel.TransferAmount);

            await _bus.SendCommand(createTransferCommand);
        }
    }
}
