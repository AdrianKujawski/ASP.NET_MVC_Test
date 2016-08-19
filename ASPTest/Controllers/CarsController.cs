using System.Linq;
using System.Web.Mvc;
using ASPTest.Models;

namespace ASPTest.Controllers
{
	public class CarsController : Controller
	{
		private readonly CarDBCtxt CarBase = new CarDBCtxt();

		// GET: Cars
		public ActionResult Index()
		{
			return View(CarBase.Cars.ToList());
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Brand,Model,Price,Bought,Sold")] Car car)
		{
			if (ModelState.IsValid)
			{
				CarBase.Cars.Add(car);
				CarBase.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(car);
		}
	}
}