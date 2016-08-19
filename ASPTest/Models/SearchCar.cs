using System;

namespace ASPTest.Models
{
	public class SearchCar
	{
		public string ModelFind { get; set; }
		public string BrandFind { get; set; }

		public bool IsEmpty()
		{
			if (String.IsNullOrEmpty(ModelFind) || String.IsNullOrEmpty(BrandFind))
				return true;
			return false;
		}
	}
}