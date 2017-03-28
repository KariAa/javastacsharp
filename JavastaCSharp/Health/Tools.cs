using System;

namespace Health
{
	public class Tools
	{
		public const int KORKEA_ALAPAINE = 90;
		public const int KORKEA_YLAPAINE = 140;

		public static string calculatePressureDescription (int systolic, int diastolic)
		{ 
			string kuvaus; 
			if (systolic < KORKEA_ALAPAINE && diastolic < KORKEA_YLAPAINE) { 
				kuvaus = "normaali verenpaine";
			} else if (systolic > KORKEA_ALAPAINE && diastolic > KORKEA_YLAPAINE) { 
				kuvaus = "korkeat verenpaineet";
			} else {
				kuvaus = "tarkkailtavalla tasolla";
			} 
			return kuvaus;
		}


	}
}

