// See https://aka.ms/new-console-template for more information

Console.WriteLine("Titolo: ");
string Titolo = Console.ReadLine();

Console.WriteLine("Autore: ");
string Autore = Console.ReadLine();

Console.WriteLine("ISBN: ");
long ISBN = Int32.Parse(Console.ReadLine());

Console.WriteLine("NumeroPagine: ");
int NumeroPagine = Int32.Parse(Console.ReadLine());

Console.WriteLine("PesoLibro: ");
int PesoLibro = Int32.Parse(Console.ReadLine());

Console.WriteLine("larghezza: ");
double larghezza = double.Parse(Console.ReadLine());

Console.WriteLine("Profondità: ");
double Profondità = double.Parse(Console.ReadLine());

Console.WriteLine("Altezza: ");
double Altezza = double.Parse(Console.ReadLine());

Console.WriteLine("Recensione: ");
double Recensione = double.Parse(Console.ReadLine());

Console.WriteLine("NumeroRecensioni: ");
int NumeroRecensioni = Int32.Parse(Console.ReadLine());

Console.WriteLine("VersioneKindle: Si/No ");
string VersioneKindle = "";
do
{
    VersioneKindle = Console.ReadLine();
} while ((VersioneKindle != "Si" && VersioneKindle != "No"));


Console.WriteLine("CopertinaFlessibile: Si/No ");
string CopertinaFlessibile = "";
do
{
   CopertinaFlessibile = Console.ReadLine();
} while ((CopertinaFlessibile != "Si" && CopertinaFlessibile != "No"));


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
