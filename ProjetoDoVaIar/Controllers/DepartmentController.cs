using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoDoVaIar.Models.DepartmentViewModels;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using ProjetoDoVaIar.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoDoVaIar.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly HttpClient _client;
        
        public DepartmentController()
        {
            _client = new HttpClient();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var json = _client.GetAsync("http://10.30.16.162/api/departments").Result.Content.ReadAsStringAsync().Result;
            var list = JsonConvert.DeserializeObject<List<Department>>(json);
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel c)
        {
            if (ModelState.IsValid)
            {
                await _client.PostAsync("http://10.30.16.162/api/departments", new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json"));
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
