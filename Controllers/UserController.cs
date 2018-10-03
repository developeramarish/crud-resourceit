using CrudResourceIT.Domain.Entities;
using CrudResourceIT.Repository;
using System;
using System.Web.Mvc;

namespace CrudResourceIT.Controllers
{
    public class UserController : Controller
    {
		readonly UserRepository _userRepository;
		public UserController()
		{
			_userRepository = new UserRepository();
		}

		public ActionResult Index()
		{
			var users = _userRepository.GetAll();
			return View(users);
		}

		public ActionResult Details(Guid id)
		{
			var user = _userRepository.GetById(id);
			return View(user);
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(User user)
		{
			_userRepository.Add(user);
			return RedirectToAction("Index");
		}


		public ActionResult Edit(string id)
		{
			return View();
		}

		[HttpPut]
		public ActionResult Edit(User user)
		{
			_userRepository.Update(user);
			return RedirectToAction("Index");
		}

		[HttpDelete]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(Guid id)
		{
			var user = _userRepository.GetById(id);
			_userRepository.Remove(user);
			return RedirectToAction("Index");
		}
	}
}