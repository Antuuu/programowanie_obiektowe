using System.ComponentModel;

double a, b, c, d, w, p, q, delta, w2, w3, q2, p3;

Console.WriteLine("Podaj liczbe a:");
a = Double.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbe b:");
b = Double.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbe c:");
c = Double.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbe d:");
d = Double.Parse(Console.ReadLine());
w = -b / (3.0 * a);
w2 = Math.Pow(w, 2);
w3 = Math.Pow(w, 3);
Console.WriteLine("w = " + w);
p = ((3.0 * a * w2) + (2.0 * b * w) + c) / a;
p3 = Math.Pow(p, 3);
Console.WriteLine("p = " + p);
q = ((a * w3) + (b * w2) + (c * w) + d) / a;
q2 = Math.Pow(q, 2);
Console.WriteLine("q = " + q);
delta = (q2 / 4.0) + (p3 / 27.0);
switch (delta)
{
    case > 0:
        {
            double u, v, x1, x2, x3, deltaRoot, root3, cubeRoot;
            Console.WriteLine("Delta > 0");
            deltaRoot = Math.Sqrt(delta);
            cubeRoot = Math.Cbrt(-q / 2.0);
            u = Math.Cbrt((-q / 2.0) + deltaRoot);
            Console.WriteLine("u = " + u);
            v = Math.Cbrt((-q / 2.0) - deltaRoot);
            Console.WriteLine("v = " + v);
            root3 = Math.Sqrt(3.0);
            var imaginary = ((root3 / 2.0) * (u - v));
            x1 = u + v + w;
            Console.WriteLine("x1 is: " + x1);
            x2 = (-0.5 * (u + v) + w);
            Console.WriteLine("x2 is: " + x2 + "+" + imaginary + " * i");
            x3 = (-0.5 * (u + v) + w);
            Console.WriteLine("x3 is: " + x3 + "-" + imaginary + " * i");
            break;
        }
    case < 0:
        {
            double fi, x1, x2, x3;
            Console.WriteLine("Delta < 0");
            fi = Math.Acos((3 * q) / (2.0 * p * Math.Sqrt(-p / 3.0)));
            Console.WriteLine("fi = " + fi);
            x1 = w + ((2 * Math.Sqrt(-p / 3.0)) * Math.Cos(fi / 3.0));
            Console.WriteLine("x1 is: " + x1);
            x2 = w + ((2 * Math.Sqrt(-p / 3.0)) * Math.Cos((fi / 3.0) + ((2.0 / 3.0) * Math.PI)));
            Console.WriteLine("x2 is: " + x2);
            x3 = w + ((2 * Math.Sqrt(-p / 3.0)) * Math.Cos((fi / 3.0) + ((4.0 / 3.0) * Math.PI)));
            Console.WriteLine("x3 is: " + x3);
            break;
        }
    default:
        {
            double x1, x2;
            Console.WriteLine("Delta = 0");
            x1 = w - (2.0 * Math.Cbrt(q / 2.0));
            Console.WriteLine("x1 is: " + x1);
            x2 = w + (Math.Cbrt(q / 2.0));
            Console.WriteLine("x2 is: " + x2);
            Console.WriteLine("x3 is: " + x2);
            break;
        }
}