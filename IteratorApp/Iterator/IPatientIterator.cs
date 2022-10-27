using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorApp
{
    public interface IPatientIterator
    {
        bool HasNextItem();

        PatientItem GetFirstItem();

        PatientItem GetNextPatient();

    }
}
