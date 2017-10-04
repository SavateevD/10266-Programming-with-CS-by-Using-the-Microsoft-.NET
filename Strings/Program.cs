using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //String 
                string s1 = null;
                //Console.WriteLine(s1.Length);
                string name = "\"Сергей\"";
                //string path = "e:\\m10266-0826\\";
                string path = @"e:\m10266-0826\";
                string jsCode = @"
<script>
    window.onload = alert('hello');
</script>
";
                Console.WriteLine(name);
                Console.WriteLine(path);
                Console.WriteLine(jsCode);
            }
            {
                string name = "Сергей";
                string hello = "Привет";
                string result = hello + " " +name;

                Console.WriteLine(result);
                Console.WriteLine(result.Length);
                Console.WriteLine(result.ToUpper());
                result = result.ToUpper();
                Console.WriteLine(result);

                /*
                // VERY BAD
                string s = "";
                for (int i = 1; i <= 100; i++)
                    s  = s + i.ToString() + " ";
                 */

                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= 100; i++)
                    sb.Append(i).Append(" ");

                string s = sb.ToString();

                Console.WriteLine(s);
            
            }




        }
    }
}
