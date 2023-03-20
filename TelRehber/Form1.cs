using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using TelRehber.Models;
using System.IO;
using System.Drawing.Printing;
using QRCoder;

namespace TelRehber
{
    public partial class FormRehber : Form
    {
        private ConnectionTelRehberDBEntities db = new ConnectionTelRehberDBEntities();

        public FormRehber()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Hide();

            dataGridViewTelRehber.DataSource = db.kisiler.ToList();

            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            labelDate.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void dataGridViewTelRehber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxName.Text = dataGridViewTelRehber.CurrentRow.Cells[1].Value.ToString();
            txtBoxSurname.Text = dataGridViewTelRehber.CurrentRow.Cells[2].Value.ToString();
            txtBoxTelNo.Text = dataGridViewTelRehber.CurrentRow.Cells[3].Value.ToString();

            string qrcode = dataGridViewTelRehber.CurrentRow.Cells[3].Value.ToString();
            // Generate the QR code for the cell value
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrcode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(4);

            // Show the QR code image
            pictureBoxQR.Image = qrCodeImage;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            kisiler yeniKisi = new kisiler();
            yeniKisi.Adı = txtBoxName.Text;
            yeniKisi.Soyadı = txtBoxSurname.Text;
            yeniKisi.Telefonu = txtBoxTelNo.Text;

