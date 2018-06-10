using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using ZedGraph;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Complex Function_Y(Complex x)
        {
            return Complex.Sin(5 * x) + Complex.Cos(x);
        }

        private Complex Function_Z(Complex x)
        {
            return Complex.Cos(3*x);
        }


        private void DrawValues(Complex[] funcValues, ZedGraphControl zedGraphControl, string title, Color color)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl.GraphPane;

            pane.XAxis.Title.Text = "N, номер отсчёта";
            pane.YAxis.Title.Text = "Значение функции";
            pane.Title.Text = title;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();

            // Заполняем список точек
            for (int i = 0; i < funcValues.Length;  i++)
            {
                // добавим в список точку
                list.Add(i, funcValues[i].Real);
            }

            LineItem myCurve = pane.AddCurve("", list, color, SymbolType.None);

            zedGraphControl.AxisChange();

            // Обновляем график
            zedGraphControl.Invalidate();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox_N.Text);
            double log = Math.Log(N, 2);
            if (log - Math.Truncate(log) != 0)
            {
                MessageBox.Show("N должно быть степенью двойки!");
                return;
            }

            double period = 2 * Math.PI;

            // График y
            Complex[] valuesVector_y = Fourier.GetFunctionValuesVector(Function_Y, period, N);
            DrawValues(valuesVector_y, y_graph, "y = sin(5x) + cos(x)", Color.Blue);

            // График z
            Complex[] valuesVector_z = Fourier.GetFunctionValuesVector(Function_Z, period, N);
            DrawValues(valuesVector_z, z_graph, "z = cos(3x)", Color.Brown);

            // График свёртки y и z
            Complex[] values = Fourier.Convolution(valuesVector_y, valuesVector_z);
            DrawValues(values, convolution_graph, "Свёртка y и z", Color.Green);

            // График свёртки y и z через БПФ
            values = Fourier.ConvolutionFFT(valuesVector_y, valuesVector_z);
            DrawValues(values, convolutionFFT_graph, "Свёртка y и z через БПФ", Color.Green);

            // График корреляции y и z
            values = Fourier.Correlation(valuesVector_y, valuesVector_z);
            DrawValues(values, correlation_graph, "Корреляция y и z", Color.Red);

            // График корреляции y и z через БПФ
            values = Fourier.CorrelationFFT(valuesVector_y, valuesVector_z);
            DrawValues(values, correlationFFT_graph, "Корреляция y и z через БПФ", Color.Red);
        }
    }
}
