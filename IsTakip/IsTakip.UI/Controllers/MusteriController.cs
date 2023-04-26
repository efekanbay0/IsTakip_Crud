using IsTakip.Bussines.Concrete;
using IsTakip.DataAccess.EntityFramework;
using IsTakip.Entities.Classes.MusteriClasses;
using Microsoft.AspNetCore.Mvc;

namespace IsTakip.UI.Controllers
{
	public class MusteriController : Controller
	{
		MusteriManager m_manager = new MusteriManager(new EfMusteriDal());
		public IActionResult Index()
		{
			var values = m_manager.GetAll();
			return View(values);
		}
		public IActionResult DetailsMusteri(int id) 
		{
			var values = m_manager.GetById(id);
			return View(values); 
		}
		public IActionResult DeleteMusteri(int id)
		{
			var values = m_manager.GetById(id);
			m_manager.Delete(values);
			return RedirectToAction("Index");
		}

		public IActionResult AddMusteri()
		{			
			return View();
		}
		[HttpPost]
		public IActionResult AddMusteri(Musteri musteri)
		{
			m_manager.Insert(musteri);
			return RedirectToAction("Index");
		}

		public IActionResult EditMusteri(int id) 
		{
			var values = m_manager.GetById(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult EditMusteri(Musteri musteri) 
		{
			m_manager.Update(musteri);
			return RedirectToAction("Index");
		}
	}

}
