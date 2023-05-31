using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTech1.UploadExcel
{
    class Excel
    {
        /*
        List<Sheets> sheats = new List<Sheets>();
        //List<Worker> workers = new List<Worker>();
        private Microsoft.Office.Interop.Excel.Application ObjExcel;
        private Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
        private Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;

        public void WriteToExcelFile(string[,] masData, List<Sheets> sht)
        {
            string fileName = @"Z:\ARM";
            try
            {
                ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
                ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

                for (int i = 0; i < sht.Count; i++)
                {
                    ObjExcel.Cells[1, i + 1] = sht[i].name;
                }


                for (int i = 0; i < masData.GetLength(0); i++)
                {
                    for (int j = 0; j < masData.GetLength(1); j++)
                    {

                        if (masData[i, j] == "FALSE")
                        {

                            (ObjWorkSheet.Cells[j + 2, i + 1] as Range).Interior.Color = Microsoft.Office.Interop.Excel.XlRgbColor.rgbRed;
                            (ObjWorkSheet.Cells[j + 2, i + 1] as Range).Borders.Color = Microsoft.Office.Interop.Excel.XlRgbColor.rgbWhite;
                            (ObjWorkSheet.Cells[j + 2, i + 1] as Range).Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                        }
                        else if (masData[i, j] == "TRUE")
                        {
                            (ObjWorkSheet.Cells[j + 2, i + 1] as Range).Interior.Color = Microsoft.Office.Interop.Excel.XlRgbColor.rgbGreen;
                            (ObjWorkSheet.Cells[j + 2, i + 1] as Range).Borders.Color = Microsoft.Office.Interop.Excel.XlRgbColor.rgbWhite;
                            (ObjWorkSheet.Cells[j + 2, i + 1] as Range).Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                        }
                        else
                        {
                            ObjExcel.Cells[j + 2, i + 1] = masData[i, j];
                        }
                        //MessageBox.Show(masData[i, j] + Environment.NewLine + i.ToString() + Environment.NewLine + masData.GetLength(0).ToString());

                    }
                    //ObjExcel.Cells[i + 2, 1] = (i + 1).ToString();


                }
                //MessageBox.Show("ТУТ");

                ObjWorkSheet.Columns.AutoFit();
                //ObjExcel.Cells.
                Range range1 = ObjWorkSheet.get_Range(ObjWorkSheet.Cells[1, 1], ObjWorkSheet.Cells[1, masData.GetLength(1)]);
                range1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ObjWorkBook.SaveCopyAs(fileName);


                //ObjWorkBook.Save();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }

            ObjWorkBook.Close(false, "", Type.Missing);
            // Закрытие приложения Excel.
            ObjExcel.Quit();
            ObjWorkBook = null;
            ObjWorkSheet = null;
            ObjExcel = null;
            GC.Collect();
            Process.Start(fileName);
        }
        */
    }
}
