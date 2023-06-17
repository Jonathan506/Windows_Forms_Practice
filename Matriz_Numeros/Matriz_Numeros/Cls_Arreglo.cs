using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Matriz_Numeros
{
    class Cls_Arreglo
    {
        int i, suma=0, producto=1;
        int[] arreglo = new int[10];

        public void ingresar() 
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = int.Parse(Interaction.InputBox("Agregar Dato"));

                if (arreglo[i] > 0)
                {
                    suma += arreglo[i];
                }
                if (arreglo[i] < 0)
                {
                    producto *= arreglo[i];
                }
            }
        }

        public void mostrar(ListBox mostrar) 
        {
            mostrar.Items.Clear();

            for (int i = 0; i < arreglo.Length; i++)
            {
                mostrar.Items.Add(arreglo);
            }
            MessageBox.Show($"La suma de los número positivos es : {suma} y el producto de los números negativos es de : {producto}");
        }
    }
}
