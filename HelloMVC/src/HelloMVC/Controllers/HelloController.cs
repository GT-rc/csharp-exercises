using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [Route("/")]
        [HttpGet]
        public IActionResult Index(string name, string language)
        {
            /*if (string.IsNullOrEmpty(name))
            {
                name = "World";
            }
            */

            string html = "<form method='post' action='/Hello'>" + 
                "<input type='text' name='name' />" + 
                "<select name='language'>" + 
                "<option value='eng'>English</option>" +
                "<option value='ger'>German</option>" + 
                "<option value='fr'>French</option>" + 
                "<option value='sp'>Spanish</option>" + 
                "<option value='lat'>Latin</option>" +
                "<input type='submit'value='Greet Me!' />" + 
                "</form>";

            return Content(html, "text/html");
            //System.Console.ReadLine();
            //RedirectToRoute "/Hello/{name}, {language}";
        }
        
        // /Hello/Goodbye
        // alter route to this controller to be: /Hello/Aloha
        //[Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }

        //[Route("/Hello")]
        //[HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }


        // Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Index2(string name, string language)
        {
            string greeting = CreateMessage(name, language);
            return Content(string.Format("{0}, {1}", greeting, name));
        }
        
        //[Route("/{name}{language}")]
        //[HttpPost]
        public static string CreateMessage(string name, string language)
        {
            string greeting = "Hi";

            if (language == "eng")
            {
                greeting = "Hello";
            } else if (language == "ger")
            {
                greeting = "Hallo";
            } else if (language == "fr")
            {
                greeting = "Bonjour";
            } else if (language == "sp")
            {
                greeting = "Hola";
            } else if (language == "lat")
            {
                greeting = "Salve";
            } else if (string.IsNullOrEmpty(language))
            {
                greeting = "There was a problem getting your greeting.";
            } else
            {
                greeting = "Quiet you!";
            }

            return greeting;
        }
    }
}
