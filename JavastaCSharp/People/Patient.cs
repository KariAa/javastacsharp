using System;
using Health;
using People;

namespace People
{
	public class Patient:Person
	{
		private int systolic; //yläpaine 
		private int diastolic; //alapaine private 
		string pressureDescription;
		string operation;
			
		public Patient(string firstname,string lastname, int systolic, int diastolic, string operation) : base (firstname,lastname) { 
			this.systolic = systolic;
			this.diastolic = diastolic; 
			this.operation = operation;
			this.defineBloodPressureLevel(); 
		}
		private void defineBloodPressureLevel() { 
			this.pressureDescription = Tools.calculatePressureDescription(this.systolic, this.diastolic); 
		}
		public override string ToString ()
		{
			return base.ToString () + "\n - verenpaineet " + this.diastolic + " - " + this.systolic + ", " +
			this.pressureDescription
			+ "\n - operaatio " + this.operation;
		}
	}
}

