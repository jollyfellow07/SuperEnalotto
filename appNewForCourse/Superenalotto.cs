namespace appNewForCourse;

public class Superenalotto
{
    public static Superenalotto CreateInstance()
    {
        return new Superenalotto();
    }
   
    public static int [] GetCombinazioneSuperEnalotto()
    {
       int [] array = new int [6];
       Random random = new Random(); //questa variabile ci serve per andare a prendere il tipo random.
       
        for (int i = 0; i < array.Length; i++)
        {
            int number = random.Next(1, 90);

            while (array.Contains(number))//gestisco duplicati
            {
                number = random.Next(1, 90);
            }

            array[i] = number;
    
        }

        return array;
    }

    public static int GetNumeroBiglietti()
    {
        //chiedo all'utente quanti biglietti desidera acquistare
        int numeroBiglietti = 0;
        bool success = false;
        Console.WriteLine("Inserisci il numero di biglietti che vuoi:");
        while (!success)
        { 
            try
            {
                numeroBiglietti = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "\n\nMi dispiace numero non valido, inserisci un nuovo valore: ");
            }
        }

        return numeroBiglietti;
    }

    public static List<int[]> StampaBiglietti(int numeroBiglietti)
    {
        List<int[]> Biglietti = new List<int[]>();
        Random random = new Random(); //questa variabile ci serve per andare a prendere il tipo random.
        //creo i miei biglietti
        for (int i = 0; i < numeroBiglietti; i++)
        {
            Biglietti.Add(GetCombinazioneSuperEnalotto());
        }
//una volta creati i biglietti li vado a stampare
        foreach (var controllo in Biglietti)
        {
            Console.WriteLine("\ncombinazione: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"\t {controllo[i]}");
            }
        }

        return Biglietti;
    }

    public static void GetEstrazione(List<int[]> Biglietti, int[] array)
    {
        //vado a creare un foreach che scansiona il mio array di biglietti, poi con un altro ciclo vado a vedere quanti numeri il mio biglietto
//ha in comune con l'estrazione del superenalotto.
        foreach (int[] num in Biglietti) 
        {
            int numeriInComune = 0;
            foreach (int numero in num) 
            {
                foreach (int numeroPrincipale in array) 
                {
                    if (numero == numeroPrincipale)
                    {
                        numeriInComune++;
                    }
                }
            }

            if (numeriInComune > 1)
            {
                Console.WriteLine("\nComplimenti!!!!!!!\n Il biglietto \n" + string.Join(", ", num) + " ha " + numeriInComune +
                                  " numeri in comune.\n Estrazione SUPERENALOTTO: \n" + string.Join(", ", array));


                switch (numeriInComune)
                {
                    case (2):
                        Console.WriteLine("\nComplimenti hai fatto un ambo");
                        break;
                    case (3):
                        Console.WriteLine("\nComplimenti hai fatto un terno");
                        break;
                    case (4):
                        Console.WriteLine("\nComplimenti hai fatto una quaterna");
                        break;
                    case (5):
                        Console.WriteLine("\nComplimenti hai fatto una quintina");
                        break;
                    case (6):
                        Console.WriteLine("\n\n\n\n\n\n\nCOMPLIMENTI HAI VINTO IL LOTTO! CHE FORTUNA\n\n\n\n\n");
                        break;
                }
            }
        }
    }
    
}