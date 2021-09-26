using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico_2_18_0300_
{
    public partial class Form1 : Form
    {

        // Llamamos al lexema //
        Lexico Analiza_Lexico = new Lexico();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Logica del Boton Analisis Lexico //
        private void Analisis_Lexico_Button_Click(object sender, EventArgs e)
        {
            // Inicializo el analizador lexico //
            Analiza_Lexico.Inicia();

            // Analizo el texto que esta en el richTextBox //
            Analiza_Lexico.Analiza(richTextBox1.Text);

            // Limpio el dataGridView //
            TOKEN_LEXEMA.Rows.Clear();

            // Si hay contenido entonces lleno el dataGridView //
            if (Analiza_Lexico.NoTokens > 0)
                TOKEN_LEXEMA.Rows.Add(Analiza_Lexico.NoTokens);

            // Recorro todos los valores y los voy mostrando en el dataGriDView //
            for(int i = 0; i < Analiza_Lexico.NoTokens; i++)
            {
                TOKEN_LEXEMA.Rows[i].Cells[0].Value = Analiza_Lexico.Token[i];
                TOKEN_LEXEMA.Rows[i].Cells[1].Value = Analiza_Lexico.Lexema[i];
            }

        }// Fin de la logica del boton Analisis Lexico //

        // Logica del Boton Salir //
        private void Salir_Button_Click(object sender, EventArgs e)
        {

            // Salgo de la aplicacion //
            Application.Exit();

        }// Fin de la logica del boton Salir //

        // Logica del Boton Limpiar Tabla //
        private void Limpiar_Tabla_Button_Click(object sender, EventArgs e)
        {

            // Limpio el dataGridView //
            TOKEN_LEXEMA.Rows.Clear();

            // Limpio el richTextBox //
            richTextBox1.Text = "";

            // Pongo el cursos en el richTextBox //
            richTextBox1.Focus();

        }// Fin de la logica del boton Limpiar Tabla //

    }// Fin de la clase Form1 //

}
