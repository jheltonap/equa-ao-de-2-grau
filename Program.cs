 int a;
            int b;
            int c;
            int delta;
            int x1;
            int x2;
            Console.Write("\nDigite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("\nDgite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine(a + "x²" + "+" + b + "x" + "+" + c);
            delta = b ^ 2 - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Essa equação existem dois raizes distintas");
                x1 = -b + Math.Sqrt(delta) / 2 * a;
