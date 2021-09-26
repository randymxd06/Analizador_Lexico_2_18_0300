
namespace AnalizadorLexico_2_18_0300_
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TOKEN_LEXEMA = new System.Windows.Forms.DataGridView();
            this.Analisis_Lexico_Button = new System.Windows.Forms.Button();
            this.Salir_Button = new System.Windows.Forms.Button();
            this.Limpiar_Tabla_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo a Analizar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(537, 559);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // TOKEN_LEXEMA
            // 
            this.TOKEN_LEXEMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TOKEN_LEXEMA.Location = new System.Drawing.Point(555, 79);
            this.TOKEN_LEXEMA.Name = "TOKEN_LEXEMA";
            this.TOKEN_LEXEMA.RowHeadersWidth = 51;
            this.TOKEN_LEXEMA.RowTemplate.Height = 24;
            this.TOKEN_LEXEMA.Size = new System.Drawing.Size(514, 559);
            this.TOKEN_LEXEMA.TabIndex = 2;
            // 
            // Analisis_Lexico_Button
            // 
            this.Analisis_Lexico_Button.Location = new System.Drawing.Point(12, 644);
            this.Analisis_Lexico_Button.Name = "Analisis_Lexico_Button";
            this.Analisis_Lexico_Button.Size = new System.Drawing.Size(135, 36);
            this.Analisis_Lexico_Button.TabIndex = 3;
            this.Analisis_Lexico_Button.Text = "Analisis Lexico";
            this.Analisis_Lexico_Button.UseVisualStyleBackColor = true;
            this.Analisis_Lexico_Button.Click += new System.EventHandler(this.Analisis_Lexico_Button_Click);
            // 
            // Salir_Button
            // 
            this.Salir_Button.Location = new System.Drawing.Point(179, 644);
            this.Salir_Button.Name = "Salir_Button";
            this.Salir_Button.Size = new System.Drawing.Size(82, 36);
            this.Salir_Button.TabIndex = 4;
            this.Salir_Button.Text = "Salir";
            this.Salir_Button.UseVisualStyleBackColor = true;
            this.Salir_Button.Click += new System.EventHandler(this.Salir_Button_Click);
            // 
            // Limpiar_Tabla_Button
            // 
            this.Limpiar_Tabla_Button.Location = new System.Drawing.Point(293, 644);
            this.Limpiar_Tabla_Button.Name = "Limpiar_Tabla_Button";
            this.Limpiar_Tabla_Button.Size = new System.Drawing.Size(150, 36);
            this.Limpiar_Tabla_Button.TabIndex = 5;
            this.Limpiar_Tabla_Button.Text = "Limpiar Tabla";
            this.Limpiar_Tabla_Button.UseVisualStyleBackColor = true;
            this.Limpiar_Tabla_Button.Click += new System.EventHandler(this.Limpiar_Tabla_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 707);
            this.Controls.Add(this.Limpiar_Tabla_Button);
            this.Controls.Add(this.Salir_Button);
            this.Controls.Add(this.Analisis_Lexico_Button);
            this.Controls.Add(this.TOKEN_LEXEMA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView TOKEN_LEXEMA;
        private System.Windows.Forms.Button Analisis_Lexico_Button;
        private System.Windows.Forms.Button Salir_Button;
        private System.Windows.Forms.Button Limpiar_Tabla_Button;
    }
}

