using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication23.Models;
using WebApplication23.Models.Entities;
using WebApplication23.Models.Manager;
using WebApplication23.Models.QuizUtil;
namespace WebApplication23.Controllers
{
    public class QuizController : Controller
    {
        public class PersonModel
        {
            public List<RoleModel> Roles { get; set; }
            public string Name { get; set; }
        }

        public class RoleModel
        {
            public string RoleName { get; set; }
            public string Description { get; set; }
        }


        // GET: /Quiz/
        public ActionResult Index()
        {
            return View();
        }

        public string GetQuizById()
        {
            QuizModel modelQuiz = QuizManager.getQuizById(1);

            return "blabl";
        }

        public string create()
        {

            // récuperer le json dans un string et puis le convertir à un QuizModel puis l'ajouter a la base de données
            Stream req = Request.InputStream;
            req.Seek(0, System.IO.SeekOrigin.Begin);
            string json = new StreamReader(req).ReadToEnd();
            QuizModel model = JsonConvert.DeserializeObject<QuizModel>(json);

            //model.ApplicationUserId = User.Identity.
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            //ApplicationUser user = userManager.FindByNameAsync(User.Identity.Name).Result;
            //model.ApplicationUserId = user.Id;
            QuizManager.createQuiz(model);

            return "blalalalal";

        }


        public string CorrectionQuiz()
        {

            // récuperer le json dans un string et puis le convertir à un QuizModel puis l'ajouter a la base de données
            Stream req = Request.InputStream;
            req.Seek(0, System.IO.SeekOrigin.Begin);
            string json = new StreamReader(req).ReadToEnd();
            QuizModel QuizAcorriger = JsonConvert.DeserializeObject<QuizModel>(json);

            QuizModel quizModel = QuizManager.getQuizById(1);

            int note = QuizUtil.CorrectionQuiz(quizModel, QuizAcorriger);

            return "blalalalal";

        }
    }
}