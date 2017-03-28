using System;
using People;
using System.Collections.Generic;

namespace JavastaCSharp
{
	public class TreatmentQueue
	{
		private string sairaala;
		private Doctor tohtori;
		private List<Patient> potilasjono = new List<Patient>();

		public TreatmentQueue (string sairaala, Doctor tohtori)
		{
			this.sairaala = sairaala;
			this.tohtori = tohtori;
		}
		public void addPatient(Patient pat){
			this.potilasjono.Add(pat);
		}
		override public string ToString(){
			string temp =  "SAIRAALA: " + this.sairaala +
			"\nVastaava lääkäri: " + this.tohtori +
			"\nPotilasjono ";
			foreach (Patient p in this.potilasjono) {
				temp += p + "\n";
			}
			return temp;
		}
	}
}

