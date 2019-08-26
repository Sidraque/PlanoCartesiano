using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaCoordenadasForm {

    public partial class Form1 : Form {

        Ponto pontoA = new Ponto();
        Ponto pontoB = new Ponto();

        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            try {

                if ((textBoxAX.Text == String.Empty) || (textBoxAY.Text == String.Empty) || (textBoxAZ.Text == String.Empty) || (textBoxBX.Text == String.Empty) || (textBoxBY.Text == String.Empty) || (textBoxBZ.Text == String.Empty)) {
                    MessageBox.Show("Preencha todos os campos para calcular.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else {
                    pontoA.CoordX = Convert.ToDouble(textBoxAX.Text);
                    pontoA.CoordY = Convert.ToDouble(textBoxAY.Text);
                    pontoA.CoordZ = Convert.ToDouble(textBoxAZ.Text);
                    pontoB.CoordZ = Convert.ToDouble(textBoxBZ.Text);
                    pontoB.CoordY = Convert.ToDouble(textBoxBY.Text);
                    pontoB.CoordX = Convert.ToDouble(textBoxBX.Text);

                    DadosPonto dados = new DadosPonto();

                    double resultado = dados.Distxyz(pontoA, pontoB);

                    MessageBox.Show("Distância: " + resultado.ToString("f1"), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch(Exception){
                MessageBox.Show("Por favor, preencha todos somente como caracteres númericos!" + " EXEMPLOS DE ENTRADAS VÁLIDAS: 1 | -1 | 1,5");
            }
}
        private void Button2_Click(object sender, EventArgs e) {

            if ((textBoxAX.Text == String.Empty) && (textBoxAY.Text == String.Empty) && (textBoxAZ.Text == String.Empty) && (textBoxBX.Text == String.Empty) && (textBoxBY.Text == String.Empty) && (textBoxBZ.Text == String.Empty)) {
                MessageBox.Show("Os campos já estão vazios!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else {

                textBoxAX.Text = String.Empty;
                textBoxAY.Text = String.Empty;
                textBoxAZ.Text = String.Empty;
                textBoxBX.Text = String.Empty;
                textBoxBY.Text = String.Empty;
                textBoxBZ.Text = String.Empty;
            }
        }

        private void TextBoxAX_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '-') {
                e.Handled = true;
                MessageBox.Show("Caractere não permitido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

