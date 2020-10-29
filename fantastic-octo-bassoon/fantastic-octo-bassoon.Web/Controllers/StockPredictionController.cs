using Fantastic_octo_bassoonML.Model;
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

		[HttpGet]
		public IActionResult StockPrediction()
		{
			return View();
		}

		[HttpPost]
		public ActionResult StockPrediction(ModelInput input)
		{
			ViewBag.Result = "";

			try
            {
				var stockPredictions = ConsumeModel.Predict(input);

				ViewBag.result = stockPredictions;
			}
			catch (Exception ex)
            {
				throw ex;
            }

			ViewData["ItemID"] = input.ItemID;
			ViewData["Loccode"] = input.Loccode;

			return View();
		}
	}
}
