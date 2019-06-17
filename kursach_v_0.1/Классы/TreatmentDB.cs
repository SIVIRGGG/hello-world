using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_v_0._1
{
    [Serializable]
    public class TreatmentDB
    {
        [DisplayName("Ид_Лечения")]
        public int ID_Treatmet { get; set; }
        [DisplayName("ФИО пациента")]
        public string FIO { get; set; }
        [DisplayName("Лечение")]
        public string Treatmet { get; set; }
        [DisplayName("Дата лечения")]
        public string ЕreatmentDate { get; set; }
        [DisplayName("Ид_Истории белезни")]
        public int ID_CaseRecord { get; set; }
        public TreatmentDB(int ID_Treatmet, string FIO, string Treatmet, string ЕreatmentDate, int ID_CaseRecord)
        {
            this.ID_Treatmet = ID_Treatmet;
            this.FIO = FIO;
            this.Treatmet = Treatmet;
            this.ЕreatmentDate = ЕreatmentDate;
            this.ID_CaseRecord = ID_CaseRecord;
        }
        public TreatmentDB()
        {

        }


    }
}
