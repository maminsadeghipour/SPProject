using System;
using System.Collections.Generic;
using App.Domain.Core.RequestAgg.Contracts.RequestPictureContracts;
using App.Domain.Core.RequestAgg.Entity;
using Microsoft.AspNetCore.Http;

namespace App.Domain.Service.RequestAgg
{
    public class RequestPictureService : IRequestPictureService
    {
        public async Task<List<RequestPicture>> AddPicturesToDisk(List<IFormFile> pictures)
        {
            List<RequestPicture> requestPictures = new();

            foreach (var pic in pictures)
            {
                if (pic != null && pic.Length > 0)
                {
                    var filePathToSave = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/requestimages", pic.FileName);

                    var filePathForDatabase = @"/requestimages/" + pic.FileName;

                    using (var stream = new FileStream(filePathToSave, FileMode.Create))
                    {
                        await pic.CopyToAsync(stream);
                    }

                    RequestPicture requestPicture = new() { Title = pic.FileName, PicturePath = filePathForDatabase , RequestId = null };
                    requestPictures.Add(requestPicture);
                }                
            }
            return requestPictures;
            
        }
    }
}

