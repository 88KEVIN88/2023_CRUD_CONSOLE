using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_ripasso;

namespace Crud_console
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           
            bool fatto = false;
            int scelta=0 ;
            int h = 0;
            
            Random rand = new Random();
            Class1 class1 = new Class1();
            string[] nomecampi = { "Comune", "Provincia", "Regione", "Nome", "Anno inserimento", " Data e ora inserimento", " Identificatore in OpenStreetMap", "Longitudine", "Latitudine", "Mio valore" };

            Console.WriteLine("Digitare il numero per accedere alla funzione");//
            Console.WriteLine("1 - Aggiunta di un campo con un valore random da 0 a 20");//
            Console.WriteLine("2 - Numero dei campi presenti nel file csv");//
            Console.WriteLine("3 - Lunghezza massima del record");//
            Console.WriteLine("4 - Lunghezza di ogni singolo campo");//
            Console.WriteLine("5 - Stampa dei campi");//
            Console.WriteLine("6 - Aggiunta di un record alle fine del file csv");//
            Console.WriteLine("7 - Funzione che imposta la lunghezza massima di ogni record alla lunghezza massima del record");//
            Console.WriteLine("8 - Ricerca di un record dando due campi univoci");//
            Console.WriteLine("9 - Modifica di un record dato l'indice");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Immetere la propria scelta");
            Console.ForegroundColor = ConsoleColor.White;
            scelta =int.Parse(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    if (fatto == false)
                    {
                        class1.Add();
                        Console.WriteLine("La funzione é stata eseguita");
                        fatto = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("La funzione é giá stata eseguita");
                    }
                    break;
                case 2:
                    Console.WriteLine($"Il numero di campi in questo file csv é {class1.Contatore()}");
                    break;
                case 3:
                    Console.WriteLine($"La lunghezza massima del record é di {class1.Lunghezza()}");
                    break;
                case 4:
                    
                    int[] lunghezze = class1.Lunghezzacampi();
                    foreach (int lunghezza in lunghezze)
                    {
                        Console.WriteLine($"la lunghezza del campo {nomecampi[h]} é di {lunghezza}");
                        h++;
                    }
                    break;
                case 5:
                    string[][] data = class1.Stampacampi();
                    foreach (var rowData in data)
                    {
                        // Assicurati che ci siano almeno 3 campi nella riga corrente
                        if (rowData.Length >= 3)
                        {
                            // Stampare i primi 3 campi della riga in colonne equidistanti
                            Console.WriteLine($"{rowData[0],-40}{rowData[1],-40}{rowData[2],-20}");
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("Inserisci il tuo comune:");
                    string c = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo comune:");
                    string p = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo comune:");
                    string r = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo comune:");
                    string n = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo comune:");
                    string a = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo comune:");
                    string i = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo comune:");
                    string l = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo comune:");
                    string la = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo comune:");
                    string v = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo comune:");
                    string d = Console.ReadLine();
                    class1.AggiuntaRecord(c, p, r, n, a, d, i, l, la, v);
                    break;
                case 7:
                    if (fatto == false)
                    {
                        fatto = true;
                        class1.Standart();
                    }
                    else
                    {
                        Console.WriteLine("La funzione é giá stata eseguita");
                    }
                    break;
                case 8:
                    Console.WriteLine("Funzione di ricerca:");
                    Console.WriteLine("Immetere 1 per ricercare solo nel campo del comune , 2 per ricercare solo nel campo delle provicnia e 3 per cercarlo in entrambi");
                    scelta = int.Parse(Console.ReadLine());
                    Console.WriteLine("Immetere i parametri di ricerca");
                    Console.Write("Comune:");
                    string ricercato =Console.ReadLine();
                    Console.Write("Provincia:");
                    string ric=Console.ReadLine();  
                    List<string[]> risultatiList = class1.Ricerca(ricercato, ric, scelta);
                    string[][] risultati = risultatiList.ToArray();
                    foreach (string[] riga in risultati)
                    {
                        foreach (string campo in riga)
                        {
                            Console.Write($"{campo}\t"); // Stampa il campo separato da un tabulatore
                        }
                        Console.WriteLine(); // Vai a una nuova riga dopo aver stampato una riga completa
                    }
                    break;
                    case 9:

                    Console.WriteLine("Inserisci l'indice dell'elemento che si vuole modificare");
                    int indice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il tuo comune:");
                    string q = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo provincia:");
                    string w = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo regione:");
                    string e = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo nome:");
                    string m = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo anno:");
                    string t = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo Data:");
                    string y = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo Identificatore:");
                    string u = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo Longitudine:");
                    string f = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo Latitudine:");
                    string o = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo Mio vaore:");
                    string ls = Console.ReadLine();
                    class1.Modifica(indice,q, w, e, m, t, y, u, f, o, ls);
                    break;
            }
            Console.Read();




        }
       
      
       

       
        
    }
}

