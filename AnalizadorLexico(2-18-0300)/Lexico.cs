using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico_2_18_0300_
{
    /*----------------
        Clase Lexico
    ------------------*/
    class Lexico
    {

        // Declaro las variables //
        const int TOKREC = 5;
        const int MAXTOKENS = 500;
        string[] _lexemas;
        string[] _tokens;
        string _lexema;
        int _noTokens;
        int _i;
        int _iniToken;
        Automata oAFD;

        //Este es el constructor por defecto //
        public Lexico()
        {
            _lexemas = new string[MAXTOKENS];
            _tokens = new string[MAXTOKENS];
            oAFD = new Automata();
            _i = 0;
            _iniToken = 0;
            _noTokens = 0;
        }

        public int NoTokens
        {
            get { return _noTokens; }
        }

        public string[] Lexema
        {
            get { return _lexemas; }
        }

        public string[] Token
        {
            get { return _tokens; }
        }

        public void Inicia()
        {
            _i = 0;
            _iniToken = 0;
            _noTokens = 0;
        }

        // Funcion para analizar el texto //
        public void Analiza(string texto)
        {

            // Declaro las variables //
            bool recAuto;
            int noAuto;

            // Recorro el texto que me llega por parametro //
            while(_i < texto.Length)
            {

                // Declaro las variables //
                recAuto = false;
                noAuto = 0;

                // Recorro noAuto //
                for (; noAuto < TOKREC && !recAuto;)
                    if (oAFD.Reconoce(texto, _iniToken, ref _i, noAuto)) // Si lo reconoce entonces //
                        recAuto = true; // Le asigno un valor true //
                    else // Caso contrario //
                        noAuto++; // Sigo recorriendo //

                // Si recAuto es true entonces //
                if (recAuto)
                {

                    // Le asigno valor a la variable _lexema //
                    _lexema = texto.Substring(_iniToken, _i - _iniToken);

                    // Hago un switch case //
                    switch (noAuto)
                    {

                        // Automata delimitador //
                        case 0:
                            break;

                        case 1:
                            if (EsId())
                                _tokens[_noTokens] = "id";
                            else
                                _tokens[_noTokens] = _lexema;
                            break;

                        // Automata numero //
                        case 2:
                            _tokens[_noTokens] = "num";
                            break;

                        // Automata otros //
                        case 3:
                            _tokens[_noTokens] = _lexema;
                            break;

                        // Automata cadena //
                        case 4:
                            _tokens[_noTokens] = "cad";
                            break;

                    }// Fin del switch case //

                    if (noAuto != 0)
                        _lexemas[_noTokens] = _lexema;
                }
                else
                {
                    _i++;
                    _iniToken = _i;
                }
            }

        }// Fin de la funcion Analiza //

        private bool EsId()
        {

            // Declaro un array con las palabras //
            string[] palres = { "inicio", "fin", "const", "var", "entero", "real", "cadena", "leer", "visua" };

            // Recorro el array //
            for(int i = 0; i < palres.Length; i++)

                // Si el lexema es del mismo tamaño que la palabra del array entonces //
                if (_lexema == palres[i])
                    return false; // Retorno false //
           
            // Retorno true //
            return true;

        }// Fin de la funcion EsId //

    }// Fin de la clase Lexico //
}
