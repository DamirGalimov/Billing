using System;


namespace Billing_View
{
    //TODO: комментарии?
    //TODO: исправить название класса. Check - это глагол, а не существительное
    //TODO: Если класс не связан с интерфейсами, то логичнее его переместить в проект Billing. Там уже есть DataCheking и PaymentTypeConverter, будет еще один класс-чекер.
    public static class ConvertCheck
    {
        //TODO: комментарии?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static int ConvertToInt(string text, string fileName)
        {
            //TODO: а локальная переменная нужна?
            int view;
            try
            {
                view = Convert.ToInt32(text);
            }
            catch (FormatException)
            {
                throw new FormatException("Field '" + fileName + "' must contain only digits.");
            }
            return view;
        }

        //TODO: комментарии?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static double ConvertToDouble(string text, string fileName)
        {
            //TODO: а локальная переменная нужна?
            double view;
            try
            {
                view = Convert.ToDouble(text);
            }
            catch (FormatException)
            {
                throw new FormatException("Field '" + fileName + "' must contain only digits.");
            }
            return view;
        }
    }
}