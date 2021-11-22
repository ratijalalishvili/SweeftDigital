using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigital.Tasks
{
    public class MyDataStructure<T> : Dictionary<int,T>
    {
        /* მონაცემის O1 დროში წაშლა მოხდება მაშინ როდესაც ჩვენ რაიმე ინდექსით მივწვდებით ამ ელემენტს და თან წაშლის შემდეგ მონაცემთა
         სტრუქტურის თანმიმდევრობა და განლაგება არ შეიცვლება
          
            1. გავაკეთებ Dictionary_ს სადაც Key იქნება ელემენტის ჰეშირებული კოდი.
            2. როდესაც მომხმარებელს ექენება სურვილი წაშალოს რაიმე ელემენტი იგი შეიყვანს ელემენტის სახელს, ხოლო ჩვენ მის ჰეშ კოდით ანუ როგორც ინდექსით მივწვდებით და წავშლით
            3. ჩვენს მონაცემთა სტრუქტურას ექნება ToList(),Add(), Update(), Remove() მეთოდები.
        */

        

        public List<T> ToList()
        {
            List<T> list = new List<T>();

            foreach (var item in this)
            {
                list.Add(item.Value);
            }
            return list;
        }
        public void Add(T obj)
        {
            int hashCode = obj.GetHashCode();

            this.Add(hashCode, obj);
        }

        public void Update(T oldObj, T newObj)
        {
            this.Remove(oldObj.GetHashCode());
            this.Add(newObj.GetHashCode(), newObj);
        }

        public void Remove(T obj)
        {
            this.Remove(obj.GetHashCode());
        }
       

    }
}
