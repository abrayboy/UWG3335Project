using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Team_Project.api.model;

namespace Team_Project.api
{
    /// <summary>
    /// Summary description for Apparel
    /// </summary>
    public class Apparel : HttpTaskAsyncHandler
    {

        private static Cart cart = new Cart();
    
        public override async Task ProcessRequestAsync(HttpContext context)
        {
            if (context.Request.HttpMethod != "POST")
            {
                throw new HttpException(404, String.Empty);
            }
            else if (context.Request.Headers["Authorization"] == null ||
                context.Request.Headers["Authorization"] != "UWG3335")
            {
                throw new HttpException(400, String.Empty);
            }

            context.Response.ContentType = "text/plain";

            var reader = new StreamReader(context.Request.InputStream);
            var body = await reader.ReadToEndAsync();
            try
            {
                var item = JsonConvert.DeserializeObject<ApparelItem>(body);
                cart.Add(item);
                context.Response.Write(cart.Total.ToString());
            }
            catch (Exception e)
            {
                // Do Nothing
            }
        }

        public override bool IsReusable => true;
        
    }
}