﻿using HealthTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public IActionResult ViewTest(string Date)
        {
            var test = _testRepository.GetTest(Date);
            return View(test);
        }

        public IActionResult UpdateTest(string Date)
        {
            Test bw = _testRepository.GetTest(Date);
            if (bw == null)
            {
                return View("ProductNotFound");
            }
            return View(bw);
        }

        public IActionResult UpdateTestToDatabase(Test test)
        {
            _testRepository.UpdateTest(test);

            return RedirectToAction("Index");
        }
        public IActionResult InsertTest()
        {
            var testTypes = _testRepository.AssignCategory();
            return View(testTypes);

            //var testTypes = new List<string> { "CBC", "CMP", "Lipid Panel", "Other" };

            //ViewBag.TestType_CBC = new SelectList(testTypes, "CBC");
            //ViewBag.TestType_CMP = new SelectList(testTypes, "CMP");
            //ViewBag.TestType_LipidPanel = new SelectList(testTypes, "Lipid Panel");
            //ViewBag.TestType_Other = new SelectList(testTypes, "Other");
        }


        public IActionResult InsertTestToDatabase(Test testToInsert)
        {
            _testRepository.InsertTest(testToInsert);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTest(Test test)
        {
            _testRepository.DeleteTest(test);
            return RedirectToAction("Index");
        }
    }
}

