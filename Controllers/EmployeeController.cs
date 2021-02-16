using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adoneta.Models;
using adoneta.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace adoneta.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeConntroller
        public ActionResult Index()
        {
            EmployeeRepositories EmpRepo = new EmployeeRepositories();
            ModelState.Clear();
            return View(EmpRepo.GetAllEmployee());
        }

        // GET: EmployeeConntroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeConntroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeConntroller/Create
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public ActionResult Create(EmpModel obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeRepositories EmpRepo = new EmployeeRepositories();

                    if (EmpRepo.AddEmployee(obj))
                    {
                        ViewBag.Message = "Employee details added successfully";
                        return RedirectToAction("index");
                    }
                }

                return View();
            }
            catch(Exception e)
            {
                ViewBag.Message = e.Message;
                return View();
            }
        }


        // GET: EmployeeConntroller/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                EmployeeRepositories EmpRepo = new EmployeeRepositories();
                if (EmpRepo.DeleteEmployee(id))
                {
                    ViewBag.AlertMsg = "Employee details deleted successfully";

                }
                return RedirectToAction("index");

            }
            catch
            {
                return View();
            }
        }

    }
}
