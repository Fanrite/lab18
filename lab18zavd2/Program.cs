using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab18zavd2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Ski[] arr = new Ski[]
            {
               new Ski("bogdan", 18,30,00,18,45,20),
               new Ski("roman", 18,50,00,18,59,20)
            };

            TimeSpan norm = new TimeSpan(0, 18, 0);
            var path = @"D:\\Ski.txt";
            int i = 0;
            bool flag = true;
            while (flag)
            {

                string stroka = "";
                int counterLines = System.IO.File.ReadAllLines(path).Length;

                arr = new Ski[counterLines / 3];

                using (StreamReader MyFile = new StreamReader(path))
                {
                    int count = 0;

                    while ((stroka = MyFile.ReadLine()) != null)
                    {
                        arr[count] = new Ski(stroka, DateTime.Parse(MyFile.ReadLine(),
                            System.Globalization.CultureInfo.InvariantCulture),
                            DateTime.Parse(MyFile.ReadLine(), System.Globalization.CultureInfo.InvariantCulture));
                        count++;
                    }
                }

                int v;
                Console.Clear();
                Console.WriteLine("Виберіть режим: \n1 - Ввід даних  \n2 - Ті хто пройшов норматив  \n3 - Показ всієї бази \n4 - Вихід з програми");
                v = Convert.ToInt32(Console.ReadLine());

                if (v == 1)
                {
                    bool b = true;
                    while (b)
                    {
                        int e;
                        Console.Clear();
                        Console.WriteLine("1 - Ввести  2- Вихід");
                        e = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (e == 1)
                        {
                            Array.Resize(ref arr, arr.Length + 1);
                            arr[arr.Length - 1] = new Ski();
                        }
                        if (e == 2) b = false;
                    }

                }

                if (v == 2)
                {
                    Console.Clear();
                    for (i = 0; i < arr.Length; i++)
                    {
                        if ((arr[i].fn - arr[i].st) < norm)
                            arr[i].Info();

                    }
                    Console.ReadKey();
                    
                }

                if (v == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Вся база:");
                    foreach (Ski n in arr)
                        n.Info();
                    Console.ReadKey();

                }

                if (v == 4)
                    flag = false;

                StreamWriter f = new StreamWriter("D:\\Ski.txt");
                for (i = 0; i < arr.Count(); i++)
                {
                    f.WriteLine(arr[i].name);
                    f.WriteLine(arr[i].st.ToLongTimeString());
                    f.WriteLine(arr[i].fn.ToLongTimeString());
                }
                f.Close();

            }


        }
    }
}
