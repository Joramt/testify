using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication23.Models.Entities;

namespace WebApplication23.Models.Manager
{
    public static class QuestionManager
    {

        public static List<QuestionModel> getQuestionsByQuizModelId(int QuizModelId)
        {
            List<QuestionModel> questions = null;

            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                questions = context.QuestionModels.Where(q => q.QuizModelId == QuizModelId).ToList();
            }

            return questions;
        }
    }
}