using IteratorApp.Agregat;

namespace IteratorApp
{
    /// <summary>
    /// Представляет объекты - итераторы для перебора содержимых пациентов.
    /// </summary>
    public class DoctorPatientIterator:IPatientIterator
    {
        IApoitmentPatient apoitment; //Приёмная
        int currentPatient;//текущий пациент

        /// <summary>
        /// Конструктор класса Доктор-Итератор
        /// </summary>
        /// <param name="apoitment"> Приём </param>
        public DoctorPatientIterator(IApoitmentPatient apoitment)
        {
            this.apoitment = apoitment;
            currentPatient = 0;
        }

        /// <summary>
        /// Проверка наличие следующего пациента.
        /// </summary>
        /// <returns> Возвращает резултать проверки. </returns>
        public bool HasNextItem() => currentPatient < apoitment.CountPatient-1;
        
        public PatientItem GetFirstItem()
        {
            PatientItem item = null;
            if (apoitment.CountPatient > 0)
            {
                item = apoitment[0];
            }
            return item;
        }

        public PatientItem GetNextPatient()
        {
            PatientItem item = null;
            if (currentPatient < apoitment.CountPatient - 1)
            {
                currentPatient++;
                item = apoitment[currentPatient];
            }
            return item;
        }

    }
}
