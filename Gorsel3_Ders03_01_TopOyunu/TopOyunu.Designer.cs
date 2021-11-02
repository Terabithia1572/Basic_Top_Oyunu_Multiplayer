namespace Gorsel3_Ders03_01_TopOyunu
{
    partial class TopOyunu
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
            this.timerHareket = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslbl_seviye = new System.Windows.Forms.ToolStripStatusLabel();
            this.cubuk2 = new System.Windows.Forms.PictureBox();
            this.cubuk = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.tslbl_sure = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerSure = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubuk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            this.SuspendLayout();
            // 
            // timerHareket
            // 
            this.timerHareket.Interval = 50;
            this.timerHareket.Tick += new System.EventHandler(this.timerHareket_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbl_seviye,
            this.tslbl_sure});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(388, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslbl_seviye
            // 
            this.tslbl_seviye.Name = "tslbl_seviye";
            this.tslbl_seviye.Size = new System.Drawing.Size(52, 17);
            this.tslbl_seviye.Text = "Seviye :1";
            // 
            // cubuk2
            // 
            this.cubuk2.Image = global::Gorsel3_Ders03_01_TopOyunu.Properties.Resources.cubuk;
            this.cubuk2.Location = new System.Drawing.Point(135, 44);
            this.cubuk2.Name = "cubuk2";
            this.cubuk2.Size = new System.Drawing.Size(100, 10);
            this.cubuk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cubuk2.TabIndex = 3;
            this.cubuk2.TabStop = false;
            // 
            // cubuk
            // 
            this.cubuk.Image = global::Gorsel3_Ders03_01_TopOyunu.Properties.Resources.cubuk2;
            this.cubuk.Location = new System.Drawing.Point(135, 280);
            this.cubuk.Name = "cubuk";
            this.cubuk.Size = new System.Drawing.Size(100, 10);
            this.cubuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cubuk.TabIndex = 1;
            this.cubuk.TabStop = false;
            // 
            // top
            // 
            this.top.Image = global::Gorsel3_Ders03_01_TopOyunu.Properties.Resources.futop;
            this.top.Location = new System.Drawing.Point(173, 159);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(20, 20);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 0;
            this.top.TabStop = false;
            // 
            // tslbl_sure
            // 
            this.tslbl_sure.Name = "tslbl_sure";
            this.tslbl_sure.Size = new System.Drawing.Size(42, 17);
            this.tslbl_sure.Text = "Süre :0";
            // 
            // timerSure
            // 
            this.timerSure.Interval = 1000;
            this.timerSure.Tick += new System.EventHandler(this.timerSure_Tick);
            // 
            // TopOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 358);
            this.Controls.Add(this.cubuk2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cubuk);
            this.Controls.Add(this.top);
            this.Name = "TopOyunu";
            this.Text = "Top Oyunu";
            this.Load += new System.EventHandler(this.TopOyunu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TopOyunu_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TopOyunu_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubuk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox cubuk;
        private System.Windows.Forms.Timer timerHareket;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslbl_seviye;
        private System.Windows.Forms.PictureBox cubuk2;
        private System.Windows.Forms.ToolStripStatusLabel tslbl_sure;
        private System.Windows.Forms.Timer timerSure;
    }
}

