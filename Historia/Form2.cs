using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Historia
{
    public partial class historia : Form
    {
        Narrador cuento = new Narrador();
        int buttonClicks = 0;
        bool alterna = false;

        public historia()
        {
            InitializeComponent();
            lblTexto.Text = cuento.contar(0);
            btnA.Text = cuento.opcion(0, 'A');
            btnB.Text = cuento.opcion(0, 'B');
            btnC.Text = cuento.opcion(0, 'C');
            btnD.Text = cuento.opcion(0, 'D');
        }

        private void btnSalirHistoria_Click(object sender, EventArgs e)
        {
            menu principal = new menu();
            principal.Show();
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            buttonClicks++;

            switch (buttonClicks)
            {
                case 1:
                    lblTexto.Text = cuento.contar(1);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 2:
                    lblTexto.Text = cuento.contar(5);
                    btnA.Text = cuento.opcion(5, 'A');
                    btnB.Text = cuento.opcion(5, 'B');
                    btnC.Text = cuento.opcion(5, 'C');
                    btnD.Text = cuento.opcion(5, 'D');
                    break;

                case 3:
                    lblTexto.Text = cuento.contar(6);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 4:
                    lblTexto.Text = cuento.contar(8);
                    btnA.Text = cuento.opcion(8, 'A');
                    btnB.Text = cuento.opcion(8, 'B');
                    btnC.Text = cuento.opcion(8, 'C');
                    btnD.Text = cuento.opcion(8, 'D');
                    break;

                case 5:
                    lblTexto.Text = cuento.contar(9);
                    btnA.Text = cuento.opcion(9, 'A');
                    btnB.Text = cuento.opcion(9, 'B');
                    btnC.Text = cuento.opcion(9, 'C');
                    btnD.Text = cuento.opcion(9, 'D');
                    break;

                case 6:
                    lblTexto.Text = cuento.contar(13);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 7:
                    lblTexto.Text = cuento.contar(17);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 8:
                    lblTexto.Text = cuento.contar(18);
                    btnA.Text = cuento.opcion(18, 'A');
                    btnB.Text = cuento.opcion(18, 'B');
                    btnC.Text = cuento.opcion(18, 'C');
                    btnD.Text = cuento.opcion(18, 'D');
                    break;

                case 9:
                    lblTexto.Text = cuento.contar(19);
                    btnA.Text = cuento.opcion(19, 'A');
                    btnB.Text = cuento.opcion(19, 'B');
                    btnC.Text = cuento.opcion(19, 'C');
                    btnD.Text = cuento.opcion(19, 'D');
                    break;

                case 10:
                    lblTexto.Text = cuento.contar(20);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 11:
                    lblTexto.Text = cuento.contar(24);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 12:
                    lblTexto.Text = cuento.contar(25);
                    btnA.Text = cuento.opcion(25, 'A');
                    btnB.Text = cuento.opcion(25, 'B');
                    btnC.Text = cuento.opcion(25, 'C');
                    btnD.Text = cuento.opcion(25, 'D');
                    break;

                case 13:
                    lblTexto.Text = cuento.contar(26);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 14:
                    lblTexto.Text = cuento.contar(30);
                    btnA.Text = cuento.opcion(30, 'A');
                    btnB.Text = cuento.opcion(30, 'B');
                    btnC.Text = cuento.opcion(30, 'C');
                    btnD.Text = cuento.opcion(30, 'D');
                    break;

                case 15:
                    lblTexto.Text = cuento.contar(31);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 16:
                    lblTexto.Text = cuento.contar(32);
                    btnA.Text = cuento.opcion(32, 'A');
                    btnB.Text = cuento.opcion(32, 'B');
                    btnC.Text = cuento.opcion(32, 'C');
                    btnD.Text = cuento.opcion(32, 'D');
                    break;

                case 17:
                    lblTexto.Text = cuento.contar(33);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 18:
                    lblTexto.Text = cuento.contar(37);
                    btnA.Text = cuento.opcion(37, 'A');
                    btnB.Text = cuento.opcion(37, 'B');
                    btnC.Text = cuento.opcion(37, 'C');
                    btnD.Text = cuento.opcion(37, 'D');
                    break;

                case 19:
                    lblTexto.Text = cuento.contar(38);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    cuento.terminarRelacion();
                    buttonClicks = 23;
                    break;

                case 20:
                    lblTexto.Text = cuento.contar(42);
                    btnA.Text = cuento.opcion(42, 'A');
                    btnB.Text = cuento.opcion(42, 'B');
                    btnC.Text = cuento.opcion(42, 'C');
                    btnD.Text = cuento.opcion(42, 'D');
                    break;

                case 21:
                    lblTexto.Text = cuento.contar(43);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 22:
                    lblTexto.Text = cuento.contar(47);
                    btnA.Text = cuento.opcion(47, 'A');
                    btnB.Text = cuento.opcion(47, 'B');
                    btnC.Text = cuento.opcion(47, 'C');
                    btnD.Text = cuento.opcion(47, 'D');
                    break;

                case 23:
                    lblTexto.Text = cuento.contar(48);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 24:
                    Controls.Remove(btnA);
                    Controls.Remove(btnB);
                    Controls.Remove(btnC);
                    Controls.Remove(btnD);
                    switch (cuento.contarFinal())
                    {
                        case 1:
                            lblTexto.Text = cuento.contar(60);
                            break;

                        case 2:
                            lblTexto.Text = cuento.contar(61);
                            break;

                        case 3:
                            lblTexto.Text = cuento.contar(62);
                            break;

                        case 4:
                            lblTexto.Text = cuento.contar(63);
                            break;

                        case 5:
                            lblTexto.Text = cuento.contar(64);
                            break;

                        case 6:
                            lblTexto.Text = cuento.contar(65);
                            break;

                        case 7:
                            lblTexto.Text = cuento.contar(66);
                            break;

                        default:
                            lblTexto.Text = cuento.contar(666);
                            break;
                    }
                    break;

                default:
                    btnA.Text = "¿Khe?";
                    break;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            buttonClicks++;

            switch (buttonClicks)
            {
                case 1:
                    lblTexto.Text = cuento.contar(2);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 2:
                    lblTexto.Text = cuento.contar(5);
                    btnA.Text = cuento.opcion(5, 'A');
                    btnB.Text = cuento.opcion(5, 'B');
                    btnC.Text = cuento.opcion(5, 'C');
                    btnD.Text = cuento.opcion(5, 'D');
                    break;

                case 3:
                    lblTexto.Text = cuento.contar(7);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 4:
                    lblTexto.Text = cuento.contar(8);
                    btnA.Text = cuento.opcion(8, 'A');
                    btnB.Text = cuento.opcion(8, 'B');
                    btnC.Text = cuento.opcion(8, 'C');
                    btnD.Text = cuento.opcion(8, 'D');
                    break;

                case 5:
                    lblTexto.Text = cuento.contar(10);
                    btnA.Text = cuento.opcion(9, 'A');
                    btnB.Text = cuento.opcion(9, 'B');
                    btnC.Text = cuento.opcion(9, 'C');
                    btnD.Text = cuento.opcion(9, 'D');
                    break;

                case 6:
                    lblTexto.Text = cuento.contar(14);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 7:
                    lblTexto.Text = cuento.contar(17);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 8:
                    lblTexto.Text = cuento.contar(18);
                    btnA.Text = cuento.opcion(18, 'A');
                    btnB.Text = cuento.opcion(18, 'B');
                    btnC.Text = cuento.opcion(18, 'C');
                    btnD.Text = cuento.opcion(18, 'D');
                    break;

                case 9:
                    lblTexto.Text = cuento.contar(19);
                    btnA.Text = cuento.opcion(19, 'A');
                    btnB.Text = cuento.opcion(19, 'B');
                    btnC.Text = cuento.opcion(19, 'C');
                    btnD.Text = cuento.opcion(19, 'D');
                    break;

                case 10:
                    lblTexto.Text = cuento.contar(21);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 11:
                    lblTexto.Text = cuento.contar(24);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 12:
                    lblTexto.Text = cuento.contar(25);
                    btnA.Text = cuento.opcion(25, 'A');
                    btnB.Text = cuento.opcion(25, 'B');
                    btnC.Text = cuento.opcion(25, 'C');
                    btnD.Text = cuento.opcion(25, 'D');
                    break;

                case 13:
                    lblTexto.Text = cuento.contar(27);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 14:
                    lblTexto.Text = cuento.contar(30);
                    btnA.Text = cuento.opcion(30, 'A');
                    btnB.Text = cuento.opcion(30, 'B');
                    btnC.Text = cuento.opcion(30, 'C');
                    btnD.Text = cuento.opcion(30, 'D');
                    break;

                case 15:
                    lblTexto.Text = cuento.contar(31);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 16:
                    lblTexto.Text = cuento.contar(32);
                    btnA.Text = cuento.opcion(32, 'A');
                    btnB.Text = cuento.opcion(32, 'B');
                    btnC.Text = cuento.opcion(32, 'C');
                    btnD.Text = cuento.opcion(32, 'D');
                    break;

                case 17:
                    lblTexto.Text = cuento.contar(34);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 18:
                    lblTexto.Text = cuento.contar(37);
                    btnA.Text = cuento.opcion(37, 'A');
                    btnB.Text = cuento.opcion(37, 'B');
                    btnC.Text = cuento.opcion(37, 'C');
                    btnD.Text = cuento.opcion(37, 'D');
                    break;

                case 19:
                    lblTexto.Text = cuento.contar(39);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 20:
                    lblTexto.Text = cuento.contar(42);
                    btnA.Text = cuento.opcion(42, 'A');
                    btnB.Text = cuento.opcion(42, 'B');
                    btnC.Text = cuento.opcion(42, 'C');
                    btnD.Text = cuento.opcion(42, 'D');
                    break;

                case 21:
                    lblTexto.Text = cuento.contar(44);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 22:
                    lblTexto.Text = cuento.contar(47);
                    btnA.Text = cuento.opcion(47, 'A');
                    btnB.Text = cuento.opcion(47, 'B');
                    btnC.Text = cuento.opcion(47, 'C');
                    btnD.Text = cuento.opcion(47, 'D');
                    break;

                case 23:
                    lblTexto.Text = cuento.contar(49);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 24:
                    Controls.Remove(btnA);
                    Controls.Remove(btnB);
                    Controls.Remove(btnC);
                    Controls.Remove(btnD);
                    switch (cuento.contarFinal())
                    {
                        case 1:
                            lblTexto.Text = cuento.contar(60);
                            break;

                        case 2:
                            lblTexto.Text = cuento.contar(61);
                            break;

                        case 3:
                            lblTexto.Text = cuento.contar(62);
                            break;

                        case 4:
                            lblTexto.Text = cuento.contar(63);
                            break;

                        case 5:
                            lblTexto.Text = cuento.contar(64);
                            break;

                        case 6:
                            lblTexto.Text = cuento.contar(65);
                            break;

                        case 7:
                            lblTexto.Text = cuento.contar(66);
                            break;

                        default:
                            lblTexto.Text = cuento.contar(666);
                            break;
                    }
                    break;

                default:
                    btnB.Text = "¿Khe?";
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            buttonClicks++;

            switch (buttonClicks)
            {
                case 1:
                    lblTexto.Text = cuento.contar(3);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 2:
                    lblTexto.Text = cuento.contar(5);
                    btnA.Text = cuento.opcion(5, 'A');
                    btnB.Text = cuento.opcion(5, 'B');
                    btnC.Text = cuento.opcion(5, 'C');
                    btnD.Text = cuento.opcion(5, 'D');
                    break;

                case 3:
                    lblTexto.Text = cuento.contar(7);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 4:
                    lblTexto.Text = cuento.contar(8);
                    btnA.Text = cuento.opcion(8, 'A');
                    btnB.Text = cuento.opcion(8, 'B');
                    btnC.Text = cuento.opcion(8, 'C');
                    btnD.Text = cuento.opcion(8, 'D');
                    break;

                case 5:
                    lblTexto.Text = cuento.contar(10);
                    btnA.Text = cuento.opcion(9, 'A');
                    btnB.Text = cuento.opcion(9, 'B');
                    btnC.Text = cuento.opcion(9, 'C');
                    btnD.Text = cuento.opcion(9, 'D');
                    break;

                case 6:
                    lblTexto.Text = cuento.contar(15);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 7:
                    lblTexto.Text = cuento.contar(17);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 8:
                    lblTexto.Text = cuento.contar(18);
                    btnA.Text = cuento.opcion(18, 'A');
                    btnB.Text = cuento.opcion(18, 'B');
                    btnC.Text = cuento.opcion(18, 'C');
                    btnD.Text = cuento.opcion(18, 'D');
                    break;

                case 9:
                    lblTexto.Text = cuento.contar(19);
                    btnA.Text = cuento.opcion(19, 'A');
                    btnB.Text = cuento.opcion(19, 'B');
                    btnC.Text = cuento.opcion(19, 'C');
                    btnD.Text = cuento.opcion(19, 'D');
                    break;

                case 10:
                    lblTexto.Text = cuento.contar(22);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 11:
                    lblTexto.Text = cuento.contar(24);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 12:
                    lblTexto.Text = cuento.contar(25);
                    btnA.Text = cuento.opcion(25, 'A');
                    btnB.Text = cuento.opcion(25, 'B');
                    btnC.Text = cuento.opcion(25, 'C');
                    btnD.Text = cuento.opcion(25, 'D');
                    break;

                case 13:
                    lblTexto.Text = cuento.contar(28);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 14:
                    lblTexto.Text = cuento.contar(30);
                    btnA.Text = cuento.opcion(30, 'A');
                    btnB.Text = cuento.opcion(30, 'B');
                    btnC.Text = cuento.opcion(30, 'C');
                    btnD.Text = cuento.opcion(30, 'D');
                    break;

                case 15:
                    lblTexto.Text = cuento.contar(31);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 16:
                    lblTexto.Text = cuento.contar(32);
                    btnA.Text = cuento.opcion(32, 'A');
                    btnB.Text = cuento.opcion(32, 'B');
                    btnC.Text = cuento.opcion(32, 'C');
                    btnD.Text = cuento.opcion(32, 'D');
                    break;

                case 17:
                    lblTexto.Text = cuento.contar(35);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 18:
                    lblTexto.Text = cuento.contar(37);
                    btnA.Text = cuento.opcion(37, 'A');
                    btnB.Text = cuento.opcion(37, 'B');
                    btnC.Text = cuento.opcion(37, 'C');
                    btnD.Text = cuento.opcion(37, 'D');
                    break;

                case 19:
                    lblTexto.Text = cuento.contar(40);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 20:
                    lblTexto.Text = cuento.contar(42);
                    btnA.Text = cuento.opcion(42, 'A');
                    btnB.Text = cuento.opcion(42, 'B');
                    btnC.Text = cuento.opcion(42, 'C');
                    btnD.Text = cuento.opcion(42, 'D');
                    break;

                case 21:
                    lblTexto.Text = cuento.contar(45);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 22:
                    lblTexto.Text = cuento.contar(47);
                    btnA.Text = cuento.opcion(47, 'A');
                    btnB.Text = cuento.opcion(47, 'B');
                    btnC.Text = cuento.opcion(47, 'C');
                    btnD.Text = cuento.opcion(47, 'D');
                    break;

                case 23:
                    lblTexto.Text = cuento.contar(50);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 24:
                    Controls.Remove(btnA);
                    Controls.Remove(btnB);
                    Controls.Remove(btnC);
                    Controls.Remove(btnD);
                    switch (cuento.contarFinal())
                    {
                        case 1:
                            lblTexto.Text = cuento.contar(60);
                            break;

                        case 2:
                            lblTexto.Text = cuento.contar(61);
                            break;

                        case 3:
                            lblTexto.Text = cuento.contar(62);
                            break;

                        case 4:
                            lblTexto.Text = cuento.contar(63);
                            break;

                        case 5:
                            lblTexto.Text = cuento.contar(64);
                            break;

                        case 6:
                            lblTexto.Text = cuento.contar(65);
                            break;

                        case 7:
                            lblTexto.Text = cuento.contar(66);
                            break;

                        default:
                            lblTexto.Text = cuento.contar(666);
                            break;
                    }
                    break;

                default:
                    btnC.Text = "¿Khe?";
                    break;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            buttonClicks++;

            switch (buttonClicks)
            {
                case 1:
                    lblTexto.Text = cuento.contar(4);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 2:
                    lblTexto.Text = cuento.contar(5);
                    btnA.Text = cuento.opcion(5, 'A');
                    btnB.Text = cuento.opcion(5, 'B');
                    btnC.Text = cuento.opcion(5, 'C');
                    btnD.Text = cuento.opcion(5, 'D');
                    break;

                case 3:
                    lblTexto.Text = cuento.contar(7);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 4:
                    lblTexto.Text = cuento.contar(8);
                    btnA.Text = cuento.opcion(8, 'A');
                    btnB.Text = cuento.opcion(8, 'B');
                    btnC.Text = cuento.opcion(8, 'C');
                    btnD.Text = cuento.opcion(8, 'D');
                    break;

                case 5:
                    lblTexto.Text = cuento.contar(11);
                    btnA.Text = cuento.opcion(9, 'A');
                    btnB.Text = cuento.opcion(9, 'B');
                    btnC.Text = cuento.opcion(9, 'C');
                    btnD.Text = cuento.opcion(9, 'D');
                    break;

                case 6:
                    lblTexto.Text = cuento.contar(16);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 7:
                    lblTexto.Text = cuento.contar(17);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 8:
                    lblTexto.Text = cuento.contar(18);
                    btnA.Text = cuento.opcion(18, 'A');
                    btnB.Text = cuento.opcion(18, 'B');
                    btnC.Text = cuento.opcion(18, 'C');
                    btnD.Text = cuento.opcion(18, 'D');
                    break;

                case 9:
                    lblTexto.Text = cuento.contar(19);
                    btnA.Text = cuento.opcion(19, 'A');
                    btnB.Text = cuento.opcion(19, 'B');
                    btnC.Text = cuento.opcion(19, 'C');
                    btnD.Text = cuento.opcion(19, 'D');
                    break;

                case 10:
                    lblTexto.Text = cuento.contar(23);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 11:
                    lblTexto.Text = cuento.contar(24);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 12:
                    lblTexto.Text = cuento.contar(25);
                    btnA.Text = cuento.opcion(25, 'A');
                    btnB.Text = cuento.opcion(25, 'B');
                    btnC.Text = cuento.opcion(25, 'C');
                    btnD.Text = cuento.opcion(25, 'D');
                    break;

                case 13:
                    lblTexto.Text = cuento.contar(29);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 14:
                    lblTexto.Text = cuento.contar(30);
                    btnA.Text = cuento.opcion(30, 'A');
                    btnB.Text = cuento.opcion(30, 'B');
                    btnC.Text = cuento.opcion(30, 'C');
                    btnD.Text = cuento.opcion(30, 'D');
                    break;

                case 15:
                    lblTexto.Text = cuento.contar(31);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 16:
                    lblTexto.Text = cuento.contar(32);
                    btnA.Text = cuento.opcion(32, 'A');
                    btnB.Text = cuento.opcion(32, 'B');
                    btnC.Text = cuento.opcion(32, 'C');
                    btnD.Text = cuento.opcion(32, 'D');
                    break;

                case 17:
                    lblTexto.Text = cuento.contar(36);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;

                case 18:
                    lblTexto.Text = cuento.contar(37);
                    btnA.Text = cuento.opcion(37, 'A');
                    btnB.Text = cuento.opcion(37, 'B');
                    btnC.Text = cuento.opcion(37, 'C');
                    btnD.Text = cuento.opcion(37, 'D');
                    break;

                case 19:
                    lblTexto.Text = cuento.contar(41);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    break;
                case 20:
                    lblTexto.Text = cuento.contar(42);
                    btnA.Text = cuento.opcion(42, 'A');
                    btnB.Text = cuento.opcion(42, 'B');
                    btnC.Text = cuento.opcion(42, 'C');
                    btnD.Text = cuento.opcion(42, 'D');
                    break;

                case 21:
                    lblTexto.Text = cuento.contar(46);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    cuento.terminarRelacion();
                    buttonClicks = 23;
                    break;

                case 22:
                    lblTexto.Text = cuento.contar(47);
                    btnA.Text = cuento.opcion(47, 'A');
                    btnB.Text = cuento.opcion(47, 'B');
                    btnC.Text = cuento.opcion(47, 'C');
                    btnD.Text = cuento.opcion(47, 'D');
                    break;

                case 23:
                    lblTexto.Text = cuento.contar(51);
                    btnA.Text = cuento.opcion(1, 'A');
                    btnB.Text = cuento.opcion(1, 'B');
                    btnC.Text = cuento.opcion(1, 'C');
                    btnD.Text = cuento.opcion(1, 'D');
                    cuento.terminarRelacion();
                    break;

                case 24:
                    Controls.Remove(btnA);
                    Controls.Remove(btnB);
                    Controls.Remove(btnC);
                    Controls.Remove(btnD);
                    switch (cuento.contarFinal())
                    {
                        case 1:
                            lblTexto.Text = cuento.contar(60);
                            break;

                        case 2:
                            lblTexto.Text = cuento.contar(61);
                            break;

                        case 3:
                            lblTexto.Text = cuento.contar(62);
                            break;

                        case 4:
                            lblTexto.Text = cuento.contar(63);
                            break;

                        case 5:
                            lblTexto.Text = cuento.contar(64);
                            break;

                        case 6:
                            lblTexto.Text = cuento.contar(65);
                            break;

                        case 7:
                            lblTexto.Text = cuento.contar(66);
                            break;

                        default:
                            lblTexto.Text = cuento.contar(666);
                            break;
                    }
                    break;

                default:
                    btnD.Text = "¿Khe?";
                    break;
            }
        }
    }
}
