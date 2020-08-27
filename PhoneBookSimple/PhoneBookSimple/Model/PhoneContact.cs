using System.Collections.Generic;

namespace PhoneBookSimple.Model
{
	public class PhoneContact
	{
		public string name { get; set; }
		public string phone_number { get; set; }
		public string address { get; set; }
	}

	public class PhoneRoot
	{
		public List<PhoneContact> contacts { get; set; }
	}
}
