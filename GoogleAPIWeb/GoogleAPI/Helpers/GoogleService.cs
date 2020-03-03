using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleAPI.Helpers
{
    public class GoogleService
    {
        private readonly IHostingEnvironment host;
        public DriveService GetDriveService()
        {
            UserCredential userCredential;
            
            var credentialPath = Path.Combine(_host.ContentRootPath, "Content", "Credentials");
            return null;
        }
    }
}
