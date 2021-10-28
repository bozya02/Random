using Bogus;
using System;
using System.IO;


namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker f = new Faker("ru");
            var rnd = new Randomizer();
            string writePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\testData.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    for (int i = 1; i < 10; ++i)    //  индекс
                    {
                        var fn = f.Name.FirstName();
                        var ln = f.Name.LastName();
                        var exp = rnd.Int(0, 30);
                        sw.WriteLine($"{i}\t{fn}\t{ln}\t{exp}");    // \t нужны для копипаста
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
