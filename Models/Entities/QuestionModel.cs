using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication23.Models.Entities
{

    public class QuestionModel
    {
        public int Id { get; set; }

        public int idQuestion { get; set; }
        public string enonceQuestion { get; set; }
        public int valeurQuestion { get; set; }
        public TypeQuestion typeQuestion { get; set; }

        public int QuizModelId { get; set; }
        public virtual QuizModel QuizModels { get; set; }


        public virtual IEnumerable<ResponseModel> reponseQuestion { get; set; }
    }
}