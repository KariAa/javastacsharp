using System;


namespace People
{
	public class Doctor:Person
	{	private string title;
		public Doctor (string firstname, string lastname, string title):base(firstname, lastname)
		{
			this.title = title;
		}
		override public string ToString(){
			return base.ToString() + ", " + this.title;

		}
	}
}

