
namespace Ahorcado
{
    partial class Resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultado));
            this.labelMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelRdo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.BackColor = System.Drawing.Color.Transparent;
            this.labelMsg.Font = new System.Drawing.Font("Showcard Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelMsg.Location = new System.Drawing.Point(12, 9);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(25, 21);
            this.labelMsg.TabIndex = 0;
            this.labelMsg.Text = "...";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(112, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelRdo
            // 
            this.labelRdo.AutoSize = true;
            this.labelRdo.BackColor = System.Drawing.Color.Transparent;
            this.labelRdo.Font = new System.Drawing.Font("Showcard Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRdo.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelRdo.Location = new System.Drawing.Point(12, 32);
            this.labelRdo.Name = "labelRdo";
            this.labelRdo.Size = new System.Drawing.Size(25, 21);
            this.labelRdo.TabIndex = 2;
            this.labelRdo.Text = "...";
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(299, 98);
            this.Controls.Add(this.labelRdo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMsg);
            this.DoubleBuffered = true;
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelRdo;
    }
}