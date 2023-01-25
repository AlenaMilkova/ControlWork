// Программа, решающая поставленную задачу
//Функция ввода данных
double EnterData(string text)
{
    Console.WriteLine(text);
    double number  = Convert.ToDouble(Console.ReadLine());
    return number;
}

double s1 = EnterData("Введите расстояние, пройденное первым пешеходом s1");
double s2 = EnterData("Введите расстояние, пройденное вторым пешеходом s2");
double t1 = EnterData("Введите время, затраченное первым пешеходом t1");
double t2 = EnterData("Введите время, затраченное вторым пешеходом t2");

//Функция нахождения скорости
double Speed(double s, double t)
    
{
    double v = s / t;
    return v;
}

double v1 = Speed(s1, t1);
double v2 = Speed(s2, t2);
Console.WriteLine("Скорость первого пешехода в км/ч - " + v1);
Console.WriteLine("Скорость второго пешехода в км/ч  - " + v2);

if (v1 > v2) Console.WriteLine("Скорость первого пешехода больше");
else Console.WriteLine("Скорость второго пешехода больше");
if (v1 == v2) Console.WriteLine("Скорости равны");


