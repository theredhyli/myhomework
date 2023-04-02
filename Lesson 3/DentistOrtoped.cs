using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork3;
public class Ortoped : Dentists
{
    string surname = "Иванов";
    string name = "Сергей";
    string patronymic = "Иванович";
    int age = 24;
    int experience = 5;
    string university = "НГМУ";
    public Ortoped(string surname)
    {
        this.surname = surname;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {surname} {name} {patronymic} Возраст: {age} Стаж: {experience} Место учебы: {university}");
    }
}

