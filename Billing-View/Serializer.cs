using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Billing_View
{
    public static class Serializer
    {
        static BinaryFormatter formatter = new BinaryFormatter();

        /// <summary>
        /// Сериализация
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fileName"></param>
        public static void Serialize(BillingProject file, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, file);
                file.Filename = fileName;
            }
        }

        /// <summary>
        /// Десериализация
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static BillingProject Deserialize(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                {
                    BillingProject file = (BillingProject)formatter.Deserialize(fs);
                    file.Filename = fileName;
                    return file;
                }
            }
        }
    }
}
