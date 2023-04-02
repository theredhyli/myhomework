using System;

namespace HomeWork3;
public static class Program
{ 
    public static void Main()
    {
        Console.WriteLine("Введите Фамилию, Имя, Отчество, Возраст, Город проживания пациента");
        var patientSurname = Console.ReadLine() ?? "Неизвестно";
        var patientName = Console.ReadLine() ?? "Неизвестно";
        var patientPatronymic = Console.ReadLine() ?? "Неизвестно";
        int patientAge;
        while (!int.TryParse(Console.ReadLine(), out patientAge) || (patientAge<1) || (patientAge>120))
        {
            Console.WriteLine("Ошибка! Введите возраст");
        }
        var patientCityOfresidence = Console.ReadLine() ?? "Неизвестно";
        Console.Clear();
        var patient = new Patient(patientSurname, patientName, patientPatronymic, patientAge, patientCityOfresidence);
        patient.DisplayInfo();
        patient.ChooseADentist();
        Console.WriteLine("Вы выбрали врача и автоматически встали в очередь!");
        Dentists dentist1 = new Terapist("Кищук");
        dentist1.DiagnosisPatient(patient);
        Console.WriteLine($"Ваш статус здоровья: {patient.health}");
        Console.WriteLine("Хотите оставить отзыв о докторе? ДА - 1, НЕТ - 2");
        if (Int32.TryParse(Console.ReadLine(), out int soglasie) && (1 <= soglasie) && (soglasie <= 2))
        {
            if (soglasie == 1)
            {
               patient.DentistsRewiew(); 
            }
            if (soglasie == 2)
            {
                Console.WriteLine("Спасибо, что были на приеме у доктора!");
            }
        }
        else throw new Exception("Выберите число из перечисленных!");
    }
}
