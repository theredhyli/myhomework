using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3; 
public abstract class Dentists
{
    string surname { get; set; } = "Неизвестно";
    string name { get; set; } = "Неизвестно";
    string patronymic { get; set; } = "Неизвестно";
    int age { get; set; } = 1;
    int experience { get; set; } = 1;
    string university { get; set; } = "Неизвестно";
    public void DiagnosisPatient(Patient patient)
    {
        Console.WriteLine("Есть ли у вас жалобы? ДА - 1, НЕТ - 2");
        if (Int32.TryParse(Console.ReadLine(), out int patientcomplaints) && (1 <= patientcomplaints) && (patientcomplaints <= 2))
        {
            if (patientcomplaints == 1)
            {
                patient.health = "Болен. Вам нужен будет повторный прием"; 
            }
            else
            {
                patient.health = "Здоров";
            }
        }
        else
        {
            throw new Exception("/nВведено не то число!");
        }
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {surname} {name} {patronymic} Возраст: {age} Стаж: {experience} Место учебы: {university}");
    }
}
