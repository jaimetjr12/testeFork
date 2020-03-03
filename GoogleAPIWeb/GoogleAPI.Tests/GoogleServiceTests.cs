using GoogleAPI.Helpers;
using System;
using Xunit;

namespace GoogleAPI.Tests
{
    public class GoogleServiceTests
    {
        [Fact]
        public void PegaServicoDoGoogle()
        {
            var googleService = new GoogleService();

            var driveService = googleService.GetDriveService();

            Assert.NotNull(driveService);
        }
    }
}
