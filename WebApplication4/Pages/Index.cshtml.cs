using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;



namespace RazorPages
{
    public class IndexModel : PageModel
    {

        private static WebClient client = new WebClient();

        [BindProperty]
        public string code { get; set; }
        [BindProperty]
        public string message { get; set; }

        public void OnGet()
        {
            if(code != null && message != null)
            {
                
            }
        }
        public IActionResult OnPost()
        {
            var parameters = new NameValueCollection { { "token", "ajs2vpgniz8d4kkox4wbghmdnodjxs" }, { "user", code }, { "message", message }
                };
            Console.WriteLine(code + " " + message + " !!!! ");
            client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
            return Page();

        }
    }
}
