using IteratorApp.Agregat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Работа с шаблоном Итератор";
            IApoitmentPatient apoitmentFirst = new ReceptionPatient(5);
            
            AdddNewPatient(apoitmentFirst, "Никита З.", "Мужской", new DateTime(2002, 12, 11), PatientItem.Priorety.low);
            AdddNewPatient(apoitmentFirst, "Никита З.", "Мужской", new DateTime(2002, 12, 11), PatientItem.Priorety.low);
            AdddNewPatient(apoitmentFirst, "Хидиров А.", "Мужской", new DateTime(2002, 12, 11), PatientItem.Priorety.medium);
            AdddNewPatient(apoitmentFirst, "Глеб М.", "Мужской", new DateTime(2002, 10, 11), PatientItem.Priorety.medium);
            AdddNewPatient(apoitmentFirst, "Исомадинов А", "Мужской", new DateTime(2002, 12, 8), PatientItem.Priorety.hight);
            
            Console.WriteLine("Содержимое 1-ой приёмной\n");
            Console.WriteLine();
       
            ShowPatient(apoitmentFirst);
            Console.WriteLine();
            
            Console.WriteLine($"Количество мест в приёмной:{apoitmentFirst.CountPatient}");
            
            Console.WriteLine();
            string itemName = "Глеб М.";
            
            Console.WriteLine($"Принимаем пациента с именем {itemName}");
            apoitmentFirst.TakePatientItemByName(itemName);

            ShowPatient(apoitmentFirst);
            Console.WriteLine();
            var pr = PatientItem.Priorety.medium;
            Console.WriteLine($"Принимаем пациентов с приоритетом {pr}");

            apoitmentFirst.TakePatientItemByPriorety(pr);
            ShowPatient(apoitmentFirst);
            Console.WriteLine();
            Console.WriteLine($"Количество пустых мест в приёмной {apoitmentFirst.GetEmptyPlaceReception()}");


            Console.WriteLine("-------------------------------------------------------------");

            IApoitmentPatient apoitmentSecond = new ReceptionPatient(5);

            AdddNewPatient(apoitmentSecond, "Кабанов В.", "Мужской", new DateTime(2002, 12, 11), PatientItem.Priorety.low);
            AdddNewPatient(apoitmentSecond, "Кабанов В.", "Мужской", new DateTime(2002, 12, 11), PatientItem.Priorety.low);
            AdddNewPatient(apoitmentSecond, "Иван К.", "Мужской", new DateTime(2002, 12, 11), PatientItem.Priorety.medium);
            AdddNewPatient(apoitmentSecond, "Максимова Г.", "Женский", new DateTime(2002, 10, 11), PatientItem.Priorety.medium);
            AdddNewPatient(apoitmentSecond, "Шнайдера Л", "Женский", new DateTime(2002, 12, 8), PatientItem.Priorety.hight);

            Console.WriteLine("Содержимое 2-ой приёмной\n");

            ShowPatient(apoitmentSecond);
            Console.WriteLine();

            Console.WriteLine($"Количество мест в приёмной:{apoitmentSecond.CountPatient}");

            Console.WriteLine();
            itemName = "Кабанов В.";

            Console.WriteLine($"Принимаем пациента с именем {itemName}");
            apoitmentSecond.TakePatientItemByName(itemName);

            ShowPatient(apoitmentSecond);
            Console.WriteLine();
            pr = PatientItem.Priorety.low;
            Console.WriteLine($"Принимаем пациентов с приоритетом {pr}");

            apoitmentSecond.TakePatientItemByPriorety(pr);
            ShowPatient(apoitmentSecond);

            Console.WriteLine($"Принимаем пациентов по очереди");
            apoitmentSecond.TakePatientItemByStack();
            ShowPatient(apoitmentSecond);

            Console.WriteLine();
            Console.WriteLine($"Количество пустых мест в приёмной {apoitmentSecond.GetEmptyPlaceReception()}");
            Console.ReadLine();
        }


        static void AdddNewPatient(IApoitmentPatient apoitment, string fullName,
            string gender, DateTime date, PatientItem.Priorety pry)
        {
            apoitment.AddNewPatientItem(new PatientItem()
            {
                FullName = fullName,
                Gender = gender,
                DateBirthday = date,
                priorety = pry
            }
              );
        }

        static void ShowPatient(IApoitmentPatient apoitment)
        {
            IPatientIterator patientIterator = apoitment.CreateIterator();
            PatientItem firstItem = patientIterator.GetFirstItem();
            if(firstItem != null)
            {
                Console.WriteLine(patientIterator.GetFirstItem().ToString());
            }
            else
            {
                Console.WriteLine("Пусто");
            }
            while(patientIterator.HasNextItem() == true)
            {
                PatientItem item = patientIterator.GetNextPatient();
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                }
                else { Console.WriteLine("Пусто");  }
            }
            Console.WriteLine();

        }
    }
}
