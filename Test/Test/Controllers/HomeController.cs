using LibraryExtension.Application.Interfaces;
using LibraryExtension.Domain.Entities;
using LibraryExtension.Domain.Enums;
using LibraryExtension.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test.Models;

namespace Test.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReaderService _readerService;
        private readonly ITransactionService _transactionService;
        private readonly IBookService _bookService;
        public HomeController(ILogger<HomeController> logger, IReaderService readerService, ITransactionService transactionService, IBookService bookService)
        {
            _logger = logger;
            _readerService = readerService;
            _transactionService = transactionService;
            _bookService = bookService;
        }

        [HttpPost]
        public async Task<IActionResult> AddReader(Reader reader)
        {
            var reader2 = await _readerService.AddReader(reader);
            return Ok(reader2);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(Book book)
        {
            await _bookService.AddBook(book);
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> BorrowBook(int bookId, int readerId, int rentalDays)
        {
            await _transactionService.BorrowBook(bookId, readerId, rentalDays);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> ReturnBook(int transactionId)
        {
            await _transactionService.ReturnBook(transactionId);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(int readerId)
        {
            return Ok(await _readerService.CalculateFine(readerId));
        }

        [HttpPut]
        public async Task<IActionResult> Promote(int readerId, ReaderTypeEnum readerType)
        {
            return Ok(await _readerService.Promote(readerId, readerType));
        }
    }
}