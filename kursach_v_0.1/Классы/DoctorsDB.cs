using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_v_0._1
{
    [Serializable]
    class DoctorsDB
    {
        [DisplayName("Ид_Врача")]
        public int ID_Doctor { get; set; }
        [DisplayName("ФИО врача")]
        public string FIO { get; set; }
        [DisplayName("Возраст")]
        public int Age { get; set; }
        [DisplayName("Должность")]
        public string Post { get; set; }
        [DisplayName("Телефон")]
        public int Phone { get; set; }
        [DisplayName("Ид_Истории болезни")]
        public int ID_CaseRecord { get; set; }
        [DisplayName("Ид_Отделения")]
        public int ID_Department { get; set; }
        public DoctorsDB(int ID_Doctor, string FIO, int Age, string Post, int Phone, int ID_CaseRecord, int ID_Department)
        {
            this.ID_Doctor = ID_Doctor;
            this.FIO = FIO;
            this.Age = Age;
            this.Post = Post;
            this.Phone = Phone;
            this.ID_CaseRecord = ID_CaseRecord;
            this.ID_Department = ID_Department;
        }

        public string getFIO()
        {
            return FIO;
        }

        public DoctorsDB()
        {

        }
    }
}
