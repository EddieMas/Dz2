using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задание 1
            Random random = new Random();
            int min_random = 1;
            int max_random = 100;
            short A_rasmer = 5;
            short[] A = new short[A_rasmer];
            short B_rasmer_strok = 3;
            short B_rasmer_stolbi = 4;
            float[,] B = new float[B_rasmer_strok, B_rasmer_stolbi];
            for (short i = 1; i <= A_rasmer; i++)
            {
                Console.Write("Vvedite chislo " + i);
                if (i == 1)
                    Console.Write("-oe");
                else if (i == 2)
                    Console.Write("-oe");
                else if (i == 3)
                    Console.Write("-ie");
                else
                    Console.Write("-oe");
                Console.Write(" chislo v masiv: ");
                A[i - 1] = short.Parse(Console.ReadLine());
            }
            for (int i = 0; i < B_rasmer_strok; i++)
            {
                for (int j = 0; j < B_rasmer_stolbi; j++)
                    B[i, j] = (float)random.Next(min_random, max_random) / 10;
            }
            short A_max = 0, A_min = 0, A_sum = 0, A_sum_chetnih = 0, A_proizvidenie = 1;
            float B_max = 0, B_min = 0, B_sum = 0, B_sum_nechetnih = 0, B_proizvidenie = 1;
            for (int i = 0; i < A_rasmer; i++)
            {
                Console.Write($"{A[i]}\t");
                if (i == 0)
                    A_max = A[i];
                else
                {
                    if (A_max > A[i])
                        A_max *= 1;
                    else
                        A_max = A[i];
                }
                if (i == 0)
                    A_min = A[i];
                else
                {
                    if (A_min < A[i])
                        A_min *= 1;
                    else
                        A_min = A[i];
                }
                A_sum += A[i];
                A_proizvidenie *= A[i];
                if (i % 2 == 1)
                    A_sum_chetnih += A[i];
            }
            Console.WriteLine();
            for (int i = 0; i < B_rasmer_strok; i++)
            {
                for (int j = 0; j < B_rasmer_stolbi; j++)
                {
                    Console.Write($"{B[i, j]}\t");
                    if (i == 0 && j == 0)
                        B_max = B[i, j];
                    else
                    {
                        if (B_max > B[i, j])
                            B_max *= 1;
                        else
                            B_max = B[i, j];
                    }
                    if (i == 0 && j == 0)
                        B_min = B[i, j];
                    else
                    {
                        if (B_min < B[i, j])
                            B_min *= 1;
                        else
                            B_min = B[i, j];
                    }
                    B_sum += B[i, j];
                    B_proizvidenie *= B[i, j];
                    if (j % 2 == 0)
                        B_sum_nechetnih += B[i, j];
                }
                Console.WriteLine();
            }
            Console.Write($"Maximalnii element: ");
            if (A_max > B_max)
                Console.WriteLine(A_max);
            else
                Console.WriteLine(B_max);
            Console.Write($"Minimalnii element: ");
            if (A_min < B_min)
                Console.WriteLine(A_min);
            else
                Console.WriteLine(B_min);
            Console.WriteLine($"Suma vseh elementov: {A_sum + B_sum}");
            Console.WriteLine($"Obchie proizvidenie vseh elementov: {A_proizvidenie * B_proizvidenie}");
            Console.WriteLine($"Suma chetnih elementol masiva A: {A_sum_chetnih}");
            Console.WriteLine($"Suma ne chetnih elementol masiva B: {B_sum_nechetnih}");
            */

            /*
              Задание 3
              Console.Write("Vvedite text: ");
              string text = Console.ReadLine();
              Console.Write("Vvedite chislo na skolko peremichat: ");
              short chislo = short.Parse(Console.ReadLine());
              char[] char_arr = text.ToCharArray();
              for (short i = 0; i < text.Length; i++)
                  char_arr[i] = (char)(Convert.ToInt16(text[i]) + chislo);
              string answer_str = new string(char_arr);
              Console.WriteLine($"Izmenenii text: {answer_str}");             
            */

            /*
            Задание 5
            Console.WriteLine("Vvedite dva arifmitichiskih uravnenie cherez probel: ");
            string uravnenie = Console.ReadLine();
            uravnenie = uravnenie.Insert(uravnenie.Length, " ");
            short chislo_1 = 0;
            short chislo_2 = 0;
            char math_operation = '+';
            for (short i = 0; i < uravnenie.Length; i++)
            {
                if (Convert.ToInt16(uravnenie[i]) > 47 && Convert.ToInt16(uravnenie[i]) < 59)
                {
                    if (chislo_1 == 0)
                    {
                        short temp = 0;
                        while (Convert.ToInt16(uravnenie[i]) > 47 && Convert.ToInt16(uravnenie[i]) < 59)
                        {
                            chislo_1 = (short)(chislo_1 * Math.Pow(10, temp) + short.Parse(uravnenie[i].ToString()));
                            i++;
                            temp++;
                        }
                    }
                    else
                    {
                        short temp = 0;
                        while (Convert.ToInt16(uravnenie[i]) > 47 && Convert.ToInt16(uravnenie[i]) < 59)
                        {
                            chislo_2 = (short)(chislo_2 * Math.Pow(10, temp) + short.Parse(uravnenie[i].ToString()));
                            i++;
                            temp++;
                        }
                    }
                }
                else if (Convert.ToInt16(uravnenie[i]) == 43)
                    math_operation = '+';
                else if (Convert.ToInt16(uravnenie[i]) == 45)
                    math_operation = '-';
                if (math_operation == '+')
                    chislo_1 += chislo_2;
                else if (math_operation == '-')
                    chislo_1 -= chislo_2;
                chislo_2 = 0;
            }
            Console.WriteLine($"Otvet: {chislo_1}");
            */

            /*
            Задание 6
            Console.Write("Vvedite text: ");
            string text = Console.ReadLine();
            for (short i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    while (true)
                    {
                        i++;
                        if (i != text.Length)
                        {
                            if (text[i] != ' ' && !Char.IsUpper(text[i]))
                            {
                                char[] char_arr = text.ToCharArray();
                                char_arr[i] = Convert.ToChar(Convert.ToInt16(text[i]) - 32);
                                text = new string(char_arr);
                                break;
                            }
                        }
                        else
                            break;
                    }
                }
                else if (i == 0 && !Char.IsUpper(text[i]))
                {
                    char[] char_arr = text.ToCharArray();
                    char_arr[i] = Convert.ToChar(Convert.ToInt16(text[i]) - 32);
                    text = new string(char_arr);
                }
            }
            Console.WriteLine($"Otkorekyirovanii text: {text}");
            */

            /*
              Задание 7
              Console.Write("Vvedite text: ");
              string text = Console.ReadLine();
              Console.Write("Vvedite zaprechonoe slovo: ");
              string zaprechenoe_slovo = Console.ReadLine();
              string izmenenie = new string('*', zaprechenoe_slovo.Length);
              text = text.Replace(zaprechenoe_slovo, izmenenie);
              Console.Write($"Izmenenii text: {text}");
            */
        }
    }
}
