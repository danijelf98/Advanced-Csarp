using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventForChangingLastName
{
    public class Person
    {
		private string _lastName;
		private string _name;

		public delegate void ChangePrezimeDelegat(string oldLastName, string NewLastName);
		public event ChangePrezimeDelegat ChangeLastName;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string LastName
		{
			get { return _lastName; }
			set
			{
				if (value != _lastName && !string.IsNullOrWhiteSpace(_lastName))
				{
					if (ChangeLastName != null)
					{
						ChangeLastName(_lastName, value);
					}
				}
				_lastName = value; 
			}
		}


	}
}
