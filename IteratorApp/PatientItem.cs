using System;

namespace IteratorApp
{
    public class PatientItem
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateBirthday { get; set; }

        public Priorety priorety { get; set; }
        public enum Priorety 
        {
            low,
            medium,
            hight

        }

       
        public override string ToString()
        {
            return string.Format($"ФИО:{FullName}\nПол:{Gender}\n" +
                $"Дата рождение:{DateBirthday}\nПриоритет: {priorety}\n");
        } 
    }
}
