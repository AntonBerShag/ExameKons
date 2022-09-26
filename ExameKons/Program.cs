using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //для регулярных выражений
using System.IO; //Для записи файлов

namespace ExameKons
{
    public class SomeClass
    {
        /*static private int counter;
        public SomeClass()
        {
            counter++;
            Console.WriteLine("Присвоен номер {0}", counter);
        }
        public void SomeMethod(in int first, string _text = "123", params
            string[] _arr)
        {
            //first++;
            Console.WriteLine(_text + first);
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 0;
            short b = 0;
            var c = 3.14;
            int[] Arr = new int[] {1, 2, 3, 5, 7, 9 };
            for(int i = 0; i < Arr.Length; i++)
            {
                //Console.WriteLine("  " + Arr[^i]);
            }
            Console.WriteLine("Переменная {0} - {1}", c, c.GetType());*/
            /*var _one = new SomeClass();
            var _two = new SomeClass();
            _two.SomeMethod();
            var _three = new SomeClass();
            _three.SomeMethod("Привет!");
            Console.ReadKey();*/
            /*try
            {
                Console.WriteLine(args[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Нет аргументов", e.ToString());
                //throw;
            }
            finally
            {
                Console.WriteLine("Этот код выполнится в любом случае...");
            }
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }*/

            /*Regex regex = new Regex(@"\d*");
            Console.WriteLine("Введите строку с числами");
            MatchCollection matches = regex.Matches(Console.ReadLine());
            foreach (var item in matches)
            {
                if (item.ToString().Length != 0) 
                {
                    Console.WriteLine(item);
                }
            }*/
            string _path = "myFile.txt";
            _path = Environment.GetFolderPath
                (Environment.SpecialFolder.MyDocuments) + 
                "\\" + _path;
            Console.WriteLine(_path);
            StreamWriter output = new StreamWriter(_path, true);
            output.WriteLine(_path);
            output.Close();
            var input = new StreamReader(_path);
            string _tmp;
            while ((_tmp = input.ReadLine()) != null)
            {
                Console.WriteLine(_tmp);
            }
            /*do
            {
                Console.WriteLine(_tmp);
                _tmp = input.ReadLine();
            } while (_tmp != null);*/
            
            input.Close();
            Console.ReadKey();
        }
    }
}
