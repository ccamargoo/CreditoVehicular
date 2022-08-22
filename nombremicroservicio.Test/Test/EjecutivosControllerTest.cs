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
    public class EjecutivosControllerTest
    {
        #region GetAll

        [Fact]
        public async Task GetAll_OnSuccess_ListOfClients()
        {
            //Arrange
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(EjecutivosDummyData.Ejecutivos);
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.GetAll();
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)await ObjController.GetAll();
            objResult.Value.Should().BeOfType<List<EjecutivoModel>>();
        }

        [Fact]
        public async Task GetAll_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(new List<EjecutivoModel>());
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.GetAll();
            //Assert
            result.Should().BeOfType<NotFoundObjectResult>();
            var objResult = (NotFoundObjectResult)result;
            objResult.StatusCode.Should().Be(404);


        }
        #endregion

        #region Get
        [Fact]
        public async Task Get_OnSuccess_ClientModel()
        {
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(EjecutivosDummyData.Ejecutivo);
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.Get(1);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)await ObjController.GetAll();
            objResult.Value.Should().BeOfType<EjecutivoModel>();
        }

        [Fact]
        public async Task Get_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(new EjecutivoModel());
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.Get(1);
            //Assert
            result.Should().BeOfType<NotFoundObjectResult>();
            var objResult = (NotFoundObjectResult)result;
            objResult.StatusCode.Should().Be(404);
        }
        #endregion

        #region Post
        [Fact]
        public async Task Post_OnSucces_ClienteModel()
        {
            //Arrange
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.Post(EjecutivosDummyData.Ejecutivo))
                .Returns(EjecutivosDummyData.Ejecutivo);
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.Post(EjecutivosDummyData.Ejecutivo);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)await ObjController.Post(EjecutivosDummyData.Ejecutivo);
            objResult.Value.Should().BeOfType<EjecutivoModel>();
        }

        [Fact]
        public async Task Post_OnError_ErrorCodeConflict409()
        {
            //Arrange
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.Post(EjecutivosDummyData.Ejecutivo))
                .Returns(new EjecutivoModel());
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.Post(EjecutivosDummyData.Ejecutivo);
            //Assert
            result.Should().BeOfType<ConflictObjectResult>();
            var objResult = (ConflictObjectResult)result;
            objResult.StatusCode.Should().Be(409);
        }
        #endregion

        #region Put
        [Fact]
        public async Task Put_OnSucces_ClienteModel()
        {
            //Arrange
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.Put(1, EjecutivosDummyData.Ejecutivo))
                .Returns(true);
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.Put(1, EjecutivosDummyData.Ejecutivo);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)await ObjController.Put(1,EjecutivosDummyData.Ejecutivo);
            objResult.Value.Should().BeOfType<bool>();
        }

        [Fact]
        public async Task Put_OnError_Bool()
        {
            //Arrange
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.Put(1, EjecutivosDummyData.Ejecutivo))
                .Returns(false);
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.Put(1, EjecutivosDummyData.Ejecutivo);
            //Assert
            result.Should().BeOfType<NotFoundObjectResult>();
            var objResult = (NotFoundObjectResult)result;
            objResult.StatusCode.Should().Be(404);
        }
        #endregion

        #region Delete
        [Fact]
        public async Task Delete_OnSucces_Bool()
        {
            //Arrange
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(true);
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.Delete(1);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)await ObjController.Delete(1);
            objResult.Value.Should().BeOfType<bool>();
        }

        [Fact]
        public async Task Delete_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IEjecutivos>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(false);
            var ObjController = new EjecutivosController(mockService.Object);
            //Act
            var result = await ObjController.Delete(1);
            //Assert
            result.Should().BeOfType<NotFoundObjectResult>();
            var objResult = (NotFoundObjectResult)result;
            objResult.StatusCode.Should().Be(404);
        }
        #endregion
    }
}
