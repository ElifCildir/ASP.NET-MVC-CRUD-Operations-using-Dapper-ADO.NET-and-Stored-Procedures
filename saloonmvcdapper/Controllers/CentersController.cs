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
    public class CentersController : Controller
    {
        // GET: Salons
        public ActionResult Index()
        {
            return View(DP.List<Centers>("SalonsViewAll"));
        }

        [HttpGet]
         public ActionResult SalCRUP(int id=0)
        {
            if(id==0)
            {
                return View();
            }

            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CenterID", id);
                return View(DP.List<Centers>("SalonViewByID", param).FirstOrDefault<Centers>());
              
            }


        }

        [HttpPost]
        public ActionResult  SalCRUP(Centers centers)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@CenterID", centers.CenterID);
            param.Add("@CenterName", centers.CenterName);
            param.Add("@CenterDoorNumber", centers.CenterDoorNumber);
            param.Add("@OperationPerformed", centers.OperationPerformed);
            param.Add("@NumberofOperations", centers.NumberofOperations);
            DP.ExecuteReturn("SalonCRUP", param);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id=0)
        {
            DynamicParameters param =new DynamicParameters();
            param.Add("CenterID", id);
            DP.ExecuteReturn("SalonDelete", param);
            return RedirectToAction("Index");



        }



    }
}