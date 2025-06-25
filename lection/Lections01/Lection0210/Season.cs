enum Season
{
    Spring, // 0
    Summer, // 1
    Autumn, // 2
    Winter  // 3
}

enum SummerMonth : byte
{
    June = 6,
    July = 7,
    August = 8
}

[Flags]
enum Color
{
    Black = 0,
    Red = 1,
    Yellow = 2,
    Blue = 4,
    Orange = Red | Yellow,       // 3
    Purple = Red | Blue,         // 5
    Green = Blue | Yellow,       // 6
    White = Red | Yellow | Blue, // 7
}