            string isim_sorgula = dataGridViewTelRehber.CurrentRow.Cells[1].Value.ToString();
            string soyisim_sorgula = dataGridViewTelRehber.CurrentRow.Cells[2].Value.ToString();
            if (yeniKisi.Adı != isim_sorgula && yeniKisi.Soyadı != isim_sorgula)
            {
                db.kisiler.Add(yeniKisi);
                db.SaveChanges();
                dataGridViewTelRehber.DataSource = db.kisiler.ToList();
            }
            else
            {
                MessageBox.Show("Bu kişi zaten kayıtlarda var. aynı isim ve soyisimde yeni birini ekleyemezsiniz.", "DUR !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*Bu alana sistem için yetkilendirme işlemi ekleyeceğim.*/
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewTelRehber.CurrentRow.Cells[0].Value.ToString());

            kisiler sil_kisi = db.kisiler.FirstOrDefault(x => x.ID == id);

            /*Bir messagebox ile gerçekten silinip silinmek istemediği sorulsun*/

            DialogResult silinsin_mi = new DialogResult();
            silinsin_mi = MessageBox.Show($@"{sil_kisi.Adı} {sil_kisi.Soyadı} İsimli personel kalıcı olarak silinecek. Onaylıyor Musunuz?", "Kalıcı Olarak Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silinsin_mi == DialogResult.Yes)
            {
                /*Silme işlemi gerçeklessin*/
                db.kisiler.Remove(sil_kisi);
                /* degisiklikler veritabanına kaydedilsin */
                db.SaveChanges();
                /*datagridviev güncelle*/
                dataGridViewTelRehber.DataSource = db.kisiler.ToList();

                /*silindikten sonra textboxların içini bosalt*/
                txtBoxName.Text = txtBoxSurname.Text = txtBoxTelNo.Text = null;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewTelRehber.CurrentRow.Cells[0].Value.ToString());

            kisiler updt_kisi = db.kisiler.FirstOrDefault(x => x.ID == id);
            updt_kisi.Adı = txtBoxName.Text;
            updt_kisi.Soyadı = txtBoxSurname.Text;
            updt_kisi.Telefonu = txtBoxTelNo.Text;

            db.SaveChanges();

            dataGridViewTelRehber.DataSource = db.kisiler.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = txtBoxSrch.Text;

            kisiler kisi_ara = db.kisiler.FirstOrDefault(x => x.Adı == search | x.Soyadı == search);

            if (kisi_ara != null)
            {
                dataGridViewTelRehber.DataSource = kisi_ara.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewTelRehber.DataSource = db.kisiler.ToList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            labelDate.Text = currentTime.ToString("yyyy hh:mm:ss, dddd, MMMM dd");

            if (labelName.Left > -240)
            {
                labelName.Left -= 1;
            }
            else
            {
                labelName.Left = 350;
            }
        }

        private void labelDate_Click(object sender, EventArgs e)
        {
        }

        private void buttonXls_Click(object sender, EventArgs e)
        {
            // Get the path to the desktop folder
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Create a new Excel workbook and worksheet
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Add();
            var worksheet = workbook.Sheets[1];

            // Loop through each row and column in the DataGridView
            for (int i = 0; i < dataGridViewTelRehber.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewTelRehber.Columns.Count; j++)
                {
                    // Add the cell value to the corresponding cell in the Excel worksheet
                    worksheet.Cells[i + 1, j + 1] = dataGridViewTelRehber.Rows[i].Cells[j].Value;
                }
            }

            // Save the Excel workbook on the desktop
            string filePath = Path.Combine(desktopPath, "TelRehber.xlsx");
            workbook.SaveAs(filePath);
            workbook.Close();
            excelApp.Quit();
            MessageBox.Show("Belgeniz başarı ile masaüstü konumuna kaydedilmiştir");
        }

        private void buttonDocx_Click(object sender, EventArgs e)
        {
            // Create a new instance of Word
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Document doc = word.Documents.Add();

            // Create a table with the same number of rows and columns as the DataGridView
            Table table = doc.Tables.Add(doc.Range(), dataGridViewTelRehber.RowCount, dataGridViewTelRehber.ColumnCount);

            // Copy the data from the DataGridView to the table
            for (int i = 0; i < dataGridViewTelRehber.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewTelRehber.ColumnCount; j++)
                {
                    table.Cell(i + 1, j + 1).Range.Text = dataGridViewTelRehber[j, i].Value.ToString();
                }
            }

            // Save the document on the desktop
            object filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TelRehber.docx";
            doc.SaveAs2(ref filename);
            MessageBox.Show("Belgeniz başarıyla masaüstüne kaydedilmiştir.");
            // Close Word
            ((Microsoft.Office.Interop.Word._Document)doc).Close();
            ((Microsoft.Office.Interop.Word._Application)word).Quit();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            DataGridView dgv = dataGridViewTelRehber;
            int rowHeight = dgv.RowTemplate.Height;
            int columnWidth;
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int cellHeight;
            int cellWidth;
            int rowCount = dgv.Rows.Count;
            int columnCount = dgv.Columns.Count;
            string cellValue;

            // Print column headers
            for (int i = 0; i < columnCount; i++)
            {
                columnWidth = dgv.Columns[i].Width;
                cellHeight = rowHeight;
                cellWidth = columnWidth;
                cellValue = dgv.Columns[i].HeaderText;
                e.Graphics.FillRectangle(Brushes.LightGray, new System.Drawing.Rectangle(x, y, cellWidth, cellHeight));
                e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle(x, y, cellWidth, cellHeight));
                e.Graphics.DrawString(cellValue, dgv.ColumnHeadersDefaultCellStyle.Font, Brushes.Black, new RectangleF(x, y, cellWidth, cellHeight), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                x += cellWidth;
            }
            y += rowHeight;

            // Print rows
            for (int i = 0; i < rowCount; i++)
            {
                x = e.MarginBounds.Left;
                for (int j = 0; j < columnCount; j++)
                {
                    columnWidth = dgv.Columns[j].Width;
                    cellHeight = rowHeight;
                    cellWidth = columnWidth;
                    cellValue = dgv.Rows[i].Cells[j].FormattedValue.ToString();
                    e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle(x, y, cellWidth, cellHeight));
                    e.Graphics.DrawString(cellValue, dgv.DefaultCellStyle.Font, Brushes.Black, new RectangleF(x, y, cellWidth, cellHeight), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    x += cellWidth;
                }
                y += rowHeight;
            }
        }
    }
}