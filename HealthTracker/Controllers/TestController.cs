using Microsoft.AspNetCore.Mvc;

namespace HealthTracker.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestRepository _testRepository;

        public TestController(ITestRepository repo)
        {
            _testRepository = repo;
        }
        public IActionResult Index()
        {
            var tests = _testRepository.GetAllTests();
            return View(tests);
        }
        public IActionResult ViewTest(int id)
        {
            var test = _testRepository.GetTest(id);
            return View(test);
        }

        
    }
}

