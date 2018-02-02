﻿using System;
using System.Numerics;

namespace SAM.Core.DataProcessing
{
    public static class DIP
    {
        #region Fourier and Hilbert

        public static void FHT(double[] data, FourierTransform.Direction direction)
        {
            int N = data.Length;

            // Forward operation
            if (direction == FourierTransform.Direction.Forward)
            {
                // Copy the input to a complex array which can be processed
                //  in the complex domain by the FFT
                var cdata = new Complex[N];
                for (int i = 0; i < N; i++)
                    cdata[i] = new Complex(data[i], 0.0);

                // Perform FFT
                FFT(cdata, FourierTransform.Direction.Forward);

                //double positive frequencies
                for (int i = 1; i < (N / 2); i++)
                {
                    cdata[i] *= 2.0;
                }

                // zero out negative frequencies
                //  (leaving out the dc component)
                for (int i = (N / 2) + 1; i < N; i++)
                {
                    cdata[i] = Complex.Zero;
                }

                // Reverse the FFT
                FFT(cdata, FourierTransform.Direction.Backward);

                // Convert back to our initial double array
                for (int i = 0; i < N; i++)
                    data[i] = cdata[i].Imaginary;
            }

            else // Backward operation
            {
                // The inverse Hilbert can be calculated by
                //  negating the transform and reapplying the
                //  transformation.
                //
                // H^–1{h(t)} = –H{h(t)}

                FHT(data, FourierTransform.Direction.Forward);

                for (int i = 0; i < data.Length; i++)
                    data[i] = -data[i];
            }
        }

        public static void FHT(Complex[] data, FourierTransform.Direction direction)
        {
            int N = data.Length;

            // Forward operation
            if (direction == FourierTransform.Direction.Forward)
            {
                // Makes a copy of the data so we don't lose the
                //  original information to build our final signal
                var shift = (Complex[])data.Clone();

                // Perform FFT
                FFT(shift, FourierTransform.Direction.Backward);

                //double positive frequencies
                for (int i = 1; i < (N / 2); i++)
                {
                    shift[i] *= 2.0;
                }
                // zero out negative frequencies
                //  (leaving out the dc component)
                for (int i = (N / 2) + 1; i < N; i++)
                {
                    shift[i] = Complex.Zero;
                }

                // Reverse the FFT
                FFT(shift, FourierTransform.Direction.Forward);

                // Put the Hilbert transform in the Imaginary part
                //  of the input signal, creating a Analytic Signal
                for (int i = 0; i < N; i++)
                    data[i] = new Complex(data[i].Real, shift[i].Imaginary);
            }

            else // Backward operation
            {
                // Just discard the imaginary part
                for (int i = 0; i < data.Length; i++)
                    data[i] = new Complex(data[i].Real, 0.0);
            }
        }

        public static double[] FastHT(Complex[] data, FourierTransform.Direction direction, out double peak, out int peakIndex)
        {
            int N = data.Length;
            peak = double.MinValue;
            peakIndex = -1;
            var hbData = new double[data.Length];

            // Forward operation
            if (direction == FourierTransform.Direction.Forward)
            {
                // Makes a copy of the data so we don't lose the
                //  original information to build our final signal
                var shift = (Complex[])data.Clone();

                // Perform FFT
                FFT(shift, FourierTransform.Direction.Backward);

                //double positive frequencies
                for (int i = 1; i < (N / 2); i++)
                {
                    shift[i] *= 2.0;
                }
                // zero out negative frequencies
                //  (leaving out the dc component)
                for (int i = (N / 2) + 1; i < N; i++)
                {
                    shift[i] = Complex.Zero;
                }

                // Reverse the FFT
                FFT(shift, FourierTransform.Direction.Forward);

                // Put the Hilbert transform in the Imaginary part
                // of the input signal, creating a Analytic Signal
                for (int i = 0; i < N; i++)
                {
                    var iVal = new Complex(data[i].Real, shift[i].Imaginary).Magnitude;
                    hbData[i] = iVal;
                    if (iVal > peak)
                    {
                        peak = iVal;
                        peakIndex = i;
                    }
                }
            }

            else // Backward operation
            {
                // Just discard the imaginary part
                for (int i = 0; i < data.Length; i++)
                {
                    var iVal = new Complex(data[i].Real, 0.0).Magnitude;
                    hbData[i] = iVal;
                    if (iVal > peak)
                    {
                        peak = iVal;
                        peakIndex = i;
                    }
                }
            }
            return hbData;
        }

