using System;
using System.Drawing;
using System.Windows.Forms;

namespace _NET_Senac_Forms_1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formulario());

        }

        public class Formulario : Form
        {
            Label lbNome;
            TextBox tbNome;
            RadioButton rbSexoMasculino;
            RadioButton rbSexoFeminino;
            GroupBox Group;
            CheckBox cbRock;
            CheckBox cbSertanejo;
            CheckBox cbFunk;
            ComboBox estado;

            public Formulario()
            {
                //Propriedades do formulário
                this.Size = new Size(300, 300);
                this.MinimizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Text = "Exercício";

                //Campos
                lbNome = new Label();
                lbNome.Text = "Nome:";
                lbNome.Size = new Size(50,20);
                lbNome.Location = new Point(20,20);

                tbNome = new TextBox();
                tbNome.Size = new Size(250, 100);
                tbNome.Location = new Point(20, 40);


                //Inicio container                
                Group = new GroupBox();
                Group.Text = "Sexo";
                Group.Size = new Size(250,60);
                Group.Location = new Point(20, 70);

                rbSexoMasculino = new RadioButton();
                rbSexoMasculino.Text = "Masculino";
                rbSexoMasculino.Size = new Size(80, 30);
                rbSexoMasculino.Location = new Point(15,15);


                rbSexoFeminino = new RadioButton();
                rbSexoFeminino.Text = "Feminino";
                rbSexoFeminino.Size = new Size(80,30);
                rbSexoFeminino.Location = new Point(120,15);

                Group.Controls.Add(rbSexoMasculino);
                Group.Controls.Add(rbSexoFeminino);

                cbFunk = new CheckBox();
                cbFunk.Text = "Funk";
                cbFunk.Size = new Size(60,20);
                cbFunk.Location = new Point(20, 130);

                cbRock = new CheckBox();
                cbRock.Text = "Rock";
                cbRock.Size = new Size(60,20);
                cbRock.Location = new Point(80, 130);

                cbSertanejo = new CheckBox();
                cbSertanejo.Text = "Sertanejo";
                cbSertanejo.Size = new Size(75,20);
                cbSertanejo.Location = new Point(150, 130);

                string[] estados = {"PR","SC","SP"};
                estado = new ComboBox();  
                estado.Size = new Size(50,15);
                estado.Location = new Point(20, 170);
                estado.AutoCompleteSource = AutoCompleteSource.ListItems;
                estado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                foreach(string est in estados){
                    estado.Items.Add(est);
                }


                //Adiciona elementos ao forms
                this.Controls.Add(estado);
                this.Controls.Add(cbSertanejo);
                this.Controls.Add(cbRock);
                this.Controls.Add(cbFunk);
                this.Controls.Add(lbNome);
                this.Controls.Add(tbNome);
                this.Controls.Add(Group);
            }


        }
    }
}
