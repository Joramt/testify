using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication23.Models.Entities;

namespace WebApplication23.Models.QuizUtil
{
    public static class QuizUtil
    {

        public static int CorrectionQuiz(QuizModel quizModel, QuizModel quizACorriger)
        {
            int PourcentageEvaluationQuizModel = quizModel.pourcentageEvaluation;
            int TotalePnderationQuestion = GetNoteTotale(quizModel);

            int noteQuiz = 0;

            float noteFinale = 0;

            foreach (QuestionModel question in quizModel.questions)
            {
                int ponderationQuestion = question.valeurQuestion;
                float noteReponse = 0;
                QuestionModel questionAcorriger = quizACorriger.questions.Where(q => q.idQuestion == question.idQuestion).FirstOrDefault();

                switch (question.typeQuestion)
                {

                    case TypeQuestion.MultiplechoiceQuestion:

                        int nbrRepExactes = getNombreReposesExactes(question);
                        int nbrRepExactesQuizAcorriger = 0;

                        foreach (ResponseModel reponse in question.reponseQuestion)
                        {
                            ResponseModel reponseAcorriger = questionAcorriger.reponseQuestion.Where(r => r.enonceReponse == reponse.enonceReponse).FirstOrDefault();

                            if (reponse.valeur == true && reponseAcorriger.valeur == true)
                                nbrRepExactesQuizAcorriger++;

                            if (reponse.valeur == false && reponseAcorriger.valeur == true)
                                nbrRepExactesQuizAcorriger--;

                            if (reponse.valeur == true && reponseAcorriger.valeur == false)
                            {
                                // ne rien faire  (cas ou l'utilisateur a oublier de cocher une bonne réponse)
                            }

                            if (reponse.valeur == false && reponseAcorriger.valeur == false)
                            {
                                // ne rein faier
                            }
                        }

                        if (nbrRepExactesQuizAcorriger < 0)
                            nbrRepExactesQuizAcorriger = 0;
                        noteReponse = ((float)nbrRepExactesQuizAcorriger / nbrRepExactes) * ponderationQuestion;
                        int aad = 22;
                        break;

                    case TypeQuestion.TrueFalseQuestion:

                        if (questionAcorriger.reponseQuestion.FirstOrDefault().valeur == question.reponseQuestion.FirstOrDefault().valeur)
                        {
                            noteReponse = ponderationQuestion;
                        }


                        break;

                    case TypeQuestion.FillIntheBlankQuestion:

                        if (questionAcorriger.reponseQuestion.FirstOrDefault().enonceReponse == question.reponseQuestion.FirstOrDefault().enonceReponse)
                        {
                            noteReponse = ponderationQuestion;
                        }


                        break;
                }


                noteFinale += noteReponse;
            }


            noteQuiz = (int)((PourcentageEvaluationQuizModel * noteFinale) / TotalePnderationQuestion);

            return noteQuiz;
        }

        private static int GetNoteTotale(QuizModel quizModel)
        {
            int noteTotale = 0;


            foreach (QuestionModel question in quizModel.questions)
            {
                noteTotale += question.valeurQuestion;
            }

            return noteTotale;
        }


        // le nombre de réponse exactes ( valeur = true) dans une question de type MultipleChoiceQuestion
        private static int getNombreReposesExactes(QuestionModel question)
        {
            int nbrRepExacte = 0;

            foreach (ResponseModel reponse in question.reponseQuestion)
            {
                if (reponse.valeur == true)
                    nbrRepExacte++;
            }
            return nbrRepExacte;
        }
    }
}