using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3;
public class Terapist : Dentists
{
    string surname = "Федоров";
    string name = "Даниил";
    string patronymic = "Павлович";
    int age = 17;
    int experience = 4;
    string university = "ОГМУ";
    public Terapist(string surname)
    {
        this.surname = surname;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {surname} {name} {patronymic} Возраст: {age} Стаж: {experience} Место учебы: {university}");
    }
}
