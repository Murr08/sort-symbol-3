
        Console.Clear();
        string [] array=FillArray(); // заполняем массив 
        Func3(); // определяем символы <=3

        string[] FillArray()
        {

        Console.Write("Введите массив символов через ' ', ',', '.' ");
        
            string[] symbols = Console.ReadLine()!.Split(' ', ',', '.');
            return(symbols);
        }


        string Func3()
        {  string[] symb3={};
            int count=-1;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <=3) {
                  
                     count += 1;
                 
                    Array.Resize(ref  symb3, count+1);
                      symb3[count]=array[i];
                   

                   
                }
            }
Console.Write("Вывод массива где элементы <=3 : \n");  
 for (int j = 0; j < symb3.Length; j++)
            {
                Console.Write("{0}",symb3[j]);
                if(symb3.Length-1!=j) Console.Write(",");
            }

        return(symb3[count]);
        }
