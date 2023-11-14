public enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Cyan,
    Magneta
}
public class Programm2
{
    public static void ColorPrint(Color color)
    {
        switch (color)
        {
            case Color.Red:
                Console.WriteLine("FF000000255");
                break;
            case Color.Green:
                Console.WriteLine("00800001280");
                break;
            case Color.Blue:
                Console.WriteLine("0000FF00255");
                break;
            case Color.Yellow:
                Console.WriteLine("FFFF002552550");
                break;
            case Color.Cyan:
                Console.WriteLine("00FFFF0255255");
                break;
            case Color.Magneta:
                Console.WriteLine("FF00FF2550255");
                break;
            default:
                Console.WriteLine("Цвет вне диапазона");
                break;
        }
    }
    public static void Main(string[] args)
    {
        Color color1 = Color.Red;
        Color color2 = Color.Green;
        Color color3 = Color.Blue;
        Color color4 = Color.Yellow;
        Color color5 = Color.Cyan;
        Color color6 = Color.Magneta;
        ColorPrint(color1);
        ColorPrint(color2);
        ColorPrint(color3);
        ColorPrint(color4);
        ColorPrint(color5);
        ColorPrint(color6);
    }
}