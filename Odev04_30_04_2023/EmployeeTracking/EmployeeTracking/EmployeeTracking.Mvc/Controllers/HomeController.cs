using EmployeeTracking.Business.Abstract;
using EmployeeTracking.Business.Concrete;
using EmployeeTracking.Data.Concrete.EfCore.Contexts;
using EmployeeTracking.Entity;
using EmployeeTracking.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmployeeTracking.Mvc.Controllers { 

public class HomeController : Controller
{


    private readonly IEmployeeService _employeeManager;
    private readonly IDepartmentService _departmentManager;

    public HomeController(IEmployeeService employeeManager, IDepartmentService departmentManager)
    {
        _employeeManager = employeeManager;
        _departmentManager = departmentManager;
    }

    public IActionResult Index()
    {
            var employeeList = _employeeManager.GetAll();   
            var departmentList = _departmentManager.GetAll();
            var employeeDepartmentList = _employeeManager.GetEmployeesDepartment();
            
            return View(employeeDepartmentList); //çalışanları departmanları ile birlikte gönderir
            //return View(employeeList); //çalışan listesini view'e yollar.
            //return View(departmentList); // department listesini view'e yollar.
        }

    }



}