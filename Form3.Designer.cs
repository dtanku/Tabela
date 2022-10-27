
namespace Paranumeron
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.converttable = new System.Windows.Forms.TableLayoutPanel();
            this.currencyfrom = new System.Windows.Forms.ComboBox();
            this.converted = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.NumericUpDown();
            this.koha = new System.Windows.Forms.Label();
            this.konvertimi = new System.Windows.Forms.Label();
            this.currencyto = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printo = new System.Windows.Forms.Button();
            this.kohatani = new System.Windows.Forms.Timer(this.components);
            this.converttable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.SuspendLayout();
            // 
            // converttable
            // 
            this.converttable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.converttable.ColumnCount = 2;
            this.converttable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converttable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converttable.Controls.Add(this.currencyfrom, 1, 1);
            this.converttable.Controls.Add(this.converted, 0, 3);
            this.converttable.Controls.Add(this.input, 0, 1);
            this.converttable.Controls.Add(this.koha, 1, 0);
            this.converttable.Controls.Add(this.konvertimi, 0, 0);
            this.converttable.Controls.Add(this.currencyto, 1, 3);
            this.converttable.Controls.Add(this.button3, 1, 4);
            this.converttable.Controls.Add(this.button1, 0, 4);
            this.converttable.Controls.Add(this.printo, 0, 5);
            this.converttable.Location = new System.Drawing.Point(0, 55);
            this.converttable.Name = "converttable";
            this.converttable.RowCount = 6;
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.converttable.Size = new System.Drawing.Size(501, 361);
            this.converttable.TabIndex = 0;
            // 
            // currencyfrom
            // 
            this.currencyfrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currencyfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyfrom.FormattingEnabled = true;
            this.currencyfrom.Items.AddRange(new object[] {
            "ALL",
            "USD",
            "EUR",
            "GBP",
            "CHF",
            "CAD",
            "AUD",
            "CNY",
            "JPY"});
            this.currencyfrom.Location = new System.Drawing.Point(253, 39);
            this.currencyfrom.Name = "currencyfrom";
            this.currencyfrom.Size = new System.Drawing.Size(245, 21);
            this.currencyfrom.TabIndex = 1;
            this.currencyfrom.SelectedIndexChanged += new System.EventHandler(this.currency1_SelectedIndexChanged);
            // 
            // converted
            // 
            this.converted.AutoSize = true;
            this.converted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.converted.Location = new System.Drawing.Point(3, 164);
            this.converted.Name = "converted";
            this.converted.Size = new System.Drawing.Size(244, 64);
            this.converted.TabIndex = 3;
            this.converted.Text = "Sasia";
            this.converted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input
            // 
            this.input.DecimalPlaces = 2;
            this.input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.input.Location = new System.Drawing.Point(3, 39);
            this.input.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(244, 20);
            this.input.TabIndex = 4;
            this.input.ValueChanged += new System.EventHandler(this.input_ValueChanged);
            // 
            // koha
            // 
            this.koha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.koha.AutoSize = true;
            this.koha.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koha.Location = new System.Drawing.Point(253, 0);
            this.koha.Name = "koha";
            this.koha.Size = new System.Drawing.Size(245, 36);
            this.koha.TabIndex = 5;
            this.koha.Text = "Koha Tani";
            this.koha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // konvertimi
            // 
            this.konvertimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.konvertimi.AutoSize = true;
            this.konvertimi.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konvertimi.Location = new System.Drawing.Point(3, 0);
            this.konvertimi.Name = "konvertimi";
            this.konvertimi.Size = new System.Drawing.Size(244, 36);
            this.konvertimi.TabIndex = 6;
            this.konvertimi.Text = "Konvertim";
            this.konvertimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyto
            // 
            this.currencyto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currencyto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyto.FormattingEnabled = true;
            this.currencyto.Items.AddRange(new object[] {
            "ALL",
            "USD",
            "EUR",
            "GBP",
            "CHF",
            "CAD",
            "AUD",
            "CNY",
            "JPY"});
            this.currencyto.Location = new System.Drawing.Point(253, 167);
            this.currencyto.Name = "currencyto";
            this.currencyto.Size = new System.Drawing.Size(245, 21);
            this.currencyto.TabIndex = 7;
            this.currencyto.SelectedIndexChanged += new System.EventHandler(this.currency2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(253, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 58);
            this.button3.TabIndex = 11;
            this.button3.Text = "Shiko Historikun";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Printo faturen e fundit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printo
            // 
            this.printo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.converttable.SetColumnSpan(this.printo, 2);
            this.printo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printo.Location = new System.Drawing.Point(3, 295);
            this.printo.Name = "printo";
            this.printo.Size = new System.Drawing.Size(495, 63);
            this.printo.TabIndex = 8;
            this.printo.Text = "Printo";
            this.printo.UseVisualStyleBackColor = true;
            this.printo.Click += new System.EventHandler(this.printo_Click);
            // 
            // kohatani
            // 
            this.kohatani.Enabled = true;
            this.kohatani.Interval = 1000;
            this.kohatani.Tick += new System.EventHandler(this.kohatani_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 416);
            this.Controls.Add(this.converttable);
            this.Name = "Form3";
            this.Text = "Form3";
            this.converttable.ResumeLayout(false);
            this.converttable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel converttable;
        private System.Windows.Forms.ComboBox currencyfrom;
        private System.Windows.Forms.Label converted;
        private System.Windows.Forms.NumericUpDown input;
        private System.Windows.Forms.Timer kohatani;
        private System.Windows.Forms.Label koha;
        private System.Windows.Forms.Label konvertimi;
        private System.Windows.Forms.ComboBox currencyto;
        private System.Windows.Forms.Button printo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}