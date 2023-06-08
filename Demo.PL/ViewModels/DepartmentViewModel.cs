﻿using Demo.DAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Demo.PL.ViewModels
{
    // View Model
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is Required!")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is Required!")]
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }

        // Navigational Property [Many]
        ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
