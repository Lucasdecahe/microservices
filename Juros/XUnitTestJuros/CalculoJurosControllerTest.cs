using Juros.Calculo.Common;
using Juros.Calculo.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace Juros.Calculo.Test
{
    public class CalculoJurosControllerTest
    {
        CalculaJurosController _controller;
        IRepository _repository;

        public  CalculoJurosControllerTest()
        {
            _repository = new Repository();
            _controller = new CalculaJurosController(_repository);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetAsync(100, 5);
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
    }
}
