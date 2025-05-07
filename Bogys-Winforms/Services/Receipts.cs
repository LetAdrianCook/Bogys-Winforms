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
        private static string receiptText = "";

        public static void PrintReceipt(string customername, int videoId, string sloganTitle, string category,
                                        int rentDays, DateOnly rentDate, DateOnly returnDate, int price)
        {
            string rentDateStr = rentDate.ToString("MM/dd/yyyy");
            string returnDateStr = returnDate.ToString("MM/dd/yyyy");
            float priceFloat = (float)price;
            string formattedPrice = priceFloat.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-PH"));

            receiptText = "";
            receiptText += "===== Bogsy Video Rental Store =====\n\n";
            receiptText += $"Customer Name: {customername}\n\n";
            receiptText += $"Video ID    : {videoId}\n\n";
            receiptText += $"Title       : {sloganTitle}\n\n";
            receiptText += $"Category    : {category}\n\n";
            receiptText += $"Rent Date   : {rentDateStr}\n\n";
            receiptText += $"Return Date : {returnDateStr}\n\n\n";
            receiptText += $"Video Price : {formattedPrice}\n\n\n";
            receiptText += $"Thank you for renting {sloganTitle} for {rentDays} day(s).\n\n";
            receiptText += $"Note: Please return it during {returnDateStr}. A charge of ₱5.00 pesos per day will be the consequence.\n";

            PrintDocument printDoc = new PrintDocument();

            PaperSize receiptSize = new PaperSize("Receipt", 315, 800);
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

        private static void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Font printFont = new Font("Courier New", 8))
            {
                e.Graphics.DrawString(receiptText, printFont, Brushes.Black,
                    new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height));
            }
        }

    }
}
