using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyTask.Models;

namespace MyTask.Pages
{
    public class AdditionFormModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int Number2 { get; set; }
        public void OnGet()
        {
            // Initialization logic if needed
        }
        public IActionResult OnPost()
        {          
            //Calculate the result
             int result = Number1 + Number2;
            // Pass the result to the Result page using TempData
            TempData["Result"] = result;
            return RedirectToPage("/ResultPage"); // Adjust the page path accordingly
        }
    }
}
