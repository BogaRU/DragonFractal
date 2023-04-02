// В этом пространстве имен содержатся средства для работы с изображениями. 
// Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System;
using System.Drawing;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		static double x;
		static double y;
		public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
			x = 1;
			y = 0;
			Random rnd = new Random(seed);
			for (int i = 0; i < iterationsCount; i++)
			{
				var randomValue = rnd.Next(2);
				if (randomValue == 1) Transform1(ref x, ref y);
				else Transform2(ref x, ref y);
				pixels.SetPixel(x, y);
            }
		}
		public static void Transform1 (ref double x, ref double y)
		{
			double X = x;
			double Y = y;
			x = (X * Math.Cos(Math.PI / 4) - Y * Math.Sin(Math.PI / 4)) / Math.Sqrt(2);
			y = (X * Math.Sin(Math.PI / 4) + Y * Math.Cos(Math.PI / 4)) / Math.Sqrt(2);

        }
        public static void Transform2(ref double x, ref double y)
        {
            double X = x;
            double Y = y;
            x = (-X * Math.Cos(Math.PI / 4) - Y * Math.Sin(Math.PI / 4)) / Math.Sqrt(2) + 1;
            y = (X * Math.Sin(Math.PI / 4) - Y * Math.Cos(Math.PI / 4)) / Math.Sqrt(2);
        }
    }
}