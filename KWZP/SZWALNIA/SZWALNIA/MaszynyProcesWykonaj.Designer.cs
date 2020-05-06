namespace SZWALNIA
{
    partial class MaszynyProcesWykonaj
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
            this.lblIdMaszynyProces = new System.Windows.Forms.Label();
            this.dgvRodzajMaszyny = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajMaszyny)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdMaszynyProces
            // 
            this.lblIdMaszynyProces.AutoSize = true;
            this.lblIdMaszynyProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblIdMaszynyProces.Location = new System.Drawing.Point(10, 13);
            this.lblIdMaszynyProces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMaszynyProces.Name = "lblIdMaszynyProces";
            this.lblIdMaszynyProces.Size = new System.Drawing.Size(332, 39);
            this.lblIdMaszynyProces.TabIndex = 54;
            this.lblIdMaszynyProces.Text = "ID_Maszyna_Proces";
            // 
            // dgvRodzajMaszyny
            // 
            this.dgvRodzajMaszyny.AllowUserToAddRows = false;
            this.dgvRodzajMaszyny.AllowUserToDeleteRows = false;
            this.dgvRodzajMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRodzajMaszyny.Location = new System.Drawing.Point(9, 69);
            this.dgvRodzajMaszyny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRodzajMaszyny.Name = "dgvRodzajMaszyny";
            this.dgvRodzajMaszyny.ReadOnly = true;
            this.dgvRodzajMaszyny.RowHeadersWidth = 51;
            this.dgvRodzajMaszyny.RowTemplate.Height = 24;
            this.dgvRodzajMaszyny.Size = new System.Drawing.Size(779, 266);
            this.dgvRodzajMaszyny.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(425, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 36);
            this.label8.TabIndex = 46;
            // 
            // MaszynyProcesWykonaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.lblIdMaszynyProces);
            this.Controls.Add(this.dgvRodzajMaszyny);
            this.Controls.Add(this.label8);
            this.Name = "MaszynyProcesWykonaj";
            this.Text = "MaszynyProcesWykonaj";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajMaszyny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdMaszynyProces;
        private System.Windows.Forms.DataGridView dgvRodzajMaszyny;
        private System.Windows.Forms.Label label8;
    }
}