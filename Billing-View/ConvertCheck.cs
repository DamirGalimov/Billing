using System;


namespace Billing_View
{
    public static class ConvertCheck
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static int ConvertToInt(string text, string fileName)
        {
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static double ConvertToDouble(string text, string fileName)
        {
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