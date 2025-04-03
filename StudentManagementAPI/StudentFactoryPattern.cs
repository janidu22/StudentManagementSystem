using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementAPI
{
    public class StudentFactoryPattern<K, T> where T : class, K , new()
    {
        public static K GetInstance()
        {
            K objk;
            objk = new T();
            return objk;
        }
    }


}
