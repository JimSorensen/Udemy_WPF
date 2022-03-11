using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe1_Assignment_1_F22.Models
{
	public class PositionModel
	{
		public int Id { get; set; }
		public string PositionName { get; set; }
		public string DepartmentName { get; set; }
		public int DepartmentId { get; set; }
	}
}
