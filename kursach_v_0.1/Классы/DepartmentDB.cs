using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_v_0._1
{
    [Serializable]
    class DepartmentDB
    {
        [DisplayName("Ид_Отделения")]
        public int ID_Department { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Количество персонала")]
        public int NumberOfStaff { get; set; }
        [DisplayName("Телефон")]
        public int Phone { get; set; }
        [DisplayName("Количество мест")]
        public int NumberOfSeats { get; set; }
        [DisplayName("Количество свободных мест")]
        public int NumberOfFreePlaces { get; set; }
        [DisplayName("Ид_Истории болезни")]
        public int ID_CaseRecord { get; set; }
        public DepartmentDB(int ID_Department, string Name, int NumberOfStaff, int Phone, int NumberOfSeats, int NumberOfFreePlaces, int ID_CaseRecord)
        {
            this.ID_Department = ID_Department;
            this.Name = Name;
            this.NumberOfStaff = NumberOfStaff;
            this.Phone = Phone;
            this.NumberOfSeats = NumberOfSeats;
            this.NumberOfFreePlaces = NumberOfFreePlaces;
            this.ID_CaseRecord = ID_CaseRecord;
        }
        public DepartmentDB()
        {

        }
    }
}
