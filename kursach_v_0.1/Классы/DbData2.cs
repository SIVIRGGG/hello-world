using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace kursach_v_0._1
{
    class DbData2
    {
        private BindingList<DoctorsDB> data;
        public DbData2()
        {
            data = new BindingList<DoctorsDB>();
        }
        public void AddData(DoctorsDB item)
        {
            data.Add(item);
        }
        public void SaveToFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://DoctorsDB.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bf.Serialize(fStream, data);
            }
        }
        public void LoadFromFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://DoctorsDB.dat", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                data = (BindingList<DoctorsDB>)bf.Deserialize(fStream);
            }
        }
        public void Sort()
        {
            data = new BindingList<DoctorsDB>(data.OrderByDescending(value => value.FIO).ToList());
        }
        public void Sort1()
        {
            data = new BindingList<DoctorsDB>(data.OrderByDescending(value => value.Post).ToList());
        }
        public BindingList<DoctorsDB> getData()
        {
            return data;
        }
    }
}
