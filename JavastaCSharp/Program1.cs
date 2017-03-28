using System;
using People;
using Health;

namespace JavastaCSharp
{
	class MainClass1
	{
		public static void Main (string[] args)
		{
			People.Person p = new People.Person ("Kalle", "Kononen");
			Console.WriteLine (p.ToString());
			Doctor doc = new Doctor ("Keijo", "Kutistaja", "Head Doctor");
			TreatmentQueue tq = new TreatmentQueue ("Jorvi", doc);

			Patient pat = new Patient ("Kippa", "Kipeä", 80, 110, "Lobotomy");
			tq.addPatient (pat);
			Console.WriteLine (tq);
			Console.ReadKey();
		}
	}
}
