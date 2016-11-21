using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace MindWeb_v._2.Controllers
{
    public class ExerciseController : SurfaceController
    {
        // GET: Exercise
        public ActionResult Index(int id)
        {
            var model = Umbraco.Content(id);
            return PartialView("Exercise", model);
        }
    }
}