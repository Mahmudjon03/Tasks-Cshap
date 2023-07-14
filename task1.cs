int a, b = 0, d = 0, c = 0, s = 0;
			a = Convert.ToInt32(Console.ReadLine());

			if (a > 3600) {
				d = a;
				b = a / 3600;
				c = (d - b * 3600) / 60;
				s = (d - b * 3600) % 60;
			} else if (a < 3600 && a > 60) {
				b = 0;
				c = a / 60;
				s = a % 60;
			} else {
				s = a;
			}

			while (b >= 24)
			{
				b = b - 24;

			}
            System.Console.WriteLine($"{b}:{c}:{s}"); 
    