
namespace ComauBatteryPackXml
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Estrai_IN_XML = new RoundedBtnStyle.RoundedButton();
            this.Visualizza_IN_XML = new RoundedBtnStyle.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(717, 353);
            this.webBrowser.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Estrai_IN_XML, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Visualizza_IN_XML, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.14477F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.03118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.73497F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visualizzatore XML";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Estrai_IN_XML
            // 
            this.Estrai_IN_XML.BorderColor = System.Drawing.Color.Silver;
            this.Estrai_IN_XML.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.Estrai_IN_XML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Estrai_IN_XML.FlatAppearance.BorderSize = 0;
            this.Estrai_IN_XML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Estrai_IN_XML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Estrai_IN_XML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Estrai_IN_XML.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estrai_IN_XML.Location = new System.Drawing.Point(574, 407);
            this.Estrai_IN_XML.Name = "Estrai_IN_XML";
            this.Estrai_IN_XML.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.Estrai_IN_XML.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.Estrai_IN_XML.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Estrai_IN_XML.Size = new System.Drawing.Size(89, 40);
            this.Estrai_IN_XML.TabIndex = 6;
            this.Estrai_IN_XML.Text = "Estrai XML";
            this.Estrai_IN_XML.TextColor = System.Drawing.Color.White;
            this.Estrai_IN_XML.UseVisualStyleBackColor = true;
            this.Estrai_IN_XML.Click += new System.EventHandler(this.Estrai_IN_XML_Click);
            // 
            // Visualizza_IN_XML
            // 
            this.Visualizza_IN_XML.BorderColor = System.Drawing.Color.Silver;
            this.Visualizza_IN_XML.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.Visualizza_IN_XML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Visualizza_IN_XML.FlatAppearance.BorderSize = 0;
            this.Visualizza_IN_XML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Visualizza_IN_XML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Visualizza_IN_XML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizza_IN_XML.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizza_IN_XML.Location = new System.Drawing.Point(669, 407);
            this.Visualizza_IN_XML.Name = "Visualizza_IN_XML";
            this.Visualizza_IN_XML.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.Visualizza_IN_XML.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.Visualizza_IN_XML.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Visualizza_IN_XML.Size = new System.Drawing.Size(89, 40);
            this.Visualizza_IN_XML.TabIndex = 7;
            this.Visualizza_IN_XML.Text = "Visualizza XML";
            this.Visualizza_IN_XML.TextColor = System.Drawing.Color.White;
            this.Visualizza_IN_XML.UseVisualStyleBackColor = true;
            this.Visualizza_IN_XML.Click += new System.EventHandler(this.Visualizza_IN_XML_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.webBrowser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(41, 48);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 4);
            this.panel1.Size = new System.Drawing.Size(717, 353);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private RoundedBtnStyle.RoundedButton Estrai_IN_XML;
        private RoundedBtnStyle.RoundedButton Visualizza_IN_XML;
        private System.Windows.Forms.Panel panel1;
    }
}

