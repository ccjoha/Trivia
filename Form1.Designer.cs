namespace Trivia
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.cmbdificultad = new System.Windows.Forms.ComboBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.lblpregunta = new System.Windows.Forms.Label();
            this.rbopcion1 = new System.Windows.Forms.RadioButton();
            this.rbopcion2 = new System.Windows.Forms.RadioButton();
            this.rbopcion3 = new System.Windows.Forms.RadioButton();
            this.rbopcion4 = new System.Windows.Forms.RadioButton();
            this.btnresponder = new System.Windows.Forms.Button();
            this.pbTiempo = new System.Windows.Forms.ProgressBar();
            this.lblpreguntasrestantes = new System.Windows.Forms.Label();
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.lbltiemporestante = new System.Windows.Forms.Label();
            this.dgahistorial = new System.Windows.Forms.DataGridView();
            this.btnreiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgahistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONE UNA CATEGORIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELECCIONE UNA DIFICULTAD";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(105, 73);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbcategoria.TabIndex = 2;
            // 
            // cmbdificultad
            // 
            this.cmbdificultad.FormattingEnabled = true;
            this.cmbdificultad.Location = new System.Drawing.Point(105, 145);
            this.cmbdificultad.Name = "cmbdificultad";
            this.cmbdificultad.Size = new System.Drawing.Size(121, 24);
            this.cmbdificultad.TabIndex = 3;
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(120, 200);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(75, 23);
            this.btniniciar.TabIndex = 4;
            this.btniniciar.Text = "INICIAR";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // lblpregunta
            // 
            this.lblpregunta.AutoSize = true;
            this.lblpregunta.Location = new System.Drawing.Point(117, 252);
            this.lblpregunta.Name = "lblpregunta";
            this.lblpregunta.Size = new System.Drawing.Size(10, 16);
            this.lblpregunta.TabIndex = 5;
            this.lblpregunta.Text = ".";
            // 
            // rbopcion1
            // 
            this.rbopcion1.AutoSize = true;
            this.rbopcion1.Location = new System.Drawing.Point(120, 273);
            this.rbopcion1.Name = "rbopcion1";
            this.rbopcion1.Size = new System.Drawing.Size(37, 20);
            this.rbopcion1.TabIndex = 6;
            this.rbopcion1.TabStop = true;
            this.rbopcion1.Text = "A";
            this.rbopcion1.UseVisualStyleBackColor = true;
            // 
            // rbopcion2
            // 
            this.rbopcion2.AutoSize = true;
            this.rbopcion2.Location = new System.Drawing.Point(120, 299);
            this.rbopcion2.Name = "rbopcion2";
            this.rbopcion2.Size = new System.Drawing.Size(37, 20);
            this.rbopcion2.TabIndex = 7;
            this.rbopcion2.TabStop = true;
            this.rbopcion2.Text = "B";
            this.rbopcion2.UseVisualStyleBackColor = true;
            // 
            // rbopcion3
            // 
            this.rbopcion3.AutoSize = true;
            this.rbopcion3.Location = new System.Drawing.Point(120, 325);
            this.rbopcion3.Name = "rbopcion3";
            this.rbopcion3.Size = new System.Drawing.Size(37, 20);
            this.rbopcion3.TabIndex = 8;
            this.rbopcion3.TabStop = true;
            this.rbopcion3.Text = "C";
            this.rbopcion3.UseVisualStyleBackColor = true;
            // 
            // rbopcion4
            // 
            this.rbopcion4.AutoSize = true;
            this.rbopcion4.Location = new System.Drawing.Point(120, 351);
            this.rbopcion4.Name = "rbopcion4";
            this.rbopcion4.Size = new System.Drawing.Size(38, 20);
            this.rbopcion4.TabIndex = 9;
            this.rbopcion4.TabStop = true;
            this.rbopcion4.Text = "D";
            this.rbopcion4.UseVisualStyleBackColor = true;
            // 
            // btnresponder
            // 
            this.btnresponder.Location = new System.Drawing.Point(57, 399);
            this.btnresponder.Name = "btnresponder";
            this.btnresponder.Size = new System.Drawing.Size(173, 40);
            this.btnresponder.TabIndex = 10;
            this.btnresponder.Text = "RESPONDER";
            this.btnresponder.UseVisualStyleBackColor = true;
            this.btnresponder.Click += new System.EventHandler(this.btnresponder_Click);
            // 
            // pbTiempo
            // 
            this.pbTiempo.Location = new System.Drawing.Point(382, 53);
            this.pbTiempo.Name = "pbTiempo";
            this.pbTiempo.Size = new System.Drawing.Size(215, 17);
            this.pbTiempo.TabIndex = 11;
            this.pbTiempo.Click += new System.EventHandler(this.pbTiempo_Click);
            // 
            // lblpreguntasrestantes
            // 
            this.lblpreguntasrestantes.AutoSize = true;
            this.lblpreguntasrestantes.Location = new System.Drawing.Point(379, 156);
            this.lblpreguntasrestantes.Name = "lblpreguntasrestantes";
            this.lblpreguntasrestantes.Size = new System.Drawing.Size(177, 16);
            this.lblpreguntasrestantes.TabIndex = 12;
            this.lblpreguntasrestantes.Text = "PREGUNTAS FALTANTES:";
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.Location = new System.Drawing.Point(379, 130);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(73, 16);
            this.lblpuntaje.TabIndex = 13;
            this.lblpuntaje.Text = "PUNTAJE:";
            // 
            // lbltiemporestante
            // 
            this.lbltiemporestante.AutoSize = true;
            this.lbltiemporestante.Location = new System.Drawing.Point(379, 102);
            this.lbltiemporestante.Name = "lbltiemporestante";
            this.lbltiemporestante.Size = new System.Drawing.Size(64, 16);
            this.lbltiemporestante.TabIndex = 14;
            this.lbltiemporestante.Text = "TIEMPO: ";
            // 
            // dgahistorial
            // 
            this.dgahistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgahistorial.Location = new System.Drawing.Point(639, 53);
            this.dgahistorial.Name = "dgahistorial";
            this.dgahistorial.RowHeadersWidth = 51;
            this.dgahistorial.RowTemplate.Height = 24;
            this.dgahistorial.Size = new System.Drawing.Size(369, 196);
            this.dgahistorial.TabIndex = 15;
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.Location = new System.Drawing.Point(383, 279);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(173, 40);
            this.btnreiniciar.TabIndex = 16;
            this.btnreiniciar.Text = "REINICIAR";
            this.btnreiniciar.UseVisualStyleBackColor = true;
            this.btnreiniciar.Click += new System.EventHandler(this.btnreiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 588);
            this.Controls.Add(this.btnreiniciar);
            this.Controls.Add(this.dgahistorial);
            this.Controls.Add(this.lbltiemporestante);
            this.Controls.Add(this.lblpuntaje);
            this.Controls.Add(this.lblpreguntasrestantes);
            this.Controls.Add(this.pbTiempo);
            this.Controls.Add(this.btnresponder);
            this.Controls.Add(this.rbopcion4);
            this.Controls.Add(this.rbopcion3);
            this.Controls.Add(this.rbopcion2);
            this.Controls.Add(this.rbopcion1);
            this.Controls.Add(this.lblpregunta);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.cmbdificultad);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgahistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.ComboBox cmbdificultad;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Label lblpregunta;
        private System.Windows.Forms.RadioButton rbopcion1;
        private System.Windows.Forms.RadioButton rbopcion2;
        private System.Windows.Forms.RadioButton rbopcion3;
        private System.Windows.Forms.RadioButton rbopcion4;
        private System.Windows.Forms.Button btnresponder;
        private System.Windows.Forms.ProgressBar pbTiempo;
        private System.Windows.Forms.Label lblpreguntasrestantes;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Label lbltiemporestante;
        private System.Windows.Forms.DataGridView dgahistorial;
        private System.Windows.Forms.Button btnreiniciar;
    }
}

