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
    public class PatiosAutosControllerTest
    {
        #region GetAll

        [Fact]
        public void GetAll_OnSuccess_ListOfPatios()
        {
            //Arrange
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(PatiosAutosDummyData.Patios);
            var ObjController = new PatiosAutosController(mockService.Object);
            //Act
            var result = ObjController.GetAll();
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.GetAll();
            objResult.Value.Should().BeOfType<List<PatiosAutosModel>>();
        }

        [Fact]
        public void GetAll_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.GetAll())
                .Returns(new List<PatiosAutosModel>());
            var ObjController = new PatiosAutosController(mockService.Object);
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
        public void Get_OnSuccess_PatiosAutosModel()
        {
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(PatiosAutosDummyData.Patio);
            var ObjController = new PatiosAutosController(mockService.Object);
            //Act
            var result = ObjController.Get(1);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Get(1);
            objResult.Value.Should().BeOfType<PatiosAutosModel>();
        }

        [Fact]
        public void Get_OnError_ErrorCode404()
        {
            //Arrange
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.Get(1))
                .Returns(new PatiosAutosModel());
            var ObjController = new PatiosAutosController(mockService.Object);
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
        public void Post_OnSucces_PatioModel()
        {
            //Arrange
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.Post(PatiosAutosDummyData.Patio))
                .Returns(PatiosAutosDummyData.Patio);
            var ObjController = new PatiosAutosController(mockService.Object);
            //Act
            var result = ObjController.Post(PatiosAutosDummyData.Patio);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Post(PatiosAutosDummyData.Patio);
            objResult.Value.Should().BeOfType<PatiosAutosModel>();
        }

        [Fact]
        public void Post_OnError_ErrorCodeConflict409()
        {
            //Arrange
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.Post(PatiosAutosDummyData.Patio))
                .Returns(new PatiosAutosModel());
            var ObjController = new PatiosAutosController(mockService.Object);
            //Act
            var result = ObjController.Post(PatiosAutosDummyData.Patio);
            //Assert
            result.Should().BeOfType<ConflictObjectResult>();
            var objResult = (ConflictObjectResult)result;
            objResult.StatusCode.Should().Be(409);
        }
        #endregion

        #region Put
        [Fact]
        public void Put_OnSucces_PatiosAutosModel()
        {
            //Arrange
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.Put(1, PatiosAutosDummyData.Patio))
                .Returns(true);
            var ObjController = new PatiosAutosController(mockService.Object);
            //Act
            var result = ObjController.Put(1, PatiosAutosDummyData.Patio);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Put(1, PatiosAutosDummyData.Patio);
            objResult.Value.Should().BeOfType<bool>();
        }

        [Fact]
        public void Put_OnError_Bool()
        {
            //Arrange
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.Put(1, PatiosAutosDummyData.Patio))
                .Returns(false);
            var ObjController = new PatiosAutosController(mockService.Object);
            //Act
            var result = ObjController.Put(1, PatiosAutosDummyData.Patio);
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
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(true);
            var ObjController = new PatiosAutosController(mockService.Object);
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
            var mockService = new Mock<IPatiosAutosService>();
            mockService
                .Setup(service => service.Delete(1))
                .Returns(false);
            var ObjController = new PatiosAutosController(mockService.Object);
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
