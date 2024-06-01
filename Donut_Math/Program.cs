class Donut //:3
{
    static void Main(string[] args)
    {
        float A = 0, B = 0;
        float i, j;
        int k;
        float[] z = new float[1760];
        char[] b = new char[1760];

        Console.Clear();

        while (true)
        {
            Array.Fill<char>(b, ' ');
            Array.Fill(z, 0);

            for (j = 0; j < 6.28; j += 0.07f) //from 0 to 2pi
            {
                for (i = 0; i < 6.28; i += 0.02f) //from 0 to 2pi
                {
                    float c = (float)Math.Sin(i);
                    float d = (float)Math.Cos(j);
                    float e = (float)Math.Sin(A);
                    float f = (float)Math.Sin(j);
                    float g = (float)Math.Cos(A);
                    float h = d + 2;
                    float D = 1 / (c * h * e + f * g + 5); //Donut size
                    float l = (float)Math.Cos(i);
                    float m = (float)Math.Cos(B);
                    float n = (float)Math.Sin(B);
                    float t = c * h * g - f * e;
                    int x = (int)(40 + 30 * D * (l * h * m - t * n)); // 3d x coordinate after rotation
                    int y = (int)(12 + 15 * D * (l * h * n + t * m)); // 3d y coordinate after rotation
                    int o = (int)(x + 80 * y); //3d z coordinate after rotation
                    int N = (int)(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n));

                    if (22 > y && y > 0 && x > 0 && 80 > x && D > z[o])
                    {
                        z[o] = D;
                        b[o] = ".,-~:OwO!*:$@"[N > 0 ? N : 0];
                    }
                }
            }

            Console.SetCursorPosition(0, 0);

            for (k = 0; k < 1761; k++)
            {
                Console.Write(k % 80 == 0 ? Environment.NewLine : b[k]);
                A += 0.00006f; // yaw speed
                B += 0.00003f; // pitch speed
            }

            Thread.Sleep(10);
        }
    }
}