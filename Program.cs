using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;

namespace SkillFactory_13_6_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = new HttpClient().GetStringAsync(@"https://lms-cdn.skillfactory.ru/assets/courseware/v1/dc9cf029ae4d0ae3ab9e490ef767588f/asset-v1:SkillFactory+CDEV+2021+type@asset+block/Text1.txt").Result;

            string[] splitted = result.Split(new char[] { '\n' });
            List<string> list = splitted.Cast<string>().ToList();

            var watchOne = Stopwatch.StartNew();
            list.Add("Моя прекрасная Диляра");
            Console.WriteLine($"Вставка в  словарь: {watchOne.Elapsed.TotalMilliseconds}  мс");


            LinkedList<string> linkedList = new LinkedList<string>(list);
            var watchTwo = Stopwatch.StartNew();
            linkedList.AddLast("Моя прекрасная Диляра");

            Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        }
    }
}
