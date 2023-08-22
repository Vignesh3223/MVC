using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task_2108.Models;

namespace Task_2108.ViewModel
{
    public class Employee
    {
        public Trainer Trainers { get; set; }
        public Trainee Trainees { get; set; }
    }
}