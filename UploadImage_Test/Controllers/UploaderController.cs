using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UploadImage_Test.Models;

namespace UploadImage_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploaderController : ControllerBase
    {
        [HttpPost("UploadFile")]
        public Response UploadFile([FromForm] FileModel fileModel)
        {
            Response response = new Response();
            try
            {
                Console.WriteLine(fileModel);
                string path = Path.Combine("ImageVersDossier", fileModel.File.FileName);
                using (Stream stream = new FileStream(path, FileMode.Create))
                {
                    fileModel.File.CopyTo(stream);
                }
                 response.Statuscode = 200;
                response.ErrorMessage = "Created";
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                response.Statuscode = 100;
                response.ErrorMessage = "Error";
            }
            return response;
        }
    }
}
