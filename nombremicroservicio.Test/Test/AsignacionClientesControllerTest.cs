using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using nombremicroservicio.API.Controllers;
using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using nombremicroservicio.Test.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace nombremicroservicio.Test.Test
{
    public class AsignacionClientesControllerTest
    {
        #region GetAll

        [Fact]
        public void GetAll_OnSuccess_ListOfAsignacionesCreditos()
        {
            //Arrange
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(AsignacionClientesDummyData.Asignaciones);
            var ObjController = new AsignacionClientesController(mockService.Object);
            //Act
            var result = ObjController.GetAll();
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.GetAll();
            objResult.Value.Should().BeOfType<List<AsignacionClientesModel>>();
        }

        [Fact]
        public void GetAll_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(new List<AsignacionClientesModel>());
            var ObjController = new AsignacionClientesController(mockService.Object);
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
        public void Get_OnSuccess_AsignacionesCreditosModel()
        {
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(AsignacionClientesDummyData.Asignacion);
            var ObjController = new AsignacionClientesController(mockService.Object);
            //Act
            var result = ObjController.Get(1);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Get(1);
            objResult.Value.Should().BeOfType<AsignacionClientesModel>();
        }

        [Fact]
        public void Get_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(new AsignacionClientesModel());
            var ObjController = new AsignacionClientesController(mockService.Object);
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
        public void Post_OnSucces_AsignacionCreditoModel()
        {
            //Arrange
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.Post(AsignacionClientesDummyData.Asignacion))
                .Returns(AsignacionClientesDummyData.Asignacion);
            var ObjController = new AsignacionClientesController(mockService.Object);
            //Act
            var result = ObjController.Post(AsignacionClientesDummyData.Asignacion);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Post(AsignacionClientesDummyData.Asignacion);
            objResult.Value.Should().BeOfType<AsignacionClientesModel>();
        }

        [Fact]
        public void Post_OnError_ErrorCodeConflict409()
        {
            //Arrange
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.Post(AsignacionClientesDummyData.Asignacion))
                .Returns(new AsignacionClientesModel());
            var ObjController = new AsignacionClientesController(mockService.Object);
            //Act
            var result = ObjController.Post(AsignacionClientesDummyData.Asignacion);
            //Assert
            result.Should().BeOfType<ConflictObjectResult>();
            var objResult = (ConflictObjectResult)result;
            objResult.StatusCode.Should().Be(409);
        }
        #endregion

        #region Put
        [Fact]
        public void Put_OnSucces_AsignacionesCreditoModel()
        {
            //Arrange
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.Put(1, AsignacionClientesDummyData.Asignacion))
                .Returns(true);
            var ObjController = new AsignacionClientesController(mockService.Object);
            //Act
            var result = ObjController.Put(1, AsignacionClientesDummyData.Asignacion);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Put(1, AsignacionClientesDummyData.Asignacion);
            objResult.Value.Should().BeOfType<bool>();
        }

        [Fact]
        public void Put_OnError_Bool()
        {
            //Arrange
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.Put(1, AsignacionClientesDummyData.Asignacion))
                .Returns(false);
            var ObjController = new AsignacionClientesController(mockService.Object);
            //Act
            var result = ObjController.Put(1, AsignacionClientesDummyData.Asignacion);
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
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(true);
            var ObjController = new AsignacionClientesController(mockService.Object);
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
            var mockService = new Mock<IAsignacionClientes>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(false);
            var ObjController = new AsignacionClientesController(mockService.Object);
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
