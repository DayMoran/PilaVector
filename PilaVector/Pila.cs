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
            top = -1;
            Console.WriteLine("La pila ha sido limpiada.");
        }
    }
}
