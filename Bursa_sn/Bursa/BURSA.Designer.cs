namespace Bursa
{
    partial class BURSA
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actiunuleMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_DeschideBursa = new System.Windows.Forms.Button();
            this.button_InchideBursa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilizatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilizatorToolStripMenuItem
            // 
            this.utilizatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actiunuleMeleToolStripMenuItem,
            this.graficProfitToolStripMenuItem});
            this.utilizatorToolStripMenuItem.Name = "utilizatorToolStripMenuItem";
            this.utilizatorToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.utilizatorToolStripMenuItem.Text = "Utilizator";
            // 
            // actiunuleMeleToolStripMenuItem
            // 
            this.actiunuleMeleToolStripMenuItem.Name = "actiunuleMeleToolStripMenuItem";
            this.actiunuleMeleToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.actiunuleMeleToolStripMenuItem.Text = "Actiunule mele";
            // 
            // graficProfitToolStripMenuItem
            // 
            this.graficProfitToolStripMenuItem.Name = "graficProfitToolStripMenuItem";
            this.graficProfitToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.graficProfitToolStripMenuItem.Text = "Grafic Profit";
            // 
            // button_DeschideBursa
            // 
            this.button_DeschideBursa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeschideBursa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_DeschideBursa.Location = new System.Drawing.Point(12, 59);
            this.button_DeschideBursa.Name = "button_DeschideBursa";
            this.button_DeschideBursa.Size = new System.Drawing.Size(197, 36);
            this.button_DeschideBursa.TabIndex = 1;
            this.button_DeschideBursa.Text = "Deschide Bursa";
            this.button_DeschideBursa.UseVisualStyleBackColor = true;
            this.button_DeschideBursa.Click += new System.EventHandler(this.button_DeschideBursa_Click);
            // 
            // button_InchideBursa
            // 
            this.button_InchideBursa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InchideBursa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_InchideBursa.Location = new System.Drawing.Point(244, 59);
            this.button_InchideBursa.Name = "button_InchideBursa";
            this.button_InchideBursa.Size = new System.Drawing.Size(197, 36);
            this.button_InchideBursa.TabIndex = 2;
            this.button_InchideBursa.Text = "Inchide Bursa";
            this.button_InchideBursa.UseVisualStyleBackColor = true;
            this.button_InchideBursa.Click += new System.EventHandler(this.button_InchideBursa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(508, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rata reimprospatare:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(726, 60);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 297);
            this.dataGridView1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BURSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_InchideBursa);
            this.Controls.Add(this.button_DeschideBursa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BURSA";
            this.Text = "BURSA";
            this.Load += new System.EventHandler(this.BURSA_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilizatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actiunuleMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficProfitToolStripMenuItem;
        private System.Windows.Forms.Button button_DeschideBursa;
        private System.Windows.Forms.Button button_InchideBursa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}