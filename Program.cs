namespace Prototype
{
    class Prototype
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            IFigure figure;
            IFigure clonedFigure;

            // Output for Rectangle
            figure = new Rectangle(10, 20);
            clonedFigure = figure.Clone();
            DisplayFigureInfo("Прямокутник", figure, clonedFigure);
            Console.WriteLine();

            // Output for Circle
            figure = new Circle(15);
            clonedFigure = figure.Clone();
            DisplayFigureInfo("Коло", figure, clonedFigure);
            Console.WriteLine();

            // Output for Triangle
            figure = new Triangle(3, 4, 5);
            clonedFigure = figure.Clone();
            DisplayFigureInfo("Трикутник", figure, clonedFigure);

            Console.Read();
        }

        static void DisplayFigureInfo(string figureName, IFigure original, IFigure clone)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Інформація про {figureName}:");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Оригінал:");
            original.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Копія:");
            clone.GetInfo();

            Console.WriteLine("--------------------------------------------------");
        }
    }

    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine($"\t - Висота: {height} одиниць");
            Console.WriteLine($"\t - Ширина: {width} одиниць");
        }
    }

    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine($"\t - Радіус: {radius} одиниць");
        }
    }

    class Triangle : IFigure
    {
        double firstSide;
        double secondSide;
        double thirdSide;
        public Triangle(double f, double s, double t)
        {
            firstSide = f;
            secondSide = s;
            thirdSide = t;
        }
        public IFigure Clone()
        {
            return new Triangle(firstSide, secondSide, thirdSide);
        }
        public void GetInfo()
        {
            Console.WriteLine($"\t - Перша сторона: {firstSide} одиниць");
            Console.WriteLine($"\t - Друга сторона: {secondSide} одиниць");
            Console.WriteLine($"\t - Третя сторона: {thirdSide} одиниць");
        }
    }
}
