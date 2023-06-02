using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Threading;
using FinTech1.Data;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace FinTech1
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
            Thread fc = new Thread(FillComboBox);
            fc.Start();
            
           

        }

        void FillComboBox()
        {
            //заполнение комбобокс именами из таблицы
            if (comboBox1.InvokeRequired)
            {
                comboBox1.BeginInvoke(new System.Action(delegate ()
                {
                    
                    DataControl dc = new DataControl();
                    comboBox1.DataSource = dc.Get_Names();

                }
                ));
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //объявление классов
            DataControl dc = new DataControl();
            Izdel izdel = dc.GetIzdels(comboBox1.Text)[0]; //поиск по выбранному изделию
            List<Products> products = new List<Products>();
            Link linkL1 = dc.GetLinks(izdel.Id)[0];

            //вызов Офиса и наполнение его первой строкой
            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            exApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet wsh = exApp.ActiveSheet;
            wsh.Cells[1, 1] = "Изделие";
            wsh.Cells[1, 2] = "Кол-во";
            wsh.Cells[1, 3] = "Стоимость";
            wsh.Cells[1, 4] = "Цена";


            List <Link> links1 = new List<Link>(dc.GetLinks(izdel.Id));
            double priceL2 = 0.0;
            List<Products> productsL3 = new List<Products>();
            List<Products> productsL2 = new List<Products>();

            //поиск необходимых зависимостей
            for (int i = 0; i < links1.Count(); i++)
            {
                productsL3.Clear();

                List<Link> links2 = new List<Link>(dc.GetLinks(links1[i].Izdel));
                double priceL3 = 0.0;
                for (int j = 0; j < links2.Count(); j++)
                {
                    Izdel izdelL3 = dc.GetIzdelsById(links2[j].Izdel)[0];
                    productsL3.Add(new Products("      " + izdelL3.Name, links2[j].Count, Convert.ToDouble(links2[j].Count * izdelL3.Price), izdelL3.Price));
                    priceL3 += Convert.ToDouble(links2[j].Count * izdelL3.Price);
                    
                }
                
                Izdel izdelL2 = dc.GetIzdelsById(links1[i].Izdel)[0];
                productsL2.Add(new Products("   " + izdelL2.Name, links1[i].Count, Convert.ToDouble(links1[i].Count * izdelL2.Price) + priceL3, izdelL2.Price));
                for (int j = 0; j < productsL3.Count(); j++)
                {
                    productsL2.Add(productsL3[j]);
                   
                }

                priceL2 += Convert.ToDouble(links1[i].Count * izdelL2.Price) + priceL3;

            }

            linkL1.Count = 1;

            Products productL1 = new Products(izdel.Name, linkL1.Count, Convert.ToDouble(linkL1.Count * izdel.Price) + priceL2, izdel.Price);

            products.Add(productL1);
            for (int i = 0; i < productsL2.Count(); i++)
            {
                products.Add(productsL2[i]);
               

            }
            
           
            //ввывод в офис
            dataGridView1.DataSource = products;
            for (int i = 1; i < dataGridView1.RowCount + 1; i++) 
            {
                
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                {
                    var value = products[j];
                   
                    wsh.Cells[i+1,j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            
            exApp.Visible = true;
        }
    }
}
