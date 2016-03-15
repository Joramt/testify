using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication23.Models.Entities;

namespace WebApplication23.Models.Manager
{
    public static class QuizManager
    {

        public static void createQuiz(QuizModel quizModel)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                context.QuizModels.Add(quizModel);
                context.SaveChanges();

                foreach (QuestionModel question in quizModel.questions)
                {
                    switch (question.typeQuestion)
                    {
                        case TypeQuestion.MultiplechoiceQuestion:

                            question.QuizModelId = quizModel.Id;
                            context.QuestionModels.Add(question);
                            context.SaveChanges();

                            foreach (ResponseModel reponse in question.reponseQuestion)
                            {
                                reponse.QuestionModelId = question.Id;
                                context.ResponseModels.Add(reponse);
                                context.SaveChanges();
                            }

                            break;

                        case TypeQuestion.TrueFalseQuestion:

                            question.QuizModelId = quizModel.Id;
                            context.QuestionModels.Add(question);
                            context.SaveChanges();
                            ResponseModel reponse2 = question.reponseQuestion.First();
                            reponse2.QuestionModelId = question.Id;
                            context.ResponseModels.Add(reponse2);
                            context.SaveChanges();



                            break;

                        case TypeQuestion.FillIntheBlankQuestion:

                            question.QuizModelId = quizModel.Id;
                            context.QuestionModels.Add(question);
                            context.SaveChanges();
                            ResponseModel reponse3 = question.reponseQuestion.First();
                            reponse3.valeur = false;
                            reponse3.QuestionModelId = question.Id;
                            context.ResponseModels.Add(reponse3);
                            context.SaveChanges();

                            break;
                    }
                }

            }
        }

        public static QuizModel getQuizById(int id)
        {
            QuizModel quizModel = null;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                quizModel = context.QuizModels.Where(q => q.Id == id).FirstOrDefault();
                List<QuestionModel> questions = QuestionManager.getQuestionsByQuizModelId(quizModel.Id).ToList();

                quizModel.questions = questions;


                quizModel.questions.ToList().ForEach(question =>
                {
                    IEnumerable<ResponseModel> reponses = context.ResponseModels.Where(r => r.QuestionModelId == question.Id).ToList();

                   
                       
                    

                    question.reponseQuestion=reponses;
                    int a = 0;

                });

                 
                

            }

            return quizModel;
        }

    }
}