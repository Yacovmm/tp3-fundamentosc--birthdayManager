using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_BirthdayManager
{
    class Repository
    {
        private List<Person> persons = new List<Person>();

        public void Insert(Person p)
        {
            persons.Add(p);
            Console.WriteLine("Pessoa cadastrada com sucesso!");
        }

        public void Search(string n)
        {
            bool b = false;
            while (persons.Count != null)
            {
                 b = true;
            }

            if (b) 
            {
                foreach (var x in persons)
                {
                    if (x.Name == n)
                    {
                        Console.WriteLine(x.Name + x.LastName + x.Birthday);
                    }
                    else
                    {
                        Console.WriteLine("Esse nome não consta no sistema");
                    }
                    
                }


            }
            else
            {
                Console.WriteLine("NÃO EXISTE PESSOAS CADASTRADAS!");
            }
               
            

        }

    }
}
