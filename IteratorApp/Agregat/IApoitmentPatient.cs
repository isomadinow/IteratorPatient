

namespace IteratorApp.Agregat
{
    /// <summary>
    /// Предстваляет объекты для работы со пациентами.
    /// </summary>
    public interface IApoitmentPatient
    {
      
        /// <summary>
        /// Количество пациентов
        /// </summary>
        int CountPatient { get; }
      
        /// <summary>
        /// Добавляем нового пациента.
        /// </summary>
        /// <param name="patient"></param>
        void AddNewPatientItem(PatientItem patient);
     
        /// <summary>
        /// Принимаем пациентов по имени.
        /// </summary>
        /// <param name="fullName"> ФИО Пациента</param>
        PatientItem TakePatientItemByName(string fullName);

        /// <summary>
        /// Принимаем пациента по приоритету.
        /// </summary>
        /// <param name="priorety">Приоритет</param>
        int GetEmptyPlaceReception();
        PatientItem TakePatientItemByPriorety(PatientItem.Priorety priorety);
        /// <summary>
        /// Возвращает из приёмной пациента с указанным кодом
        /// </summary>
        /// <param name="p">Код пациента</param>
        PatientItem this[int p] { get; }
      
        /// <summary>
        /// Примаем пациениа в порядке очереди.
        /// </summary>
        PatientItem TakePatientItemByStack();
    
         /// <summary>
         /// Создаём объект итератор.
        /// </summary>
        IPatientIterator CreateIterator();



    }
}
