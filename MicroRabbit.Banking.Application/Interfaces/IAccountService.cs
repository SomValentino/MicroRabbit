﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccounts();

        Task TransferFunds(AccountTransferModel accountTransferModel);
    }
}
