string[] str;
            Console.WriteLine("Введите массив строк через запятую");
            string line = Console.ReadLine();
            str = line.Split(',');
            var result = new string[str.Length];
            int size = 0;
            foreach (var col in str)
            {
                if (col.Length <= 3)
                {
                    result[size] = col;
                    size++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, size));
            