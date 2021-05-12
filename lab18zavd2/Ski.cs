using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab18zavd2
{
    class Ski
    {
        public string name;
        public DateTime st;
        public DateTime fn;

        public Ski (string n, int sh, int sm, int ss, int fh, int fm, int fs)
        {
            name = n;
            st = new DateTime(2021, 02, 12, sh, sm, ss);
            fn = new DateTime(2021, 02, 12, fh, fm, fs);  
        }

        public Ski(string name, DateTime st, DateTime fn)
        {
            this.name = name;
            this.st = st;
            this.fn = fn;
        }

        public Ski ()
        {
            v:
            try
            {
                Console.Clear();
                int sh, sm, ss, fh, fm, fs;
                Console.WriteLine("Введіть імя");
                name = Console.ReadLine();

                Console.WriteLine("Введіть початкову годину");
                sh = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть початкову хвилину");
                sm = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть початкову секунду");
                ss = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть кінцеву годину");
                fh = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть кінцеву хвилину");
                fm = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть кінцеву секунду");
                fs = Convert.ToInt32(Console.ReadLine());

                st = new DateTime(2021, 02, 12, sh, sm, ss);
                fn = new DateTime(2021, 02, 12, fh, fm, fs);
                

            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Помилка вводу даних");
                Console.ReadKey();
                goto v;
            }
        }

        public void Info ()
        {
            Console.WriteLine($"{name} {st.ToLongTimeString()} {fn.ToLongTimeString()}");
        }
    }
}
