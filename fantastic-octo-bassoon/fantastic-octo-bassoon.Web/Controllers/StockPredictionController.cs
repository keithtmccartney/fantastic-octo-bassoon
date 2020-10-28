using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantastic_octo_bassoon.Web.Controllers
{
	public class StockPredictionController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
