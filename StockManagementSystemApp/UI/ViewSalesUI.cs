using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class ViewSalesUI : Form
    {
        public ViewSalesUI()
        {
            InitializeComponent();
            fromdateTimePicker.Format = DateTimePickerFormat.Custom;
            fromdateTimePicker.CustomFormat = "yyyy-MM-dd";
            todateTimePicker.Format = DateTimePickerFormat.Custom;
            todateTimePicker.CustomFormat = "yyyy-MM-dd";

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int sr = 1;
            StockManageManager stockManageManager=new StockManageManager();
            List<Item> itemList= stockManageManager.GetSalesItems(fromdateTimePicker.Text, todateTimePicker.Text);
            foreach (Item  items in itemList)
            {
                int ck = 0;
                foreach (ListViewItem lvi in listView1.Items)
                {
                    string itemName = lvi.SubItems[2].Text;
                    int quantity = Convert.ToInt32(lvi.SubItems[3].Text);
                    if ((items.ItemName == itemName))
                    {
                        lvi.SubItems[3].Text = (items.GetQuantity()+ quantity).ToString();
                        ck = 1;
                        break;
                    }
                }
                if (ck == 0)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = sr++.ToString();
                    item.SubItems.Add(items.CompanyName);
                    item.SubItems.Add(items.ItemName);
                    item.SubItems.Add(items.GetQuantity().ToString());
                    listView1.Items.Add(item);
                }
            }
        }
        public String GetTimestamp(DateTime value)
        {
            return value.ToString("\ndd-MM-yyyy \nHH-mm-ss");
        }
        private void generatePDFbutton_Click(object sender, EventArgs e)
        {
            Paragraph paragraph=new Paragraph();
            paragraph.Add("Stock Management System\n\n");

            paragraph.Add("Generating Time : "+GetTimestamp(DateTime.Now)+"\n\n");
            
           
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(listView1.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
           
            //Adding Header row
            foreach (ColumnHeader column in listView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (ListViewItem itemRow in listView1.Items)
            {
                int i = 0;
                for (i = 0; i < itemRow.SubItems.Count ; i++)
                {
                    pdfTable.AddCell(itemRow.SubItems[i].Text);
                }
            }
            Paragraph paragraph2=new Paragraph();
            paragraph2.Add("\n\nPowered by Akib");
            paragraph2.Alignment = Right;
            //Exporting to PDF
            string folderPath = @"C:\Users\Trainer 402\Desktop\Project 1\Batch 56\Stack_Underflow\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "ViewSales "+fromdateTimePicker.Text+" To "+todateTimePicker.Text+".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(paragraph);
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(paragraph2);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Please Check Your Project Folder");
        }
    }
}
