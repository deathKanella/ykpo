//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Table hashTable = new Table(7);
//            hashTable.insert("rhino");
//            hashTable.insert("man");
//            hashTable.insert("computer");
//            hashTable.insert("home");
//            hashTable.insert("basket");
//            hashTable.insert("Ferrari");
//            hashTable.insert("nam");
//            hashTable.print();

//            Console.WriteLine();
//            hashTable.delete("rhino");
//            Console.WriteLine();
//            hashTable.print();

//            Console.ReadLine();
//        }

//    }
//    class Item1
//    {
//        private String key;

//        public Item1(String key)
//        {
//            this.key = key;
//        }

//        public String getKey()
//        {
//            return key;
//        }

//        public void setKey(String key)
//        {
//            this.key = key;
//        }
//    }

//    class Table
//    {
//        private Item1[] table;//массив для элементов(сама хештаблица)
//        private int size;
//        private Item1 notitem;

//        public Table(int size)
//        {
//            this.size = size;
//            this.table = new Item1[size];
//            notitem = new Item1("**");
//        }

//        public void add(Item s)
//        {
//            int count = 0;
//            if (count <= size)
//                table[count] = s;
//            count++;

//        }

//        //вывод на экран
//        public void print()
//        {
//            for (int i = 0; i < size; i++)
//            {
//                if (table[i] != null)
//                    Console.WriteLine(i + " " + table[i].getKey());
//                else
//                    Console.WriteLine(i + " **");
//            }

//        }

//        private int hash(String key)
//        {
//            int hash = 0;
//            //методом Горнера. В конечный результат вычисления адреса вносят свою лепту все символы ключа.
//            // Функция charAt() вернет целочисленное значение, представляющее символ.
//            // Мы затем умножим его на простое число, которое будет больше, чем значение, полученное для любого символа.
//            // Наконец, вычисляем остаток от деления(оператор %).
//            for (int i = 0; i < key.Length; i++)
//                hash = (31 * hash + key[i]) % size;

//            return hash;
//        }
//        //Хешфункция 2
//        //возвращаемое значение больше 0 и меньше размера массива
//        //шаг смещения
//        private int hash2(String key)
//        {
//            int hash = 0;
//            for (int i = 0; i < key.Length; i++)
//                hash = 5 - (31 * hash + key[i]) % 5;
//            return hash;
//        }

//        //вставка
//        public void insert(String key)
//        {
//            Item item = new Item(key);

//        }

//        //Поиск
//        public Item find(String key)
//        {
//            //хеширование ключа
//            int hashVal = hash(key);
//            int hashval2 = hash2(key);

//            while (table[hashVal] != null)
//            {
//                if (table[hashVal].getKey() == key)
//                {//Если ключ найден
//                    return table[hashVal];//возвращаем его
//                }
//                hashVal = (hashVal + hashval2) % size;
//            }
//            return null;//если не найден не возвращаем
//        }

//        //Удаление
//        public void delete(String key)
//        {
//            //хеширование ключа
//            int hashVal = hash(key);
//            int hashval2 = hash2(key);

//            while (table[hashVal] != null)
//            {
//                if (table[hashVal].getKey() == key)
//                {
//                    table[hashVal] = notitem;
//                    Console.WriteLine("Удалено");
//                }
//                hashVal = (hashVal + hashval2) % size;
//            }
//        }

//    }
//}
