using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication23.Models.Entities;

namespace WebApplication23.Models.Manager
{
    public static  class ResponseManager
    {

        public static List<ResponseModel> GetAllResponse()
        {
            List<ResponseModel> reponses = null;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                reponses = context.ResponseModels.ToList();
            }

            return reponses;
        }



        public static List<ResponseModel> GetResponseByQuestionId(int questionId)
        {
            List<ResponseModel> reponses = null;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                reponses = context.ResponseModels.Where(r => r.QuestionModelId == questionId).ToList();
            }

            return reponses;
        }

        
        
    }
}