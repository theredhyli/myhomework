using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3;
public class Surgeon : Dentists
{
    string surname = "Петров";
    string name = "Глеб";
    string patronymic = "Игоревич";
    int age = 48;
    int experience = 40;
    string university = "СибГМУ";
    public Surgeon(string surname)
    {
        this.surname = surname;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {surname} {name} {patronymic} Возраст: {age} Стаж: {experience} Место учебы: {university}");
    }
}