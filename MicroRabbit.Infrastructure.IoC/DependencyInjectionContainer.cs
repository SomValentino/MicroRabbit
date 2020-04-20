using System;
using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infrastructure.IoC
{
    public static class DependencyInjectionContainer
    {
        public static void RegisterRabbitMQEventBus(this IServiceCollection services)
        {
            //Event bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
        public static void RegisterBankingServices(this IServiceCollection services)
        {
            //Application services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
        public static void RegisterBankingCommands(this IServiceCollection services)
        {
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
        }
    }
}
