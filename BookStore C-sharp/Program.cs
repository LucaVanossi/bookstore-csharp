// See https://aka.ms/new-console-template for more information

string Titolo = "CLEAN CODE";
string Autore = "Robert C.Martin";
long ISBN = 9780132350884;
int NumeroPagine = 431;
int PesoLibro = 660;
double larghezza = 17.91;
double Profondità = 2.54;
double Altezza = 23.5;
double Recensione = 4.7;
int NumeroRecensioni = 3309;
bool VersioneKindle = true;
bool CopertinaFlessibile = true;

Console.WriteLine("--- IL LIBRO DI OGGI: " + Titolo + " di " + Autore);
Console.WriteLine("Informazioni Generiche:");
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Numero delle pagine: " + NumeroPagine);
Console.WriteLine("Peso del Libro: " + PesoLibro + " g");
Console.WriteLine("Dimensioni del libro: " + larghezza + " cm x " + Altezza + " cm x " + Profondità + " cm");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + NumeroRecensioni + " recensioni");
Console.WriteLine("Valutazione media: " + Recensione + " stelline");
Console.WriteLine("Kindle disponibile: " + VersioneKindle);
Console.WriteLine("Copertina flessibile disponibile: " + CopertinaFlessibile);