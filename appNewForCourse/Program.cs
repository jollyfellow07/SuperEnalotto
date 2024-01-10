// See https://aka.ms/new-console-template for more information

using appNewForCourse;
using static appNewForCourse.Superenalotto;

Random random = new Random(); //questa variabile ci serve per andare a prendere il tipo random.
Console.WriteLine("In questo codice proveremo a iterare un array con valori int random");
//dichiaro le variabili array e random
int[] array = Superenalotto.GetCombinazioneSuperEnalotto();

//inizio creando le liste 
List<int[]> Biglietti = new List<int[]>();
//mi genero il numero di biglietti che desidero acquistare
int numeroBiglietti = Superenalotto.GetNumeroBiglietti();
//pmi stampo e salvo tutti i biglietti che ho comprato
Biglietti = Superenalotto.StampaBiglietti(numeroBiglietti);
Superenalotto.StampaCombinazioneSuperEnalotto(array);
//stampo e verifico l'estrazione di oggi 
Superenalotto.GetEstrazione(Biglietti, array);
