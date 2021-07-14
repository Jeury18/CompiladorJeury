using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorIT
{
    public partial class compilador : Form
    {
        Lexico oAnaLex = new Lexico();
        Class1 oTablaSimb = new Class1(26);


        string[] reservado = { "else", "if",  "print"};
        List<char> numeros = new List<char>(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
        List<char> letras = new List<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'});
        List<string> Reservadas = new List<string>(new string[] { "if", "else", "print" });
        List<char> tiposOperadores = new List<char>(new char[] { '+', '-', '*', '/', '%', '!', '>', '<', '=', '&', '|'});
        List<char> delimitadores = new List<char>(new char[] { '(', ')', '{', '}', '[', ']', ';' });
        List<char> espacios = new List<char>(new char[] { ' ' });
        DataTable Resultado = new DataTable();
        DataTable Resultado1 = new DataTable();
        DataTable Resultado2 = new DataTable();
        public compilador()
        {
            InitializeComponent();
        }

        private void compilar_Click(object sender, EventArgs e)
        {
            // Resultado.Clear();


            
            tabla_simb = new Simbolos();
            CodigoSalida.Text = "";
            tabla_errorres.inicialestaE();
            leer_texto(CodigoEntrada.Text);
            string[] sent = une_tokens();
            tabla_simb.comparacion_semantic();

            Analisis_Sint_Sem(sent);

            Resultado.Clear();
            List<char> cadena = CodigoSalida.Text.Replace(" ", "").ToCharArray().ToList();

          // List<string> cadena1 = CodigoSalida.Text.Replace(" ", "").ToCharArray().ToList();
     

            if (cadena.Count > 0 || cadena.Count.ToString() == "")
            {
                DataRow fila;

                foreach (char caracter in cadena)
                {
                    fila = Resultado.NewRow();
                    
                    if (numeros.Contains(caracter))
                    {
                        fila["TOKEN"] = caracter;
                        fila["TIPO"] = "VALOR NUMERICO";
                    }
                    else if (tiposOperadores.Contains(caracter))
                    {
                        fila["TOKEN"] = caracter;
                        fila["TIPO"] = "SIGNO DE OPERACION";
                    }
                    else if (delimitadores.Contains(caracter))
                    {
                        fila["TOKEN"] = caracter;
                        fila["TIPO"] = "DELIMITADOR DE CODIGO";

                    }else                     
                     {
                         fila["Token"] = ' ';
                         fila["Tipo"] = "ESPACIO";
                     }
                   

                    Resultado.Rows.Add(fila);
                }
           
                AnalizadorLexico.DataSource = Resultado;
                AnalizadorLexico.Refresh();
            }
            else
            {
                AnalizadorLexico.DataSource = null;
                AnalizadorLexico.Refresh();
            }
            sintactico();
            TablaSimbolos();

            oAnaLex.Inicia();
            oAnaLex.Analiza(CodigoEntrada.Text);
            dataGridView1.Rows.Clear();
            if (oAnaLex.NoTokens > 0)
                dataGridView1.Rows.Add(oAnaLex.NoTokens);
            for (int i = 0; i < oAnaLex.NoTokens; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = oAnaLex.Token[i];
                dataGridView1.Rows[i].Cells[1].Value = oAnaLex.Lexema[i];
            }
            
        }

        void TablaSimbolos()
        {
            Resultado2.Clear();
            List<char> cadena = CodigoSalida.Text.Replace(" ", "").ToCharArray().ToList();
           //List<string> cadena2 = CodigoSalida.Text.ToString();

          if (cadena.Count > 0 || cadena.Count.ToString() == "")
            {
                DataRow fila;
               
                foreach (char caracter in cadena)
                {
                    fila = Resultado2.NewRow();

                    if (numeros.Contains(caracter))
                    {
                        fila["TOKEN"] = caracter;
                        fila["DESCRIPCION"] = "NUMERO";
                    }
                    /* else if (letras.Contains(caracter.ToString().ToUpper()[0]))
                     {
                         fila["Token"] = caracter;
                         fila["Tipo"] = "Variable";
                     }*/
                    else if (Reservadas.Contains(caracter.ToString().ToUpper()))
                    {
                        fila["TOKEN"] = caracter;
                        fila["DESCRIPCION"] = "RESERVADO";
                    }
                    else if (espacios.Contains(caracter.ToString().ToUpper()[0]))
                    {
                        fila["TOKEN"] = caracter;
                        fila["DESCRIPCION"] = "ESPACIO";
                    }
                    else if (tiposOperadores.Contains(caracter))
                    {
                        fila["TOKEN"] = caracter;
                        fila["DESCRIPCION"] = "OPERADOR";
                    }
                    else if (delimitadores.Contains(caracter))
                    {
                        fila["TOKEN"] = caracter;
                        fila["DESCRIPCION"] = "DELIMITADOR";


                    }
                    else
                    {
                        fila["TOKEN"] = ' ';
                        fila["DESCRIPCION"] = "SALTO DE LINEA";
                    }

                    Resultado2.Rows.Add(fila);
                }

                TablaDeSimbolos.DataSource = Resultado2;
                TablaDeSimbolos.Refresh();
            }
            else
            {
                TablaDeSimbolos.DataSource = null;
                TablaDeSimbolos.Refresh();
            }
        }

        void sintactico()
        {
            Resultado1.Clear();
            List<char> cadena = CodigoSalida.Text.Replace(" ", "").ToCharArray().ToList();
            //List<string> cadena2 = CodigoSalida.Text.ToString();

            if (cadena.Count > 0 || cadena.Count.ToString() == "")
            {
                DataRow fila;

                foreach (char caracter in cadena)
                {
                    fila = Resultado1.NewRow();

                    if (tiposOperadores.Contains(caracter))
                    {
                        fila["IDENTIFICADOR"] = caracter;
                        fila["OBSERVACION"] = " <- SE DECLARO UN OPERADOR";
                    }
                    else if (delimitadores.Contains(caracter))
                    {
                        fila["IDENTIFICADOR"] = caracter;
                        fila["OBSERVACION"] = " <-  SE ESTABLECIO UN DELIMITADOR";

                    }
                    

                    Resultado1.Rows.Add(fila);
                }

                AnalizadorSintacticoo.DataSource = Resultado1;
                AnalizadorSintacticoo.Refresh();
            }
            else
            {
                AnalizadorSintacticoo.DataSource = null;
                AnalizadorSintacticoo.Refresh();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            CodigoEntrada.Text = "";
            CodigoSalida.Text = "";
            CodigoEntrada.Clear();
            Resultado.Clear();
            AnalizadorLexico.DataSource = null;
            AnalizadorLexico.Refresh();
            Resultado1.Clear();
            AnalizadorSintacticoo.DataSource = null;
            AnalizadorSintacticoo.Refresh();
            Resultado2.Clear();
            TablaDeSimbolos.DataSource = null;
            TablaDeSimbolos.Refresh();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int cantLineas = 0;

        Sentencias tabla_errorres = new Sentencias();
        Simbolos tabla_simb = new Simbolos();
        Simbolos tabla_simb2 = new Simbolos();

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void leer_texto(string texto)
        {

            int contador_Ambitoi = 0;
            int contador_Ambitf = 0;
            int ambito = 0;

            string Rtexto = "";

            Rtexto = CodigoEntrada.Text;

            try
            {
                string[] palabra_sep;
                int num_lineas = CodigoEntrada.Lines.Length;

                int num_line_token = 0;

                while (Rtexto != "")
                {
                    palabra_sep = CodigoEntrada.Text.Split(' ');
                    foreach (var palabra in palabra_sep)
                    {
                        num_line_token = num_line_token + 1;

                        if (palabra == "{")
                        {
                            contador_Ambitoi = contador_Ambitoi + 1;
                        }
                        if (palabra == "}")
                        {
                            contador_Ambitf = contador_Ambitf + 1;
                        }
                        ambito = contador_Ambitoi;

                        if (tabla_simb2.compararAL(palabra.ToString()) && palabra != null)
                        {

                            Table obj = new Table(palabra, "", num_line_token, -0, ambito, tabla_simb2.compararALRef(palabra.ToString()), "palabra nueva", "palabra contenida en la tabla de simbolos", "");
                            tabla_simb.añadir_obj(obj);
                        }
                        else
                        {
                            if (Regex.IsMatch(palabra, @"[a-zA-Z]") && palabra != null)
                            {
                                Table obj = new Table(palabra, "", num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "palabra nueva", "palabra que no coincide con la Tabla de simbolos,pero no se considera error", "");
                                tabla_simb.añadir_obj(obj);
                            }
                            else if (Regex.IsMatch(palabra, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}") && palabra != null)
                            {
                                Table obj = new Table(palabra, palabra, num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "numero nuevo", "numero", "");
                                tabla_simb.añadir_obj(obj);
                            }
                            else if (palabra != null && palabra == "->")
                            {
                                Table obj = new Table(palabra, palabra, num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "numero nuevo", "numero", "");
                                tabla_simb.añadir_obj(obj);
                            }
                        }
                    }
                    palabra_sep = null;
                    Rtexto = "";
                    cantLineas = num_lineas;
                }
                if (contador_Ambitf != contador_Ambitoi)
                {
                    tabla_errorres.agrega_error(8);

                }

            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Error");

                tabla_errorres.agrega_error(2);
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }


        }

        public string[] une_tokens()
        {
            string sentencia = null;
            int tam = 1;
            string[] sentencias = new string[tam + 1];

            int comp = 0;

            string tipov = "";
            List<string> Ltoken = new List<string>();

            for (int i = 1; i <= tam; i++)
            {
                foreach (var token in tabla_simb.llamatabla())
                {
                    if (token.num_linea == i && token != null)
                    {
                        if (comp == 0 && Regex.IsMatch(token.Simbolo, @"(.integer|.float|.double|.booleano|.String)$"))
                        {

                            token.Tipo_Dato = token.Simbolo;
                            tipov = token.Simbolo;
                        }


                        if (comp != 0)
                        {
                            sentencia = sentencia + " " + token.simbolo.ToString();
                            token.Tipo_Dato = tipov;
                        }
                        else
                        {
                            sentencia = sentencia + token.simbolo.ToString();
                            comp = 1;
                        }

                    }
                    else
                    {

                        sentencia = sentencia + " " + token.simbolo.ToString();
                    }
                }
                sentencias[i] = sentencia;
                sentencia = null;
                comp = 0;
                tipov = "";
            }

            return sentencias;
        }

        public void Analisis_Sint_Sem(string[] sentencias)
        {
            List<string> sintaxisLNV = new List<string>();

            int cantidad = 0;

            for (int j = 0; j < sentencias.Length; j++)
            {
                if (sentencias[j] != null)
                    cantidad = System.Text.RegularExpressions.Regex.Matches(sentencias[j], "\n").Count;

            }

            for (int i = 1; i < sentencias.Length; i++)
            {


                if (sentencias[i] != null)
                {
                    for (int a = 0; a < cantidad; a++)
                    {
                        if (sentencias[i].Contains(".integer") && !sintaxisLNV.Contains(".integer"))
                        {
                            sintaxisLNV.Add(".integer");

                            string[] separanum;
                            separanum = sentencias[i].Split(' ');


                            try
                            {
                                sentencias[i] = sentencias[i].Replace(".integer", "int");
                                if (sentencias[i].Contains("->"))
                                    sentencias[i] = sentencias[i].Replace("->", "=");


                            }
                            catch (FormatException e)
                            {

                                tabla_errorres.agrega_error_l(0, i);

                            }
                            catch (IndexOutOfRangeException e)
                            {

                                tabla_errorres.agrega_error_l(10, i);
                            }



                        }

                        else if (sentencias[i].Contains(".double") && !sintaxisLNV.Contains(".double"))
                        {
                            sintaxisLNV.Add(".double");
                            string[] separanum;
                            separanum = sentencias[i].Split(' ');
                            try
                            {
                                sentencias[i] = sentencias[i].Replace(".double", "double");
                                if (sentencias[i].Contains("->"))
                                    sentencias[i] = sentencias[i].Replace("->", "=");

                                double num;
                                num = double.Parse(separanum[3]);


                            }
                            catch (FormatException e)
                            {
                                tabla_errorres.agrega_error_l(0, i);


                            }
                            catch (IndexOutOfRangeException e)
                            {

                                tabla_errorres.agrega_error_l(10, i);


                            }


                        }
                        else if (sentencias[i].Contains(".String") && !sintaxisLNV.Contains(".String"))
                        {
                            sintaxisLNV.Add(".String");
                            sentencias[i] = sentencias[i].Replace(".String", "String");
                            if (sentencias[i].Contains("->"))
                                sentencias[i] = sentencias[i].Replace("->", "=");

                        }
                        else if (sentencias[i].Contains(".booleano") && !sintaxisLNV.Contains(".booleano"))
                        {
                            sintaxisLNV.Add(".booleano");


                            string[] separavar;
                            separavar = sentencias[i].Split(' ');
                            try
                            {
                                sentencias[i] = sentencias[i].Replace(".booleano", "bool");
                                if (sentencias[i].Contains("->"))
                                    sentencias[i] = sentencias[i].Replace("->", "=");

                                bool var;
                                var = bool.Parse(separavar[3]);

                            }
                            catch (FormatException e)
                            {

                                tabla_errorres.agrega_error_l(0, i);
                            }

                        }
                        else if (sentencias[i].Contains("<<") && !sintaxisLNV.Contains(".<<"))
                        {
                            sintaxisLNV.Add(".<<");
                            sentencias[i] = sentencias[i].Replace("<<", "//");
                            if (sentencias[i].Contains("->"))
                                sentencias[i] = sentencias[i].Replace("->", "=");
                        }
                        else if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s[a-z]|(\w)*\s\+\s(\w)*|\d(0,32000)*\s;$") && !sintaxisLNV.Contains("->"))
                        {
                            sintaxisLNV.Add("->");
                            if (sentencias[i].Contains("->"))
                                sentencias[i] = sentencias[i].Replace("->", "=");

                            string tpv1 = "";
                            string tpv2 = "";
                            string tpv3 = "";

                            string[] separavar;
                            separavar = sentencias[i].Split(' ');

                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\+\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("el tipo de las variables son el mismo");
                                }
                            }
                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\-\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("El tipo de las variables son iguales");
                                }
                            }
                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\/\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("El tipo de las variables son iguales");
                                }
                            }
                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\*\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("El tipo de las variables son iguales");
                                }
                            }

                        }

                        else if (sentencias[i].Contains("si") && !sintaxisLNV.Contains("si"))
                        {
                            sintaxisLNV.Add("si");
                            sentencias[i] = sentencias[i].Replace("si", "if");
                        }
                        else if (sentencias[i].Contains("entonces") && !sintaxisLNV.Contains("entonces"))
                        {
                            sintaxisLNV.Add("sentonces");
                            sentencias[i] = sentencias[i].Replace("entonces", "else ");
                        }
                        else if (sentencias[i].Contains("entonces si") && !sintaxisLNV.Contains("entonces si"))
                        {
                            sintaxisLNV.Add("entonces si");
                            sentencias[i] = sentencias[i].Replace("entonces si", "else if");
                        }
                        else if (sentencias[i].Contains(".ent") && !sintaxisLNV.Contains(".ent"))
                        {
                            sintaxisLNV.Add("entonces");
                            sentencias[i] = sentencias[i].Replace("entonces", "else");
                        }
                        else if (sentencias[i].Contains(">") && !sintaxisLNV.Contains(">"))
                        {
                            sintaxisLNV.Add(">");
                            sentencias[i] = sentencias[i].Replace(">", ">");
                        }
                        else if (sentencias[i].Contains("entero") && !sintaxisLNV.Contains("entero"))
                        {
                            sintaxisLNV.Add("entero");
                            sentencias[i] = sentencias[i].Replace("entero", "int");
                        }
                        else if (sentencias[i].Contains("real") && !sintaxisLNV.Contains("real"))
                        {
                            sintaxisLNV.Add("real");

                            sentencias[i] = sentencias[i].Replace("real", "float");
                        }
                        else if (sentencias[i].Contains("cadena") && !sintaxisLNV.Contains("cadena"))
                        {
                            sintaxisLNV.Add("cadena");
                            sentencias[i] = sentencias[i].Replace("cadena", "String");
                        }

                        else if (sentencias[i].Contains("salida") && !sintaxisLNV.Contains("salida"))
                        {
                            sintaxisLNV.Add("salida");
                            sentencias[i] = sentencias[i].Replace("salida", "print");

                        }
                        else if (sentencias[i].Contains("final") && !sintaxisLNV.Contains("final"))
                        {
                            sintaxisLNV.Add("final");
                            sentencias[i] = sentencias[i].Replace("final", "}");

                        }
                        else if (sentencias[i].Contains("visua") && !sintaxisLNV.Contains("visua"))
                        {
                            sintaxisLNV.Add("visua");
                            sentencias[i] = sentencias[i].Replace("visua", "print");

                        }
                        else if (sentencias[i].Contains("inicio") && !sintaxisLNV.Contains("inicio"))
                        {
                            sintaxisLNV.Add("inicio");
                            sentencias[i] = sentencias[i].Replace("inicio", "main(){");

                        }
                        else if (sentencias[i].Contains(" * ") && !sintaxisLNV.Contains(" * "))
                        {
                            sintaxisLNV.Add(" * ");
                            sentencias[i] = sentencias[i].Replace(" * ", " * ");

                        }
                        else if (sentencias[i].Contains(" = ") && !sintaxisLNV.Contains(" = "))
                        {
                            sintaxisLNV.Add(" = ");
                            sentencias[i] = sentencias[i].Replace(" = ", " = ");

                        }
                        else
                        {
                            if (sentencias[i] != null)
                            {
                                tabla_errorres.agrega_error_l(9, i);
                            }
                        }
                    }

                }
            }
            for (int i = 0; i < sentencias.Length; i++)
            {
                if (sentencias[i] != null)
                    CodigoSalida.Text += sentencias[i];
            }


        }

        private void Principal_Load(object sender, EventArgs e)
        {
            tabla_simb2.inicialista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compilador_Load(object sender, EventArgs e)
        {
            Resultado.Columns.Add("TOKEN", typeof(char));
            Resultado.Columns.Add("TIPO", typeof(string));

            Resultado1.Columns.Add("IDENTIFICADOR", typeof(char));
            Resultado1.Columns.Add("OBSERVACION", typeof(string));

            Resultado2.Columns.Add("TOKEN", typeof(char));
            Resultado2.Columns.Add("DESCRIPCION", typeof(string));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablaSimbolos formaTablaSimb = new TablaSimbolos();
            //oTablaSimb.Visua(formaTablaSimb.dataGridView1);
            formaTablaSimb.Show();
        }
    }
}
