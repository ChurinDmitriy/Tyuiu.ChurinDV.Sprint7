using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.ChurinDV.Sprint7.Project.V6.Lib
{
    public class Patient
    {
        public string Familia { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public int Number { get; set; }
        public DateTime Birthday { get; set; }
    }


    public class PatientRepository
    {
        private const string PatientsFilePath = "patientsbase.csv";

        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (StreamReader reader = new StreamReader(PatientsFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');

                    if (values.Length == 5)
                    {
                        Patient patient = new Patient();
                        patient.Familia = values[0];
                        patient.Name = values[1];
                        patient.Otch = values[2];
                        patient.Number = int.Parse(values[3]);
                        patient.Birthday = DateTime.Parse(values[7]);

                        patients.Add(patient);
                    }
                }
            }
            return patients;
        }
    }
}
