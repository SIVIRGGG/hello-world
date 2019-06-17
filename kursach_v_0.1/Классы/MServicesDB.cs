using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_v_0._1
{
    [Serializable]
    class MServicesDB
    {
        [DisplayName("Ид_Услуги и процедуры")]
        public int ID_MServices { get; set; }
        [DisplayName("Медицинская услуга")]
        public string MeditsinsikeServices { get; set; }
        [DisplayName("Лечебная процедура")]
        public string MedicalProcedure { get; set; }
        [DisplayName("Отделение")]
        public string Department { get; set; }
        [DisplayName("Ид_Лечения")]
        public int ID_Treatment { get; set; }
        [DisplayName("Ид_Врача")]
        public int ID_Doctors { get; set; }
        public MServicesDB(int ID_MServices, string MeditsinsikeServices, string MedicalProcedure, string Department, int ID_Treatment, int ID_Doctors)
        {
            this.ID_MServices = ID_MServices;
            this.MeditsinsikeServices = MeditsinsikeServices;
            this.MedicalProcedure = MedicalProcedure;
            this.Department = Department;
            this.ID_Treatment = ID_Treatment;
            this.ID_Doctors = ID_Doctors;
        }
        public MServicesDB()
        {

        }
    }
}
