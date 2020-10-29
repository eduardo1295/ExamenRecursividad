using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenRecursividad
{
    public partial class Form1 : Form
    {
        string cambio = "minimo";
        string bin = "";
        string oct = "";
        string hex = "";
        string ulm = "";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            bin = ""; oct = ""; hex = ""; ulm = "";
            Random n = new Random();
            int numeroaleatorio = n.Next(1, 1000);
            
            binario(numeroaleatorio);
            octal(numeroaleatorio);
            hexadecimal(numeroaleatorio);
            label2.Text = string.Format("El numero aleatorio es: {0} \nBinario es: {1} \nOctal es: {2} \nHexadecimal es: {3}"
                          , numeroaleatorio, bin,oct,hex);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            ulm = "";
            Random n = new Random();
            int numeroaulam = n.Next(1, 100);
            ulam(numeroaulam);
            MessageBox.Show(ulm);
        }

        public void binario(int n) {
            if (n > 1)
            {
                binario(n / 2);
                bin += (n % 2 == 0) ? "0" : "1";
            }
            else
            {
                bin += "1";
            }
        }
        public void octal(int n)
        {
            if (n > 8)
            {
                octal(n / 8);
                oct += (n % 8).ToString();
            }
            else
            {
                oct += n;  
            }
        }
        public void hexadecimal (int n)
        {
            if(n > 16)
            {
                hexadecimal(n / 16);
                int reciduo = n % 16;
                hexaTomarLetra(reciduo);
            }
            else
            {
                hexaTomarLetra(n);
            }
        }

        public void hexaTomarLetra( int reciduo)
        {
            if (reciduo < 10)
            {
                hex += reciduo.ToString();
            }
            else
            {
                switch (reciduo)
                {
                    case 10:
                        hex += "A";
                        break;
                    case 11:
                        hex += "B";
                        break;
                    case 12:
                        hex += "C";
                        break;
                    case 13:
                        hex += "D";
                        break;
                    case 14:
                        hex += "E";
                        break;
                    case 15:
                        hex += "F";
                        break;
                    case 16:
                        hex += "10";
                        break;
                }
            }
            
        }

        public void ulam(int numero)
        {
            if( numero > 1) {
                if( numero  % 2 == 0)
                {
                    ulm += numero.ToString() + "; ";
                    ulam(numero / 2);
                }
                else
                {
                    ulm += numero.ToString() + "; ";
                    ulam((numero * 3) + 1 );
                }
            }
            else { ulm += " 1;"; }
        }

        
    }
}
