using System;

namespace People
{
	public class Person
	{
		private string firstname;
		private string lastname;
		public Person (string firstname, string lastname)
		{
			this.firstname = firstname;
			this.lastname = lastname;
		}
		override public string ToString(){
			return this.firstname +" "+this.lastname;
		}
	}
}

