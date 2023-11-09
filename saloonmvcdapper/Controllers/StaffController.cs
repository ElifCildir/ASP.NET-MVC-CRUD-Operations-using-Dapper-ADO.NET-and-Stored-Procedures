using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using System.Data.SqlClient;
using saloonmvcdapper.Models;

namespace saloonmvcdapper.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View(DP.List<Staff>("StaffViewAll"));
        }

        public ActionResult StaffCRUP(int id = 0)
        {
            if (id == 0)
            { return View(); }

            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@StaffID", id);
                return View(DP.List<Staff>("StaffViewByStaffID", param).FirstOrDefault<Staff>());


            }

        }
            [HttpPost]
            public ActionResult StaffCRUP(Staff staff)
            {
                DynamicParameters param= new DynamicParameters();
                param.Add("@StaffID", staff.StaffID);
                param.Add("@NameSurname", staff.NameSurname);
                param.Add("@Age", staff.Age);
                param.Add("@Phone", staff.Phone);
                param.Add("@Salary", staff.Salary);
                param.Add("@WorkSchedule", staff.WorkSchedule);
                param.Add("@Bonus", staff.Bonus);
                param.Add("@CenterID", staff.CenterID);
                DP.ExecuteReturn("StaffCRUP", param);
                return RedirectToAction("Index");


            }

        public ActionResult Delete(int id=0)
        {
           DynamicParameters param = new DynamicParameters();
            param.Add("@StaffID",id);
            DP.ExecuteReturn("StaffDelete", param);
            return RedirectToAction("Index");



        }



        }
    }
