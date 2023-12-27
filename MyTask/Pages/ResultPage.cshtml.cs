using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyTask.Pages
{
    public class ResultPageModel : PageModel
    {
        public int ResultValue { get; set; }

        public void OnGet()
        {
            // Retrieving the result from TempData 
            if (TempData.TryGetValue("Result", out object result)) //here "Result" acts as a key should match the key used when storing the result in TempData on the previous page (AdditionForm.cshtml.cs).
            {
                ResultValue = (int)result;
            }
        }
    }
}
