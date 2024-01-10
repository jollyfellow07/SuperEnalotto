// See https://aka.ms/new-console-template for more information

using appNewForCourse;
using static appNewForCourse.Superenalotto;
Superenalotto Giocata = new Superenalotto();
Random random = new Random(); //questa variabile ci serve per andare a prendere il tipo random.
Console.WriteLine("In questo codice proveremo a iterare un array con valori int random");
//dichiaro le variabili array e random
int[] array = Giocata.GetCombinazioneSuperEnalotto();

//inizio creando le liste 
List<int[]> Biglietti = new List<int[]>();
//mi genero il numero di biglietti che desidero acquistare
int numeroBiglietti = Giocata.GetNumeroBiglietti();
//pmi stampo e salvo tutti i biglietti che ho comprato
Biglietti = Giocata.StampaBiglietti(numeroBiglietti);
Giocata.StampaCombinazioneSuperEnalotto(array);
//stampo e verifico l'estrazione di oggi 
Giocata.GetEstrazione(Biglietti, array);

