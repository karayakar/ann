﻿using Ann.Core.Tests.Utils;
using System.Collections.Generic;

namespace Ann.Core.Tests.MatrixHelper
{
    public static class MatrixHelperTestData
    {
        public static readonly double[][][,,] TransposeInput;
        public static readonly double[][][,,] TransposeOutput;

        public static readonly double[][,,] RotateInput;
        public static readonly double[][,,] RotateOutput;

        public static readonly double[][,,] PadInput;
        public static readonly double[][,,] PadOutput;

        public static readonly double[][,,] MaxPoolEvenInput;
        public static readonly double[][,,] MaxPoolEvenOutput;
        public static readonly byte[][,,] MaxPoolEvenCacheOutput;

        public static readonly double[][,,] MaxPoolOddInput;
        public static readonly double[][,,] MaxPoolOddOutput;
        public static readonly byte[][,,] MaxPoolOddCacheOutput;

        static MatrixHelperTestData()
        {
            TransposeInput = new double[3][][,,]
            {
                ArrayConverter.ConvertToJagged3D(
                    new double[] { -0.1373, -0.6652, -0.3023, 0.8314, -0.522, -0.7727, 0.3415, -0.2609, 0.1327, -0.4703, -0.0114, 0.6249, 0.9343, 0.1582, 0.917, 0.6703, 0.9075, 0.6387, -0.7363, -0.489, 0.4913, 0.054, 0.1426, -0.277, -0.0756, 0.8314, 0.4752, 0.3949, -0.7723, 0.767, 0.6695, -0.1751, 0.0343, -0.7253, 0.5736, -0.0578, -0.4426, -0.1919, 0.6756, 0.8578, 0.0139, -0.5566, -0.5064, 0.2652, 0.4916, 0.1366, 0.542, -0.1373, -0.639, -0.9406, 0.2761, 0.6286, -0.4181, 0.5821, -0.6358, 0.1893, 0.507, -0.1096, -0.519, 0.9411, -0.1629, -0.9503, 0.5175, 0.0283, 0.5582, -0.6672, -0.5613, 0.5167, -0.6943, 0.1718, -0.0591, 0.5904, -0.2378, 0.3119, -0.4655, 0.5526, -0.6986, -0.1458, -0.5741, 0.7244, -0.7515, 0.3658, -0.7677, 0.1873, -0.0783, -0.7959, -0.6267, -0.8305, 0.1768, -0.9438, -0.6817, 0.8343, 0.1781, 0.6528, 0.7406, -0.371, 0.2024, -0.4601, 0.8106, 0.5506, -0.5852, 0.5811, 0.438, 0.419, -0.9318, 0.3794, 0.3052, -0.6674 },
                    4, new int[] { 3, 3, 3 }),
                ArrayConverter.ConvertToJagged3D(
                    new double[] { -0.6358,-0.1667,-0.8008,0.3328,-0.0234,0.7288,-0.1629,0.2376,0.6312,0.0283,-0.5099,-0.8766,-0.5613,0.6568,-0.5844,0.1718,-0.5939,0.1401,-0.2378,0.0095,-0.0072,0.5526,0.6412,-0.7755,-0.5741,0.3328,-0.0234,-0.1037,-0.2738,-0.7286,0.171,-0.6736,0.5328,-0.2268,0.075,0.4408,0.0559,0.3066,0.1771,0.3593,0.5124,0.9448,-0.0078,-0.2333,0.9901,0.6351,0.0435,0.3612,0.8625,-0.4421,-0.2224,0.1301,0.0804,0.0836,-0.2593,0.2924,-0.5891,-0.614,0.1876,0.9768,-0.6614,0.5453,-0.0358,0.5268,0.0596,0.8285,-0.0628,-0.9848,0.8072,-0.3268,-0.5577,-0.911,0.2607,-0.1867,-0.964,-0.9489,-0.2,-0.6443,0.9273,0.2259,0.7499,-0.6972,0.5609,-0.6433,0.5599,0.8384,-0.5178,0.8731,0.5542,0.6124,-0.2134,0.7097,-0.0109,-0.8487,-0.5734,0.0396,0.7009,0.0443,0.858,-0.9508,-0.0866,0.0826,0.9365,0.9175,0.5696,-0.1192,-0.1933,-0.1689 },
                    4, new int[] { 3, 3, 3 }),
                ArrayConverter.ConvertToJagged3D(
                    new double[] { 0.9273,-0.1657,0.3804,0.0836,0.5328,0.5937,0.5804,0.4408,-0.2641,-0.1159,0.1771,0.7666,0.7861,0.9448,0.8946,-0.9267,0.9901,0.7782,-0.9623,0.3612,-0.2099,0.2476,-0.2224,0.421,-0.8467,0.0836,0.7496,-0.2122,0.0868,0.9721,-0.3641,0.6455,-0.8854,0.2629,0.1538,-0.6213,-0.5344,0.5661,0.2731,0.7603,0.0371,-0.0683,0.0512,0.6432,-0.5481,-0.1172,-0.7684,0.6424,-0.6561,0.4326,-0.6854,0.7794,-0.851,0.772,0.7413,0.6297,0.3549,-0.9316,0.1135,0.6741,-0.0988,0.9498,-0.4857,0.283,-0.7954,-0.0751,-0.0552,0.7061,0.4481,-0.7163,-0.8635,-0.4813,-0.6806,-0.8999,0.8937,-0.579,0.2421,0.1235,0.8892,0.6734,0.5297,-0.4615,0.5503,-0.1625,-0.9689,-0.44,-0.8971,0.6106,-0.1007,0.7507,-0.221,-0.6656,0.3158,0.3191,0.472,-0.1381,0.7467,0.5668,-0.3794,0.1413,-0.6775,-0.8014,-0.4374,0.131,-0.3025,0.2371,0.8632,-0.0379 },
                    4, new int[] { 3, 3, 3 })
            };

            TransposeOutput = new double[3][][,,]
            {
                ArrayConverter.ConvertToJagged3D(
                    new double[] { -0.1373,-0.6652,-0.3023,0.8314,-0.522,-0.7727,0.3415,-0.2609,0.1327,0.3949,-0.7723,0.767,0.6695,-0.1751,0.0343,-0.7253,0.5736,-0.0578,-0.6358,0.1893,0.507,-0.1096,-0.519,0.9411,-0.1629,-0.9503,0.5175,0.3658,-0.7677,0.1873,-0.0783,-0.7959,-0.6267,-0.8305,0.1768,-0.9438,-0.4703,-0.0114,0.6249,0.9343,0.1582,0.917,0.6703,0.9075,0.6387,-0.4426,-0.1919,0.6756,0.8578,0.0139,-0.5566,-0.5064,0.2652,0.4916,0.0283,0.5582,-0.6672,-0.5613,0.5167,-0.6943,0.1718,-0.0591,0.5904,-0.6817,0.8343,0.1781,0.6528,0.7406,-0.371,0.2024,-0.4601,0.8106,-0.7363,-0.489,0.4913,0.054,0.1426,-0.277,-0.0756,0.8314,0.4752,0.1366,0.542,-0.1373,-0.639,-0.9406,0.2761,0.6286,-0.4181,0.5821,-0.2378,0.3119,-0.4655,0.5526,-0.6986,-0.1458,-0.5741,0.7244,-0.7515,0.5506,-0.5852,0.5811,0.438,0.419,-0.9318,0.3794,0.3052,-0.6674 },
                    3, new int[] { 4, 3, 3 }),
                ArrayConverter.ConvertToJagged3D(
                    new double[] { -0.6358,-0.1667,-0.8008,0.3328,-0.0234,0.7288,-0.1629,0.2376,0.6312,-0.1037,-0.2738,-0.7286,0.171,-0.6736,0.5328,-0.2268,0.075,0.4408,-0.2593,0.2924,-0.5891,-0.614,0.1876,0.9768,-0.6614,0.5453,-0.0358,-0.6972,0.5609,-0.6433,0.5599,0.8384,-0.5178,0.8731,0.5542,0.6124,0.0283,-0.5099,-0.8766,-0.5613,0.6568,-0.5844,0.1718,-0.5939,0.1401,0.0559,0.3066,0.1771,0.3593,0.5124,0.9448,-0.0078,-0.2333,0.9901,0.5268,0.0596,0.8285,-0.0628,-0.9848,0.8072,-0.3268,-0.5577,-0.911,-0.2134,0.7097,-0.0109,-0.8487,-0.5734,0.0396,0.7009,0.0443,0.858,-0.2378,0.0095,-0.0072,0.5526,0.6412,-0.7755,-0.5741,0.3328,-0.0234,0.6351,0.0435,0.3612,0.8625,-0.4421,-0.2224,0.1301,0.0804,0.0836,0.2607,-0.1867,-0.964,-0.9489,-0.2,-0.6443,0.9273,0.2259,0.7499,-0.9508,-0.0866,0.0826,0.9365,0.9175,0.5696,-0.1192,-0.1933,-0.1689 },
                    3, new int[] { 4, 3, 3 }),
                ArrayConverter.ConvertToJagged3D(
                    new double[] { 0.9273,-0.1657,0.3804,0.0836,0.5328,0.5937,0.5804,0.4408,-0.2641,-0.2122,0.0868,0.9721,-0.3641,0.6455,-0.8854,0.2629,0.1538,-0.6213,0.7413,0.6297,0.3549,-0.9316,0.1135,0.6741,-0.0988,0.9498,-0.4857,-0.4615,0.5503,-0.1625,-0.9689,-0.44,-0.8971,0.6106,-0.1007,0.7507,-0.1159,0.1771,0.7666,0.7861,0.9448,0.8946,-0.9267,0.9901,0.7782,-0.5344,0.5661,0.2731,0.7603,0.0371,-0.0683,0.0512,0.6432,-0.5481,0.283,-0.7954,-0.0751,-0.0552,0.7061,0.4481,-0.7163,-0.8635,-0.4813,-0.221,-0.6656,0.3158,0.3191,0.472,-0.1381,0.7467,0.5668,-0.3794,-0.9623,0.3612,-0.2099,0.2476,-0.2224,0.421,-0.8467,0.0836,0.7496,-0.1172,-0.7684,0.6424,-0.6561,0.4326,-0.6854,0.7794,-0.851,0.772,-0.6806,-0.8999,0.8937,-0.579,0.2421,0.1235,0.8892,0.6734,0.5297,0.1413,-0.6775,-0.8014,-0.4374,0.131,-0.3025,0.2371,0.8632,-0.0379 },
                    3, new int[] { 4, 3, 3 })
            };

            RotateInput = new double[3][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.1373,-0.6652,-0.3023,0.8314,-0.522,-0.7727,0.3415,-0.2609,0.1327,-0.4703,-0.0114,0.6249,0.9343,0.1582,0.917,0.6703,0.9075,0.6387,-0.7363,-0.489,0.4913,0.054,0.1426,-0.277,-0.0756,0.8314,0.4752 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.6358,-0.1667,-0.8008,0.3328,-0.0234,0.7288,-0.1629,0.2376,0.6312,0.0283,-0.5099,-0.8766,-0.5613,0.6568,-0.5844,0.1718,-0.5939,0.1401,-0.2378,0.0095,-0.0072,0.5526,0.6412,-0.7755,-0.5741,0.3328,-0.0234 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.9273,-0.1657,0.3804,0.0836,0.5328,0.5937,0.5804,0.4408,-0.2641,-0.1159,0.1771,0.7666,0.7861,0.9448,0.8946,-0.9267,0.9901,0.7782,-0.9623,0.3612,-0.2099,0.2476,-0.2224,0.421,-0.8467,0.0836,0.7496 },
                    new int[] { 3,3,3 }
                )
            };

