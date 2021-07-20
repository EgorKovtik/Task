using System;
using System.Text.RegularExpressions;

namespace for_tasting
{
    /*
            Описание через регулярные выражения
    сперва с помощью регулярного выражения мы в строке находим числа и записываем их в совпадения
    затем при помощи цикала foreach делам то для чего он и нужен, перебираем коллекцию наших совпадений 
    и каждое совпадение конвертируем сперва из объекта коллекции в строку, а потом в число. После чего прибавляем
    его к итоговой сумме.
     
    [0-9]+ — это регулярное обозначение значит что мы выбираем десятичные числа одно или более.
     
     */
    class Program
    {

        static void Main(string[] args)
        {
            string field = "ab23ff4";
            int sum = 0;

            var result = new Regex("[0-9]+").Matches(field);
            foreach (var match in result)
            {
                sum += int.Parse(match.ToString());
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}


