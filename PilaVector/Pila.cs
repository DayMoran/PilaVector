using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaVector
{
    public class Pila
    {
        int max;
        int[] pila;
        int top;
        public Pila(int tam)
        {
            max= tam;
            pila= new int[max];
            top = -1;
        }
        public bool pilaVacia()
        {
            if (top<0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool pilaLlena()
        {
            if (top==max-1)
            {
                return true;
            }
            else
            {
                return false ;
            }
        }

        public void push(int dato)
        {
            if (pilaLlena()==false)
            {
                top++;
                pila[top] = dato;
            }
            else
            {
                Console.WriteLine("La pila Esta LLena...!!!");
            }
        }
        public int pop()
        {
            int dato=-1;
            if (pilaVacia()==false)
            {
                dato = pila[top];
                top--;
            }
            else
            {
                Console.WriteLine("La Pila esta Vacia...!!!");
            }
            return dato;
        }

        public void muestraPila()
        {
            if (pilaVacia()==false)
            {
                for (int i = top; i >=0; i--)
                {
                    Console.WriteLine("[{0}]", pila[i]);
                }

            }
        }

        public void LimpiarPila()
        {

            while (!pilaVacia())
            {
                pop();
            }
            Console.WriteLine("La pila ha sido limpiada.");
        }

        public void ContarElementos()
        {
            Console.WriteLine("La pila tiene: {0} elementos.", top + 1); 
        }

        public void MostrarElementoMayor()
        {
            if (!pilaVacia())
            {
                int maxElemento = pila[0];
                for (int i = 1; i <= top; i++)
                {
                    if (pila[i] > maxElemento)
                    {
                        maxElemento = pila[i];
                    }
                }
                Console.WriteLine("El elemento mayor en la pila es: {0}", maxElemento);
            }
            else
            {
                Console.WriteLine("La pila está vacía!");
            }
        }

        public void MostrarElementoMenor()
        {
            if (!pilaVacia())
            {
                int minElemento = pila[0];
                for (int i = 1; i <= top; i++)
                {
                    if (pila[i] < minElemento)
                    {
                        minElemento = pila[i];
                    }
                }
                Console.WriteLine("El elemento menor en la pila es: {0}", minElemento);
            }
            else
            {
                Console.WriteLine("La pila está vacía!");
            }
        }
    }
}
