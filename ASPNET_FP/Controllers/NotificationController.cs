﻿using Microsoft.AspNetCore.Mvc;

namespace ASPNET_FP.Controllers
{
	public class NotificationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
