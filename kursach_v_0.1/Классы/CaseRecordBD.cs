using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_v_0._1
{
    [Serializable]
    class CaseRecordBD
    {
        [DisplayName("Ид_Истории болезни")]
        public int ID_CaseRecord { get; set; }
        [DisplayName("ФИО пациента")]
        public string FIO { get; set; }
        [DisplayName("Пол")]
        public string Sex { get; set; }
        [DisplayName("Возраст")]
        public int Age { get; set; }
        [DisplayName("Адрес")]
        public string Address { get; set; }
        [DisplayName("Телефон")]
        public int Phone { get; set; }
        [DisplayName("Диагноз")]
        public string Diagnosis { get; set; }
        [DisplayName("Дата поступления")]
        public string ReceiptDate { get; set; }
        [DisplayName("Дата выписки")]
        public string DateOfIssue { get; set; }
        [DisplayName("Ид_Врача")]
        public int ID_Doctors { get; set; }
        [DisplayName("Ид_Отделения")]
        public int ID_Department { get; set; }
        public CaseRecordBD(int ID_CaseRecord, string FIO, string Sex, int Age, string Address, int Phone, string Diagnosis, string ReceiptDate, string DateOfIssue, int ID_Doctors, int ID_Department)
        {
            this.ID_CaseRecord = ID_CaseRecord;
            this.FIO = FIO;
            this.Sex = Sex;
            this.Age = Age;
            this.Address = Address;
            this.Phone = Phone;
            this.Diagnosis = Diagnosis;
            this.ReceiptDate = ReceiptDate;
            this.DateOfIssue = DateOfIssue;
            this.ID_Doctors = ID_Doctors;
            this.ID_Department = ID_Department;
        }
        public CaseRecordBD()
        {

        }
    }
}
