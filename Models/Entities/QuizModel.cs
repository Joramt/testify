using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication23.Models.Entities;

namespace WebApplication23.Models
{
  public enum TypeQuestion
    {
        MultiplechoiceQuestion, TrueFalseQuestion, FillIntheBlankQuestion
    }
    public class QuizModel

    {
        public int Id { get; set; }

        public string quizName { get; set; }
        public int pourcentageEvaluation { get; set; }
        public bool randomiserQuestion { get; set; }
        public int temps { get; set; }
        public string description { get; set; }
        public string cours { get; set; }

        public virtual IEnumerable<QuestionModel> questions { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser applicationUser { get; set; }
    }




}