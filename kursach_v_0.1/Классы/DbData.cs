using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace kursach_v_0._1
{
    class DbData
    {
        private BindingList<TreatmentDB> data;

        public void add(string txt1, string txt2, string txt3, string txt4, string txt5)
        {
            data.Add(new TreatmentDB(int.Parse(txt1), txt2, txt3, txt4, int.Parse(txt5)));
        }

        public DbData()
        {
            data = new BindingList<TreatmentDB>();
        }
        public void AddData(TreatmentDB item)
        {
            data.Add(item);
        }
        public void SaveToFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://TreatmentDB.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bf.Serialize(fStream, data);
            }
        }
        public void LoadFromFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://TreatmentDB.dat", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                data = (BindingList<TreatmentDB>)bf.Deserialize(fStream);
            }
        }
        public void Sort()
        {
            data = new BindingList<TreatmentDB>(data.OrderBy(value => value.FIO).ToList());
        }
        public void Sort1()
        {
            data = new BindingList<TreatmentDB>(data.OrderBy(value => value.Treatmet).ToList());
        }
        public void Sort2()
        {
            data = new BindingList<TreatmentDB>(data.OrderBy(value => value.ЕreatmentDate).ToList());
        }

        public BindingList<TreatmentDB> getData()
        {
            return data;
        }
    }
}
