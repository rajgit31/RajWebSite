using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.IO;
using System.Net;

namespace RajSoftware
{
    /// <summary>
    /// CustomRouteHandler
    /// </summary>
    public class CustomRouteHandler : IRouteHandler
    {

        /// <summary>
        /// Provides the object that processes the request.
        /// </summary>
        /// <param name="requestContext">An object that encapsulates information about the request.</param>
        /// <returns>An object that processes the request.</returns>
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            string filename = requestContext.RouteData.Values["filename"] as string;
            
            if (string.IsNullOrEmpty(filename))
            {
                // return a 404 HttpHandler here
                throw new HttpException(404, "Unable to locate the file name");
            }
            else
            {
                requestContext.HttpContext.Response.Clear();
                requestContext.HttpContext.Response.ContentType = GetContentType(requestContext.HttpContext.Request.Url.ToString());

                // find physical path to image here.   
                requestContext.HttpContext.Response.WriteFile(requestContext.HttpContext.Server.MapPath("~/Images/" + filename));
                requestContext.HttpContext.Response.End();
            }           

            return null;
        }

        private static string GetContentType(String path)
        {
            switch (Path.GetExtension(path))
            {
                case ".bmp": return "Image/bmp";
                case ".gif": return "Image/gif";
                case ".jpg": return "Image/jpeg";
                case ".png": return "Image/png";
                default: break;
            }
            return "";
        }     
    } 

}


