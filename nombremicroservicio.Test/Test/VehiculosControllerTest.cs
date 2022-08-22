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
using Xunit;

namespace nombremicroservicio.Test.Test
{
    public class VehiculosControllerTest
    {

        #region GetAll

        [Fact]
        public void GetAll_OnSuccess_ListOfClients()
        {
            //Arrange
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(VehiculosDummyData.Vehiculos);
            var ObjController = new VehiculosController(mockService.Object);
            //Act
            var result = ObjController.GetAll();
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.GetAll();
            objResult.Value.Should().BeOfType<List<VehiculoModel>>();
        }

        [Fact]
        public void GetAll_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(new List<VehiculoModel>());
            var ObjController = new VehiculosController(mockService.Object);
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
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(VehiculosDummyData.Vehiculo);
            var ObjController = new VehiculosController(mockService.Object);
            //Act
            var result = ObjController.Get(1);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Get(1);
            objResult.Value.Should().BeOfType<VehiculoModel>();
        }

        [Fact]
        public void Get_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(new VehiculoModel());
            var ObjController = new VehiculosController(mockService.Object);
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
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.Post(VehiculosDummyData.Vehiculo))
                .Returns(VehiculosDummyData.Vehiculo);
            var ObjController = new VehiculosController(mockService.Object);
            //Act
            var result = ObjController.Post(VehiculosDummyData.Vehiculo);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Post(VehiculosDummyData.Vehiculo);
            objResult.Value.Should().BeOfType<VehiculoModel>();
        }

        [Fact]
        public void Post_OnError_ErrorCodeConflict409()
        {
            //Arrange
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.Post(VehiculosDummyData.Vehiculo))
                .Returns(new VehiculoModel());
            var ObjController = new VehiculosController(mockService.Object);
            //Act
            var result = ObjController.Post(VehiculosDummyData.Vehiculo);
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
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.Put(1, VehiculosDummyData.Vehiculo))
                .Returns(true);
            var ObjController = new VehiculosController(mockService.Object);
            //Act
            var result = ObjController.Put(1, VehiculosDummyData.Vehiculo);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Put(1, VehiculosDummyData.Vehiculo);
            objResult.Value.Should().BeOfType<bool>();
        }

        [Fact]
        public void Put_OnError_Bool()
        {
            //Arrange
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.Put(1, VehiculosDummyData.Vehiculo))
                .Returns(false);
            var ObjController = new VehiculosController(mockService.Object);
            //Act
            var result = ObjController.Put(1, VehiculosDummyData.Vehiculo);
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
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(true);
            var ObjController = new VehiculosController(mockService.Object);
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
            var mockService = new Mock<IVehiculosService>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(false);
            var ObjController = new VehiculosController(mockService.Object);
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
