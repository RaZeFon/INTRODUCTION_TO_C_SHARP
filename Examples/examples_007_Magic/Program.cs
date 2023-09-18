//Console.SetCursorPosition(10, 4) отступ от левого 10, и сверху 4
// в качестве аргументов мы можем указать (отступ от левого края и отступ от верхнего края)
//Console.WriteLine("+") рисовать будем знаком +.

Console.Clear();

int xa = 20, ya = 1,
    xb = 1, yb = 10,
    xc = 40, yc = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb;
int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0, 3); // [0; 3) 0 1 2
    // определяем случайное число
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}


