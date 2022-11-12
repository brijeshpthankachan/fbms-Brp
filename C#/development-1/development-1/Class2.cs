namespace development_1
{
	internal class Student
	{

		public string? Name { get; set; }

		//private int _age;

		//public int Age
		//{
		//	get { return _age; }
		//	set { 
		//		if(value > 100)
		//		{
		//			Console.WriteLine("Invalid Age");
		//			return;
		//		}
		//		_age = value;
		//	}
		//}

		private int _age;

		public int Age
		{

			get { return _age; }
			set
			{
				if (Age < 100)
				{
					Console.WriteLine("invalid value");
					return;
				}
				_age = value;
			}
		}

	

	}
}