using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;

        public TransferRepository(TransferDbContext transferDbContext)
        {
            _context = transferDbContext;
        }

        public async Task<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return await _context.TransferLogs.ToListAsync();
        }
    }
}
