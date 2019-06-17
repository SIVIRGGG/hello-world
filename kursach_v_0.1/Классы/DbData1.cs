using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace kursach_v_0._1
{
    class DbData1
    {
        private BindingList<CaseRecordBD> data;
        public DbData1()
        {
            data = new BindingList<CaseRecordBD>();
        }
        public void AddData(CaseRecordBD item)
        {
            data.Add(item);
        }
        public void SaveToFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://CaseRecordBD.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bf.Serialize(fStream, data);
            }
        }
        public void LoadFromFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://CaseRecordBD.dat", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                data = (BindingList<CaseRecordBD>)bf.Deserialize(fStream);
            }
        }
        public void Sort()
        {
            data = new BindingList<CaseRecordBD>(data.OrderByDescending(value => value.FIO).ToList());
        }
        public void Sort1()
        {
            data = new BindingList<CaseRecordBD>(data.OrderByDescending(value => value.Age).ToList());
        }
        public void Sort2()
        {
            data = new BindingList<CaseRecordBD>(data.OrderByDescending(value => value.Diagnosis).ToList());
        }
        public void Sort3()
        {
            data = new BindingList<CaseRecordBD>(data.OrderByDescending(value => value.ReceiptDate).ToList());
        }
        public BindingList<CaseRecordBD> getData()
        {
            return data;
        }
    }
}
