﻿namespace CreatingFormwithTaghelper.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int age{ get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public string Married { get; set; }
        public string Description { get; set; }

    }
    public enum Gender
    {
        MALE,FEMALE
    }
}
