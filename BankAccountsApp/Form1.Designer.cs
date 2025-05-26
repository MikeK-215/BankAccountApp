namespace BankAccountsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WikthdrawBtn = new Button();
            CreateAccountBtn = new Button();
            InterestRateLabel = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 62);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 337);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            label2.Click += label2_Click;
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(112, 62);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(269, 35);
            OwnerTxt.TabIndex = 2;
            OwnerTxt.TextChanged += textBox1_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(166, 337);
            AmountNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(269, 35);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(387, 62);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.Size = new Size(637, 243);
            BankAccountsGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(477, 324);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(263, 48);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WikthdrawBtn
            // 
            WikthdrawBtn.Location = new Point(761, 324);
            WikthdrawBtn.Name = "WikthdrawBtn";
            WikthdrawBtn.Size = new Size(263, 48);
            WikthdrawBtn.TabIndex = 6;
            WikthdrawBtn.Text = "Withdraw";
            WikthdrawBtn.UseVisualStyleBackColor = true;
            WikthdrawBtn.Click += WikthdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(112, 171);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(269, 48);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // InterestRateLabel
            // 
            InterestRateLabel.AutoSize = true;
            InterestRateLabel.Location = new Point(34, 123);
            InterestRateLabel.Name = "InterestRateLabel";
            InterestRateLabel.Size = new Size(166, 30);
            InterestRateLabel.TabIndex = 8;
            InterestRateLabel.Text = "Interest Rate (%)";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(200, 121);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(181, 35);
            InterestRateNum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 395);
            Controls.Add(InterestRateNum);
            Controls.Add(InterestRateLabel);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WikthdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WikthdrawBtn;
        private Button CreateAccountBtn;
        private Label InterestRateLabel;
        private NumericUpDown InterestRateNum;
    }
}
