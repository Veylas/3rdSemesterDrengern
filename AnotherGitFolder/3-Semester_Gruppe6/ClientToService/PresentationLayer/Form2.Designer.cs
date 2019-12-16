using System.Windows.Forms;
using ClientToService.ControlLayer;


namespace ClientToService
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.Delete_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.auctionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentWinnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxId2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnCreateAuction = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxStatus = new System.Windows.Forms.TextBox();
            this.TxtByd = new System.Windows.Forms.TextBox();
            this.TxtBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.TxtBoxCurrentPrice = new System.Windows.Forms.TextBox();
            this.TxtBoxDescription = new System.Windows.Forms.TextBox();
            this.TxtBoxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.auctionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(867, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Opdater auktioner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.Location = new System.Drawing.Point(1451, 566);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.Size = new System.Drawing.Size(187, 26);
            this.TxtBoxId.TabIndex = 2;
            this.TxtBoxId.Text = "Indsæt id";
            this.TxtBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Delete_Click
            // 
            this.Delete_Click.Location = new System.Drawing.Point(1487, 598);
            this.Delete_Click.Name = "Delete_Click";
            this.Delete_Click.Size = new System.Drawing.Size(112, 36);
            this.Delete_Click.TabIndex = 3;
            this.Delete_Click.Text = "Slet";
            this.Delete_Click.UseVisualStyleBackColor = true;
            this.Delete_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liste over auktioner";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1497, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slet auktion";
            // 
            // auctionModelBindingSource
            // 
            this.auctionModelBindingSource.DataSource = typeof(ClientToService.ServiceReference1.AuctionModel);
            this.auctionModelBindingSource.CurrentChanged += new System.EventHandler(this.auctionModelBindingSource_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.bidDataGridViewTextBoxColumn,
            this.maxPriceDataGridViewTextBoxColumn,
            this.currentPriceDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.currentWinnerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.auctionModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1873, 464);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "Bid";
            this.bidDataGridViewTextBoxColumn.HeaderText = "Bid";
            this.bidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.Width = 150;
            // 
            // maxPriceDataGridViewTextBoxColumn
            // 
            this.maxPriceDataGridViewTextBoxColumn.DataPropertyName = "MaxPrice";
            this.maxPriceDataGridViewTextBoxColumn.HeaderText = "MaxPrice";
            this.maxPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maxPriceDataGridViewTextBoxColumn.Name = "maxPriceDataGridViewTextBoxColumn";
            this.maxPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentPriceDataGridViewTextBoxColumn
            // 
            this.currentPriceDataGridViewTextBoxColumn.DataPropertyName = "CurrentPrice";
            this.currentPriceDataGridViewTextBoxColumn.HeaderText = "CurrentPrice";
            this.currentPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currentPriceDataGridViewTextBoxColumn.Name = "currentPriceDataGridViewTextBoxColumn";
            this.currentPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentWinnerDataGridViewTextBoxColumn
            // 
            this.currentWinnerDataGridViewTextBoxColumn.DataPropertyName = "CurrentWinner";
            this.currentWinnerDataGridViewTextBoxColumn.HeaderText = "CurrentWinner";
            this.currentWinnerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currentWinnerDataGridViewTextBoxColumn.Name = "currentWinnerDataGridViewTextBoxColumn";
            this.currentWinnerDataGridViewTextBoxColumn.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 542);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Skriv id på den auktion som skal ændres";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxId2
            // 
            this.textBoxId2.Location = new System.Drawing.Point(136, 567);
            this.textBoxId2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxId2.Name = "textBoxId2";
            this.textBoxId2.Size = new System.Drawing.Size(148, 26);
            this.textBoxId2.TabIndex = 40;
            this.textBoxId2.Text = "Indsæt id";
            this.textBoxId2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Elektronik",
            "Hus",
            "Bil"});
            this.comboBox1.Location = new System.Drawing.Point(136, 713);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 833);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // BtnCreateAuction
            // 
            this.BtnCreateAuction.Location = new System.Drawing.Point(134, 980);
            this.BtnCreateAuction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCreateAuction.Name = "BtnCreateAuction";
            this.BtnCreateAuction.Size = new System.Drawing.Size(150, 35);
            this.BtnCreateAuction.TabIndex = 37;
            this.BtnCreateAuction.Text = "Bekræft";
            this.BtnCreateAuction.UseVisualStyleBackColor = true;
            this.BtnCreateAuction.Click += new System.EventHandler(this.BtnCreateAuction_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(28, 918);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(56, 20);
            this.Status.TabIndex = 36;
            this.Status.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 878);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Byd beløb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 838);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Slut dato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 798);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Max Pris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 758);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Start Pris";
            // 
            // TxtBoxStatus
            // 
            this.TxtBoxStatus.Location = new System.Drawing.Point(136, 913);
            this.TxtBoxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxStatus.Name = "TxtBoxStatus";
            this.TxtBoxStatus.Size = new System.Drawing.Size(148, 26);
            this.TxtBoxStatus.TabIndex = 31;
            // 
            // TxtByd
            // 
            this.TxtByd.Location = new System.Drawing.Point(136, 873);
            this.TxtByd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtByd.Name = "TxtByd";
            this.TxtByd.Size = new System.Drawing.Size(148, 26);
            this.TxtByd.TabIndex = 30;
            // 
            // TxtBoxMaxPrice
            // 
            this.TxtBoxMaxPrice.Location = new System.Drawing.Point(136, 793);
            this.TxtBoxMaxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxMaxPrice.Name = "TxtBoxMaxPrice";
            this.TxtBoxMaxPrice.Size = new System.Drawing.Size(148, 26);
            this.TxtBoxMaxPrice.TabIndex = 29;
            // 
            // TxtBoxCurrentPrice
            // 
            this.TxtBoxCurrentPrice.Location = new System.Drawing.Point(136, 753);
            this.TxtBoxCurrentPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxCurrentPrice.Name = "TxtBoxCurrentPrice";
            this.TxtBoxCurrentPrice.Size = new System.Drawing.Size(148, 26);
            this.TxtBoxCurrentPrice.TabIndex = 28;
            // 
            // TxtBoxDescription
            // 
            this.TxtBoxDescription.Location = new System.Drawing.Point(136, 670);
            this.TxtBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxDescription.Name = "TxtBoxDescription";
            this.TxtBoxDescription.Size = new System.Drawing.Size(148, 26);
            this.TxtBoxDescription.TabIndex = 27;
            // 
            // TxtBoxTitle
            // 
            this.TxtBoxTitle.Location = new System.Drawing.Point(136, 629);
            this.TxtBoxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxTitle.Name = "TxtBoxTitle";
            this.TxtBoxTitle.Size = new System.Drawing.Size(148, 26);
            this.TxtBoxTitle.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 718);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Katagori";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 675);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Beskrivelse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 633);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Titel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 598);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(438, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Skriv hvad auktionens informationer skal ændres til her under";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(68, 508);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(356, 25);
            this.label12.TabIndex = 43;
            this.label12.Text = "Ændre auktionens informationer her";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1456, 507);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 25);
            this.label13.TabIndex = 44;
            this.label13.Text = "Slet auktioner her";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1775, 957);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 37);
            this.button2.TabIndex = 45;
            this.button2.Text = "Luk";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClose);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxId2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnCreateAuction);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxStatus);
            this.Controls.Add(this.TxtByd);
            this.Controls.Add(this.TxtBoxMaxPrice);
            this.Controls.Add(this.TxtBoxCurrentPrice);
            this.Controls.Add(this.TxtBoxDescription);
            this.Controls.Add(this.TxtBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_Click);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Administrere auktioner";
            ((System.ComponentModel.ISupportInitialize)(this.auctionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtBoxId;
        private System.Windows.Forms.Button Delete_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BindingSource auctionModelBindingSource;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox textBoxId2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button BtnCreateAuction;
        private Label Status;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox TxtBoxStatus;
        private TextBox TxtByd;
        private TextBox TxtBoxMaxPrice;
        private TextBox TxtBoxCurrentPrice;
        private TextBox TxtBoxDescription;
        private TextBox TxtBoxTitle;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentWinnerDataGridViewTextBoxColumn;
        private Button button2;

    }
}