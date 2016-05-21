using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pasifiklib.core
{
    public class Utils
    {
        public static string[] clean_phone_list(string[] phone_list)
        {
            List<string> liston = new List<string>();
            foreach (string number in phone_list)
            {
                string number1 = Regex.Replace(number, @"[^\w\s\-\+\ ]", "");
                if (number1.All(char.IsDigit))
                {
                    number1 = Regex.Replace(number1, @"^00", "");//0090
                    //number1 = Regex.Replace(number1, @"^90", "");
                    number1 = Regex.Replace(number1, @"^0", "");
                    liston.Add(number1);
                }
            }
            return liston.Distinct().ToArray();
        }
        public static string clean_phone(string number)
        {
            number = number.Replace(".0", "");
            number = Regex.Replace(number, @"[^\w\s\-\+\ ]", "");

            if (number.All(char.IsDigit))
            {
                number = Regex.Replace(number, @"^00", "");//0090
                //number = Regex.Replace(number, @"^90", "");
                number = Regex.Replace(number, @"^0", "");
            }
            else
            {
                number = "";
            }
            return number;
        }

        public static bool is_number(string number)
        {
            bool isNumeric = false;
            try
            {
                number = number.Replace("+", "");
                number = number.Replace(".0", "");
                number = number.Replace(" ", "");
                isNumeric = number.All(char.IsDigit);
            }
            catch
            {
                isNumeric = false;
            }
            return isNumeric;
        }

        public static SortedDictionary<int, string> period_dict = new SortedDictionary<int, string> { 
            {60, "1 Saat"},
            {120, "2 Saat"},
            {180, "3 Saat"},
            {240, "4 Saat"},
            {300, "5 Saat"},
            {360, "6 Saat"},
            {420, "7 Saat"},
            {480, "8 Saat"},
            {540, "9 Saat"},
            {600, "10 Saat"},
            {660, "11 Saat"},
            {720, "12 Saat"},
            {780, "13 Saat"},
            {840, "14 Saat"},
            {900, "15 Saat"},
            {960, "16 Saat"},
            {1020, "17 Saat"},
            {1080, "18 Saat"},
            {1140, "19 Saat"},
            {1200, "20 Saat"},
            {1260, "21 Saat"},
            {1320, "22 Saat"},
            {1380, "23 Saat"},
            {1440, "24 Saat"}
        };
        public static readonly Dictionary<string, int> excel_header_dic = new Dictionary<string, int>() { 
            {"A", 1}, {"B", 2}, {"C", 3}, {"D", 4}, {"E", 5}, {"F", 6}, {"G", 7}, {"H", 8}, {"I", 9}, {"J", 10}, {"K", 11},
            {"L", 12}, {"M", 13}, {"N", 14}, {"O", 15}, {"P", 16}, {"Q", 17}, {"R", 18}, {"S", 19}, {"T", 20}, {"U", 21}, {"V", 22},
            {"W", 23}, {"X", 24}, {"Y", 25}, {"Z", 26}, {"AA", 27}, {"AB", 28}, {"AC", 29}
        };
        public static readonly Dictionary<string, string> alphabet_dic = new Dictionary<string, string>(){
            {"Varsayılan GSM (1 SMS - 160 karakter)", "Default"}, 
            {"Türkçe (1 SMS - 155 karakter)", "TurkishSingleShift"},
            {"Unicode (1 SMS - 70 karakter)", "UCS2"},
            {"Flaş SMS - Varsayılan GSM (1 SMS - 160 karakter)", "DefaultMclass0"}
        };
        public static string EscapeStringValue1(string value)
        {
            const char BACK_SLASH = '\\';
            const char SLASH = '/';
            const char DBL_QUOTE = '"';

            var output = new StringBuilder(value.Length);
            foreach (char c in value)
            {
                switch (c)
                {
                    case SLASH:
                        output.AppendFormat("{0}{1}", BACK_SLASH, SLASH);
                        break;

                    case BACK_SLASH:
                        output.AppendFormat("{0}{0}", BACK_SLASH);
                        break;

                    case DBL_QUOTE:
                        output.AppendFormat("{0}{1}", BACK_SLASH, DBL_QUOTE);
                        break;

                    default:
                        output.Append(c);
                        break;
                }
            }

            return output.ToString();
        }
        public static string EscapeStringValue(string value)
        {
            //value = value.Replace(@"\", @"\\");
            //value = value.Replace(@"\n", @"\\n");
            //value = value.Replace(@"\t", @"\\t");
            value = value.Replace(System.Environment.NewLine, string.Empty);
            return value;
        }
        public static string EscapeStringValue2(string s)
        {
            if (s == null || s.Length == 0)
            {
                return "";
            }

            char c = '\0';
            int i;
            int len = s.Length;
            StringBuilder sb = new StringBuilder(len + 4);
            String t;

            for (i = 0; i < len; i += 1)
            {
                c = s[i];
                switch (c)
                {
                    case '\\':
                    case '"':
                        sb.Append('\\');
                        sb.Append(c);
                        break;
                    case '/':
                        sb.Append('\\');
                        sb.Append(c);
                        break;
                    case '\b':
                        sb.Append("\\b");
                        break;
                    case '\t':
                        sb.Append("\\t");
                        break;
                    case '\n':
                        sb.Append("\\n");
                        break;
                    case '\f':
                        sb.Append("\\f");
                        break;
                    case '\r':
                        sb.Append("\\r");
                        break;
                    default:
                        if (c < ' ')
                        {
                            t = "000" + String.Format("X", c);
                            sb.Append("\\u" + t.Substring(t.Length - 4));
                        }
                        else
                        {
                            sb.Append(c);
                        }
                        break;
                }
            }
            return sb.ToString();
        }
        public static int sms_count_calc(string message, string alphabet)
        {
            int sms_count = 1;
            if (alphabet == "Default" || alphabet == "DefaultMclass0")
            {
                if (message.Length > 0 && message.Length <= 160)
                {
                    sms_count = 1;
                }
                else if (message.Length > 160 && message.Length <= 306)
                {
                    sms_count = 2;
                }
                else if (message.Length > 306 && message.Length <= 459)
                {
                    sms_count = 3;
                }
                else if (message.Length > 459 && message.Length <= 612)
                {
                    sms_count = 4;
                }
            }
            else if (alphabet == "TurkishSingleShift")
            {
                if (message.Length > 0 && message.Length <= 155)
                {
                    sms_count = 1;
                }
                else if (message.Length > 155 && message.Length <= 298)
                {
                    sms_count = 2;
                }
                else if (message.Length > 298 && message.Length <= 447)
                {
                    sms_count = 3;
                }
                else if (message.Length > 447 && message.Length <= 596)
                {
                    sms_count = 4;
                }
            }
            else if (alphabet == "UCS2")
            {
                if (message.Length > 0 && message.Length <= 70)
                {
                    sms_count = 1;
                }
                else if (message.Length > 70 && message.Length <= 134)
                {
                    sms_count = 2;
                }
                else if (message.Length > 134 && message.Length <= 201)
                {
                    sms_count = 3;
                }
                else if (message.Length > 201 && message.Length <= 268)
                {
                    sms_count = 4;
                }
            }
            return sms_count;
        }
    }
}
