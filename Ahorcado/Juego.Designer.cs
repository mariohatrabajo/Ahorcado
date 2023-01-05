
namespace Ahorcado
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.labelPalabra = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelUsadas = new System.Windows.Forms.Label();
            this.labelPtos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAciertos = new System.Windows.Forms.Label();
            this.labelFallos = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPalabra
            // 
            this.labelPalabra.AutoSize = true;
            this.labelPalabra.BackColor = System.Drawing.Color.Transparent;
            this.labelPalabra.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalabra.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelPalabra.Location = new System.Drawing.Point(224, 38);
            this.labelPalabra.Name = "labelPalabra";
            this.labelPalabra.Size = new System.Drawing.Size(38, 44);
            this.labelPalabra.TabIndex = 0;
            this.labelPalabra.Text = "_";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.Color.Transparent;
            this.botonVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonVolver.BackgroundImage")));
            this.botonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.Cornsilk;
            this.botonVolver.Location = new System.Drawing.Point(628, 283);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(143, 36);
            this.botonVolver.TabIndex = 1;
            this.botonVolver.Text = "Volver al menú";
            this.botonVolver.UseVisualStyleBackColor = false;
            // 
            // labelUsadas
            // 
            this.labelUsadas.AutoSize = true;
            this.labelUsadas.BackColor = System.Drawing.Color.Transparent;
            this.labelUsadas.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsadas.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelUsadas.Location = new System.Drawing.Point(227, 94);
            this.labelUsadas.Name = "labelUsadas";
            this.labelUsadas.Size = new System.Drawing.Size(0, 23);
            this.labelUsadas.TabIndex = 9;
            // 
            // labelPtos
            // 
            this.labelPtos.AutoSize = true;
            this.labelPtos.BackColor = System.Drawing.Color.Transparent;
            this.labelPtos.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPtos.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelPtos.Location = new System.Drawing.Point(625, 59);
            this.labelPtos.Name = "labelPtos";
            this.labelPtos.Size = new System.Drawing.Size(129, 20);
            this.labelPtos.TabIndex = 10;
            this.labelPtos.Text = "Puntuación: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usa tu teclado para escribir la palabra.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(30, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 203);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelAciertos
            // 
            this.labelAciertos.AutoSize = true;
            this.labelAciertos.BackColor = System.Drawing.Color.Transparent;
            this.labelAciertos.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAciertos.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelAciertos.Location = new System.Drawing.Point(654, 94);
            this.labelAciertos.Name = "labelAciertos";
            this.labelAciertos.Size = new System.Drawing.Size(103, 20);
            this.labelAciertos.TabIndex = 12;
            this.labelAciertos.Text = "Aciertos: 0";
            // 
            // labelFallos
            // 
            this.labelFallos.AutoSize = true;
            this.labelFallos.BackColor = System.Drawing.Color.Transparent;
            this.labelFallos.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFallos.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelFallos.Location = new System.Drawing.Point(676, 128);
            this.labelFallos.Name = "labelFallos";
            this.labelFallos.Size = new System.Drawing.Size(82, 20);
            this.labelFallos.TabIndex = 13;
            this.labelFallos.Text = "Fallos: 0";
            // 
            // labelCategoria
            // 
            this.labelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.labelCategoria.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelCategoria.Location = new System.Drawing.Point(396, 9);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(372, 25);
            this.labelCategoria.TabIndex = 14;
            this.labelCategoria.Text = "Categoria: ";
            this.labelCategoria.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dibujo0.png");
            this.imageList1.Images.SetKeyName(1, "dibujo1.png");
            this.imageList1.Images.SetKeyName(2, "dibujo2.png");
            this.imageList1.Images.SetKeyName(3, "dibujo3.png");
            this.imageList1.Images.SetKeyName(4, "dibujo4.png");
            this.imageList1.Images.SetKeyName(5, "dibujo5.png");
            this.imageList1.Images.SetKeyName(6, "dibujo6.png");
            this.imageList1.Images.SetKeyName(7, "dibujo7.png");
            // 
            // textBoxRes
            // 
            this.textBoxRes.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxRes.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRes.Location = new System.Drawing.Point(97, 277);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(143, 27);
            this.textBoxRes.TabIndex = 15;
            this.textBoxRes.Enter += new System.EventHandler(this.textBoxRes_Enter);
            this.textBoxRes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRes_KeyDown);
            this.textBoxRes.Leave += new System.EventHandler(this.textBoxRes_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Resolver";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelFallos);
            this.Controls.Add(this.labelAciertos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPtos);
            this.Controls.Add(this.labelUsadas);
            this.Controls.Add(this.labelPalabra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonVolver);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 369);
            this.MinimumSize = new System.Drawing.Size(800, 369);
            this.Name = "Juego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Juego_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPalabra;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsadas;
        private System.Windows.Forms.Label labelPtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAciertos;
        private System.Windows.Forms.Label labelFallos;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Label label2;
    }
}