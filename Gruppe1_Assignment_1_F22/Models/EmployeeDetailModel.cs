﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe1_Assignment_1_F22.Models
{
	public class EmployeeDetailModel
	{
        public int Id { get; set; }
        public int UserNo { get; set; }
        public string ?Name { get; set; }
        public string ?Surname { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public string ?PositionName { get; set; }
        public string ?DepartmentName { get; set; }
        public int Salary { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime BirthDay { get; set; }
        public string ?Adress { get; set; }
        public string ?Password { get; set; }
        public string ?ImagePath { get; set; }
    }
}
