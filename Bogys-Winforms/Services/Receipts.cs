using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Services
{
    class Receipts
    {
        private string receiptText = "";
        public void PrintReceipt(string customername, int videoId, string videoTitle, string category,
                                        int rentDays, DateOnly rentDate, DateOnly returnDate, int price)
        {
            string rentDateStr = rentDate.ToString("MM/dd/yyyy");
            string returnDateStr = returnDate.ToString("MM/dd/yyyy");
            float priceFloat = (float)price;
            string formattedPrice = priceFloat.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-PH"));

            receiptText = "";
            receiptText += "===== Bogsy Video Rental Store =====\n\n";
            receiptText += "-----       Rent Receipt       -----\n\n";
            receiptText += $"Customer Name: {customername}\n\n";
            receiptText += $"Video ID    : {videoId}\n\n";
            receiptText += $"Title       : {videoTitle}\n\n";
            receiptText += $"Category    : {category}\n\n";
            receiptText += $"Rent Date   : {rentDateStr}\n\n";
            receiptText += $"Return Date : {returnDateStr}\n\n\n";
            receiptText += $"Video Price : {formattedPrice}\n\n\n";
            receiptText += $"Thank you for renting {videoTitle} for {rentDays} day(s).\n\n";
            receiptText += $"Note: Please return it during {returnDateStr}. A charge of ₱5.00 pesos per day will be the consequence.\n";

            PrintDocument printDoc = new PrintDocument();

            PaperSize receiptSize = new PaperSize("Receipt", 315, 375);
            printDoc.DefaultPageSettings.PaperSize = receiptSize;
            printDoc.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);

            printDoc.PrintPage += PrintDoc_PrintPage;

            using (PrintPreviewDialog printDialog = new PrintPreviewDialog())
            {
                printDialog.Document = printDoc;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            printDoc.PrintPage -= PrintDoc_PrintPage;
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Font printFont = new Font("Courier New", 8))
            {
                e.Graphics.DrawString(receiptText, printFont, Brushes.Black,
                    new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height));
            }
        }
        public void PrintReturnReceipt(string customername, int videoId, string videoTitle, string category,
                                        int rentDays, DateOnly rentDate, DateOnly returnDate, int price, DateOnly actualReturnDate)
        {
            string rentDateStr = rentDate.ToString("MM/dd/yyyy");
            string returnDateStr = returnDate.ToString("MM/dd/yyyy");
            float priceFloat = (float)price;
            string formattedPrice = priceFloat.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-PH"));

            receiptText = "";
            receiptText += "===== Bogsy Video Rental Store =====\n\n";
            receiptText += "-----      Return Receipt      -----\n\n";
            receiptText += $"Date Returned :{actualReturnDate}\n\n";
            receiptText += $"Customer Name : {customername}\n\n";
            receiptText += $"Video ID      : {videoId}\n\n";
            receiptText += $"Title         : {videoTitle}\n\n";
            receiptText += $"Category      : {category}\n\n";
            receiptText += $"Rent Day(s)   : {rentDays}\n\n";
            receiptText += $"Rent Date     : {rentDateStr}\n\n";
            receiptText += $"Return Date   : {returnDateStr}\n\n";
            receiptText += $"Due Charge    : {formattedPrice}\n\n\n";
            receiptText += $"Thank you for renting at the Bogsy Video Rental Store.\n\n";
            receiptText += $"Please Rent again!";

            PrintDocument printDoc = new PrintDocument();

            PaperSize receiptSize = new PaperSize("Receipt", 315, 375);
            printDoc.DefaultPageSettings.PaperSize = receiptSize;
            printDoc.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);

            printDoc.PrintPage += PrintDoc_PrintPage2;

            using (PrintPreviewDialog printDialog = new PrintPreviewDialog())
            {
                printDialog.Document = printDoc;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            printDoc.PrintPage -= PrintDoc_PrintPage2;
        }
        private void PrintDoc_PrintPage2(object sender, PrintPageEventArgs e)
        {
            using (Font printFont = new Font("Courier New", 8))
            {
                e.Graphics.DrawString(receiptText, printFont, Brushes.Black,
                    new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height));
            }
        }

    }
}
