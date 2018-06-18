﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppCurriculo.Models;

namespace WebAppCurriculo.Controllers
{
    public class CurriculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View(new Curriculo());
        }

        [HttpPost]
        public IActionResult Cadastro(Curriculo curriculo)
        {
            return View(curriculo);
        }

    }

}
