/**
 * Created by Bouach Omar on 12/03/2016.
 */

var MultiplechoiceQuestion = function () {

    // valeur par defaut

    this.idQuestion = -1;
    this.enonceQuestion = "";
    this.valeurQuestion = 0;
    this.typeQuestion = "MultiplechoiceQuestion";
    this.reponseQuestion = [];

};



var TrueFalseQuestion = function Question() {

    // valeur par defaut

    this.idQuestion = -1;
    this.enonceQuestion = "";
    this.valeurQuestion = 0;
    this.typeQuestion = "TrueFalseQuestion";
    this.reponseQuestion =[];

};




var FillIntheBlankQuestion = function Question() {

    // valeur par defaut

    this.idQuestion = -1;
    this.enonceQuestion = "";
    this.valeurQuestion = 0;
    this.typeQuestion = "FillIntheBlankQuestion";
    this.reponseQuestion = [];

};


var ReponseQuestion = function(){
    this.enonceReponse = "";
    this.valeur = false;
};
