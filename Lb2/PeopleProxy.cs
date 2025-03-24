using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Lb2.Test")]

namespace Lb2
{
    public class PeopleProxy : IStack
    {
        /// <summary>
        /// Прокси-стек
        /// </summary>
        private Stack<Person> stackProxy;
        /// <summary>
        /// Реальный объект
        /// </summary>
        private static People people = new People();

        /// <summary>
        /// Метод для тестового доступа. Возвращает стек реального объекта
        /// </summary>
        /// <returns>Стек реального объекта</returns>
        internal static People GetPeople()
        {
            return people;
        }

        /// <summary>
        /// конструктор по умолчанию. При создании нового объекта в прокси копируется содержимое реального объекта
        /// </summary>
        public PeopleProxy()
        {
            stackProxy = new Stack<Person>();
            downloadChanges();
        }

        /// <summary>
        /// делегат(добавление элемента)
        /// </summary>
        public delegate void PersonAdd();

        /// <summary>
        /// делегат(удаление элемента)
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

        /// <summary>
        /// добавляет нового человека в стек
        /// </summary>
        /// <param name="person">новый человек</param>
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

        /// <summary>
        /// удаляет человека из стека по номеру
        /// </summary>
        /// <param name="id">Номер человека</param>
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
        /// Загружает версию стека прокси в реальный стек
        /// </summary>
        public void uploadChanges()
        {
            people.Clear();
            foreach (Person i in stackProxy)
            {
                people.Add(i);
            }
        }

        /// <summary>
        /// Загружает версию реального стека в прокси
        /// </summary>
        public void downloadChanges()
        {
            stackProxy.Clear();
            foreach (Person i in people.getStack())
            {
                stackProxy.Push(i);
            }
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

        ///// <summary>
        ///// Имитатор деструктора для демонстрации работы паттерна
        ///// </summary>
        //public void deletePeopleProxy()
        //{
        //    uploadChanges();
        //    stackProxy.Clear();
        //    ////people.Clear();
        //    //while (stackProxy.Count > 0)
        //    //{
        //    //    Person person = stackProxy.Pop();
        //    //    people.Add(person);
        //    //}
        //}

        /// <summary>
        /// Деструктор прокси
        /// </summary>
        ~PeopleProxy()
        {
            uploadChanges();
            stackProxy.Clear();
            //people.Clear();
            //while (stackProxy.Count > 0)
            //{
            //    Person person = stackProxy.Pop();
            //    people.Add(person);
            //}
        }
    }
}
