﻿using Ann.Misc;
using Ann.Utils;
using Gdo;
using System;
using System.Linq;

namespace Ann.Layers.Convolution
{
    class ConvolutionFullLayer : ConvolutionForwardLayer, IFullLayer, ILearnable
    {
        private readonly double[,,] _cache;
        private readonly double[] _dedb;
        private readonly double[][,,] _dedf;
        private readonly Optimizer[][,,] _weightOptimizers;
        private readonly Optimizer[] _biasOptimizers;

        public ConvolutionFullLayer(
            MessageShape inputMessageShape, 
            int kernelSize,
            int numberOfkernels,
            Optimizer optimizer) 
            : base(inputMessageShape, kernelSize, numberOfkernels)
        {
            _dedb = new double[numberOfkernels];
            _dedf = new double[numberOfkernels][,,];
            _dedf.UpdateForEach<double[,,]>(q => new double[inputMessageShape.Depth, kernelSize, kernelSize]);
            _weightOptimizers = Helper.InitializeKernelOptimizers(
                inputMessageShape.Depth, numberOfkernels, kernelSize, optimizer);
            _biasOptimizers = Helper.InitializeBiasOptimizers(numberOfkernels, optimizer);
        }

        public Array PassBackward(Array error)
        {
            var gradients = error as double[,,];
            ComputeFilterGradients(gradients);
            ComputeBiasGradient(gradients);
            return ComputeInputGradients(gradients);
        }

        public new Array PassForward(Array input)
        {
            _cache.UpdateForEach<double>((q, idx) => (double)input.GetValue(idx));
            return base.PassForward(input);
        }

        public void RandomizeWeights(double stddev)
        {
            throw new NotImplementedException();
        }

        public void UpdateBiases()
        {
            _biasOptimizers.ForEach((q, i) => Biases[i] = q.Update());
        }

        public void UpdateWeights()
        {
            Kernels.ForEach((kernel, kernelIndex) =>
            {
                kernel.UpdateForEach<double>((q, idx) => ((Optimizer)_weightOptimizers[kernelIndex].GetValue(idx)).Update());
            });
        }

        private void ComputeBiasGradient(double[,,] gradients)
        {
            for (int i = 0; i < gradients.GetLength(0); i++)
            {
                _biasOptimizers[i].SetGradient(gradients.GetChannel(i).Cast<double>().Sum());
            }
        }

        private void ComputeFilterGradients(double[,,] gradients)
        {
            for (int i = 0; i < gradients.GetLength(0); i++)
            {
                var dEdO = gradients.GetChannel(i);

                for (int j = 0; j < _cache.GetLength(0); j++)
                {
                    var dedf = MatrixHelper.Convolution(_cache.GetChannel(j), dEdO);
                    _weightOptimizers[i]
                        .GetChannel(j)
                        .ForEach((q, ii, jj) => q.SetGradient(dedf[ii, jj]));
                }
            }
        }

        private double[,,] ComputeInputGradients(double[,,] input)
        {
            var transposed = Kernels
                .Transpose()
                .Select(q => q.Rotate())
                .ToArray();

            var padded = input.Pad(KernelSize - 1);

            return MatrixHelper.Convolution(transposed, padded);
        }
    }
}