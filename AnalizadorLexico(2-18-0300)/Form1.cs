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

            string frase = richTextBox1.Text;
            int indice = 0;
            int estado = 0;
            int estadoFinal = -1;
            string lexema = "";
            string token;

            TOKEN_LEXEMA.Columns.Add("ID", "ID");
            TOKEN_LEXEMA.Columns.Add("Lexema", "Lexema");
            TOKEN_LEXEMA.Columns.Add("Token", "Token");

            while ((indice <= (frase.Length - 1)) && (estadoFinal == -1))
            {
                lexema = " ";
                token = "error";
                while ((indice <= (frase.Length - 1)) && (estadoFinal != 25))
                {
                    if (estadoFinal == -1)
                    {
                        if (char.IsWhiteSpace(frase[indice]))
                        {
                            estadoFinal = -1;
                        }
                        else if (char.IsLetter(frase[indice]) || frase[indice] == '_')
                        {
                            estado = 0;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "Identificador";
                        }
                        else if (char.IsDigit(frase[indice]))
                        {
                            estado = 1;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "Entero";
                        }
                        else
                        {
                            estadoFinal = 25;
                            lexema = frase[indice].ToString();
                            token = "Error";
                        }
                        indice++;
                    }
                    else if (estadoFinal == -1)
                    {
                        estadoFinal = 25;
                    }
                    else if (estadoFinal == 0)
                    {
                        if (char.IsLetter(frase[indice]) || frase[indice] == '_')
                        {
                            estado = 0;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "Identificador";
                            indice++;
                        }
                        else if (char.IsDigit(frase[indice]))
                        {
                            estado = 0;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "Identificador";
                            indice++;
                        }
                        else
                        {
                            estadoFinal = 25;
                        }
                    }
                    else if (estadoFinal == 1)
                    {
                        if (char.IsDigit(frase[indice]))
                        {
                            estado = 1;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "Entero";
                            indice++;
                        }
                        else if (frase[indice] == '.')
                        {
                            estado = 24;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "Punto";
                            indice++;
                        }
                        else
                        {
                            estadoFinal = 25;
                        }
                    }
                    else if (estadoFinal == 24)
                    {
                        if (char.IsDigit(frase[indice]))
                        {
                            estado = 1;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "Float";
                            indice++;
                        }
                        else
                        {
                            estadoFinal = 25;
                        }
                    }

                }
                TOKEN_LEXEMA.Rows.Add(estado, lexema, token);
                estadoFinal = -1;
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
