using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inovaProyCalcMatriz_WindForms2
{
    
    public partial class Form1 : Form
    {
        int q;
        double determinante;
        bool rs; // para decidie si es una suma o una resta
        bool dm; // para decidir si es una division o una multiplicacion
        bool operacion; // para decidir si es para rs o dm, rs true dm falase
        int m1; // indica el renglon principal
        int m2; // indica el reglon secundario
        int m3;// indica donde se guarda el resultado
        int ndm; //indica el numero que se va a multiplicar o que va a dividir
        int n; // dimension de la matriz
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dm = false;
            operacion = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Todos los datos que nos proporcione numericUpDown se guardaran en la variable "n"
            n = (int)numericUpDown1.Value;
            do
            {
                n = (int)numericUpDown1.Value;


                if (n > 3)
                {
                    MessageBox.Show("Escribe una matriz mas pequeña");
                    n = 3;
                }
                else if (n < 2)
                {
                    MessageBox.Show("Escribir una matriz mas grande");
                    n = 2;
                }

            } while (n < 1 || n > 3);

            MatA.Columns.Clear();
            MatriA.Columns.Clear();
            MatriB.Columns.Clear();
            MatriC.Columns.Clear();
            MatriD.Columns.Clear();


            for (int i = 0; i < n; i++)
            {
                DataGridViewColumn columna1 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna1.Name = (i + 1).ToString();
                columna1.Width = 24;
                MatA.Columns.Add(columna1);
                DataGridViewColumn columna2 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna2.Name = (i + 1).ToString();
                columna2.Width = 24;
                MatriA.Columns.Add(columna2);
                DataGridViewColumn columna3 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna3.Name = (i + 1).ToString();
                columna3.Width = 24;
                MatriB.Columns.Add(columna3);
                DataGridViewColumn columna4 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna3.Name = (i + 1).ToString();
                columna3.Width = 24;
                MatriC.Columns.Add(columna4);
                DataGridViewColumn columna5 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna4.Name = (i + 1).ToString();
                columna4.Width = 24;
                MatriD.Columns.Add(columna5);
            }
            MatA.Rows.Add(n);
            MatriA.Rows.Add(n);
            MatriB.Rows.Add(n);
            MatriC.Rows.Add(n);
            MatriD.Rows.Add(n);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rs= true;
            operacion= true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            bool n1;
            if (n > 2) //matriz de 3x3 
            {
                n1 = true;
            }
            else { n1 = false; } //matriz de 2x2
            double PD;//POSITIVO DETERMIANTE
            double ND; // NEGATIVO DETERMINANTE

            if (n1 == true)
            {
                PD = double.Parse(MatA[0, 0].Value.ToString()) * double.Parse(MatA[1, 1].Value.ToString()) * double.Parse(MatA[2, 2].Value.ToString()) + double.Parse(MatA[1, 0].Value.ToString()) * double.Parse(MatA[2, 1].Value.ToString()) * double.Parse(MatA[0, 2].Value.ToString()) + double.Parse(MatA[2, 0].Value.ToString()) * double.Parse(MatA[0, 1].Value.ToString()) * double.Parse(MatA[1, 2].Value.ToString());
                ND = double.Parse(MatA[2, 0].Value.ToString()) * double.Parse(MatA[1, 1].Value.ToString()) * double.Parse(MatA[0, 2].Value.ToString()) + double.Parse(MatA[0, 0].Value.ToString()) * double.Parse(MatA[2, 1].Value.ToString()) * double.Parse(MatA[1, 2].Value.ToString()) + double.Parse(MatA[1, 0].Value.ToString()) * double.Parse(MatA[0, 1].Value.ToString()) * double.Parse(MatA[2, 2].Value.ToString());
                determinante = PD - ND;
            }
            else if (n1 == false)
            {
                PD = double.Parse(MatA[0, 0].Value.ToString()) * double.Parse(MatA[1, 1].Value.ToString());
                ND = double.Parse(MatA[1, 0].Value.ToString()) * double.Parse(MatA[1, 0].Value.ToString());
                determinante = PD - ND;
            }
            MessageBox.Show("La determinante es: " + determinante);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rs = false;
            operacion= true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dm = true;
            operacion = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatriA[i, j].Value = int.Parse(MatriC[i, j].Value.ToString());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatriB[i, j].Value = int.Parse(MatriD[i, j].Value.ToString());
                }
            }
            if (operacion == true)
            {
                if (rs == true) //si rs es true se suma los renglones
                {
                    for (int i = 0; i < n; i++)
                    {
                        MatriD[q, i].Value = int.Parse(MatriA[n, i].Value.ToString())
                           + int.Parse(ndm.ToString());
                    }
                }
                else if (rs == false) //si rs es false se resta los renglones
                {
                    for (int i = 0; i < n; i++)
	                {
                  
                        MatriD[q, i].Value = int.Parse(MatriA[n, i].Value.ToString())
                           - int.Parse(ndm.ToString());
                    }
                }
            }
            else if (operacion == false) 
            {
                if (dm == true) //si rs es true se suma los renglones
                {
                    for (int i = 0; i < n; i++)
                    {

                        MatriD[q, i].Value = int.Parse(MatriA[n, i].Value.ToString())
                           * int.Parse(ndm.ToString());
                        
                    }
                }
                else if (dm == false) //si rs es false se resta los renglones
                {
                    for (int i = 0; i < n; i++)
                    {
                        MatriD[q, i].Value = int.Parse(MatriA[n, i].Value.ToString()) 
                            / int.Parse(ndm.ToString());
                    }
                }
            }
            m1 = -1;
            m2 = -1;
            m3 = -1;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MatA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void llenado9_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatA[i, j].Value = r.Next(10) + 1;
                    //MatB[i, j].Value = r.Next(10) + 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatriC[i,j].Value = int.Parse(MatA[i,j ].Value.ToString());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                { if (i == j)
                    {
                        MatriD[i, j].Value = int.Parse(1.ToString());
                    }
                    else { MatriD[i,j].Value = int.Parse(0.ToString()); }
                    MatriC[i, j].Value = int.Parse(MatA[i, j].Value.ToString());
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (m1 ==  1)
            { }
            else if (m1 == 2)
            { }else { m1 = 0; }

            if (m2 == 1)
            { }
            else if (m2 == 2)
            { }
            else { m2 = 0; }

            if (m3 == 1)
            { }
            else if (m3 == 2)
            { }
            else { m3 = 0; }


        }

        private void MatriC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (m1 == 0)
            { }
            else if (m1 == 2)
            { }
            else { m1 = 1; }

            if (m2 == 0)
            { }
            else if (m2 == 2)
            { }
            else { m2 = 1; }

            if (m3 == 0)
            { }
            else if (m3 == 2)
            { }
            else { m3 = 1; }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (m1 == 1)
            { }
            else if (m1 == 0)
            { }
            else { m1 = 2; }

            if (m2 == 1)
            { }
            else if (m2 == 0)
            { }
            else { m2 = 2; }

            if (m3 == 1)
            { }
            else if (m3 == 0)
            { }
            else { m3 = 2; }
        }
    }
}