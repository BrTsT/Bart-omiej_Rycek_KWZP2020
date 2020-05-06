namespace SZWALNIA
{
    partial class Start
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
            this.btnPrzygotowanieProdukcji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrzygotowanieProdukcji
            // 
            this.btnPrzygotowanieProdukcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzygotowanieProdukcji.Location = new System.Drawing.Point(12, 12);
            this.btnPrzygotowanieProdukcji.Name = "btnPrzygotowanieProdukcji";
            this.btnPrzygotowanieProdukcji.Size = new System.Drawing.Size(294, 107);
            this.btnPrzygotowanieProdukcji.TabIndex = 0;
            this.btnPrzygotowanieProdukcji.Text = "Przygotowanie Produkcji";
            this.btnPrzygotowanieProdukcji.UseVisualStyleBackColor = true;
            this.btnPrzygotowanieProdukcji.Click += new System.EventHandler(this.btnPrzygotowanieProdukcji_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrzygotowanieProdukcji);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrzygotowanieProdukcji;
    }
}