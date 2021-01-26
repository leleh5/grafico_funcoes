using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcoes
{
    public partial class Form1 : Form
    {
        Button[] btn = new Button[6];
        TextBox[] txt_1 = new TextBox[2];
        Label[] lab_1 = new Label[2];
        TextBox[] txt_2 = new TextBox[3];
        Label[] lab_2 = new Label[3];
        TextBox[] txt_3 = new TextBox[1];
        Label[] lab_3 = new Label[3];
        Button[] btn_1 = new Button[1];
        Button[] btn_2 = new Button[1];


        int pag = 0, i = 0;
        public Form1()
        {
            InitializeComponent();
            pag = 1;
            tela_index(pag);

            chart1.SendToBack();

        }

        private void tela_index(int pag)
        {
            i = 0;

            btn_2[0] = new Button();

            btn_2[0].Size = new System.Drawing.Size(75, 25);
            btn_2[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));

            btn_2[0].Click += new System.EventHandler(this.voltar);
            btn_2[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_2[0].UseVisualStyleBackColor = true;
            btn_2[0].Location = new System.Drawing.Point(708, 409);

            this.Controls.Add(btn_2[0]);
            btn_2[0].Text = "Voltar";

            chart1.BackColor = System.Drawing.Color.Transparent;
            chart1.BorderlineColor = System.Drawing.Color.Transparent;

            for (int i4 = 0; i4 <= 5; i4++)
            {
                int x4 = 272;
                int y4 = 20 + (68 * (i4));

                btn[i4] = new Button();

                btn[i4].Size = new System.Drawing.Size(300, 70);
                btn[i4].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));

                btn[i4].Click += new System.EventHandler(this.evento_do_botao_index);
                btn[i4].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn[i4].ForeColor = System.Drawing.Color.White;
                btn[i4].Location = new System.Drawing.Point(x4, y4);

                this.Controls.Add(btn[i4]);

                if (i4 == 5)
                {
                    btn[0].Text = "Equação do 1º grau";
                    btn[1].Text = "Equação do 2º grau";
                    btn[2].Text = "Função Seno do Ângulo, em Graus";
                    btn[3].Text = "Função Cosseno do Ângulo, em Graus";
                    btn[4].Text = "Função Tangente do Ângulo, em Graus";
                    btn[5].Text = "Sair";
                }
            }
        }

        private void evento_do_botao_index(object sender, EventArgs e)
        {

            Button generico_b = (Button)sender;
            switch (generico_b.Text)
            {
                case "Equação do 1º grau":
                    pag = 2;
                    tela_eq1();
                    break;

                case "Equação do 2º grau":
                    pag = 3;
                    tela_eq2();
                    break;

                case "Função Seno do Ângulo, em Graus":
                    pag = 4;
                    tela_sen();
                    break;

                case "Função Cosseno do Ângulo, em Graus":
                    pag = 5;
                    tela_cos();
                    break;

                case "Função Tangente do Ângulo, em Graus":
                    pag = 6;
                    tela_tan();
                    break;

                case "Sair":
                    this.Close();
                    break;

            }
        }


        private void tela_eq1()
        {
             for (int i4 = 0; i4 <= 5; i4++)
             {
                 this.Controls.Remove(btn[i4]);
             }

             for (int i1 = 0; i1 <= 1; i1++)
             {
                int x_t = 67 + (80*i1);
                int y_t = 26;
                int x_l = 28 + (87*i1);
                int y_l = 29;

                txt_1[i1] = new TextBox();

                txt_1[i1].Size = new System.Drawing.Size(42, 26);

                txt_1[i1].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txt_1[i1].ForeColor = System.Drawing.Color.Black;
                txt_1[i1].Location = new System.Drawing.Point(x_t, y_t);

                this.Controls.Add(txt_1[i1]);

                lab_1[i1] = new Label();

                lab_1[i1].Size = new System.Drawing.Size(48, 20);

                lab_1[i1].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lab_1[i1].ForeColor = System.Drawing.Color.Black;
                lab_1[i1].Location = new System.Drawing.Point(x_l, y_l);

                this.Controls.Add(lab_1[i1]);

                if (i1 == 1)
                {
                    lab_1[0].Text = "f(x) = ";
                    lab_1[1].Text = "X + ";

                    btn_1[0] = new Button();

                    btn_1[0].Size = new System.Drawing.Size(41, 34);
                    btn_1[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));

                    btn_1[0].Click += new System.EventHandler(this.eq1);
                    btn_1[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_1[0].UseVisualStyleBackColor = true;
                    btn_1[0].Location = new System.Drawing.Point(207, 22);

                    this.Controls.Add(btn_1[0]);
                    btn_1[0].Text = "ok";
                }
             }

            chart1.BringToFront();
            btn_2[0].BringToFront();
        }

        private void eq1(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();
            funcoes.setTxt_1(txt_1[0].Text);
            funcoes.setTxt_2(txt_1[1].Text);
            FuncoesBLL.validadados2(funcoes);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }

            else
            {
                float y = 0;

                System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series1.Legend = "Legend1";
                series1.Name = "y = +(" + funcoes.getTxt_1() + ") x +(" + funcoes.getTxt_2() + ")";
                this.chart1.Series.Add(series1);

                for (int x = -100; x <= 100; x++)
                {
                        y = float.Parse(funcoes.getTxt_1()) * x + float.Parse(funcoes.getTxt_2());
                        chart1.Series[i].Points.AddXY(x, y);
                }
                
                i = i + 1;

            } 
        }

        private void tela_eq2()
        {
            for (int i4 = 0; i4 <= 5; i4++)
            {
                this.Controls.Remove(btn[i4]);
            }

            for (int i2 = 0; i2 <= 2; i2++)
            {
                int x_t = 72 + (80 * i2);
                int y_t = 26;
                int x_l = 28 + (87 * i2);
                int y_l = 29;

                txt_2[i2] = new TextBox();

                txt_2[i2].Size = new System.Drawing.Size(42, 26);

                txt_2[i2].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txt_2[i2].ForeColor = System.Drawing.Color.Black;
                txt_2[i2].Location = new System.Drawing.Point(x_t, y_t);

                this.Controls.Add(txt_2[i2]);

                lab_2[i2] = new Label();

                lab_2[i2].Size = new System.Drawing.Size(48, 20);

                lab_2[i2].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lab_2[i2].ForeColor = System.Drawing.Color.Black;
                lab_2[i2].Location = new System.Drawing.Point(x_l, y_l);

                this.Controls.Add(lab_2[i2]);

                if (i2 == 2)
                {
                    lab_2[0].Text = "f(x) = ";
                    lab_2[1].Text = "X² + ";
                    lab_2[2].Text = "X + ";

                    btn_1[0] = new Button();

                    btn_1[0].Size = new System.Drawing.Size(41, 34);
                    btn_1[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));

                    btn_1[0].Click += new System.EventHandler(this.eq2);
                    btn_1[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_1[0].UseVisualStyleBackColor = true;
                    btn_1[0].Location = new System.Drawing.Point(287, 22);

                    this.Controls.Add(btn_1[0]);
                    btn_1[0].Text = "ok";
                }
            }

            chart1.BringToFront();
            btn_2[0].BringToFront();
        }

        private void eq2(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();
            funcoes.setTxt_1(txt_2[0].Text);
            funcoes.setTxt_2(txt_2[1].Text);
            funcoes.setTxt_3(txt_2[2].Text);
            FuncoesBLL.validadados3(funcoes);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }

            else
            {
                double y = 0;

                System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series1.Legend = "Legend1";
                series1.Name = "y = +(" + funcoes.getTxt_1() + ") x² +(" + funcoes.getTxt_2() +") x +(" + funcoes.getTxt_3() + ")";
                this.chart1.Series.Add(series1);

                for (int x = -10; x <= 10; x++)
                {
                        y = float.Parse(funcoes.getTxt_1()) * Math.Pow(x, 2) + float.Parse(funcoes.getTxt_2()) * x + float.Parse(funcoes.getTxt_3());
                        chart1.Series[i].Points.AddXY(x, y);
                }

                i = i + 1;
            }
        }

        private void tela_sen()
        {
            for (int i4 = 0; i4 <= 5; i4++)
            {
                this.Controls.Remove(btn[i4]);
            }

            lab_3[0] = new Label();

            lab_3[0].Size = new System.Drawing.Size(48, 20);

            lab_3[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab_3[0].ForeColor = System.Drawing.Color.Black;
            lab_3[0].Location = new System.Drawing.Point(28, 29);

            this.Controls.Add(lab_3[0]);

            txt_3[0] = new TextBox();

            txt_3[0].Size = new System.Drawing.Size(42, 26);

            txt_3[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt_3[0].ForeColor = System.Drawing.Color.Black;
            txt_3[0].Location = new System.Drawing.Point(115, 26);

            this.Controls.Add(txt_3[0]);

            for (int i1 = 1; i1 <= 2; i1++)
            {
                int x_l = 77 + (80 * (i1-1));
                int y_l = 29; 

                lab_3[i1] = new Label();

                lab_3[i1].Size = new System.Drawing.Size(48, 20);

                lab_3[i1].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lab_3[i1].ForeColor = System.Drawing.Color.Black;
                lab_3[i1].Location = new System.Drawing.Point(x_l, y_l);

                this.Controls.Add(lab_3[i1]);

                if (i1 == 2)
                {
                    lab_3[0].Text = "f(x) = ";
                    lab_3[1].Text = "sen(";
                    lab_3[2].Text = ")";

                    btn_1[0] = new Button();

                    btn_1[0].Size = new System.Drawing.Size(41, 34);
                    btn_1[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));

                    btn_1[0].Click += new System.EventHandler(this.sen);
                    btn_1[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_1[0].UseVisualStyleBackColor = true;
                    btn_1[0].Location = new System.Drawing.Point(207, 22);

                    this.Controls.Add(btn_1[0]);
                    btn_1[0].Text = "ok";
                }
            }

            System.Windows.Forms.DataVisualization.Charting.Series series0 = new System.Windows.Forms.DataVisualization.Charting.Series(); 
            
            series0.ChartArea = "ChartArea1";
            series0.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series0.Legend = "Legend1";
            series0.Name = "Série base";
            this.chart1.Series.Add(series0);

            chart1.BringToFront();
            btn_2[0].BringToFront();

            double y;

                for (int x = 0; x <= 360; x++)
                {
                    y = Math.Sin((x * Math.PI / 180));
                    chart1.Series[0].Points.AddXY(x, y);
                }
        }

        private void sen(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();
            funcoes.setTxt_1(txt_3[0].Text);
            FuncoesBLL.validadados(funcoes);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }

            else
            {
                i = i + 1;

                double y1;

                y1 = Math.Round(Math.Sin((float.Parse(txt_3[0].Text) * Math.PI / 180)),4);
                float x1 = float.Parse(txt_3[0].Text);

                System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                series1.Legend = "Legend1";
                series1.Name = "sen(" + x1 + ") = " + y1;
                this.chart1.Series.Add(series1);

                chart1.Series[i].Points.AddXY(x1, y1);
            }
        }

        private void tela_cos()
        {
            for (int i4 = 0; i4 <= 5; i4++)
            {
                this.Controls.Remove(btn[i4]);
            }

            lab_3[0] = new Label();

            lab_3[0].Size = new System.Drawing.Size(48, 20);

            lab_3[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab_3[0].ForeColor = System.Drawing.Color.Black;
            lab_3[0].Location = new System.Drawing.Point(28, 29);

            this.Controls.Add(lab_3[0]);

            txt_3[0] = new TextBox();

            txt_3[0].Size = new System.Drawing.Size(42, 26);

            txt_3[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt_3[0].ForeColor = System.Drawing.Color.Black;
            txt_3[0].Location = new System.Drawing.Point(115, 26);

            this.Controls.Add(txt_3[0]);

            for (int i1 = 1; i1 <= 2; i1++)
            {
                int x_l = 77 + (80 * (i1 - 1));
                int y_l = 29;

                lab_3[i1] = new Label();

                lab_3[i1].Size = new System.Drawing.Size(48, 20);

                lab_3[i1].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lab_3[i1].ForeColor = System.Drawing.Color.Black;
                lab_3[i1].Location = new System.Drawing.Point(x_l, y_l);

                this.Controls.Add(lab_3[i1]);

                if (i1 == 2)
                {
                    lab_3[0].Text = "f(x) = ";
                    lab_3[1].Text = "cos(";
                    lab_3[2].Text = ")";

                    btn_1[0] = new Button();

                    btn_1[0].Size = new System.Drawing.Size(41, 34);
                    btn_1[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));

                    btn_1[0].Click += new System.EventHandler(this.cos);
                    btn_1[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_1[0].UseVisualStyleBackColor = true;
                    btn_1[0].Location = new System.Drawing.Point(207, 22);

                    this.Controls.Add(btn_1[0]);
                    btn_1[0].Text = "ok";
                }
            }

            System.Windows.Forms.DataVisualization.Charting.Series series0 = new System.Windows.Forms.DataVisualization.Charting.Series();
            
            series0.ChartArea = "ChartArea1";
            series0.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series0.Legend = "Legend1";
            series0.Name = "Série base";
            this.chart1.Series.Add(series0);

            chart1.BringToFront();
            btn_2[0].BringToFront();

            double y;

            for (int x = 0; x <= 360; x++)
            {
                y = Math.Cos((x * Math.PI / 180));
                chart1.Series[0].Points.AddXY(x, y);
            }

        }

        private void cos(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();
            funcoes.setTxt_1(txt_3[0].Text);
            FuncoesBLL.validadados(funcoes);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }


            else
            {
                i = i + 1;

                double y1;

                y1 = Math.Round(Math.Cos((float.Parse(txt_3[0].Text) * Math.PI / 180)),4);
                float x1 = float.Parse(txt_3[0].Text);

                System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                series1.Legend = "Legend1";
                series1.Name = "cos(" + x1 + ") = " + y1;
                this.chart1.Series.Add(series1);

                chart1.Series[i].Points.AddXY(x1, y1);
            }
        }

        private void tela_tan()
        {
            for (int i4 = 0; i4 <= 5; i4++)
            {
                this.Controls.Remove(btn[i4]);
            }

            lab_3[0] = new Label();

            lab_3[0].Size = new System.Drawing.Size(48, 20);

            lab_3[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab_3[0].ForeColor = System.Drawing.Color.Black;
            lab_3[0].Location = new System.Drawing.Point(28, 29);

            this.Controls.Add(lab_3[0]);

            txt_3[0] = new TextBox();

            txt_3[0].Size = new System.Drawing.Size(42, 26);

            txt_3[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt_3[0].ForeColor = System.Drawing.Color.Black;
            txt_3[0].Location = new System.Drawing.Point(115, 26);

            this.Controls.Add(txt_3[0]);

            for (int i1 = 1; i1 <= 2; i1++)
            {
                int x_l = 77 + (80 * (i1 - 1));
                int y_l = 29;

                lab_3[i1] = new Label();

                lab_3[i1].Size = new System.Drawing.Size(48, 20);

                lab_3[i1].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lab_3[i1].ForeColor = System.Drawing.Color.Black;
                lab_3[i1].Location = new System.Drawing.Point(x_l, y_l);

                this.Controls.Add(lab_3[i1]);

                if (i1 == 2)
                {
                    lab_3[0].Text = "f(x) = ";
                    lab_3[1].Text = "tan(";
                    lab_3[2].Text = ")";

                    btn_1[0] = new Button();

                    btn_1[0].Size = new System.Drawing.Size(41, 34);
                    btn_1[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));

                    btn_1[0].Click += new System.EventHandler(this.tan);
                    btn_1[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_1[0].UseVisualStyleBackColor = true;
                    btn_1[0].Location = new System.Drawing.Point(207, 22);

                    this.Controls.Add(btn_1[0]);
                    btn_1[0].Text = "ok";
                }
            }

            chart1.BringToFront();
            btn_2[0].BringToFront();
        }

        private void tan(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();
            funcoes.setTxt_1(txt_3[0].Text);
            FuncoesBLL.validadados(funcoes);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }

            else
            {
                double y1;

                y1 = Math.Round(Math.Tan((float.Parse(txt_3[0].Text) * Math.PI / 180)),4);
                float x1 = float.Parse(txt_3[0].Text);
                    
                System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                series1.Legend = "Legend1";
                series1.Name = "tan(" + x1 + ") = " + y1;
                this.chart1.Series.Add(series1);

                chart1.Series[i].Points.AddXY(x1, y1);

                i = i + 1;
            }
        }
        private void voltar(object sender, EventArgs e)
        {
            if (pag == 2)
            {
                for (int i4 = 0; i4 <= 1; i4++)
                {
                    this.Controls.Remove(txt_1[i4]);
                    this.Controls.Remove(lab_1[i4]);
                }
                this.Controls.Remove(btn_1[0]);
                pag = 1;
                tela_index(pag);
                chart1.SendToBack();
                this.chart1.Series.Clear();
            }

            if (pag == 3)
            {
                for (int i4 = 0; i4 <= 2; i4++)
                {
                    this.Controls.Remove(txt_2[i4]);
                    this.Controls.Remove(lab_2[i4]);
                }
                this.Controls.Remove(btn_1[0]);
                pag = 1;
                tela_index(pag);
                chart1.SendToBack();
                this.chart1.Series.Clear();
            }

            if (pag == 4 || pag == 5 || pag == 6)
            {
                for (int i4 = 0; i4 <= 2; i4++)
                {
                    this.Controls.Remove(lab_3[i4]);
                }
                this.Controls.Remove(txt_3[0]);
                this.Controls.Remove(btn_1[0]);
                pag = 1;
                tela_index(pag);
                chart1.SendToBack();
                this.chart1.Series.Clear();
            }
        }

    }
}
