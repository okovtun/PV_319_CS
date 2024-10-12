using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Graduate:Student
	{
		public string Subject { get; set; }
		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,
			string subject
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Subject = subject;
			Console.WriteLine($"GConstructor:\t{GetHashCode()}");
		}
		~Graduate()
		{
			Console.WriteLine($"GDestructor:\t{GetHashCode()}");
		}
		public override string ToString()
		{
			return base.ToString() + Subject;
		}
		public override string ToFileString()
		{
			return base.ToFileString()+$",{Subject}";
		}
	}
}
