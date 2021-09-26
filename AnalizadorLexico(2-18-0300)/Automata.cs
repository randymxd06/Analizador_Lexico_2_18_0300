namespace AnalizadorLexico_2_18_0300_
{
    /*------------------
        Clase Automata 
    --------------------*/
    class Automata
    {

        // Declaro variables globales //
        string _textoIma;
        int _edoAct;

        // Funcion sigCar //
        char sigCar(ref int i)
        {
            // Si i es igual al tamaño del textoIma entonces //
            if (i == _textoIma.Length)
            {

                // Incremento a i en 1 //
                i++;

                // Retorno un espacio //
                return ' ';

            }
            // Caso contrario //
            else
            {

                // Retorno el textoIma en su posicion siguiente //
                return _textoIma[i++];

            }

        }// Fin de la funcion sigCar //

        // Funcion Reconoce //
        public bool Reconoce(string texto, int iniToken, ref int i, int noAuto)
        {

            // Declaro las variables //
            char c;
            _textoIma = texto;
            string lenguaje;

            // Hago un switch case //
            switch (noAuto)
            {

                // Automata delimitador //
                case 0: _edoAct = 0; break;

                // Automata id //
                case 1: _edoAct = 3; break;

                // Automata numero //
                case 2: _edoAct = 6; break;

                // Automata otros //
                case 3: _edoAct = 9; break;

                // Automata cadena
                case 4: _edoAct = 11; break;

            }// Fin del switch case //

            // Recorro textoIma //
            while(i <= _textoIma.Length)
            {

                // Hago un switch case //
                switch (_edoAct)
                {

                    // Automata delimitador //
                    case 0:
                        c = sigCar(ref i);
                        if ((lenguaje = " \n\r\t").IndexOf(c) >= 0) { _edoAct = 1; }
                        else
                        {
                            i = iniToken;
                            return false;
                        }
                        break;

                    case 1:
                        c = sigCar(ref i);
                        if ((lenguaje = " \n\r\t").IndexOf(c) >= 0)
                        {
                            _edoAct = 1;
                        } else {
                            if ((lenguaje = "!\"#$%&\'()*+,-./123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_'abcdefghijklmnopqrstuvwxyz{|}~`\f").IndexOf(c) >= 0) { _edoAct = 2; }
                            else
                            {
                                i = iniToken;
                                return false;
                            }
                        }
                        break;

                    case 2:
                        i--;
                        return true;
                        break;

                    // Automata id //
                    case 3:
                        c = sigCar(ref i);
                        if ((lenguaje = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz").IndexOf(c) >= 0) { _edoAct = 4; }
                        else
                        {
                            i = iniToken;
                            return false;
                        }
                        break;

                    case 4:
                        c = sigCar(ref i);
                        if ((lenguaje = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz").IndexOf(c) >= 0) { _edoAct = 4; }
                        else {
                            if ((lenguaje = "0123456789").IndexOf(c) >= 0) { _edoAct = 4; }
                            else
                            {
                                if ((lenguaje = "_").IndexOf(c) >= 0) { _edoAct = 4; }
                                else
                                {
                                    if ((lenguaje = " !\"#$%&\'()*+,-./:;<=>?@[\\]^`~{|},,...__\n\t\r\f").IndexOf(c) >= 0) { _edoAct = 5; }
                                    else
                                    {
                                        i = iniToken;
                                        return false;
                                    }
                                }
                            }
                        }
                        
                        break;

                    case 5:
                        i--;
                        return true;
                        break;

                    // Automata numero //
                    case 6:
                        c = sigCar(ref i);
                        if ((lenguaje = "0123456789").IndexOf(c) >= 0) { _edoAct = 7; }
                        else
                        {
                            i = iniToken;
                            return false;
                        }
                        break;

                    case 7:
                        c = sigCar(ref i);
                        if ((lenguaje = " !\"#$%&\'()*+,-./:;<=>?@[\\]^`~{|},,...__\n\t\r\f").IndexOf(c) >= 0) { _edoAct = 7; }
                        else
                        {
                            if ((lenguaje = "!\"#$%&\'()*+,-./123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_'abcdefghijklmnopqrstuvwxyz{|}~`\n\t\r\f").IndexOf(c) >= 0) { _edoAct = 8; }
                            else
                            {
                                i = iniToken;
                                return false;
                            }
                        }
                        break;

                    case 8:
                        i--;
                        return true;
                        break;

                    // Automata otros //
                    case 9:
                        c = sigCar(ref i);
                        if ((lenguaje = "=").IndexOf(c) >= 0) { _edoAct = 10; }
                        else
                        {
                            if ((lenguaje = ";").IndexOf(c) >= 0) { _edoAct = 10; }
                            else
                            {
                                if ((lenguaje = ",").IndexOf(c) >= 0) { _edoAct = 10; }
                                else
                                {
                                    if ((lenguaje = ".").IndexOf(c) >= 0) { _edoAct = 10; }
                                    else
                                    {
                                        if ((lenguaje = "+").IndexOf(c) >= 0) { _edoAct = 10; }
                                        else
                                        {
                                            if ((lenguaje = "-").IndexOf(c) >= 0) { _edoAct = 10; }
                                            else
                                            {
                                                if ((lenguaje = "*").IndexOf(c) >= 0) { _edoAct = 10; }
                                                else
                                                {
                                                    if ((lenguaje = "/").IndexOf(c) >= 0) { _edoAct = 10; }
                                                    else
                                                    {
                                                        if ((lenguaje = "(").IndexOf(c) >= 0) { _edoAct = 10; }
                                                        else
                                                        {
                                                            if ((lenguaje = ")").IndexOf(c) >= 0) { _edoAct = 10; }
                                                            else
                                                            {
                                                                i = iniToken;
                                                                return false;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;


                    case 10:
                        return true;
                        break;

                    // Automata cadena //
                    case 11:
                        c = sigCar(ref i);
                        if ((lenguaje = "\"").IndexOf(c) >= 0) { _edoAct = 12; }
                        else
                        {
                            i = iniToken;
                            return false;
                        }
                        break;

                    case 12:
                        c = sigCar(ref i);
                        if ((lenguaje = "\"").IndexOf(c) >= 0) { _edoAct = 13; }
                        else {
                            if ((lenguaje = "!\"#$%&\'()*+,-./123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_'abcdefghijklmnopqrstuvwxyz{|}~`\n\t\r\f").IndexOf(c) >= 0) { _edoAct = 12; }
                            else
                            {
                                i = iniToken;
                                return false;
                            }
                        }                      
                        break;

                    case 13:
                        return true;
                        break;

                }// Fin del switch case //

                // Hago otro switch case //
                switch (_edoAct)
                {
                    // Automata delimitador //
                    case 2:

                    // Automata id //
                    case 5:
                    
                    // Automata numero //
                    case 8:
                        --i;
                        return true;

                }// Fin del switch case //

            }// Fin del while //

            return false;

        }// Fin de la funcion Reconoce //

    }// Fin de la clase Automata //

}// Fin del namespace //
