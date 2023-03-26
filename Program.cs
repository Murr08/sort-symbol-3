
        Console.Clear();
        string [] array=FillArray(); // заполняем массив 
        Func3(); // определяем символы <=3
//        PrintArray(); //выводим массив

        string[] FillArray()
        {
            string[] symbols = Console.ReadLine()!.Split(' ', ',', '.');
            return(symbols);
        }


        //string[] 
        void Func3()
        {  string[] symb3={};
            int count=0;
       // if(array[array.Length].Length >3) Array.Resize(ref array, array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <=3) {
                     count += 1;
                  Console.WriteLine("count ={0}", count);
                    Array.Resize(ref  symb3, count);


                    symb3[0]=array[i];
                   
                }
            }
            Console.WriteLine("wwedeno <=3 symbols={0}   length={1}", count, symb3.Length);

 for (int i = 0; i < symb3.Length; i++)
            {
                Console.WriteLine(symb3[i]);
            }

        //return (symb3);
        }

 

/*        void PrintArray()
        {
            for (int i = 0; i < symb3.Length; i++)
            {
                Console.WriteLine(symb3[i]);
            }
        }
*/
