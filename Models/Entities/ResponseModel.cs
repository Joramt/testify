using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication23.Models.Entities
{
    public class ResponseModel
    {
        public int Id { get; set; }

        public string enonceReponse { get; set; }
        public bool valeur { get; set; }

        public int QuestionModelId { get; set; }
        public virtual QuestionModel question { get; set; }
    }
}