using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using nombremicroservicio.API.Controllers;
using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using nombremicroservicio.Test.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace nombremicroservicio.Test.Test
{
    public class ClientesControllerTest
    {
        #region GetAll

        [Fact]
        public void GetAll_OnSuccess_ListOfClients()
        {
            //Arrange
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(ClientesDummyData.Clientes);
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.GetAll();
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.GetAll();
            objResult.Value.Should().BeOfType<List<ClienteModel>>();
        }

        [Fact]
        public void GetAll_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(new List<ClienteModel>());
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.GetAll();
            //Assert
            result.Should().BeOfType<NotFoundObjectResult>();
            var objResult = (NotFoundObjectResult)result;
            objResult.StatusCode.Should().Be(404);


        }
        #endregion

        #region Get
        [Fact]
        public void Get_OnSuccess_ClientModel()
        {
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(ClientesDummyData.Cliente);
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.Get(1);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Get(1);
            objResult.Value.Should().BeOfType<ClienteModel>();
        }

        [Fact]
        public void Get_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(new ClienteModel());
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.Get(1);
            //Assert
            result.Should().BeOfType<NotFoundObjectResult>();
            var objResult = (NotFoundObjectResult)result;
            objResult.StatusCode.Should().Be(404);
        }
        #endregion

        #region Post
        [Fact]
        public void Post_OnSucces_ClienteModel()
        {
            //Arrange
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.Post(ClientesDummyData.Cliente))
                .Returns(ClientesDummyData.Cliente);
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.Post(ClientesDummyData.Cliente);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Post(ClientesDummyData.Cliente);
            objResult.Value.Should().BeOfType<ClienteModel>();
        }

        [Fact]
        public void Post_OnError_ErrorCodeConflict409()
        {
            //Arrange
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.Post(ClientesDummyData.Cliente))
                .Returns(new ClienteModel());
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.Post(ClientesDummyData.Cliente);
            //Assert
            result.Should().BeOfType<ConflictObjectResult>();
            var objResult = (ConflictObjectResult)result;
            objResult.StatusCode.Should().Be(409);
        }
        #endregion

        #region Put
        [Fact]
        public void Put_OnSucces_ClienteModel()
        {
            //Arrange
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.Put(1,ClientesDummyData.Cliente))
                .Returns(true);
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.Put(1,ClientesDummyData.Cliente);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Put(1,ClientesDummyData.Cliente);
            objResult.Value.Should().BeOfType<bool>();
        }

        [Fact]
        public void Put_OnError_Bool()
        {
            //Arrange
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.Put(1,ClientesDummyData.Cliente))
                .Returns(false);
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.Put(1,ClientesDummyData.Cliente);
            //Assert
            result.Should().BeOfType<NotFoundObjectResult>();
            var objResult = (NotFoundObjectResult)result;
            objResult.StatusCode.Should().Be(404);
        }
        #endregion

        #region Delete
        [Fact]
        public void Delete_OnSucces_Bool()
        {
            //Arrange
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(true);
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.Delete(1);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)result;
            objResult.Value.Should().BeOfType<bool>();
        }

        [Fact]
        public void Delete_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IClientesService>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(false);
            var ObjController = new ClientesController(mockService.Object);
            //Act
            var result = ObjController.Delete(1);
            //Assert
            result.Should().BeOfType<NotFoundObjectResult>();
            var objResult = (NotFoundObjectResult)result;
            objResult.StatusCode.Should().Be(404);
        }
        #endregion
    }
}
