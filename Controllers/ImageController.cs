using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Http;
using WindowsAuthentication.Models;
using System.Web.Http.Cors;

namespace WindowsAuthentication.Controllers
{
    //[Produces("application/json")]
   // [Route("api/Image")]
    public class ImageController : ApiController
    {
     //   [HttpPost]
       // [Route("api/UploadImage")]
        //public HttpResponseMessage UploadImage()
        //{
            //string imageName = null;
            //var httpRequest = System.Web.HttpContext.Current.Request;
            ////Upload Image
            //var postedFile = httpRequest.Files["Image"];
            ////Create custom filename
            //imageName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(10).ToArray()).Replace(" ", "-");
            //imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedFile.FileName);
            //var filePath = HttpContext.Current.Server.MapPath("~/Image/" + imageName);
            //postedFile.SaveAs(filePath);

            ////Save to DB
            ////using (DBModel db = new DBModel())
            ////{
            ////    Image image = new Image()
            ////    {
            ////        ImageCaption = httpRequest["ImageCaption"],
            ////        ImageName = imageName
            ////    };
            ////    db.Images.Add(image);
            ////    db.SaveChanges();
            ////}
            //return Request.CreateResponse(HttpStatusCode.Created);
       // }
    }
}