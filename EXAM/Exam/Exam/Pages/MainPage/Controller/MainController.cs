using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam.Managers.DatabaseManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Exam.Models;
//using Exam.Pages.MainPage.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Exam.Pages.MainPage.Controller
{
    public class MainController : Controller
    {
        private readonly IDatabaseManager _databaseManager;
        // GET: Main

        public MainController(IDatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        // GET: Main/Details/5
        public IActionResult Index()
        {
            return View(_databaseManager.Files.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
                _context.Files.Add(file);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}