using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb2
{
    /// <summary>
    /// Класс, содержащий коллекцию людей
    /// </summary>
    public class People
    {
        /// <summary>
        /// стек
        /// </summary>
        private Stack<Person> peopleStack;

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

        ///// <summary>
        ///// возвращает стек
        ///// </summary>
        ///// <returns></returns>
        //public Stack<Person> getAll()
        //{
        //    return peopleStack;
        //}

        /// <summary>
        /// Создает объект, содержащий данные всех людей для вывода в таблицу
        /// </summary>
        /// <returns>Таблица с данными людей</returns>
        public DataTable GenerateData()
        {
            DataTable dataTable = new DataTable();

            if (peopleStack.Count > 0)
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
                foreach (Person person in peopleStack)
                {
                    dataTable.Rows.Add(counter++, person.name, person.surname, person.Gender, person.Year_of_birth,
                        person.City, person.Country, person.Height);
                }
            }

            return dataTable;
        }

        /// <summary>
        /// добавляет нового человека в стек
        /// </summary>
        /// <param name="person">новый человек</param>
        public void Add(Person person)
        {
            try
            {
                peopleStack.Push(person);
                NotifyAdd?.Invoke();
            }
            catch (Exception) {
                Console.WriteLine("Error: Add(Person person) in People.cs");
            }
        }

        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public People()
        {
            peopleStack = new Stack<Person>();
        }

        /// <summary>
        /// Ищет объект в стеке по индексу
        /// </summary>
        /// <param name="id">индекс искомого объекта</param>
        /// <returns>если объект найден, возвращает объект, иначе - null</returns>
        public Person? Find(int id)
        {
            Stack<Person> helpStack = new Stack<Person>();
            int count = 0;
            Person curr = null;
            while (peopleStack.Count > 0)
            {
                curr = peopleStack.Pop();
                helpStack.Push(curr);
                if (count == id)
                {
                    break;
                }
                count++;
            }
            while (helpStack.Count > 0)
            {
                peopleStack.Push(helpStack.Pop());
            }
            return curr;
        }

        /// <summary>
        /// удаляет человека из стека по номеру
        /// </summary>
        /// <param name="id">Номер человека</param>
        public void Remove(int id)
        {
            //id--;
            Stack<Person> helpStack = new Stack<Person> ();
            int count = 0;
            while (peopleStack.Count > 0)
            {
                Person curr = peopleStack.Pop();
                if (count != id)
                {
                    helpStack.Push(curr);
                }
                count++;
            }
            while (helpStack.Count > 0)
            {
                peopleStack.Push(helpStack.Pop ());
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
    }
}
