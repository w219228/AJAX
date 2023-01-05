﻿using EmployeeService.Models;

namespace EmployeeService.DTOs
{
	public class EmployeeDTO 
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }
}