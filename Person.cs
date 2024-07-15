using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.models
{
    internal class Person
    {
        private int _id;
        private string _name;
        private int _age;
        private double _height;
        private double _weight;
        private string _title;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        //Constructor which has all the attributes
        public Person(int id, string name, int age, double height, double weight, string title)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Title = title;
        }
        //Constructor with default values for height weight and title
        public Person(int id, string name, int age) : this(id, name, age, 152.4, 50.0, "Person Details")
        { }

        //Actual calculation of BMI 
        public double CalculateBMI()
        {
            double convertedHeight = Height / 100.0;
            double bmi = Weight / (convertedHeight * convertedHeight);
            return bmi;
        }

        //Retrive the Body type based on the BMI value of the person
        public string GetBodyType()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5)
                return "Under Weight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                return "Normal Weight";
            else if (bmi >= 25 && bmi <= 29.9)
                return "Over Weight";
            else
                return "Obese";
        }

        public override string ToString()
        {
            return $"\n=========={Title}==========" +
            $"\nDetails of Age, Height & Weight of {Name} is as follows: " +
                $"\nAge: {Age}" +
                $"\nHeight: {Height} " +
                $"\nWeight: {Weight}" +
                $"\nBMI(Body Mass Indxed) based on the above data is: {CalculateBMI()} & " +
                $"their Body Type is {GetBodyType()}";
        }
    }
}
