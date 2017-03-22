using System.Runtime.Serialization.Formatters.Binary;
using Billing;
using System.IO;
using System.Collections.Generic;


namespace Billing_View

{
    public static class Serialization
    {
        static BinaryFormatter formatter = new BinaryFormatter();

        public static void Serialize(string fileName, List<IEmployee> file)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, file);
            }
        }


        public static List<IEmployee> Deserialize(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                List<IEmployee> file = (List<IEmployee>)formatter.Deserialize(fs);
                return file;
            }
        }
    }
}