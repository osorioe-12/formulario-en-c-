namespace formulariooo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string telefono = textBox3.Text;
            string estatura = textBox4.Text;
            string edad = textBox5.Text;
            string genero = "";
            if (radioButton1.Checked)
            {
                genero = "hombre";
            }
            else if (radioButton2.Checked)
            {
                genero = "mujer";

            }
            string datos = $"nombre:{nombre}\r\napellido: {apellido}\r\ntelefono:{telefono}kg\r\nestatura:{estatura}cm\r\nedad:{edad}años\r\ngenero:{genero}";
            string RutaArchivo = "C:/Users/efrai/Documentos.txt";
            bool archivoExiste = File.Exists(RutaArchivo);
            Console.WriteLine(archivoExiste);
            if (archivoExiste == false)
            {
                File.WriteAllText(RutaArchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(RutaArchivo, true))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }

            }
            MessageBox.Show(" Datos guardados con exito: \n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}