        public static void FFT(Complex[] data, FourierTransform.Direction direction)
        {
            int n = data.Length;

            if (n == 0)
                return;

            if (direction == FourierTransform.Direction.Backward)
            {
                for (int i = 0; i < data.Length; i++)
                    data[i] = new Complex(data[i].Imaginary, data[i].Real);
            }

            if ((n & (n - 1)) == 0)
            {
                // Is power of 2
                TransformRadix2(data);
            }
            else
            {
                // More complicated algorithm for arbitrary sizes
                TransformBluestein(data);
            }

            if (direction == FourierTransform.Direction.Backward)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    double im = data[i].Imaginary;
                    double re = data[i].Real;
                    data[i] = new Complex(im / n, re / n);
                }
            }
        }

        /// <summary>
        ///   1-D Fast Fourier Transform.
        /// </summary>
        /// 
        /// <param name="real">The real part of the complex numbers to transform.</param>
        /// <param name="imag">The imaginary part of the complex numbers to transform.</param>
        /// <param name="direction">The transformation direction.</param>
        /// 
        /// <code source="Unit Tests\Accord.Tests.Math\FourierTransformTest.cs" region="doc_fft" />
        /// 
        public static void FFT(double[] real, double[] imag, FourierTransform.Direction direction)
        {
            if (direction == FourierTransform.Direction.Forward)
            {
                FFT(real, imag);
            }
            else
            {
                FFT(imag, real);
            }

            if (direction == FourierTransform.Direction.Backward)
            {
                for (int i = 0; i < real.Length; i++)
                {
                    real[i] /= real.Length;
                    imag[i] /= real.Length;
                }
            }
        }

        /// <summary>
        ///   2-D Fast Fourier Transform.
        /// </summary>
        /// 
        /// <param name="data">The data to transform.</param>
        /// <param name="direction">The Transformation direction.</param>
        /// 
        /// <code source="Unit Tests\Accord.Tests.Math\FourierTransformTest.cs" region="doc_fft2" />
        /// 
        public static void FFT2(Complex[][] data, FourierTransform.Direction direction)
        {
            int n = data.Length;
            int m = data[0].Length;

            // process rows
            for (int i = 0; i < data.Length; i++)
            {
                // transform it
                FFT(data[i], direction);
            }

            // process columns
            var col = new Complex[n];
            for (int j = 0; j < m; j++)
            {
                // copy column
                for (int i = 0; i < col.Length; i++)
                    col[i] = data[i][j];

                // transform it
                FFT(col, direction);

                // copy back
                for (int i = 0; i < col.Length; i++)
                    data[i][j] = col[i];
            }
        }

        /// <summary>
        ///   Computes the discrete Fourier transform (DFT) of the given complex vector, 
        ///   storing the result back into the vector. The vector can have any length. 
        ///   This is a wrapper function.
        /// </summary>
        /// 
        /// <param name="real">The real.</param>
        /// <param name="imag">The imag.</param>
        /// 
        private static void FFT(double[] real, double[] imag)
        {
            int n = real.Length;

            if (n == 0)
                return;

            if ((n & (n - 1)) == 0)
            {
                // Is power of 2
                TransformRadix2(real, imag);
            }
            else
            {
                // More complicated algorithm for arbitrary sizes
                TransformBluestein(real, imag);
            }
        }

        /// <summary>
        ///   Computes the inverse discrete Fourier transform (IDFT) of the given complex 
        ///   vector, storing the result back into the vector. The vector can have any length.
        ///   This is a wrapper function. This transform does not perform scaling, so the 
        ///   inverse is not a true inverse.
        /// </summary>
        /// 
        private static void IDFT(Complex[] data)
        {
            int n = data.Length;

            if (n == 0)
                return;

            for (int i = 0; i < data.Length; i++)
                data[i] = new Complex(data[i].Imaginary, data[i].Real);

            if ((n & (n - 1)) == 0)
            {
                // Is power of 2
                TransformRadix2(data);
            }
            else
            {
                // More complicated algorithm for arbitrary sizes
                TransformBluestein(data);
            }

            for (int i = 0; i < data.Length; i++)
            {
                double im = data[i].Imaginary;
                double re = data[i].Real;
                data[i] = new Complex(im, re);
            }
        }

        /// <summary>
        ///   Computes the inverse discrete Fourier transform (IDFT) of the given complex 
        ///   vector, storing the result back into the vector. The vector can have any length.
        ///   This is a wrapper function. This transform does not perform scaling, so the 
        ///   inverse is not a true inverse.
        /// </summary>
        /// 
        private static void IDFT(double[] real, double[] imag)
        {
            FFT(imag, real);
        }

        /// <summary>
        ///   Computes the discrete Fourier transform (DFT) of the given complex vector, storing 
        ///   the result back into the vector. The vector's length must be a power of 2. Uses the 
        ///   Cooley-Tukey decimation-in-time radix-2 algorithm.
        /// </summary>
        /// 
        /// <exception cref="System.ArgumentException">Length is not a power of 2.</exception>
        /// 
        private static void TransformRadix2(double[] real, double[] imag)
        {
            int n = real.Length;

            var levels = (int)Math.Floor(Math.Log(n, 2));

            if (1 << levels != n)
                throw new ArgumentException("Length is not a power of 2");

            // TODO: keep those tables in memory
            var cosTable = new double[n / 2];
            var sinTable = new double[n / 2];
            for (int i = 0; i < n / 2; i++)
            {
                cosTable[i] = Math.Cos(2 * Math.PI * i / n);
                sinTable[i] = Math.Sin(2 * Math.PI * i / n);
            }

            // Bit-reversed addressing permutation
            for (int i = 0; i < real.Length; i++)
            {
                int j = unchecked((int)((uint)Reverse(i) >> (32 - levels)));

                if (j > i)
                {
                    var temp = real[i];
                    real[i] = real[j];
                    real[j] = temp;

                    temp = imag[i];
                    imag[i] = imag[j];
                    imag[j] = temp;
                }
            }

            // Cooley-Tukey decimation-in-time radix-2 FFT
            for (int size = 2; size <= n; size *= 2)
            {
                int halfsize = size / 2;
                int tablestep = n / size;

                for (int i = 0; i < n; i += size)
                {
                    for (int j = i, k = 0; j < i + halfsize; j++, k += tablestep)
                    {
                        int h = j + halfsize;
                        double re = real[h];
                        double im = imag[h];

                        double tpre = +re * cosTable[k] + im * sinTable[k];
                        double tpim = -re * sinTable[k] + im * cosTable[k];

                        real[h] = real[j] - tpre;
                        imag[h] = imag[j] - tpim;

                        real[j] += tpre;
                        imag[j] += tpim;
                    }
                }

                // Prevent overflow in 'size *= 2'
                if (size == n)
                    break;
            }
        }

        /// <summary>
        ///   Computes the discrete Fourier transform (DFT) of the given complex vector, storing 
        ///   the result back into the vector. The vector's length must be a power of 2. Uses the 
        ///   Cooley-Tukey decimation-in-time radix-2 algorithm.
        /// </summary>
        /// 
        /// <exception cref="System.ArgumentException">Length is not a power of 2.</exception>
        /// 
        private static void TransformRadix2(Complex[] complex)
        {
            int n = complex.Length;

            var levels = (int)Math.Floor(Math.Log(n, 2));

            if (1 << levels != n)
                throw new ArgumentException("Length is not a power of 2");

            // TODO: keep those tables in memory
            var cosTable = new double[n / 2];
            var sinTable = new double[n / 2];
            for (int i = 0; i < n / 2; i++)
            {
                cosTable[i] = Math.Cos(2 * Math.PI * i / n);
                sinTable[i] = Math.Sin(2 * Math.PI * i / n);
            }

            // Bit-reversed addressing permutation
            for (int i = 0; i < complex.Length; i++)
            {
                var j = unchecked((int)((uint)Reverse(i) >> (32 - levels)));

                if (j > i)
                {
                    var temp = complex[i];
                    complex[i] = complex[j];
                    complex[j] = temp;
                }
            }


            // Cooley-Tukey decimation-in-time radix-2 FFT
            for (int size = 2; size <= n; size *= 2)
            {
                int halfsize = size / 2;
                int tablestep = n / size;

                for (int i = 0; i < n; i += size)
                {
                    for (int j = i, k = 0; j < i + halfsize; j++, k += tablestep)
                    {
                        int h = j + halfsize;
                        double re = complex[h].Real;
                        double im = complex[h].Imaginary;

                        double tpre = +re * cosTable[k] + im * sinTable[k];
                        double tpim = -re * sinTable[k] + im * cosTable[k];

                        double rej = complex[j].Real;
                        double imj = complex[j].Imaginary;

                        complex[h] = new Complex(rej - tpre, imj - tpim);
                        complex[j] = new Complex(rej + tpre, imj + tpim);
                    }
                }

                // Prevent overflow in 'size *= 2'
                if (size == n)
                    break;
            }
        }

        /// <summary>
        ///   Computes the discrete Fourier transform (DFT) of the given complex vector, storing 
        ///   the result back into the vector. The vector can have any length. This requires the 
        ///   convolution function, which in turn requires the radix-2 FFT function. Uses 
        ///   Bluestein's chirp z-transform algorithm.
        /// </summary>
        /// 
        private static void TransformBluestein(double[] real, double[] imag)
        {
            int n = real.Length;
            int m = HighestOneBit(n * 2 + 1) << 1;

            // Trignometric tables
            var cosTable = new double[n];
            var sinTable = new double[n];
            for (int i = 0; i < cosTable.Length; i++)
            {
                var j = (int)((long)i * i % (n * 2));  // This is more accurate than j = i * i
                cosTable[i] = Math.Cos(Math.PI * j / n);
                sinTable[i] = Math.Sin(Math.PI * j / n);
            }

            // Temporary vectors and preprocessing
            var areal = new double[m];
            var aimag = new double[m];
            for (int i = 0; i < real.Length; i++)
            {
                areal[i] = +real[i] * cosTable[i] + imag[i] * sinTable[i];
                aimag[i] = -real[i] * sinTable[i] + imag[i] * cosTable[i];
            }

            var breal = new double[m];
            var bimag = new double[m];
            breal[0] = cosTable[0];
            bimag[0] = sinTable[0];

            for (int i = 1; i < cosTable.Length; i++)
            {
                breal[i] = breal[m - i] = cosTable[i];
                bimag[i] = bimag[m - i] = sinTable[i];
            }

            // Convolution
            var creal = new double[m];
            var cimag = new double[m];
            Convolve(areal, aimag, breal, bimag, creal, cimag);

            // Postprocessing
            for (int i = 0; i < n; i++)
            {
                real[i] = +creal[i] * cosTable[i] + cimag[i] * sinTable[i];
                imag[i] = -creal[i] * sinTable[i] + cimag[i] * cosTable[i];
            }
        }

        private static void TransformBluestein(Complex[] data)
        {
            int n = data.Length;
            int m = HighestOneBit(n * 2 + 1) << 1;

            // Trignometric tables
            var cosTable = new double[n];
            var sinTable = new double[n];
            for (int i = 0; i < cosTable.Length; i++)
            {
                var j = (int)((long)i * i % (n * 2));  // This is more accurate than j = i * i
                cosTable[i] = Math.Cos(Math.PI * j / n);
                sinTable[i] = Math.Sin(Math.PI * j / n);
            }

            // Temporary vectors and preprocessing
            var areal = new double[m];
            var aimag = new double[m];

            for (int i = 0; i < data.Length; i++)
            {
                double re = data[i].Real;
                double im = data[i].Imaginary;

                areal[i] = +re * cosTable[i] + im * sinTable[i];
                aimag[i] = -re * sinTable[i] + im * cosTable[i];
            }

            var breal = new double[m];
            var bimag = new double[m];
            breal[0] = cosTable[0];
            bimag[0] = sinTable[0];

            for (int i = 1; i < cosTable.Length; i++)
            {
                breal[i] = breal[m - i] = cosTable[i];
                bimag[i] = bimag[m - i] = sinTable[i];
            }

            // Convolution
            var creal = new double[m];
            var cimag = new double[m];
            Convolve(areal, aimag, breal, bimag, creal, cimag);

            // Postprocessing
            for (int i = 0; i < data.Length; i++)
            {
                double re = +creal[i] * cosTable[i] + cimag[i] * sinTable[i];
                double im = -creal[i] * sinTable[i] + cimag[i] * cosTable[i];
                data[i] = new Complex(re, im);
            }
        }

        /// <summary>
        ///   Computes the circular convolution of the given real 
        ///   vectors. All vectors must have the same length.
        /// </summary>
        /// 
        public static void Convolve(double[] x, double[] y, double[] result)
        {
            int n = x.Length;
            Convolve(x, new double[n], y, new double[n], result, new double[n]);
        }

        /// <summary>
        ///   Computes the circular convolution of the given complex 
        ///   vectors. All vectors must have the same length.
        /// </summary>
        /// 
        public static void Convolve(Complex[] x, Complex[] y, Complex[] result)
        {
            FFT(x, FourierTransform.Direction.Forward);
            FFT(y, FourierTransform.Direction.Forward);

            for (int i = 0; i < x.Length; i++)
            {
                double xreal = x[i].Real;
                double ximag = x[i].Imaginary;
                double yreal = y[i].Real;
                double yimag = y[i].Imaginary;

                double re = xreal * yreal - ximag * yimag;
                double im = ximag * yreal + xreal * yimag;

                x[i] = new Complex(re, im);
            }

            IDFT(x);

            // Scaling (because this FFT implementation omits it)
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] / x.Length;
            }
        }

        /// <summary>
        ///   Computes the circular convolution of the given complex 
        ///   vectors. All vectors must have the same length.
        /// </summary>
        /// 
        public static void Convolve(double[] xreal, double[] ximag, double[] yreal, double[] yimag, double[] outreal, double[] outimag)
        {
            int n = xreal.Length;

            FFT(xreal, ximag);
            FFT(yreal, yimag);

            for (int i = 0; i < xreal.Length; i++)
            {
                var temp = xreal[i] * yreal[i] - ximag[i] * yimag[i];
                ximag[i] = ximag[i] * yreal[i] + xreal[i] * yimag[i];
                xreal[i] = temp;
            }

            IDFT(xreal, ximag);

            // Scaling (because this FFT implementation omits it)
            for (int i = 0; i < n; i++)
            {
                outreal[i] = xreal[i] / n;
                outimag[i] = ximag[i] / n;
            }
        }

        private static int HighestOneBit(int i)
        {
            i |= (i >> 1);
            i |= (i >> 2);
            i |= (i >> 4);
            i |= (i >> 8);
            i |= (i >> 16);
            return i - (int)((uint)i >> 1);
        }

        private static int Reverse(int i)
        {
            i = (i & 0x55555555) << 1 | (int)((uint)i >> 1) & 0x55555555;
            i = (i & 0x33333333) << 2 | (int)((uint)i >> 2) & 0x33333333;
            i = (i & 0x0f0f0f0f) << 4 | (int)((uint)i >> 4) & 0x0f0f0f0f;
            i = (i << 24) | ((i & 0xff00) << 8) |
                ((int)((uint)i >> 8) & 0xff00) | (int)((uint)i >> 24);
            return i;
        }

        #endregion

    }
}