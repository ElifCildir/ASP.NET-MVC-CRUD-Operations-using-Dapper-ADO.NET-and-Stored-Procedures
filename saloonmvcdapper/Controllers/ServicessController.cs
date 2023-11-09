using Dapper;
using saloonmvcdapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace saloonmvcdapper.Controllers
{
    public class ServicessController : Controller
    {
        // GET: Servicess
        public ActionResult Index()
        {
         
     
            return View(DP.List<Servicess>("ServicessViewAll"));
        }

        [HttpGet]
        public ActionResult ServicessCRUP(int id=0)
        {
            if (id == 0)
            {
                return View();

            }

            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ServiceID", id);
                return View(DP.List<Servicess>("ServicessViewByID",param).FirstOrDefault<Servicess>());

            }

        }

        [HttpPost]
        public ActionResult ServicessCRUP(Servicess servicess)
        {
            DynamicParameters param= new DynamicParameters();
            param.Add("@ServiceID", servicess.ServiceID);
            param.Add("@ServiceName", servicess.ServiceName);
            param.Add("@ServicePurpose", servicess.ServicePurpose);
            param.Add("@ServiceFee", servicess.ServiceFee);
            param.Add("@PaymentType", servicess.PaymentType);
            param.Add("@StaffID", servicess.StaffID);
            DP.ExecuteReturn("ServicessCRUP", param);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id=0) 
        {   
            DynamicParameters param = new DynamicParameters();
            param.Add("@ServiceID", id);
            DP.ExecuteReturn("ServicessDelete", param);
            return RedirectToAction("Index");
        
        
        }



    }
}