
namespace Ahorcado
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.botonJugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPtos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.BackColor = System.Drawing.Color.Tan;
            this.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategorias.ForeColor = System.Drawing.Color.Crimson;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(122, 323);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(277, 35);
            this.comboBoxCategorias.TabIndex = 0;
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.categoriaSeleccionada);
            // 
            // botonJugar
            // 
            this.botonJugar.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonJugar.ForeColor = System.Drawing.Color.Crimson;
            this.botonJugar.Location = new System.Drawing.Point(108, 186);
            this.botonJugar.Name = "botonJugar";
            this.botonJugar.Size = new System.Drawing.Size(110, 52);
            this.botonJugar.TabIndex = 1;
            this.botonJugar.Text = "Jugar";
            this.botonJugar.UseVisualStyleBackColor = true;
            this.botonJugar.Visible = false;
            this.botonJugar.Click += new System.EventHandler(this.empezarJuego);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(201, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoría";
            // 
            // labelPtos
            // 
            this.labelPtos.AutoSize = true;
            this.labelPtos.BackColor = System.Drawing.Color.Transparent;
            this.labelPtos.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPtos.ForeColor = System.Drawing.Color.Gold;
            this.labelPtos.Location = new System.Drawing.Point(360, 129);
            this.labelPtos.Name = "labelPtos";
            this.labelPtos.Size = new System.Drawing.Size(165, 27);
            this.labelPtos.TabIndex = 3;
            this.labelPtos.Text = "Puntuación: 0";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 432);
            this.Controls.Add(this.labelPtos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonJugar);
            this.Controls.Add(this.comboBoxCategorias);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 471);
            this.MinimumSize = new System.Drawing.Size(624, 471);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Button botonJugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPtos;
    }
}

