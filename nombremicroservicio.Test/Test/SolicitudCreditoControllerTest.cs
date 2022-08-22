using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using nombremicroservicio.API.Controllers;
using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using nombremicroservicio.Infrastructure.Services;
using nombremicroservicio.Test.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace nombremicroservicio.Test.Test
{
    public  class SolicitudCreditoControllerTest
    {
        #region Post
        [Fact]
        public void Post_OnSucces_SolictudCreditoModel()
        {
            //Arrange
            var mockService = new Mock<ISolicitudesCreditoService>();
            mockService
                .Setup(service => service.Post(SolicitudCreditoDummyData.solicitudCredito))
                .Returns(SolicitudCreditoDummyData.solicitudCredito);
            var ObjController = new SolicitudCreditoController(mockService.Object);
            //Act
            var result = ObjController.Post(SolicitudCreditoDummyData.solicitudCredito);
            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objResult = (OkObjectResult)ObjController.Post(SolicitudCreditoDummyData.solicitudCredito);
            objResult.Value.Should().BeOfType<SolicitudCreditoModel>();
        }

        [Fact]
        public void Post_OnError_ErrorCodeConflict409()
        {
            //Arrange
            var mockService = new Mock<ISolicitudesCreditoService>();
            mockService
                .Setup(service => service.Post(SolicitudCreditoDummyData.solicitudCredito))
                .Returns(new SolicitudCreditoModel());
            var ObjController = new SolicitudCreditoController(mockService.Object);
            //Act
            var result = ObjController.Post(SolicitudCreditoDummyData.solicitudCredito);
            //Assert
            result.Should().BeOfType<ConflictObjectResult>();
            var objResult = (ConflictObjectResult)result;
            objResult.StatusCode.Should().Be(409);
        }

        [Fact]
        public void Post_OnErrorAlreadyExist_ErrorCodeConflict409()
        {
            //Arrange
            var mockService = new Mock<ISolicitudesCredito>();
            mockService
                .Setup(service => service.Post(SolicitudCreditoDummyData.solicitudCredito))
                .Returns(new SolicitudCreditoModel());
            var ObjController = new SolicitudesCreditoService(mockService.Object);
            //Act
            var result = ObjController.Post(SolicitudCreditoDummyData.solicitudCredito);
            //Assert
            result.Should().BeOfType<SolicitudCreditoModel>();
        }
        #endregion
    }
}
