﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class RouteFunSecondModel : PageModel
    {
        //public string Mess;
        [BindProperty(SupportsGet = true)]
        public string Message { get; set; }

        //public void OnGet(string message)
        //{
        //    Mess = message;
        //}
    }
}