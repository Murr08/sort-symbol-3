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
        int[] array=FillArray(); // заполняем массив 
        Func0(); // определяем >0
        PrintArray(); //выводим массив

        int[] FillArray()
        {
            int[] chisla = Console.ReadLine()!.Split(' ', ',', '.').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
            return(chisla);
        }


        void Func0()
        {  int count=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <100) 
                {count += 1;
                Console.WriteLine("wwedeno <100 chisel={0}", array[i]);
                }
            }
            Console.WriteLine("wwedeno <100 chisel={0}", count);
        }

 

        void PrintArray()
        {
            Console.WriteLine("Array you enter:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
