using Microsoft.AspNetCore.Mvc;
using PrefinalExamMVC.Data;

namespace PrefinalExamMVC.Controllers;

public class HomeController : Controller
{
    // GET /  -> full exam review, grouped by topic
    public IActionResult Index()
    {
        var grouped = QuestionData.All
            .OrderBy(q => q.Number)
            .GroupBy(q => q.Topic)
            .ToList();

        return View(grouped);
    }

    // GET /Home/Details/5 -> single question as a flashcard
    public IActionResult Details(int id)
    {
        var item = QuestionData.All.FirstOrDefault(q => q.Number == id);
        if (item == null)
        {
            return NotFound();
        }

        return View(item);
    }

    public IActionResult Error() => View();
}
