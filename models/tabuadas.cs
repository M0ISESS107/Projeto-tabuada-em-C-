using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Tabuadas.models
{
    public class Tabuada
    {
        public void tabuadasrep()
        {
            string msg = "1- tabuada com o for, 2- tabuada com while, 3- tabuada com o Do while";
            Console.WriteLine(msg);
            int Alternativa = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"porfavor diga qual tabuada vc deseja!");
            int numero = Convert.ToInt32(Console.ReadLine());
            int contador = 1;


            switch (Alternativa)
            {


                case 1:


                    for (int cont = 1; cont <= 10; cont++)
                    {
                        Console.WriteLine($"{numero} X {cont} = {numero * cont}");
                    }
                    break;
                case 2:
                   
                    while (contador <= 10)
                    {
                        Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                        contador++;
                    }

                    break;
                case 3:{
                    do{
                         Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                         contador++;

                    }while(contador<=10);

                }break;
                default:
                    Console.WriteLine($"Porvaor escolha uma opção valida");
                    break;
            }
        }
    }
}