namespace _05_Perceptron_Iirs_Plant
{
    public partial class Form1 : Form
    {

        int entradas;
        double filas;
        double salidaY = 0;

        int contadorCorrectas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarDatos();

        }

        // Funcion mostrar Archivo
        public void mostrarDatos()     
        {
            //Lectura de Archivo iris.txt
            StreamReader leeLinea = new StreamReader("iris.txt");
            string linea;
            int contador = -1;
            try
            {
                linea = leeLinea.ReadLine();
                while (linea != null)
                {
                    lBdatos.Items.Add(linea + "\n");
                    linea = leeLinea.ReadLine();
                    contador++;
                }
                lBdatos.Items.Add("Numero de datos: " + contador);
            }
            catch
            {
                MessageBox.Show("¡Error, no se encuentra el archivo!    ಥ‿ಥ ");
            }
            leeLinea.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entradas = 4;
            filas = 100;
            limpia();
            contadorCorrectas = 0;

            CreaTabla(entradas, filas);
            LlenarTabla(entradas, filas);
            Y_esperada(entradas);
            Y_calculada(entradas, filas);

        }

        public void limpia()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            lBresultados.Items.Clear();
        }

        public void CreaTabla(int entradas, double filas)
        {
            for (int i = 0; i < entradas; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "X" + (i + 1).ToString() });
            }

            for (int j = 1; j < filas; j++)
            {
                j = dataGridView1.Rows.Add(new DataGridViewRow());
            }

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Yesperada" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ycalculada" });
        }

        public void LlenarTabla(int entradas, double filas)
        {
            StreamReader leeLinea = new StreamReader("iris.txt");
            string linea;

            linea = leeLinea.ReadLine();
            string[] datos = linea.Split(',');
            string clase = datos[datos.Length - 1];

                if (CBOpciones.Text == "Setosa-Versicolor")
                {

                    for (int i = 0; i < 50; i++)
                    {

                        for (int j = 0; j < entradas; j++)
                        {

                            dataGridView1.Rows[i].Cells[j].Value = datos[j];

                        }
                        linea = leeLinea.ReadLine();
                        datos = linea.Split(',');
                    }

                    for (int i = 50; i < 100; i++)
                    {

                        for (int j = 0; j < entradas; j++)
                        {

                            dataGridView1.Rows[i].Cells[j].Value = datos[j];

                        }
                        linea = leeLinea.ReadLine();
                        datos = linea.Split(',');
                    }
                }

                else if(CBOpciones.Text == "Setosa-Virginica")
                {

                    for (int i = 0; i < 49; i++)
                    {

                        for (int j = 0; j < entradas; j++)
                        {

                            dataGridView1.Rows[i].Cells[j].Value = datos[j];

                        }
                        linea = leeLinea.ReadLine();
                        datos = linea.Split(',');
                    }

                    for(int k = 50; k < 100; k++)
                    {
                        linea = leeLinea.ReadLine();
                    }

                    for (int i = 49; i < 100; i++)
                    {

                        for (int j = 0; j < entradas; j++)
                        {

                            dataGridView1.Rows[i].Cells[j].Value = datos[j];

                        }
                        linea = leeLinea.ReadLine();
                        datos = linea.Split(',');
                    }

                }

                else if(CBOpciones.Text == "Versicolor-Virginica")
                {
                    for (int k = 0; k < 49; k++)
                    {
                        linea = leeLinea.ReadLine();
                    }

                linea = leeLinea.ReadLine();
                datos = linea.Split(',');

                for (int i = 0; i < 50; i++)
                    {

                        for (int j = 0; j < entradas; j++)
                        {

                            dataGridView1.Rows[i].Cells[j].Value = datos[j];

                        }
                        linea = leeLinea.ReadLine();
                        datos = linea.Split(',');
                    }

                    for (int i = 50; i < 100; i++)
                    {

                        for (int j = 0; j < entradas; j++)
                        {

                            dataGridView1.Rows[i].Cells[j].Value = datos[j];

                        }
                        linea = leeLinea.ReadLine();
                        datos = linea.Split(',');
                    }
                }
                else
                {
                    MessageBox.Show("Opción no disponible.");
                }
            leeLinea.Close();
        }

        public void Y_esperada(int entradas)
        {
            for(int i = 0; i < 50; i++)
            {
                dataGridView1.Rows[i].Cells[entradas].Value = "-1";
            }

            for (int i = 50; i < 100; i++)
            {
                dataGridView1.Rows[i].Cells[entradas].Value = "1";
            }
        }

        public void Y_calculada(int entradas, double filas)
        {
            Random umbral = new Random();
            Random pesos = new Random();
            Random pesos1 = new Random();
            Random umbral1 = new Random();
            double valorTabla = 0;

            //.........
            //Pesos aleatoreos
            double[] pesosAleatoreos = new double[75];
            double valorUmbral;
            double[] valoresUmbral = new double[75];
            int posicionPesos, posicionUmbral;

            for (int i = 0; i < 75; i++)
            {
                pesosAleatoreos[i] = pesos.NextDouble();
                valoresUmbral[i] = umbral.NextDouble();
            }

            pesosAleatoreos[60] = 0;
            pesosAleatoreos[27] = 1;

            valoresUmbral[47] = 0;
            valoresUmbral[15] = 1;


            //........
            double[] pesos_array = new double[entradas];

            int contador = 0;

            int n = 0;

            //Calcula los pesos aleatoreos 
            for (int i = 0; i < entradas; i++)
            {
                posicionPesos = pesos1.Next(0, 75);
                pesos_array[i] = pesosAleatoreos[posicionPesos];
            }

            posicionUmbral = umbral1.Next(0, 75);
            valorUmbral = valoresUmbral[posicionUmbral];

            //Proceso de aprendizaje completo
            do
            {

                if (contadorCorrectas == filas)
                {
                    MessageBox.Show("Solución encontrada!!!");
                    break;
                }

                contadorCorrectas = 0;

                //Muestra valores de los pesos y umbral en listBox
                for (int i = 0; i < entradas; i++)
                {
                    lBresultados.Items.Add("Peso[" + i + "]: " + pesos_array[i]);
                }
                lBresultados.Items.Add("Umbral: " + valorUmbral);
                lBresultados.Items.Add("Entrada: " + contador);
                lBresultados.Items.Add(" ");

                //Pone los valores en Y_calculada
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < entradas; j++)
                    {
                        // Obtencion de los valores del datagrid tabla
                        valorTabla = double.Parse((string)dataGridView1.Rows[i].Cells[j].Value);
                        // Obtencion del valor de la suma por renglon
                        salidaY = salidaY + (pesos_array[j] * valorTabla);
                    }
                    salidaY = salidaY + valorUmbral;

                    if (salidaY > 0)
                    {
                        dataGridView1.Rows[i].Cells[entradas + 1].Value = "1";
                        salidaY = 0;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[entradas + 1].Value = "-1";
                        salidaY = 0;
                    }



                    //Compara Y_esperada y Y_calculada
                    if (double.Parse((string)dataGridView1.Rows[i].Cells[entradas].Value) != double.Parse((string)dataGridView1.Rows[i].Cells[entradas + 1].Value))
                    {
                        for (int j = 0; j < entradas; j++)
                        {
                            double[] cambio_peso = new double[entradas];
                            cambio_peso[j] = double.Parse((string)dataGridView1.Rows[i].Cells[entradas].Value) * double.Parse((string)dataGridView1.Rows[i].Cells[j].Value);
                            pesos_array[j] = pesos_array[j] + cambio_peso[j];
                        }
                        valorUmbral = valorUmbral + double.Parse((string)dataGridView1.Rows[i].Cells[entradas].Value);
                    }
                    else if (double.Parse((string)dataGridView1.Rows[i].Cells[entradas].Value) == double.Parse((string)dataGridView1.Rows[i].Cells[entradas + 1].Value))
                    {
                        contadorCorrectas++;

                    }

                }

                contador++;
                if (contador == 99)
                {
                    MessageBox.Show("No tiene solución");
                }
            } while (contador < 100);
            n = 0;
        }

    }
}