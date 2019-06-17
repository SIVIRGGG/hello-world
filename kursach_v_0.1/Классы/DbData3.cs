using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace kursach_v_0._1
{
    class DbData3
    {
        private BindingList<DepartmentDB> data;
        public DbData3()
        {
            data = new BindingList<DepartmentDB>();
        }
        public void AddData(DepartmentDB item)
        {
            data.Add(item);
        }
        public void SaveToFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://DepartmentDB.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bf.Serialize(fStream, data);
            }
        }
        public void LoadFromFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fStream = new FileStream("D://DepartmentDB.dat", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                data = (BindingList<DepartmentDB>)bf.Deserialize(fStream);
            }
        }
        public void Sort()
        {
            data = new BindingList<DepartmentDB>(data.OrderByDescending(value => value.Name).ToList());
        }
        public void Sort1()
        {
            data = new BindingList<DepartmentDB>(data.OrderByDescending(value => value.NumberOfSeats).ToList());
        }
        public void Sort2()
        {
            data = new BindingList<DepartmentDB>(data.OrderByDescending(value => value.NumberOfFreePlaces).ToList());
        }
        public BindingList<DepartmentDB> getData()
        {
            return data;
        }
    }
}
