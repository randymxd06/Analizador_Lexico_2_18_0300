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
            
            // Declaro las variables //
            string texto = richTextBox1.Text;
            int i = 0;
            int estado = 0;
            int estadoFinal = -1;
            string lexema = "";
            string token;

            // Creo las columnas de la tabla //
            TOKEN_LEXEMA.Columns.Add("ID", "ID");
            TOKEN_LEXEMA.Columns.Add("Lexema", "Lexema");
            TOKEN_LEXEMA.Columns.Add("Token", "Token");

            // Recorro todo lo que este escrito en el richTextBox //
            while ((i <= (texto.Length - 1)) && (estadoFinal == -1))
            {

                // Inicializo las variables //
                lexema = " ";
                token = "error";

                // Recorro el richTextBox hasta el final //
                while ((i <= (texto.Length - 1)) && (estadoFinal != 25))
                {

                    // Si el estado final esta en su posicion inicial entonces //
                    if (estadoFinal == -1)
                    {

                        // Si es un espacio entonces //
                        if (char.IsWhiteSpace(texto[i]))
                        {
                            // Pongo el estado final en su posicion inicial //
                            estadoFinal = -1;
                        }

                        // Si es una letra entonces es un identificador //
                        else if (char.IsLetter(texto[i]) || texto[i] == '_')
                        {
                            estado = 0;
                            estadoFinal = estado;
                            lexema += texto[i];
                            token = "Identificador";
                        }

                        // Si es un digito entonces es un Entero //
                        else if (char.IsDigit(texto[i]))
                        {
                            estado = 1;
                            estadoFinal = estado;
                            lexema += texto[i];
                            token = "Entero";
                        }

                        else// Caso contrario, envio un error //
                        {
                            estadoFinal = 25;
                            lexema = texto[i].ToString();
                            token = "Error";
                        }

                        i++; // Sigo recorriendo el texto //

                    }

                    else if (estadoFinal == -1)
                    {
                        estadoFinal = 25;
                    }

                    else if (estadoFinal == 0) // Si el estado esta en la posicion 0 osea al principio entonces //
                    {

                        // Si es una letra entonces es un identificador //
                        if (char.IsLetter(texto[i]) || texto[i] == '_')
                        {
                            estado = 0;
                            estadoFinal = estado;
                            lexema += texto[i];
                            token = "Identificador";
                            i++;
                        }

                        //Si es un digito entonces es un identificador //
                        else if (char.IsDigit(texto[i]))
                        {
                            estado = 0;
                            estadoFinal = estado;
                            lexema += texto[i];
                            token = "Identificador";
                            i++;
                        }

                        else
                        {
                            estadoFinal = 25;
                        }

                    }

                    // Si esta en la posicion despues de la primera enconces aqui van los tipos de datos como int, float, etc //
                    else if (estadoFinal == 1)
                    {
                        // Si es digito entonces es un entero //
                        if (char.IsDigit(texto[i]))
                        {
                            estado = 1;
                            estadoFinal = estado;
                            lexema += texto[i];
                            token = "Entero";
                            i++;
                        }

                        // Si es un punto entonces pongo que es un punto //
                        else if (texto[i] == '.')
                        {
                            estado = 24;
                            estadoFinal = estado;
                            lexema += texto[i];
                            token = "Punto";
                            i++;
                        }

                        else
                        {
                            estadoFinal = 25;
                        }

                    }

                    else if (estadoFinal == 24)
                    {

                        if (char.IsDigit(texto[i]))
                        {
                            estado = 1;
                            estadoFinal = estado;
                            lexema += texto[i];
                            token = "Float";
                            i++;
                        }

                        else
                        {
                            estadoFinal = 25;
                        }

                    }

                }

                // Agrego a la tabla //
                TOKEN_LEXEMA.Rows.Add(estado, lexema, token);
                estadoFinal = -1;// Regreso el estado final a su valor inicial //

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
