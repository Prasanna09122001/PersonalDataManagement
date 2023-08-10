using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataManagement
{
    public class Operation
    {
        public void RetreiveTopTwoRecors(List<Person> list)
        {
            var Result = list.Where(x => x.Age < 60).Take(2);
            Display(Result.ToList());
        }
        public void RetreiveRecordsInBetweenAge(List<Person> list)
        {
            var result = list.Where(x => x.Age > 13 && x.Age < 18);
            Display(result.ToList());
        }
        public void AverageList(List<Person> list)
        {
            var result = list.Average(x => x.Age);
            Console.WriteLine(result);
        }
        public void RetreivePersonDetailsByName(List<Person> list)
        {
            Console.WriteLine("Enter the Name to Search");
            string name = Console.ReadLine();
            var Result = list.Where(x => x.Name == name);
            Display(Result.ToList());
        }
        public void RecordsOfAge(List<Person> list)
        {
            var result = list.OrderBy(x=>x.Age).Skip(list.Count(x=>x.Age<60));
            Display(result.ToList());
        }
        public void DeleeteDataFromList(List<Person> list)
        {
            Console.WriteLine("Enter the Name to Delete");
            string name = Console.ReadLine();
            var Result = list.Find(x => x.Name == name);
            list.Remove(Result);
            Display(list);
        }
        public void Display(List<Person> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.SSN + "\n" + data.Name + "\n" + data.Address + "\n" + data.Age);
            }
        }
    }
}
