using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        public Task<IEnumerable<TransferLog>> GetTransferLogs();
    }
}
