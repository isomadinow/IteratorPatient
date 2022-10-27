using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorApp.Agregat
{
    public class ReceptionPatient : IApoitmentPatient
    {
        int countPatient;//Кол-во пациентов.
        PatientItem[] items;//Пациенты.
        public ReceptionPatient()
        {
            countPatient = 10;
            items = new PatientItem[countPatient];
        }
        public ReceptionPatient(int countPatient)
        {
            this.countPatient = countPatient;
            items = new PatientItem[countPatient];
        }

        public int CountPatient
        {
            get { return countPatient; }
        }

        public PatientItem this[int index]
        {
            get { if (index > 0 && index < countPatient) 
                {
                    return items[index];
                }
            else return null;
            }
        }


        public void AddNewPatientItem(PatientItem newItem)
        {
            for (int i = 0; i < countPatient; i++)
            {
                if (items[i] == null)
                {
                    items[i] = newItem;
                    break;
                }
            }
        }

        public IPatientIterator CreateIterator()
        {
            return new DoctorPatientIterator(this);
        }

        public PatientItem TakePatientItemByName(string fullName)
        {
            PatientItem patientItem = null;
            for (int i = 0; i < countPatient; i++)
            {
                if (items[i].FullName == fullName)
                {
                    patientItem = items[i];
                    items[i] = null;
                    break;
                }
            }
            return patientItem;
        }

        public PatientItem TakePatientItemByPriorety(PatientItem.Priorety prity)
        {

            PatientItem patientitem = null;
            for (int i = 0; i < countPatient; i++)
            {
                if (items[i] != null)
                {
                    if (items[i].priorety == prity)
                    {
                        patientitem = items[i];
                        items[i] = null;
                        break;
                    }
                }
                
            }
            return patientitem;

        }

        public PatientItem TakePatientItemByStack()
        {
            PatientItem patientItem = null;
            for (int i = 0; i < countPatient; i++)
            { 
                if (items[i] != null)
                {
                    patientItem = items[i];
                    items[i] = null;
                    break;
                }
            }
            return patientItem;

        }

        public int GetEmptyPlaceReception()
        {
            int emptyCount = 0;
            foreach (var item in items)
            {
                if(item == null)
                {
                    emptyCount++;
                }
            }
            return emptyCount;
            
        }
    }
}
