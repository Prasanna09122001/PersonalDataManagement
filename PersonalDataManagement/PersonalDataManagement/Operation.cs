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
        public void Display(List<Person> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.SSN + "\n" + data.Name + "\n" + data.Address + "\n" + data.Age);
            }
        }
    }
}
