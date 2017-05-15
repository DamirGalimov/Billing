using System;
using System.Runtime.Serialization.Formatters.Binary;
using Billing;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization;


namespace Billing_View

{
    [Serializable]
    public static class SerializeElement
    {
        static BinaryFormatter formatter = new BinaryFormatter();
   
        /// <summary>
        /// Сериализация
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="file"></param>
        public static bool SaveSerialize(BillingProject file)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.dat)|*.dat";
            dialog.RestoreDirectory = true;
            if (!(dialog.FileName == null || dialog.ShowDialog() == DialogResult.Cancel))
            {
                Serializer.Serialize(file, dialog.FileName);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Десериализация
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static BillingProject OpenDeserialize()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.dat)|*.dat";
            if (!(dialog.FileName == null || dialog.ShowDialog() == DialogResult.Cancel))
            {
                try
                {
                    return Serializer.Deserialize(dialog.FileName);
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error. Empty file");
                }
            }
            return null;
        }
    }
}