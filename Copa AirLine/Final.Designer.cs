
namespace Copa_AirLine
{
    partial class Final
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
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.pbPorcentaje = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(497, 293);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.lblPorcentaje.TabIndex = 0;
            // 
            // pbPorcentaje
            // 
            this.pbPorcentaje.ForeColor = System.Drawing.Color.Green;
            this.pbPorcentaje.Location = new System.Drawing.Point(90, 293);
            this.pbPorcentaje.Name = "pbPorcentaje";
            this.pbPorcentaje.Size = new System.Drawing.Size(401, 13);
            this.pbPorcentaje.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(173, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 75);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saliendo...";
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Copa_AirLine.Properties.Resources.a5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPorcentaje);
            this.Controls.Add(this.lblPorcentaje);
            this.Name = "Final";
            this.Text = "Final";
            this.Load += new System.EventHandler(this.Final_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.ProgressBar pbPorcentaje;
        private System.Windows.Forms.Label label2;
    }
}