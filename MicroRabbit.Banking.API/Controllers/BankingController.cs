using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroRabbit.Banking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        /// <summary>
        /// Get All Accounts
        /// </summary>
        /// <returns>List of Accounts</returns>
        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            return Ok(await _accountService.GetAccounts());
        }

        /// <summary>
        /// Transfers funds from one account to the other
        /// </summary>
        /// <param name="accountTransferModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> TransferFunds(AccountTransferModel accountTransferModel)
        {
            await _accountService.TransferFunds(accountTransferModel);
            return Ok(accountTransferModel);
        }
    }
}
