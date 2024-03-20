using System.ComponentModel;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace HelloWorld2
{
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // comment 1
            /*
             * comment 2
             */
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");

            string input = Console.ReadLine();
            int y = int.Parse(input);
            int z = Convert.ToInt32(input);

            float f = 1.0f;
            int k = (int)f;
            Console.WriteLine("Max value of integer: "+int.MaxValue);

            Console.WriteLine("Enter input: " + input);

            byte a = 255;
            short b = 256;
            int i = 5555;

            char j = 'B';
            j++;

            string str = "asdasd";
            str += 1;

            string str2;
            str2 = "Name";

            string m = "A";
            


            Console.WriteLine(str);
            Console.WriteLine(str2);

            //A = 65

            {
                int q = 1;
                q++;
                q += 1;
                q = q + 1;
                {
                    int w = 2;
                    {
                        int e = 3;

                        int r = q + w + e;
                    }
                    Console.WriteLine(q);
                }
            }

            var name = "Mark";
            var date = DateTime.Now;
            // Composite formatting: {i:format} {i:F2}
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            string s = String.Format("At {0}, the temperature is {1}°C.", DateTime.Now, 20.4);
            Console.WriteLine(s);

            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            // Both calls produce the same output that is similar to:
            // Hello, Mark! Today is Wednesday, it's 19:40 now.

            Console.WriteLine("The quick brown fox \n jumps over the lazy dog");
            Console.WriteLine("""
                askdjhsdkjgfknsdfnksjd
                asdkjhsdkfjh
                askjhdksdjhf
                sldkjfslkdjf
                """);

            // | & | T | F |
            // | T | T | F |
            // | F | F | F |

            // | || | T | F |
            // | T  | T | T |
            // | F  | T | F |

            bool d = true && false;
            bool g = true || false;


            if ( i > 0 && i < 5)
            {
                int l = 0;
            }
            else if (i > 5 && i < 10)
            {

            }
            else if (false)
            {

            }
            else
            {

            }


            switch ((DayOfWeek) y)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Input is 0");
                    Console.WriteLine("Input is 0");
                    Console.WriteLine("Input is 0");
                    Console.WriteLine("Input is 0");
                    Console.WriteLine("Input is 0");
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    Console.WriteLine("Unknown input");
                    Console.WriteLine("Unknown input");
                    break;
            }

            
            while (g)
            {
                Console.WriteLine("Test");
                y++;
                if (y == 5)
                {
                    g = false;
                }
            }
            
            for (int h = 10; h >= 0 ; h--)
            {
                for(int p = 0; p < h; p++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            for (int h = 0; h <= 10; h++)
            {
                for (int p = 0; p <= h; p++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            //if (person.IsOld | person.IsPWD)
            //{

            //}
            int[] array = new int[]{1,3,5,7,8};
            string[] strArray = new string[] { "Amy", "Jay", "Pedro" };

            int[] age = new int[10];
            for (int h = 0; h < age.Length; h++)
            {
                age[h] = int.Parse(Console.ReadLine());
            }

            // int[] age = |0|1|2|3|4|5|6|7|8|9|


        }

        public static void Add(int a, int b)
        {

        }
        
        public static int Add2(int a, int b)
        {
            return 1;
        }
    }
}
