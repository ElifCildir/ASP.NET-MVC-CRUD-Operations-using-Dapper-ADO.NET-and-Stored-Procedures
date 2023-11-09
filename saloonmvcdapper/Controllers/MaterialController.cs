using Dapper;
using saloonmvcdapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace saloonmvcdapper.Controllers
{
    public class MaterialController : Controller
    {
        // GET: Material
        public ActionResult Index()
        {

            return View(DP.List<Material>("MaterialViewAll") );
        }


        public ActionResult MatCRUP(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }

            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MaterialID", id);
                return View(DP.List<Material>("MaterialViewByID", param).FirstOrDefault<Material>());

            }



        }

        [HttpPost]
        public ActionResult MatCRUP(Material material)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@MaterialID", material.MaterialID);
            param.Add("@MaterialName", material.MaterialName);
            param.Add("@MaterialPrice", material.MaterialPrice);
            param.Add("@MaterialFunction", material.MaterialFunction);
            param.Add("@MaterialDefinition", material.MaterialDefiniton);
            param.Add("@ServiceID", material.ServiceID);
            DP.ExecuteReturn("MaterialCRUP", param);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@MaterialID", id);
            DP.ExecuteReturn("MaterialDelete", param);
            return RedirectToAction("Index");

        }






   




    }
}