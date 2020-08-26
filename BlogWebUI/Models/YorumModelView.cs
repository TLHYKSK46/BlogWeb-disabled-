using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogWebUI.Controllers
{
    internal class YorumModelView
    {
        public Func<int, IActionResult> Makaleicerik { get; internal set; }
    }
}