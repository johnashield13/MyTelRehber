namespace TelRehber
{
    partial class FormRehber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRehber));
            this.dataGridViewTelRehber = new System.Windows.Forms.DataGridView();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTelNo = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonDocx = new System.Windows.Forms.Button();
            this.buttonXls = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxSrch = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelRehber)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTelRehber
            // 
            this.dataGridViewTelRehber.AllowUserToAddRows = false;
            this.dataGridViewTelRehber.AllowUserToDeleteRows = false;
            this.dataGridViewTelRehber.AllowUserToResizeColumns = false;
            this.dataGridViewTelRehber.AllowUserToResizeRows = false;
            this.dataGridViewTelRehber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTelRehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTelRehber.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTelRehber.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewTelRehber.Location = new System.Drawing.Point(15, 14);
            this.dataGridViewTelRehber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridViewTelRehber.MultiSelect = false;
            this.dataGridViewTelRehber.Name = "dataGridViewTelRehber";
            this.dataGridViewTelRehber.Size = new System.Drawing.Size(660, 463);
            this.dataGridViewTelRehber.TabIndex = 0;
            this.dataGridViewTelRehber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTelRehber_CellContentClick);
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Location = new System.Drawing.Point(111, 26);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(49, 22);
            this.labelNameSurname.TabIndex = 0;
            this.labelNameSurname.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soyadı :";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(166, 26);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(243, 29);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(166, 73);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(243, 29);
            this.txtBoxSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefon No:";
            // 
            // txtBoxTelNo
            // 
            this.txtBoxTelNo.Location = new System.Drawing.Point(166, 125);
            this.txtBoxTelNo.Name = "txtBoxTelNo";
            this.txtBoxTelNo.Size = new System.Drawing.Size(243, 29);
            this.txtBoxTelNo.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.Color.Green;
            this.buttonAdd.Location = new System.Drawing.Point(287, 170);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 41);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "KAYDET";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBoxQR);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonDocx);
            this.panel1.Controls.Add(this.buttonXls);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.txtBoxTelNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBoxSurname);
            this.panel1.Controls.Add(this.txtBoxName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelNameSurname);
            this.panel1.Location = new System.Drawing.Point(684, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 378);
            this.panel1.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelName.Location = new System.Drawing.Point(278, 356);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(168, 22);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Nuri Can KALKAN";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.IndianRed;
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPrint.Location = new System.Drawing.Point(164, 274);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(117, 29);
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "Yazdır";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonDocx
            // 
            this.buttonDocx.BackColor = System.Drawing.Color.Blue;
            this.buttonDocx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDocx.Location = new System.Drawing.Point(164, 234);
            this.buttonDocx.Name = "buttonDocx";
            this.buttonDocx.Size = new System.Drawing.Size(117, 34);
            this.buttonDocx.TabIndex = 11;
            this.buttonDocx.Text = "Word Aktar";
            this.buttonDocx.UseVisualStyleBackColor = false;
            this.buttonDocx.Click += new System.EventHandler(this.buttonDocx_Click);
            // 
            // buttonXls
            // 
            this.buttonXls.BackColor = System.Drawing.Color.Green;
            this.buttonXls.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonXls.Location = new System.Drawing.Point(164, 197);
            this.buttonXls.Name = "buttonXls";
            this.buttonXls.Size = new System.Drawing.Size(117, 31);
            this.buttonXls.TabIndex = 10;
            this.buttonXls.Text = "Excel Aktar";
            this.buttonXls.UseVisualStyleBackColor = false;
            this.buttonXls.Click += new System.EventHandler(this.buttonXls_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(14, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "⟳";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(287, 289);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 40);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "SİL";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.ForeColor = System.Drawing.Color.Navy;
            this.buttonUpdate.Location = new System.Drawing.Point(287, 227);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 41);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "GÜNCELLE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(1015, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxSrch
            // 
            this.txtBoxSrch.Location = new System.Drawing.Point(684, 64);
            this.txtBoxSrch.Name = "txtBoxSrch";
            this.txtBoxSrch.Size = new System.Drawing.Size(325, 29);
            this.txtBoxSrch.TabIndex = 3;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.SystemColors.Control;
            this.labelDate.Location = new System.Drawing.Point(766, 24);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(269, 22);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Bu Alana Tarih ve saat girilecek";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(34, 186);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(109, 117);
            this.pictureBoxQR.TabIndex = 15;
            this.pictureBoxQR.TabStop = false;
            // 
            // FormRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1146, 491);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.txtBoxSrch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTelRehber);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormRehber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Rehberi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelRehber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTelRehber;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTelNo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxSrch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonDocx;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonXls;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBoxQR;
    }
}

