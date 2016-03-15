/**
 * Created by Bouach Omar on 12/03/2016.
 */

var Quiz = function () {
    this.quizName = "";
    this.pourcentageEvaluation = 0;
    this.randomiserQuestion = false;
    this.temps = 0;
    this.description = "";
    this.cours = "";
    this.questions = [];

    this.toJson = function () {
        return JSON.stringify(this);
    }
};