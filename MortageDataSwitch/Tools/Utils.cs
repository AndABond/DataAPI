using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MortageDataSwitch.Tools
{
    public class Utils
    {
        private const int MAX_PROCESS_NUMBER = 10;
        private const int ALPANUM_PROCESS_NUMBER = 65;
        private const int NUMERIC_PROCESS_NUMBER = 48;

        public static string GenerateOriginatorReference(string type = "alphanum")
        {
            int processingType = ALPANUM_PROCESS_NUMBER;
            int processingNum = 26;
            string prefix = "TXN";
            if (type == "numeric")
            {
                processingType = NUMERIC_PROCESS_NUMBER;
                processingNum = 10;
                prefix = "";
            }
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < MAX_PROCESS_NUMBER; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(processingNum * random.NextDouble() + processingType)));
                builder.Append(ch);
            }
            return prefix + builder.ToString().ToUpper();
        }
    }
}