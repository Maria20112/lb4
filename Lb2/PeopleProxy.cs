using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal class PeopleProxy : IStack
    {
        static Stack<Person> stackProxy = new Stack<Person>();
        static People people = new People();

        /// <summary>
        /// делегат (добавление элемента)
        /// </summary>
        public delegate void PersonAdd();

        /// <summary>
        /// делегат (удаление элемента)
        /// </summary>
        public delegate void PersonRemove();

        /// <summary>
        /// событие (добавление элемента)
        /// </summary>
        public event PersonAdd? NotifyAdd;

        /// <summary>
        /// событие (удаление элемента)
        /// </summary>
        public event PersonRemove? NotifyRemove;

        public void Add(Person person)
        {
            try
            {
               stackProxy.Push(person);
                NotifyAdd?.Invoke();
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Add(Person person) in People.cs");
            }
        }

        public void Remove(int id)
        {
            Stack<Person> helpStack = new Stack<Person>();
            int count = 0;
            while (stackProxy.Count > 0)
            {
                Person curr = stackProxy.Pop();
                if (count != id)
                {
                    helpStack.Push(curr);
                }
                count++;
            }
            while (helpStack.Count > 0)
            {
                stackProxy.Push(helpStack.Pop());
            }
            try
            {
                NotifyRemove?.Invoke();
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Remove(Person person) in People.cs");
            }
        }

        public Person? Find(int id)
        {
            Stack<Person> helpStack = new Stack<Person>();
            int count = 0;
            Person curr = null;
            while (stackProxy.Count > 0)
            {
                curr = stackProxy.Pop();
                helpStack.Push(curr);
                if (count == id)
                {
                    break;
                }
                count++;
            }
            while (helpStack.Count > 0)
            {
                stackProxy.Push(helpStack.Pop());
            }
            return curr;
        }

        /// <summary>
        /// Создает объект, содержащий данные всех людей для вывода в таблицу
        /// </summary>
        /// <returns>Таблица с данными людей</returns>
        public DataTable GenerateData()
        {
            DataTable dataTable = new DataTable();

            if (stackProxy.Count > 0)
            {

                // Добавление колонок
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Имя", typeof(string));
                dataTable.Columns.Add("Фамилия", typeof(string));
                dataTable.Columns.Add("Пол", typeof(string));
                dataTable.Columns.Add("Год рожд.", typeof(int));
                dataTable.Columns.Add("Город", typeof(string));
                dataTable.Columns.Add("Страна", typeof(string));
                dataTable.Columns.Add("Рост", typeof(double));

                int counter = 0;
                // Добавление строк
                foreach (Person person in stackProxy)
                {
                    dataTable.Rows.Add(counter++, person.name, person.surname, person.Gender, person.Year_of_birth,
                        person.City, person.Country, person.Height);
                }
            }

            return dataTable;
        }


        ~PeopleProxy()
        {
            people.Clear();
            while (stackProxy.Count > 0)
            {
                Person person = stackProxy.Pop();
                people.Add(person);
            }
        }
    }
}
