using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lab2
{
    public delegate Complex Function(Complex argValue);

    static class Fourier
    {
        static public int count;


        static public Complex[] GetFunctionValuesVector(Function func, double period, int N)
        {
            double interval = period / N;
            Complex[] funcValues = new Complex[N];

            Complex x = 0;
            for (int i = 0; i < N; i++)
            {
                funcValues[i] = func(x);
                x += interval;
            }
            return funcValues;
        }

        // Дискретное преобразование Фурье
        static public Complex[] DiscreteFourierTransform(Complex[] inputValues, int dir)
        {
            count = 0;
            if (dir != 1 && dir != -1) return new Complex[] { 0 };
            int N = inputValues.Length;
            Complex[] outputValues = new Complex[N];
            for (int k = 0; k < N; k++)
            {
                for (int m = 0; m < N; m++)
                {
                    outputValues[k] += (inputValues[m] * Complex.Exp(-dir * 2 * Math.PI * Complex.ImaginaryOne * k * m / N));
                }
                if (dir == 1)
                    outputValues[k] /= N;
            }
            return outputValues;
        }


        // Быстрое преобразование Фурье с прореживанием по времени
        public static Complex[] DecimationInTimeFFT(Complex[] a, int dir)
        {
            if (dir != 1 && dir != -1)
                return new Complex[] { };
            //1.
            int N = a.Length;
            if (N == 1) return a;
            //2.
            Complex[] a1 = new Complex[N / 2 + N % 2]; //Четные
            Complex[] a2 = new Complex[N / 2]; //Нечетные
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0) a1[i / 2] = a[i];
                else a2[i / 2] = a[i];
            }
            //3.
            Complex[] b1 = DecimationInTimeFFT(a1, dir); //четные
            Complex[] b2 = DecimationInTimeFFT(a2, dir); //нечетные
            //4.
            Complex wN = new Complex(Math.Cos(2 * Math.PI / N), dir * Math.Sin(2 * Math.PI / N));
            Complex w = new Complex(1, 0);
            Complex[] y = new Complex[N];

            Complex tmp;
            if(dir == 1)
                for (int j = 0; j < N / 2; j++)
                {
                    tmp = b2[j] * w;
                    y[j] = (b1[j] + tmp) / 2;
                    y[j + N / 2] = (b1[j] - tmp) / 2;
                    w = w * wN;
                }
            else if(dir == -1)
                for (int j = 0; j < N / 2; j++)
                {
                    tmp = b2[j] * w;
                    y[j] = b1[j] + tmp;
                    y[j + N / 2] = b1[j] - tmp;
                    w = w * wN;
                }
            //5.
            return y;
        }

        // Быстрое преобразование Фурье с прореживанием по частоте
        static public Complex[] DecimationInFrequencyFFT(Complex[] inputValues, int dir)
        {
            if (dir != 1 && dir != -1)
                return new Complex[] { };
            Complex[] outputValues = DecimationInFrequencyFFT_bitReversed(inputValues, dir);
            FFTReOrder(outputValues, (ulong)outputValues.Length);
            return outputValues;
        }


        static private Complex[] DecimationInFrequencyFFT_bitReversed(Complex[] a, int dir)
        {
            if (a.Length == 1) return a;
            int N = a.Length;

            Complex wN = Complex.Exp(- dir * 2 * Math.PI * Complex.ImaginaryOne / N);
            Complex w = new Complex(1, 0);
            Complex[] y = new Complex[N];

            Complex[] left = new Complex[N / 2];
            Complex[] right = new Complex[N / 2];

            for (int j = 0; j < N / 2; j++)
            {
                left[j] = a[j] + a[j + N / 2];
                right[j] = (a[j] - a[j + N / 2]) * w;
                w = w * wN;
            }

            Complex[] b_left = DecimationInFrequencyFFT_bitReversed(left, dir);
            Complex[] b_right = DecimationInFrequencyFFT_bitReversed(right, dir);

            if(dir == 1)  // Прямое преобразование
                for (int j = 0; j < N / 2; j++)
                {
                    y[j] = b_left[j] / 2;
                    y[j + N / 2] = b_right[j] / 2;
                }
            else          // Обратное преобразование
                for (int j = 0; j < N / 2; j++)
                {
                    y[j] = b_left[j];
                    y[j + N / 2] = b_right[j];
                }
            return y;
        }

        static private void FFTReOrder(Complex[] Data, ulong Len)
        {
            Complex temp;
            if (Len <= 2) return;
            ulong r = 0;
            for (ulong x = 1; x < Len; x++)
            {
                r = rev_next(r, Len);
                if (r > x)
                {
                    temp = Data[x];
                    Data[x] = Data[r];
                    Data[r] = temp;
                }
            }
        }

        static private ulong rev_next(ulong r, ulong n)
        {
            // преобразовывает r=rev(x-1) в rev(x) 
            do
            {
                n = n >> 1; r = r ^ n;
            } while ((r & n) == 0); 
            return r;
        }


        // Свёртка двух последовательностей
        public static Complex[] Convolution(Complex[] values1, Complex[] values2)
        {
            if (values1.Length != values2.Length)
                return new Complex[] { };

            int N = values1.Length;
            Complex[] result = new Complex[N];

            for (int m = 0; m < N; m++)
            {
                for (int h = 0; h < N; h++)
                {
                    if (m - h >= 0)
                        result[m] += values1[h] * values2[m - h];
                    else
                        result[m] += values1[h] * values2[m - h + N];
                }
                result[m] /= N;
            }
            return result;
        }

        // Корреляция двух последовательностей
        public static Complex[] Correlation(Complex[] values1, Complex[] values2)
        {
            if (values1.Length != values2.Length)
                return new Complex[] { };

            int N = values1.Length;
            Complex[] result = new Complex[N];

            for (int m = 0; m < N; m++)
            {
                for (int h = 0; h < N; h++)
                {
                    if (m + h < N)
                        result[m] += values1[h] * values2[m + h];
                    else
                        result[m] += values1[h] * values2[m + h - N];
                }
                result[m] /= N;
            }
            return result;
        }

        // Свёртка двух последовательностей через БПФ
        public static Complex[] ConvolutionFFT(Complex[] values1, Complex[] values2)
        {
            if (values1.Length != values2.Length)
                return new Complex[] { };

            Complex[] transformedValues1 = DecimationInFrequencyFFT(values1, 1);
            Complex[] transformedValues2 = DecimationInFrequencyFFT(values2, 1);

            transformedValues1 = transformedValues1.Zip(transformedValues2, (x, y) => x * y).ToArray();
            return DecimationInFrequencyFFT(transformedValues1, -1);
        }

        // Корреляция двух последовательностей через БПФ
        public static Complex[] CorrelationFFT(Complex[] values1, Complex[] values2)
        {
            if (values1.Length != values2.Length)
                return new Complex[] { };

            Complex[] transformedValues1 = DecimationInFrequencyFFT(values1, 1);
            Complex[] transformedValues2 = DecimationInFrequencyFFT(values2, 1);

            transformedValues1 = transformedValues1.Zip(transformedValues2, (x, y) => Complex.Conjugate(x) * y).ToArray();
            return DecimationInFrequencyFFT(transformedValues1, -1);
        }

    }
}