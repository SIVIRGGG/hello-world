using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace kursach_v_0._1
{
    class DbData4
    {
        private BindingList<MServicesDB> data;
        public DbData4()
        {
            data = new BindingList<MServicesDB>();
        }
        public void AddData(MServicesDB item)
        {
            data.Add(item);
        }
        public void SaveToFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://MServicesDB.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bf.Serialize(fStream, data);
            }
        }
        public void LoadFromFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://MServicesDB.dat", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                data = (BindingList<MServicesDB>)bf.Deserialize(fStream);
            }
        }
        public void Sort()
        {
            data = new BindingList<MServicesDB>(data.OrderBy(value => value.MeditsinsikeServices).ToList());
        }
        public void Sort1()
        {
            data = new BindingList<MServicesDB>(data.OrderByDescending(value => value.MedicalProcedure).ToList());
        }
        public BindingList<MServicesDB> getData()
        {
            return data;
        }
    }
}
