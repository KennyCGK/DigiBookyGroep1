﻿using System;
using System.Collections.Generic;
using System.Text;
using Digibooky_api.Controllers;
using Digibooky_api.DTO;
using Digibooky_api.Helper;
using Digibooky_services.Books;
using NSubstitute;
using Xunit;

namespace DigiBooky_api_UnitTests
{
    public class BookControllerTest
    {
        [Fact]
        public void GivenBookController_WhenAskListofBooks_ThenShouldEnterMethodInService()
        {
            IBookService bookService = Substitute.For<IBookService>();
            IBookMapper bookMapper = Substitute.For<IBookMapper>();

            BookController bookSut = new BookController(bookService, bookMapper);

            bookSut.GetAllBooks();
            bookService.Received().GetAllBooks();

        }

        [Fact]
        public void GivenBookController_WhenShowDetailsOFBook_ThenShouldEnterMEthodOInService()
        {
            IBookService bookService = Substitute.For<IBookService>();
            IBookMapper bookMapper = Substitute.For<IBookMapper>();
            BookController bookController = new BookController(bookService, bookMapper);
            BookDTO testBook = new BookDTO();


            bookController.ShowDetailsOfBook(1);

            bookService.Received().ShowDetailsOfBook(1);
        }
    }
}
