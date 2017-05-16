using System;
using System.Runtime.Serialization.Formatters.Binary;
using Billing;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization;


namespace Billing_View

{
    //TODO: комментарии?
    //TODO: Зачем атрибут сериализации?
    //TODO: Название класса никак не отражает назначение класса и его принципиальное отличие от Serializer
    [Serializable]
    public static class SerializeElement
    {
        //TODO: объект не используется
        static BinaryFormatter formatter = new BinaryFormatter();

        //TODO: в xml-комментарии больше входных аргументов, чем на самом деле.
        //TODO: Некорректное название метода. Либо Save, либо Serialize - но два глагола в названии одновременно это неправильно.
        /// <summary>
        /// Сериализация
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="file"></param>
        public static bool SaveSerialize(BillingProject file)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            //TODO: общий фильтр вынести в константное поле.
            dialog.Filter = "txt files (*.dat)|*.dat";
            dialog.RestoreDirectory = true;
            if (!(dialog.FileName == null || dialog.ShowDialog() == DialogResult.Cancel))
            {
                //TODO: а здесь не могут вылететь исключения, по аналогии с OpenDeserialize()?
                Serializer.Serialize(file, dialog.FileName);
                return false;
            }
            return true;
        }

        //TODO: в xml-комментарии больше входных аргументов, чем на самом деле.
        //TODO: неправильное название метода по аналогии с SaveSerialize()
        /// <summary>
        /// Десериализация
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static BillingProject OpenDeserialize()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //TODO: общий фильтр вынести в константное поле.
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