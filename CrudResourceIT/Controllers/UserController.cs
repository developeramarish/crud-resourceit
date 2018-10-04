using CrudResourceIT.Domain.Entities;
using CrudResourceIT.Http;
using CrudResourceIT.Repository;
using Microsoft.Ajax.Utilities;
using System;
using System.Net;
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
		public JsonHttpStatusResult Create(User user)
		{
			try
			{
				_userRepository.Add(user);
				var successModel = new { message = "Usuário criado com sucesso.", success = true };
				return new JsonHttpStatusResult(successModel, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				var errorModel = new { message = "Ocorreu um erro" };
				return new JsonHttpStatusResult(errorModel, HttpStatusCode.InternalServerError); 
			}
		}


		public ActionResult Edit(Guid id)
		{
			var user = _userRepository.GetById(id);
			return View(user);
		}

		[HttpPut]
		public JsonHttpStatusResult Update(Guid id, User user)
		{
			try
			{
				_userRepository.Update(user);
				var successModel = new { message = "Usuário editado com sucesso.", success = true };
				return new JsonHttpStatusResult(successModel, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				var errorModel = new { message = "Ocorreu um erro" };
				return new JsonHttpStatusResult(errorModel, HttpStatusCode.InternalServerError);
			}
		}

		[HttpDelete]
		public JsonHttpStatusResult Delete(Guid id)
		{
			try
			{
				var user = _userRepository.GetById(id);
				_userRepository.Remove(user);
				var successModel = new { message = "Usuário deletado com sucesso.", success = true };
				return new JsonHttpStatusResult(successModel, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				var errorModel = new { message = "Ocorreu um erro" };
				return new JsonHttpStatusResult(errorModel, HttpStatusCode.InternalServerError);
			}
		}
	}
}