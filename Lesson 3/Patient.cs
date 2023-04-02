using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3;
public class Patient
{
    string surname = "Неизвестно";
    string name = "Неизвестно";
    string patronymic = "Неизвестно";
    int age;
    string cityOfresidence = "Неизвестно";
    public string health = "Неизвестно";
    public Patient(string surname, string name, string patronymic, int age, string cityOfresidence)
    {
        this.surname = surname;
        this.name = name;
        this.patronymic = patronymic;
        this.age = age;
        this.cityOfresidence = cityOfresidence;
    }
    public Patient(string health)
    {
        this.health = health;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Фамилия: {surname} Имя: {name} Отчество: {patronymic} Возраст: {age} Город проживания: {cityOfresidence}");
    }
    public void ChooseADentist()
    {
        Console.WriteLine("К какому стоматологу вы хотите обратиться? Введите число: Терапевт - 1, ортопед - 2, хирург - 3");
        if (Int32.TryParse(Console.ReadLine(), out int numberdoctors) && (1<=numberdoctors) && (numberdoctors<=3))
        {
            if (numberdoctors == 1)
            {
                Terapist dentist1 = new Terapist("Федоров");
                dentist1.DisplayInfo();
            }
            if (numberdoctors == 2)
            {
                Dentists dentist2 = new Ortoped("Иванов");
                dentist2.DisplayInfo();
            }
            if (numberdoctors == 3)
            {
                Surgeon dentist3 = new Surgeon("Петров");
                dentist3.DisplayInfo();
            }
        }
        else throw new Exception("Выберите число из перечисленных!");
    }
    public void DentistsRewiew()
    {
        Console.WriteLine("Вы можете оставить отзыв");
        var rewiew = Console.ReadLine();
        Console.WriteLine("Ваш отзыв принят");
    }
}  
   