            RotateOutput = new double[3][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.1327,-0.2609,0.3415,-0.7727,-0.522,0.8314,-0.3023,-0.6652,-0.1373,0.6387,0.9075,0.6703,0.917,0.1582,0.9343,0.6249,-0.0114,-0.4703,0.4752,0.8314,-0.0756,-0.277,0.1426,0.054,0.4913,-0.489,-0.7363 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.6312,0.2376,-0.1629,0.7288,-0.0234,0.3328,-0.8008,-0.1667,-0.6358,0.1401,-0.5939,0.1718,-0.5844,0.6568,-0.5613,-0.8766,-0.5099,0.0283,-0.0234,0.3328,-0.5741,-0.7755,0.6412,0.5526,-0.0072,0.0095,-0.2378 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.2641,0.4408,0.5804,0.5937,0.5328,0.0836,0.3804,-0.1657,0.9273,0.7782,0.9901,-0.9267,0.8946,0.9448,0.7861,0.7666,0.1771,-0.1159,0.7496,0.0836,-0.8467,0.421,-0.2224,0.2476,-0.2099,0.3612,-0.9623 },
                    new int[] { 3,3,3 }
                )
            };

            PadInput = new double[3][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.1373,-0.6652,-0.3023,0.3949,-0.7723,0.8314,-0.522,-0.7727,0.6695,-0.1751,0.3415,-0.2609,0.1327,-0.7253,0.5736,-0.4703,-0.0114,0.6249,-0.4426,-0.1919,0.9343,0.1582,0.917,0.8578,0.0139,0.6703,0.9075,0.6387,-0.5064,0.2652,-0.7363,-0.489,0.4913,0.1366,0.542,0.054,0.1426,-0.277,-0.639,-0.9406,-0.0756,0.8314,0.4752,0.6286,-0.4181,-0.0374,0.6331,-0.6089,-0.9931,-0.3484,-0.4937,-0.9013,-0.2657,-0.3771,-0.8656,0.65,-0.4255,0.2283,-0.1915,-0.6498,0.2652,-0.3673,0.9351,0.7472,-0.0991,0.708,-0.0508,-0.6944,0.1182,-0.6649,0.9512,0.3307,-0.263,0.3841,0.8366 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.6358,-0.1667,-0.8008,-0.1037,-0.2738,0.3328,-0.0234,0.7288,0.171,-0.6736,-0.1629,0.2376,0.6312,-0.2268,0.075,0.0283,-0.5099,-0.8766,0.0559,0.3066,-0.5613,0.6568,-0.5844,0.3593,0.5124,0.1718,-0.5939,0.1401,-0.0078,-0.2333,-0.2378,0.0095,-0.0072,0.6351,0.0435,0.5526,0.6412,-0.7755,0.8625,-0.4421,-0.5741,0.3328,-0.0234,0.1301,0.0804,0.467,-0.8684,0.8925,-0.4946,-0.8469,0.0048,0.5943,-0.7643,-0.8756,0.6359,-0.8456,-0.9299,-0.2702,-0.69,0.8517,-0.2392,-0.8659,-0.5663,0.2486,0.3994,0.2036,-0.5494,-0.1959,-0.3804,0.8366,0.4468,-0.1678,-0.7615,0.8826,0.3381 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.9273,-0.1657,0.3804,-0.2122,0.0868,0.0836,0.5328,0.5937,-0.3641,0.6455,0.5804,0.4408,-0.2641,0.2629,0.1538,-0.1159,0.1771,0.7666,-0.5344,0.5661,0.7861,0.9448,0.8946,0.7603,0.0371,-0.9267,0.9901,0.7782,0.0512,0.6432,-0.9623,0.3612,-0.2099,-0.1172,-0.7684,0.2476,-0.2224,0.421,-0.6561,0.4326,-0.8467,0.0836,0.7496,0.7794,-0.851,-0.4359,0.4475,0.7956,-0.1442,-0.3573,0.7107,0.0141,-0.5635,-0.8552,-0.2194,-0.2795,0.3019,-0.9931,0.4232,-0.6856,0.1538,-0.4075,-0.3601,-0.295,0.1983,-0.9956,-0.6783,-0.0062,0.2155,0.3526,0.4413,0.6376,-0.0891,0.61,-0.9085 },
                    new int[] { 3,5,5 }
                ),
            };

            PadOutput = new double[3][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-0.1373,-0.6652,-0.3023,0.3949,-0.7723,0,0,0,0,0.8314,-0.522,-0.7727,0.6695,-0.1751,0,0,0,0,0.3415,-0.2609,0.1327,-0.7253,0.5736,0,0,0,0,-0.4703,-0.0114,0.6249,-0.4426,-0.1919,0,0,0,0,0.9343,0.1582,0.917,0.8578,0.0139,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.6703,0.9075,0.6387,-0.5064,0.2652,0,0,0,0,-0.7363,-0.489,0.4913,0.1366,0.542,0,0,0,0,0.054,0.1426,-0.277,-0.639,-0.9406,0,0,0,0,-0.0756,0.8314,0.4752,0.6286,-0.4181,0,0,0,0,-0.0374,0.6331,-0.6089,-0.9931,-0.3484,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-0.4937,-0.9013,-0.2657,-0.3771,-0.8656,0,0,0,0,0.65,-0.4255,0.2283,-0.1915,-0.6498,0,0,0,0,0.2652,-0.3673,0.9351,0.7472,-0.0991,0,0,0,0,0.708,-0.0508,-0.6944,0.1182,-0.6649,0,0,0,0,0.9512,0.3307,-0.263,0.3841,0.8366,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                    new int[] { 3,9,9 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-0.6358,-0.1667,-0.8008,-0.1037,-0.2738,0,0,0,0,0.3328,-0.0234,0.7288,0.171,-0.6736,0,0,0,0,-0.1629,0.2376,0.6312,-0.2268,0.075,0,0,0,0,0.0283,-0.5099,-0.8766,0.0559,0.3066,0,0,0,0,-0.5613,0.6568,-0.5844,0.3593,0.5124,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.1718,-0.5939,0.1401,-0.0078,-0.2333,0,0,0,0,-0.2378,0.0095,-0.0072,0.6351,0.0435,0,0,0,0,0.5526,0.6412,-0.7755,0.8625,-0.4421,0,0,0,0,-0.5741,0.3328,-0.0234,0.1301,0.0804,0,0,0,0,0.467,-0.8684,0.8925,-0.4946,-0.8469,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.0048,0.5943,-0.7643,-0.8756,0.6359,0,0,0,0,-0.8456,-0.9299,-0.2702,-0.69,0.8517,0,0,0,0,-0.2392,-0.8659,-0.5663,0.2486,0.3994,0,0,0,0,0.2036,-0.5494,-0.1959,-0.3804,0.8366,0,0,0,0,0.4468,-0.1678,-0.7615,0.8826,0.3381,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                    new int[] { 3,9,9 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.9273,-0.1657,0.3804,-0.2122,0.0868,0,0,0,0,0.0836,0.5328,0.5937,-0.3641,0.6455,0,0,0,0,0.5804,0.4408,-0.2641,0.2629,0.1538,0,0,0,0,-0.1159,0.1771,0.7666,-0.5344,0.5661,0,0,0,0,0.7861,0.9448,0.8946,0.7603,0.0371,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-0.9267,0.9901,0.7782,0.0512,0.6432,0,0,0,0,-0.9623,0.3612,-0.2099,-0.1172,-0.7684,0,0,0,0,0.2476,-0.2224,0.421,-0.6561,0.4326,0,0,0,0,-0.8467,0.0836,0.7496,0.7794,-0.851,0,0,0,0,-0.4359,0.4475,0.7956,-0.1442,-0.3573,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0.7107,0.0141,-0.5635,-0.8552,-0.2194,0,0,0,0,-0.2795,0.3019,-0.9931,0.4232,-0.6856,0,0,0,0,0.1538,-0.4075,-0.3601,-0.295,0.1983,0,0,0,0,-0.9956,-0.6783,-0.0062,0.2155,0.3526,0,0,0,0,0.4413,0.6376,-0.0891,0.61,-0.9085,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                    new int[] { 3,9,9 }
                ),
            };

            MaxPoolEvenInput = new double[6][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.9343,0.1582,0.917,0.8578,0.0139,-0.5566,0.6703,0.9075,0.6387,-0.5064,0.2652,0.4916,-0.7363,-0.489,0.4913,0.1366,0.542,-0.1373,0.054,0.1426,-0.277,-0.639,-0.9406,0.2761,-0.0756,0.8314,0.4752,0.6286,-0.4181,0.5821,-0.0374,0.6331,-0.6089,-0.9931,-0.3484,0.946,-0.4937,-0.9013,-0.2657,-0.3771,-0.8656,0.5126,0.65,-0.4255,0.2283,-0.1915,-0.6498,0.8004,0.2652,-0.3673,0.9351,0.7472,-0.0991,-0.906,0.708,-0.0508,-0.6944,0.1182,-0.6649,0.8232,0.9512,0.3307,-0.263,0.3841,0.8366,-0.8638,0.4427,0.3973,-0.0943,0.3965,0.6751,-0.6886,0.7815,0.9526,0.7285,0.8998,-0.6332,0.5477,-0.6289,-0.511,0.8314,0.9564,0.2022,0.2037,-0.5571,-0.308,-0.2578,-0.1581,0.662,0.6059,0.8304,-0.8366,-0.9919,-0.2656,-0.4944,-0.522,0.2664,0.0191,0.961,-0.7195,-0.8218,0.2355,0.2108,0.4339,-0.2627,-0.395,-0.4333,0.5459 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.5613,0.6568,-0.5844,0.3593,0.5124,0.9448,0.1718,-0.5939,0.1401,-0.0078,-0.2333,0.9901,-0.2378,0.0095,-0.0072,0.6351,0.0435,0.3612,0.5526,0.6412,-0.7755,0.8625,-0.4421,-0.2224,-0.5741,0.3328,-0.0234,0.1301,0.0804,0.0836,0.467,-0.8684,0.8925,-0.4946,-0.8469,0.4475,0.0048,0.5943,-0.7643,-0.8756,0.6359,0.0141,-0.8456,-0.9299,-0.2702,-0.69,0.8517,0.3019,-0.2392,-0.8659,-0.5663,0.2486,0.3994,-0.4075,0.2036,-0.5494,-0.1959,-0.3804,0.8366,-0.6783,0.4468,-0.1678,-0.7615,0.8826,0.3381,0.6376,0.9471,0.9017,-0.5928,-0.1021,0.1766,0.8129,-0.7199,-0.543,-0.773,-0.6017,0.8682,0.0491,0.8668,-0.0125,0.3328,0.4578,0.7007,-0.2948,-0.0527,-0.8066,-0.7622,0.3404,-0.8395,-0.8956,-0.6652,0.659,-0.4934,-0.7642,-0.9929,-0.0234,0.7649,0.5176,0.4566,0.782,0.6796,-0.263,-0.2936,0.9324,-0.7671,-0.8935,-0.9319,0.0474 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.7861,0.9448,0.8946,0.7603,0.0371,-0.0683,-0.9267,0.9901,0.7782,0.0512,0.6432,-0.5481,-0.9623,0.3612,-0.2099,-0.1172,-0.7684,0.6424,0.2476,-0.2224,0.421,-0.6561,0.4326,-0.6854,-0.8467,0.0836,0.7496,0.7794,-0.851,0.772,-0.4359,0.4475,0.7956,-0.1442,-0.3573,0.8047,0.7107,0.0141,-0.5635,-0.8552,-0.2194,0.6832,-0.2795,0.3019,-0.9931,0.4232,-0.6856,-0.9066,0.1538,-0.4075,-0.3601,-0.295,0.1983,0.1959,-0.9956,-0.6783,-0.0062,0.2155,0.3526,0.3441,0.4413,0.6376,-0.0891,0.61,-0.9085,-0.8861,-0.7316,0.8129,0.1922,-0.6162,0.3492,0.9906,-0.1289,0.0491,0.8907,-0.1935,-0.2572,-0.5141,0.6027,-0.2948,0.0836,-0.2289,0.0107,-0.8742,-0.3413,-0.8956,0.631,-0.5801,-0.2061,0.8655,0.3328,-0.0234,0.7288,0.171,-0.6736,0.5328,0.1812,-0.263,0.3262,-0.7768,-0.1307,0.7032,0.6573,0.0474,-0.5381,0.7129,0.7162,-0.861 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.0628,-0.6142,0.627,0.7455,-0.28,-0.2139,-0.3268,-0.5505,0.5908,0.7388,0.5904,0.8031,0.2607,0.2229,-0.3241,-0.1534,0.6875,-0.568,-0.9489,-0.2841,0.9427,0.4323,-0.0139,0.1403,0.9273,-0.1657,0.3804,-0.2122,0.0868,-0.415,0.9656,-0.3698,0.5268,0.8516,0.3909,-0.2151,0.5034,0.0957,0.5575,0.6688,0.6588,-0.2208,-0.3471,0.5715,-0.8742,0.4833,0.1285,0.9928,-0.7377,0.6356,0.2349,-0.58,0.3315,0.6399,-0.2949,0.9521,-0.6993,-0.8887,-0.2303,0.0976,-0.0517,-0.6663,0.6794,-0.027,-0.4202,0.4672,-0.5543,-0.5998,0.0122,0.833,-0.0094,0.9804,-0.2214,-0.0445,0.1923,0.3949,-0.5112,0.8065,0.3682,0.4861,-0.1657,-0.2907,-0.6582,-0.725,0.4459,0.6949,0.7393,0.0167,-0.9933,0.6889,-0.1667,0.1605,0.0052,-0.5049,-0.7747,0.7544,-0.7366,-0.9839,-0.0419,0.762,0.4252,0.8693,-0.7921,-0.5691,0.7344,0.9361,0.4759,0.6836 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.9959,-0.4601,-0.3781,-0.2069,0.6818,0.2523,0.3493,0.0803,-0.9775,-0.4491,-0.1212,-0.7252,0.3063,0.593,-0.7065,-0.6259,-0.3581,0.192,0.1046,-0.8375,-0.3737,-0.2461,0.0708,-0.657,-0.7675,-0.2903,-0.506,-0.3173,-0.474,0.3981,-0.354,0.7041,0.9507,0.1764,-0.3297,0.2637,-0.9859,0.1939,-0.4954,-0.325,0.5371,0.8426,0.8642,-0.6068,0.5184,0.9119,0.2874,-0.6389,0.1186,0.8335,-0.0403,0.8164,-0.0516,0.0839,0.0645,-0.7905,-0.3876,-0.1718,-0.3013,0.3823,0.9212,-0.5913,0.9842,-0.3908,-0.6099,0.322,-0.0981,-0.2423,0.4313,-0.5197,-0.5943,-0.0313,-0.314,-0.1943,0.3753,-0.324,0.2534,0.275,0.2584,-0.3345,-0.2903,0.71,-0.9838,0.1285,0.8562,0.1088,-0.5477,-0.7115,-0.543,-0.1769,-0.6662,0.1268,0.4698,0.4029,-0.9343,-0.7745,0.4864,-0.9125,-0.6533,0.2906,0.6434,0.1993,-0.8018,0.7033,0.0448,0.0082,0.1518,0.887 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.0552,-0.2139,-0.5375,0.2618,0.5357,0.4302,-0.7163,0.8031,-0.2965,-0.4473,0.1447,0.9533,-0.6806,-0.568,0.5669,-0.6157,0.7331,0.1439,-0.579,0.1403,-0.7524,-0.0492,0.9311,-0.1869,0.8892,-0.415,-0.3925,0.5153,-0.3525,0.2735,-0.5839,-0.2151,0.4992,0.6258,0.1412,0.3061,0.1448,-0.2208,-0.3316,-0.2893,-0.7179,-0.8183,-0.8649,0.9928,-0.6498,0.4324,0.4789,0.5949,-0.1113,0.6399,0.5925,-0.2857,-0.1557,-0.3026,-0.6474,0.0976,0.9864,-0.2976,0.0044,-0.1544,0.6635,0.4672,0.3215,-0.0037,0.2033,0.6154,-0.4128,0.9804,-0.6482,0.0356,-0.6806,-0.5089,0.4859,0.8065,0.0895,-0.9509,-0.0741,0.8711,0.692,-0.725,-0.415,-0.1025,0.7202,-0.2702,0.3838,0.6889,0.6637,-0.315,-0.689,-0.01,-0.1657,0.7544,-0.4963,0.8092,0.906,0.4474,0.6798,0.8693,0.0308,0.4454,0.737,-0.3461,0.1588,0.6836,-0.731,0.7065,-0.9229,-0.6574 },
                    new int[] { 3,6,6 }
                ),
            };

            MaxPoolEvenOutput = new double[6][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.9343,0.917,0.4916,0.1426,0.4913,0.542,0.8314,0.6286,0.946,0.65,0.2283,0.8004,0.708,0.9351,0.8232,0.9512,0.3965,0.8366,0.9526,0.9564,0.5477,0.8304,-0.1581,0.662,0.4339,0.961,0.5459 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.6568,0.3593,0.9901,0.6412,0.8625,0.3612,0.467,0.8925,0.4475,0.5943,-0.2702,0.8517,0.2036,0.2486,0.8366,0.9471,0.8826,0.8129,0.8668,0.4578,0.8682,0.659,0.3404,-0.0234,0.9324,0.782,0.6796 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.9901,0.8946,0.6432,0.3612,0.421,0.6424,0.4475,0.7956,0.8047,0.7107,0.4232,0.6832,0.1538,0.2155,0.3526,0.8129,0.61,0.9906,0.6027,0.8907,0.0107,0.3328,0.7288,0.8655,0.6573,0.7129,0.7162 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.0628,0.7455,0.8031,0.2607,0.9427,0.6875,0.9656,0.8516,0.3909,0.5715,0.6688,0.9928,0.9521,0.2349,0.6399,-0.0517,0.833,0.9804,0.4861,0.3949,0.8065,0.6949,0.7393,0.7544,-0.5691,0.9361,0.8693 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.3493,-0.2069,0.6818,0.593,-0.2461,0.192,0.7041,0.9507,0.3981,0.8642,0.9119,0.8426,0.8335,0.8164,0.3823,0.9212,0.9842,0.322,0.2584,0.71,0.275,0.8562,0.4698,-0.1769,0.7033,0.2906,0.887 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.8031,0.2618,0.9533,0.1403,0.5669,0.9311,0.8892,0.6258,0.3061,0.9928,0.4324,0.5949,0.6399,0.9864,0.0044,0.9804,0.3215,0.6154,0.8065,0.0895,0.8711,0.7544,0.8092,0.906,0.8693,0.7065,0.737 },
                    new int[] { 3,3,3 }
                ),
            };

            MaxPoolEvenCacheOutput = new byte[6][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 1,0,1,0,0,0,0,0,0,0,0,1,0,0,1,0,1,0,0,1,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,1,0,0,1,0,0,1,0,0,0,1,0,0,0,0,1,1,0,0,0,1,0,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,0,0,1,1,0,1,0,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,1 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 0,1,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,1,0,1,0,0,0,0,0,0,0,0,1,0,1,0,0,1,0,1,0,0,0,0,0,0,1,0,1,0,0,0,0,1,0,0,1,0,0,0,1,0,0,0,0,1,0,0,1,0,0,0,0,1,0,0,0,0,1,0,1,0,0,1,0,0,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,1,1,0,0,1,0,0,0,0 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 0,0,1,0,0,0,0,1,0,0,1,0,0,1,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,1,1,0,0,1,1,0,0,0,0,1,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,1,0,0,0,1,0,0,1,0,0,0,1,0,0,0,1,0,0,0,0,0,0,1,1,0,1,0,0,0,0,0,0,0,0,0,1,0,0,1,1,0 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 1,0,0,1,0,0,0,0,0,0,0,1,1,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,1,1,0,0,0,0,1,0,0,0,1,0,0,0,1,0,0,1,0,0,1,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,1,0,0,0,1,0,1,0,1,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,1,0,1,0,0 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 0,0,0,1,1,0,1,0,0,0,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,1,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,1,0,0,0,1,0,1,0,0,0,0,0,0,0,1,1,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,1,0,0,1,0,0,0,0,1,0,0,1,0,0,0,0,0,0,1,0,0,0,1,0,0,0,1 },
                    new int[] { 3,6,6 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 0,0,0,1,0,0,0,1,0,0,0,1,0,0,1,0,0,0,0,1,0,0,1,0,1,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,1,0,1,0,1,0,1,0,0,0,0,0,0,1,0,1,0,0,0,1,0,0,1,0,1,0,0,0,0,0,1,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,1,1,0,0,1,0,0,1,0,0,0,0,1,0,0 },
                    new int[] { 3,6,6 }
                ),
            };

            MaxPoolOddInput = new double[6][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.5167,-0.6943,0.6528,0.7406,-0.371,-0.0591,0.5904,0.2024,-0.4601,0.8106,0.3119,-0.4655,0.5506,-0.5852,0.5811,-0.6986,-0.1458,0.438,0.419,-0.9318,0.7244,-0.7515,0.3794,0.3052,-0.6674,0.7636,-0.0079,0.1243,0.2029,0.493,0.537,0.6125,-0.5743,0.4495,0.7176,0.5335,0.4087,0.1137,-0.5462,-0.8135,-0.8675,0.4307,0.9504,-0.1795,-0.6198,0.2475,-0.8859,-0.9667,0.5166,0.559,-0.7242,0.2035,-0.546,0.0135,-0.405,-0.8215,0.5622,-0.8886,0.7411,-0.8593,0.5696,-0.2851,-0.8851,0.2512,-0.3856,0.6449,0.9939,-0.5743,-0.4743,0.7961,-0.9847,-0.0074,-0.259,-0.5069,-0.5932 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.9848,0.8072,-0.8487,-0.5734,0.0396,-0.5577,-0.911,0.7009,0.0443,0.858,-0.1867,-0.964,-0.9508,-0.0866,0.0826,-0.2,-0.6443,0.9365,0.9175,0.5696,0.2259,0.7499,-0.1192,-0.1933,-0.1689,-0.7379,0.4906,-0.3742,0.7014,0.9915,-0.9645,-0.889,-0.0758,-0.049,-0.7839,-0.968,-0.0898,0.6122,0.9553,-0.3149,0.634,-0.0679,-0.5511,0.3191,0.8816,-0.251,-0.3874,-0.4681,-0.9848,0.0604,0.7773,0.7021,-0.0474,0.512,-0.9035,0.68,0.0636,-0.3901,-0.7603,-0.3607,-0.9318,-0.7836,0.6163,0.7497,-0.8841,0.1464,-0.5075,0.9271,-0.9729,-0.7054,0.5168,-0.5059,-0.7575,0.9945,0.9083 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.7061,0.4481,0.3191,0.472,-0.1381,-0.8635,-0.4813,0.7467,0.5668,-0.3794,-0.8999,0.8937,0.1413,-0.6775,-0.8014,0.2421,0.1235,-0.4374,0.131,-0.3025,0.6734,0.5297,0.2371,0.8632,-0.0379,0.8962,0.9586,0.3498,-0.4562,-0.1278,-0.3559,-0.8265,0.8834,0.4968,-0.0611,0.4753,0.1988,0.5476,-0.4434,-0.6947,0.6722,-0.4341,-0.8767,-0.2169,0.9391,0.4606,-0.2502,-0.4158,0.4643,-0.4681,-0.8032,-0.3321,0.5654,0.0753,0.3721,0.7386,0.5221,0.9871,-0.0869,-0.4334,-0.3025,-0.5776,-0.7292,0.3666,0.1305,0.5929,0.4817,0.218,-0.4512,-0.7609,-0.9283,0.9404,-0.839,0.6674,0.474 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.6581,0.8614,-0.3501,-0.0749,0.5382,-0.3375,0.5797,-0.783,0.5429,-0.6435,0.3538,-0.5543,-0.882,-0.3694,-0.416,0.8063,0.8767,-0.2056,-0.875,0.2859,0.6297,0.3549,-0.4615,0.5503,-0.1625,-0.1573,-0.0089,-0.0818,0.8426,-0.8244,-0.5538,0.1837,0.5575,0.2162,0.3279,-0.1765,0.1323,-0.8189,0.9626,0.3574,-0.7161,0.7988,0.469,-0.4012,0.6624,-0.3296,0.5545,-0.5516,-0.9726,0.4213,0.3276,-0.9088,-0.8477,-0.3449,0.4475,0.1756,-0.7689,0.4326,-0.1348,-0.6591,-0.2126,0.4522,0.3639,-0.8318,-0.5096,0.3353,0.0515,0.8661,0.5169,0.6233,-0.5989,-0.3892,-0.3869,0.7987,-0.5512 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.903,-0.4944,0.1052,-0.0492,-0.567,-0.72,-0.3234,0.7757,0.7433,0.49,0.8144,-0.0395,-0.58,-0.8493,-0.5149,-0.8189,0.2455,-0.4925,-0.1019,0.3721,0.9594,-0.9779,-0.6466,-0.2163,-0.2249,-0.298,-0.6675,0.5492,-0.2481,0.1121,-0.7221,-0.1105,0.9083,0.919,0.3988,0.9225,0.5302,-0.8299,0.9917,0.0745,0.7709,0.5102,-0.6919,0.1393,-0.7327,0.346,0.3592,-0.3153,0.9617,0.8232,-0.9482,-0.0167,-0.6672,-0.7161,0.1609,-0.607,0.9401,-0.6203,0.216,-0.5415,-0.1227,-0.5179,0.3946,-0.8769,0.7963,0.6416,0.841,-0.7647,0.7342,0.3734,0.0124,-0.9355,0.1602,-0.3815,0.9702 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { -0.7954,0.9466,0.8294,-0.0265,-0.6367,0.6379,0.0172,0.2482,0.0741,-0.878,0.6015,0.3952,0.6398,-0.179,-0.3088,0.7407,0.6221,0.0611,0.6295,0.196,-0.828,0.0311,-0.2614,0.3646,0.4606,0.3977,-0.5429,-0.1487,-0.9548,0.3707,-0.8544,0.675,-0.6181,-0.0017,-0.5596,-0.0232,-0.2997,-0.9538,-0.9419,0.8068,0.1737,-0.9327,-0.3781,0.2816,-0.5624,0.9592,0.2484,-0.9144,0.9628,-0.9666,0.6983,0.1665,-0.9361,-0.4233,0.8707,0.2401,0.0236,0.4885,-0.5855,0.0652,0.196,0.9239,-0.2307,0.8651,0.6291,0.0943,0.9802,-0.2806,0.0473,0.7405,0.5732,-0.5611,-0.3405,0.1689,-0.0246 },
                    new int[] { 3,5,5 }
                ),
            };

            MaxPoolOddOutput = new double[6][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.5904,0.7406,0.8106,0.3119,0.5506,0.5811,0.7244,0.3794,-0.6674,0.7636,0.4495,0.7176,0.5335,0.9504,-0.6198,0.2475,0.5166,0.559,0.5622,0.7411,-0.405,0.9939,0.2512,0.7961,-0.0074,-0.259,-0.5932 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.8072,0.7009,0.858,-0.1867,0.9365,0.5696,0.7499,-0.1192,-0.1689,0.4906,0.7014,0.9915,0.634,0.9553,0.8816,-0.251,-0.4681,0.0604,0.7773,0.512,-0.3607,0.1464,0.9271,-0.7054,0.5168,0.9945,0.9083 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.7061,0.7467,-0.1381,0.8937,0.1413,-0.3025,0.6734,0.8632,-0.0379,0.9586,0.8834,-0.0611,0.6722,0.5476,0.9391,0.4606,0.4643,-0.4681,0.7386,0.9871,0.3721,0.5929,0.3666,0.1305,0.9404,0.6674,0.474 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.8614,0.5429,0.5382,0.8767,-0.2056,0.2859,0.6297,0.5503,-0.1625,0.1837,0.8426,0.3279,0.7988,0.9626,0.6624,0.5545,-0.5516,0.4213,0.3276,0.4326,0.4475,0.4522,0.8661,0.6233,-0.3892,0.7987,-0.5512 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.903,0.7757,0.49,0.8144,-0.1019,0.3721,0.9594,-0.2163,-0.2249,-0.1105,0.919,0.3988,0.9225,0.9917,0.0745,0.3592,0.9617,0.8232,0.9401,0.216,0.1609,0.841,0.7342,0.7963,0.0124,0.1602,0.9702 },
                    new int[] { 3,3,3 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new double[] { 0.9466,0.8294,-0.6367,0.7407,0.6398,0.196,0.0311,0.3646,0.4606,0.675,-0.0017,0.3707,0.1737,0.2816,0.8068,0.9592,0.9628,-0.9666,0.6983,0.4885,0.8707,0.9802,0.8651,0.7405,0.5732,0.1689,-0.0246 },
                    new int[] { 3,3,3 }
                ),
            };

            MaxPoolOddCacheOutput = new byte[6][,,]
            {
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 0,0,0,1,0,0,1,0,0,1,1,0,1,0,1,0,0,0,0,0,1,0,1,0,1,1,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,1,0,1,1,0,0,1,1,0,0,0,0,1,0,1,0,1,0,0,0,0,1,0,0,1,0,0,1,0,1,1,0,1 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 0,1,0,0,0,0,0,1,0,1,1,0,0,0,0,0,0,1,0,1,0,1,1,0,1,0,1,0,1,1,0,0,0,0,0,0,0,0,1,0,1,0,0,0,1,1,0,1,0,1,1,0,0,1,0,0,0,0,0,1,0,0,0,0,0,1,0,1,0,1,1,0,0,1,1 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 1,0,0,0,1,0,0,1,0,0,0,1,1,0,0,0,0,0,0,1,1,0,0,1,1,0,1,0,0,0,0,0,1,0,1,0,0,1,0,0,1,0,0,0,1,1,0,0,1,1,0,0,0,0,1,1,0,1,0,0,0,0,0,1,1,1,0,0,0,0,0,1,0,1,1 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 0,1,0,0,1,0,0,0,1,0,0,0,0,0,0,0,1,1,0,1,1,0,0,1,1,0,0,0,1,0,0,1,0,0,1,0,0,0,1,0,0,1,0,0,1,0,1,1,0,1,1,0,0,0,1,0,0,1,0,0,0,1,0,0,0,0,0,1,0,1,0,1,0,1,1 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 1,0,0,0,0,0,0,1,0,1,1,0,0,0,0,0,0,0,1,1,1,0,0,1,1,0,0,0,0,0,0,1,0,1,1,1,0,0,1,1,0,0,0,0,0,0,1,0,1,1,0,0,0,0,1,0,1,0,1,0,0,0,0,0,1,0,1,0,1,0,1,0,1,0,1 },
                    new int[] { 3,5,5 }
                ),
                ArrayConverter.Convert1Dto3D(
                    new byte[] { 0,1,1,0,1,0,0,0,0,0,0,0,1,0,0,1,0,0,0,1,0,1,0,1,1,0,0,0,0,1,0,1,0,1,0,0,0,0,0,1,1,0,0,1,0,1,0,0,1,1,1,0,0,0,1,0,0,1,0,0,0,0,0,1,0,0,1,0,0,1,1,0,0,1,1 },
                    new int[] { 3,5,5 }
                ),
            };
        }
    }
}
