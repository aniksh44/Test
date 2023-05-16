using System;

namespace LibraryManagementSystem.Framework
{
    public static class Validation
    {

        public static bool IsStringValid(params string[] value)
        {

            for (int i = 0; i < value.Length; i++)
            {
                if (string.IsNullOrEmpty(value[i]) || string.IsNullOrWhiteSpace(value[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool isIntValid(params string[] value)
        {
            
            for (int i = 0; i < value.Length; i++)
            {
                int number;
                bool isNumber = int.TryParse(value[i], out number);
                if (!isNumber)
                {
                    return false;
                }
                else
                {
                    if(number<1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
    }
}
