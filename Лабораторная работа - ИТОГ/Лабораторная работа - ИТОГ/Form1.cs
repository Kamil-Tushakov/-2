using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Лабораторная_работа___ИТОГ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileStream file = null;
        private void button1_Click(object sender, EventArgs e)
        {

        string Doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        float[,] mas;

        Random rand = new Random();
        int arrayL = Convert.ToInt32(Console.ReadLine());
        int arrayL2 = Convert.ToInt32(Console.ReadLine());
        if (file != null)
        {
            file.Close();
        }
        System.IO.File.Delete(Doc + @"\filee.txt");
        string stroka = "";
        mas = new float[arrayL, arrayL2];
        file = new FileStream(Doc + @"\filee.txt", FileMode.OpenOrCreate);
        for (int i = 0; i < arrayL2; i++)
        {
            for (int j = 0; j < arrayL; j++)
            {
                mas[i, j] = rand.Next(100);
                stroka += $"{mas[i, j].ToString()} ";
            }
            stroka += "\n";
            byte[] arr = Encoding.Default.GetBytes(stroka);
            file.Write(arr, 0, arr.Length);
            stroka = "";
        }

        if (file != null)
        {
            file.Close();
        }
    
    }
}
    }

