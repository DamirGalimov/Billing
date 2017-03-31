using System;
using System.Runtime.Serialization.Formatters.Binary;
using Billing;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization;


namespace Billing_View

{
    public static class Serializer
    {
        static BinaryFormatter formatter = new BinaryFormatter();

        /// <summary>
        /// Сериализация
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="file"></param>
        public static void Serialize(string fileName, List<IEmployee> file)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, file);
            }
        }

        /// <summary>
        /// Десериализация
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<IEmployee> Deserialize(string fileName)
        {
            
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    {
                        List<IEmployee> file = (List<IEmployee>) formatter.Deserialize(fs);
                        return file;
                    }
                    
                }
        }
    }
}