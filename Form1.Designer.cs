using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paranumeron
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabela = new System.Windows.Forms.TableLayoutPanel();
            this.shitje = new System.Windows.Forms.Label();
            this.usdshit = new System.Windows.Forms.Label();
            this.eurshit = new System.Windows.Forms.Label();
            this.gbpshit = new System.Windows.Forms.Label();
            this.chfshit = new System.Windows.Forms.Label();
            this.cadshit = new System.Windows.Forms.Label();
            this.audshit = new System.Windows.Forms.Label();
            this.cnyshit = new System.Windows.Forms.Label();
            this.jpyshit = new System.Windows.Forms.Label();
            this.blerje = new System.Windows.Forms.Label();
            this.eurbli = new System.Windows.Forms.Label();
            this.gbpbli = new System.Windows.Forms.Label();
            this.chfbli = new System.Windows.Forms.Label();
            this.cadbli = new System.Windows.Forms.Label();
            this.audbli = new System.Windows.Forms.Label();
            this.cnybli = new System.Windows.Forms.Label();
            this.jpybli = new System.Windows.Forms.Label();
            this.jpy = new System.Windows.Forms.Label();
            this.cny = new System.Windows.Forms.Label();
            this.aud = new System.Windows.Forms.Label();
            this.cad = new System.Windows.Forms.Label();
            this.chf = new System.Windows.Forms.Label();
            this.gbp = new System.Windows.Forms.Label();
            this.eur = new System.Windows.Forms.Label();
            this.usd = new System.Windows.Forms.Label();
            this.flaggbp = new System.Windows.Forms.PictureBox();
            this.flagchf = new System.Windows.Forms.PictureBox();
            this.flagcad = new System.Windows.Forms.PictureBox();
            this.flagaud = new System.Windows.Forms.PictureBox();
            this.flagcny = new System.Windows.Forms.PictureBox();
            this.flagjpy = new System.Windows.Forms.PictureBox();
            this.valuta = new System.Windows.Forms.Label();
            this.flageur = new System.Windows.Forms.PictureBox();
            this.flagusd = new System.Windows.Forms.PictureBox();
            this.usdbli = new System.Windows.Forms.Label();
            this.paranumeron = new System.Windows.Forms.Label();
            this.timenow = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableBordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualOfflineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            this.valuerefresh = new System.Windows.Forms.Timer(this.components);
            this.tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flaggbp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagchf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagcad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagaud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagcny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagjpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flageur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagusd)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabela.ColumnCount = 4;
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabela.Controls.Add(this.shitje, 3, 0);
            this.tabela.Controls.Add(this.usdshit, 3, 1);
            this.tabela.Controls.Add(this.eurshit, 3, 2);
            this.tabela.Controls.Add(this.gbpshit, 3, 3);
            this.tabela.Controls.Add(this.chfshit, 3, 4);
            this.tabela.Controls.Add(this.cadshit, 3, 5);
            this.tabela.Controls.Add(this.audshit, 3, 6);
            this.tabela.Controls.Add(this.cnyshit, 3, 7);
            this.tabela.Controls.Add(this.jpyshit, 3, 8);
            this.tabela.Controls.Add(this.blerje, 2, 0);
            this.tabela.Controls.Add(this.eurbli, 2, 2);
            this.tabela.Controls.Add(this.gbpbli, 2, 3);
            this.tabela.Controls.Add(this.chfbli, 2, 4);
            this.tabela.Controls.Add(this.cadbli, 2, 5);
            this.tabela.Controls.Add(this.audbli, 2, 6);
            this.tabela.Controls.Add(this.cnybli, 2, 7);
            this.tabela.Controls.Add(this.jpybli, 2, 8);
            this.tabela.Controls.Add(this.jpy, 1, 8);
            this.tabela.Controls.Add(this.cny, 1, 7);
            this.tabela.Controls.Add(this.aud, 1, 6);
            this.tabela.Controls.Add(this.cad, 1, 5);
            this.tabela.Controls.Add(this.chf, 1, 4);
            this.tabela.Controls.Add(this.gbp, 1, 3);
            this.tabela.Controls.Add(this.eur, 1, 2);
            this.tabela.Controls.Add(this.usd, 1, 1);
            this.tabela.Controls.Add(this.flaggbp, 0, 3);
            this.tabela.Controls.Add(this.flagchf, 0, 4);
            this.tabela.Controls.Add(this.flagcad, 0, 5);
            this.tabela.Controls.Add(this.flagaud, 0, 6);
            this.tabela.Controls.Add(this.flagcny, 0, 7);
            this.tabela.Controls.Add(this.flagjpy, 0, 8);
            this.tabela.Controls.Add(this.valuta, 0, 0);
            this.tabela.Controls.Add(this.flageur, 0, 2);
            this.tabela.Controls.Add(this.flagusd, 0, 1);
            this.tabela.Controls.Add(this.usdbli, 2, 1);
            this.tabela.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tabela.Location = new System.Drawing.Point(0, 125);
            this.tabela.Name = "tabela";
            this.tabela.Padding = new System.Windows.Forms.Padding(50, 0, 50, 20);
            this.tabela.RowCount = 9;
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabela.Size = new System.Drawing.Size(801, 326);
            this.tabela.TabIndex = 0;
            // 
            // shitje
            // 
            this.shitje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shitje.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shitje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shitje.Location = new System.Drawing.Point(472, 0);
            this.shitje.Name = "shitje";
            this.shitje.Size = new System.Drawing.Size(276, 61);
            this.shitje.TabIndex = 3;
            this.shitje.Text = "Shitje";
            this.shitje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usdshit
            // 
            this.usdshit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usdshit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdshit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usdshit.Location = new System.Drawing.Point(472, 61);
            this.usdshit.Name = "usdshit";
            this.usdshit.Size = new System.Drawing.Size(276, 30);
            this.usdshit.TabIndex = 6;
            this.usdshit.Text = "Vendos Vleren!";
            this.usdshit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eurshit
            // 
            this.eurshit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eurshit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eurshit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eurshit.Location = new System.Drawing.Point(472, 91);
            this.eurshit.Name = "eurshit";
            this.eurshit.Size = new System.Drawing.Size(276, 30);
            this.eurshit.TabIndex = 9;
            this.eurshit.Text = "Vendos Vleren!";
            this.eurshit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbpshit
            // 
            this.gbpshit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbpshit.AutoSize = true;
            this.gbpshit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpshit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbpshit.Location = new System.Drawing.Point(472, 121);
            this.gbpshit.Name = "gbpshit";
            this.gbpshit.Size = new System.Drawing.Size(276, 30);
            this.gbpshit.TabIndex = 12;
            this.gbpshit.Text = "Vendos Vleren!";
            this.gbpshit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chfshit
            // 
            this.chfshit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chfshit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chfshit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chfshit.Location = new System.Drawing.Point(472, 151);
            this.chfshit.Name = "chfshit";
            this.chfshit.Size = new System.Drawing.Size(276, 30);
            this.chfshit.TabIndex = 15;
            this.chfshit.Text = "Vendos Vleren!";
            this.chfshit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cadshit
            // 
            this.cadshit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadshit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadshit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadshit.Location = new System.Drawing.Point(472, 181);
            this.cadshit.Name = "cadshit";
            this.cadshit.Size = new System.Drawing.Size(276, 30);
            this.cadshit.TabIndex = 18;
            this.cadshit.Text = "Vendos Vleren!";
            this.cadshit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // audshit
            // 
            this.audshit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audshit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audshit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.audshit.Location = new System.Drawing.Point(472, 211);
            this.audshit.Name = "audshit";
            this.audshit.Size = new System.Drawing.Size(276, 30);
            this.audshit.TabIndex = 21;
            this.audshit.Text = "Vendos Vleren!";
            this.audshit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cnyshit
            // 
            this.cnyshit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cnyshit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnyshit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cnyshit.Location = new System.Drawing.Point(472, 241);
            this.cnyshit.Name = "cnyshit";
            this.cnyshit.Size = new System.Drawing.Size(276, 30);
            this.cnyshit.TabIndex = 24;
            this.cnyshit.Text = "Vendos Vleren!";
            this.cnyshit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jpyshit
            // 
            this.jpyshit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jpyshit.AutoSize = true;
            this.jpyshit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jpyshit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jpyshit.Location = new System.Drawing.Point(472, 271);
            this.jpyshit.Name = "jpyshit";
            this.jpyshit.Size = new System.Drawing.Size(276, 35);
            this.jpyshit.TabIndex = 27;
            this.jpyshit.Text = "Vendos Vleren!";
            this.jpyshit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blerje
            // 
            this.blerje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blerje.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blerje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blerje.Location = new System.Drawing.Point(192, 0);
            this.blerje.Name = "blerje";
            this.blerje.Size = new System.Drawing.Size(274, 61);
            this.blerje.TabIndex = 2;
            this.blerje.Text = "Blerje";
            this.blerje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eurbli
            // 
            this.eurbli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eurbli.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eurbli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eurbli.Location = new System.Drawing.Point(192, 91);
            this.eurbli.Name = "eurbli";
            this.eurbli.Size = new System.Drawing.Size(274, 30);
            this.eurbli.TabIndex = 8;
            this.eurbli.Text = "Vendos Vleren!";
            this.eurbli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbpbli
            // 
            this.gbpbli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbpbli.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpbli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbpbli.Location = new System.Drawing.Point(192, 121);
            this.gbpbli.Name = "gbpbli";
            this.gbpbli.Size = new System.Drawing.Size(274, 30);
            this.gbpbli.TabIndex = 11;
            this.gbpbli.Text = "Vendos Vleren!";
            this.gbpbli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chfbli
            // 
            this.chfbli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chfbli.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chfbli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chfbli.Location = new System.Drawing.Point(192, 151);
            this.chfbli.Name = "chfbli";
            this.chfbli.Size = new System.Drawing.Size(274, 30);
            this.chfbli.TabIndex = 14;
            this.chfbli.Text = "Vendos Vleren!";
            this.chfbli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cadbli
            // 
            this.cadbli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadbli.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadbli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadbli.Location = new System.Drawing.Point(192, 181);
            this.cadbli.Name = "cadbli";
            this.cadbli.Size = new System.Drawing.Size(274, 30);
            this.cadbli.TabIndex = 17;
            this.cadbli.Text = "Vendos Vleren!";
            this.cadbli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // audbli
            // 
            this.audbli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audbli.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audbli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.audbli.Location = new System.Drawing.Point(192, 211);
            this.audbli.Name = "audbli";
            this.audbli.Size = new System.Drawing.Size(274, 30);
            this.audbli.TabIndex = 20;
            this.audbli.Text = "Vendos Vleren!";
            this.audbli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cnybli
            // 
            this.cnybli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cnybli.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnybli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cnybli.Location = new System.Drawing.Point(192, 241);
            this.cnybli.Name = "cnybli";
            this.cnybli.Size = new System.Drawing.Size(274, 30);
            this.cnybli.TabIndex = 23;
            this.cnybli.Text = "Vendos Vleren!";
            this.cnybli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jpybli
            // 
            this.jpybli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jpybli.AutoSize = true;
            this.jpybli.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jpybli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jpybli.Location = new System.Drawing.Point(192, 271);
            this.jpybli.Name = "jpybli";
            this.jpybli.Size = new System.Drawing.Size(274, 35);
            this.jpybli.TabIndex = 26;
            this.jpybli.Text = "Vendos Vleren!";
            this.jpybli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jpy
            // 
            this.jpy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jpy.AutoSize = true;
            this.jpy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jpy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jpy.Location = new System.Drawing.Point(105, 271);
            this.jpy.Name = "jpy";
            this.jpy.Size = new System.Drawing.Size(81, 35);
            this.jpy.TabIndex = 25;
            this.jpy.Text = "JPY";
            this.jpy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cny
            // 
            this.cny.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cny.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cny.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cny.Location = new System.Drawing.Point(105, 241);
            this.cny.Name = "cny";
            this.cny.Size = new System.Drawing.Size(81, 30);
            this.cny.TabIndex = 22;
            this.cny.Text = "CNY";
            this.cny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aud
            // 
            this.aud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aud.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aud.Location = new System.Drawing.Point(105, 211);
            this.aud.Name = "aud";
            this.aud.Size = new System.Drawing.Size(81, 30);
            this.aud.TabIndex = 19;
            this.aud.Text = "AUD";
            this.aud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cad
            // 
            this.cad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cad.Location = new System.Drawing.Point(105, 181);
            this.cad.Name = "cad";
            this.cad.Size = new System.Drawing.Size(81, 30);
            this.cad.TabIndex = 16;
            this.cad.Text = "CAD";
            this.cad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chf
            // 
            this.chf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chf.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chf.Location = new System.Drawing.Point(105, 151);
            this.chf.Name = "chf";
            this.chf.Size = new System.Drawing.Size(81, 30);
            this.chf.TabIndex = 13;
            this.chf.Text = "CHF";
            this.chf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbp
            // 
            this.gbp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbp.Location = new System.Drawing.Point(105, 121);
            this.gbp.Name = "gbp";
            this.gbp.Size = new System.Drawing.Size(81, 30);
            this.gbp.TabIndex = 10;
            this.gbp.Text = "GBP";
            this.gbp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eur
            // 
            this.eur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eur.Location = new System.Drawing.Point(105, 91);
            this.eur.Name = "eur";
            this.eur.Size = new System.Drawing.Size(81, 30);
            this.eur.TabIndex = 7;
            this.eur.Text = "EUR";
            this.eur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usd
            // 
            this.usd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usd.Location = new System.Drawing.Point(105, 61);
            this.usd.Name = "usd";
            this.usd.Size = new System.Drawing.Size(81, 30);
            this.usd.TabIndex = 4;
            this.usd.Text = "USD";
            this.usd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flaggbp
            // 
            this.flaggbp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flaggbp.BackgroundImage = global::Paranumeron.Properties.Resources._2560px_Flag_of_the_United_Kingdom_svg;
            this.flaggbp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flaggbp.Location = new System.Drawing.Point(53, 124);
            this.flaggbp.Name = "flaggbp";
            this.flaggbp.Size = new System.Drawing.Size(46, 24);
            this.flaggbp.TabIndex = 30;
            this.flaggbp.TabStop = false;
            // 
            // flagchf
            // 
            this.flagchf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagchf.BackgroundImage = global::Paranumeron.Properties.Resources.Flag_of_Switzerland_edit1;
            this.flagchf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flagchf.Location = new System.Drawing.Point(53, 154);
            this.flagchf.Name = "flagchf";
            this.flagchf.Size = new System.Drawing.Size(46, 24);
            this.flagchf.TabIndex = 31;
            this.flagchf.TabStop = false;
            // 
            // flagcad
            // 
            this.flagcad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagcad.BackgroundImage = global::Paranumeron.Properties.Resources._2560px_Flag_of_Canada__Pantone__svg;
            this.flagcad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flagcad.Location = new System.Drawing.Point(53, 184);
            this.flagcad.Name = "flagcad";
            this.flagcad.Size = new System.Drawing.Size(46, 24);
            this.flagcad.TabIndex = 32;
            this.flagcad.TabStop = false;
            // 
            // flagaud
            // 
            this.flagaud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagaud.BackgroundImage = global::Paranumeron.Properties.Resources._2560px_Flag_of_Australia__converted__svg;
            this.flagaud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flagaud.Location = new System.Drawing.Point(53, 214);
            this.flagaud.Name = "flagaud";
            this.flagaud.Size = new System.Drawing.Size(46, 24);
            this.flagaud.TabIndex = 33;
            this.flagaud.TabStop = false;
            // 
            // flagcny
            // 
            this.flagcny.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagcny.BackgroundImage = global::Paranumeron.Properties.Resources._2560px_Flag_of_the_People_s_Republic_of_China_svg;
            this.flagcny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flagcny.Location = new System.Drawing.Point(53, 244);
            this.flagcny.Name = "flagcny";
            this.flagcny.Size = new System.Drawing.Size(46, 24);
            this.flagcny.TabIndex = 34;
            this.flagcny.TabStop = false;
            // 
            // flagjpy
            // 
            this.flagjpy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagjpy.BackgroundImage = global::Paranumeron.Properties.Resources._2560px_Flag_of_Japan_svg;
            this.flagjpy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flagjpy.InitialImage = null;
            this.flagjpy.Location = new System.Drawing.Point(53, 274);
            this.flagjpy.Name = "flagjpy";
            this.flagjpy.Size = new System.Drawing.Size(46, 29);
            this.flagjpy.TabIndex = 35;
            this.flagjpy.TabStop = false;
            // 
            // valuta
            // 
            this.valuta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabela.SetColumnSpan(this.valuta, 2);
            this.valuta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.valuta.Location = new System.Drawing.Point(53, 0);
            this.valuta.Name = "valuta";
            this.valuta.Size = new System.Drawing.Size(133, 61);
            this.valuta.TabIndex = 1;
            this.valuta.Text = "Valuta";
            this.valuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flageur
            // 
            this.flageur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flageur.BackgroundImage = global::Paranumeron.Properties.Resources.Flag_of_Europe_svg;
            this.flageur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flageur.Location = new System.Drawing.Point(53, 94);
            this.flageur.Name = "flageur";
            this.flageur.Size = new System.Drawing.Size(46, 24);
            this.flageur.TabIndex = 29;
            this.flageur.TabStop = false;
            // 
            // flagusd
            // 
            this.flagusd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagusd.BackgroundImage = global::Paranumeron.Properties.Resources._2560px_Flag_of_the_United_States_svg;
            this.flagusd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flagusd.Location = new System.Drawing.Point(53, 64);
            this.flagusd.Name = "flagusd";
            this.flagusd.Size = new System.Drawing.Size(46, 24);
            this.flagusd.TabIndex = 28;
            this.flagusd.TabStop = false;
            // 
            // usdbli
            // 
            this.usdbli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usdbli.AutoSize = true;
            this.usdbli.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdbli.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.usdbli.Location = new System.Drawing.Point(192, 61);
            this.usdbli.Name = "usdbli";
            this.usdbli.Size = new System.Drawing.Size(274, 30);
            this.usdbli.TabIndex = 36;
            this.usdbli.Text = "Vendos Vleren!";
            this.usdbli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paranumeron
            // 
            this.paranumeron.AutoSize = true;
            this.paranumeron.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paranumeron.ForeColor = System.Drawing.SystemColors.Control;
            this.paranumeron.Location = new System.Drawing.Point(108, 32);
            this.paranumeron.Name = "paranumeron";
            this.paranumeron.Size = new System.Drawing.Size(257, 50);
            this.paranumeron.TabIndex = 2;
            this.paranumeron.Text = "Paranumeron";
            this.paranumeron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timenow
            // 
            this.timenow.Interval = 1000;
            this.timenow.Tick += new System.EventHandler(this.timenow_Tick);
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.Control;
            this.time.Location = new System.Drawing.Point(494, 42);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(131, 37);
            this.time.TabIndex = 3;
            this.time.Text = "Koha Tani";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenToolStripMenuItem1,
            this.tableBordersToolStripMenuItem,
            this.setFontSizeToolStripMenuItem,
            this.setRatesToolStripMenuItem,
            this.settingsToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // fullscreenToolStripMenuItem1
            // 
            this.fullscreenToolStripMenuItem1.Name = "fullscreenToolStripMenuItem1";
            this.fullscreenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fullscreenToolStripMenuItem1.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem1.Click += new System.EventHandler(this.fullscreenToolStripMenuItem1_Click);
            // 
            // tableBordersToolStripMenuItem
            // 
            this.tableBordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.tableBordersToolStripMenuItem.Name = "tableBordersToolStripMenuItem";
            this.tableBordersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tableBordersToolStripMenuItem.Text = "Table Borders";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // setFontSizeToolStripMenuItem
            // 
            this.setFontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem});
            this.setFontSizeToolStripMenuItem.Name = "setFontSizeToolStripMenuItem";
            this.setFontSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setFontSizeToolStripMenuItem.Text = "Set Font Size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // setRatesToolStripMenuItem
            // 
            this.setRatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticOnlineToolStripMenuItem,
            this.manualOfflineToolStripMenuItem});
            this.setRatesToolStripMenuItem.Name = "setRatesToolStripMenuItem";
            this.setRatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setRatesToolStripMenuItem.Text = "Set Rates";
            // 
            // automaticOnlineToolStripMenuItem
            // 
            this.automaticOnlineToolStripMenuItem.Name = "automaticOnlineToolStripMenuItem";
            this.automaticOnlineToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.automaticOnlineToolStripMenuItem.Text = "Automatic [Online]";
            this.automaticOnlineToolStripMenuItem.Click += new System.EventHandler(this.automaticOnlineToolStripMenuItem_Click);
            // 
            // manualOfflineToolStripMenuItem
            // 
            this.manualOfflineToolStripMenuItem.Name = "manualOfflineToolStripMenuItem";
            this.manualOfflineToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manualOfflineToolStripMenuItem.Text = "Manual [Offline]";
            this.manualOfflineToolStripMenuItem.Click += new System.EventHandler(this.manualOfflineToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Paranumeron.Properties.Resources.paranumeron_200_200;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(90, 90);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // valuerefresh
            // 
            this.valuerefresh.Interval = 3600000;
            this.valuerefresh.Tick += new System.EventHandler(this.valuerefresh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.paranumeron);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kursi i Këmbimit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabela.ResumeLayout(false);
            this.tabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flaggbp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagchf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagcad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagaud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagcny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagjpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flageur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagusd)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabela;
        private System.Windows.Forms.Label valuta;
        private System.Windows.Forms.Label cnyshit;
        private System.Windows.Forms.Label cnybli;
        private System.Windows.Forms.Label cny;
        private System.Windows.Forms.Label audshit;
        private System.Windows.Forms.Label audbli;
        private System.Windows.Forms.Label aud;
        private System.Windows.Forms.Label cadshit;
        private System.Windows.Forms.Label cadbli;
        private System.Windows.Forms.Label cad;
        private System.Windows.Forms.Label chfshit;
        private System.Windows.Forms.Label chfbli;
        private System.Windows.Forms.Label chf;
        private System.Windows.Forms.Label gbpshit;
        private System.Windows.Forms.Label gbpbli;
        private System.Windows.Forms.Label gbp;
        private System.Windows.Forms.Label eurshit;
        private System.Windows.Forms.Label eurbli;
        private System.Windows.Forms.Label eur;
        private System.Windows.Forms.Label usdshit;
        private System.Windows.Forms.Label usd;
        private System.Windows.Forms.Label jpy;
        private System.Windows.Forms.Label jpybli;
        private System.Windows.Forms.Label jpyshit;
        private System.Windows.Forms.PictureBox flaggbp;
        private System.Windows.Forms.PictureBox flagchf;
        private System.Windows.Forms.PictureBox flagcad;
        private System.Windows.Forms.PictureBox flagaud;
        private System.Windows.Forms.PictureBox flagcny;
        private System.Windows.Forms.PictureBox flagjpy;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label paranumeron;
        private System.Windows.Forms.Timer timenow;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tableBordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.Label blerje;
        private System.Windows.Forms.Label shitje;
        private ToolStripMenuItem setFontSizeToolStripMenuItem;
        private ToolStripMenuItem smallToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem largeToolStripMenuItem;
        private PictureBox flageur;
        private PictureBox flagusd;
        private Label usdbli;
        private ToolStripMenuItem setRatesToolStripMenuItem;
        private ToolStripMenuItem automaticOnlineToolStripMenuItem;
        private ToolStripMenuItem manualOfflineToolStripMenuItem;
        private Timer valuerefresh;
        private ToolStripMenuItem settingsToolStripMenuItem1;
    }
}

