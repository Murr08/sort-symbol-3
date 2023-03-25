/*итоговый проект
 1репоз на гите
 2 блок схема
 3 описание текстом решения
 4 прогу написать
 5 этапы  2,3,4 в разных коммитах

 задача : массив создать и создать фильтр на <=3 символов, 
 из полученого  создать массив строк

*/

Console.WriteLine("Enter symbols or numbers");

        Console.Clear();
        string[] array=FillArray(); // заполняем массив 
        Func3(); // определяем <=3 символов  в элементе  массива
        PrintArray(); //выводим массив

        string[] FillArray()
        {
            string[] symbol = Console.ReadLine()!.Split(' ', ',', '.').ToArray();
                Console.WriteLine("wwedeno <100 chisel={0}", symbol);
            return(symbol);
        }


        void Func3()
        {  int count=0; 
        string del;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].Length<=3) 
                {count += 1;
                Console.WriteLine("wwedeno <=3 chisel={0}", array[i]);
                }
                else 
                { del=array[i];
                    array[i].Remove(del);
                }
            }
            Console.WriteLine("wwedeno <=3 chisel={0}", count);
        }

 

        void PrintArray()
        {
            Console.WriteLine("Array you enter:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
