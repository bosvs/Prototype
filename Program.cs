namespace Prototype
{
    class Prototype
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            IFigure figure;
            IFigure clonedFigure;

            figure = new Rectangle(10, 20);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            Console.WriteLine();

            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            Console.WriteLine();

            figure = new Triangle(3, 4, 5);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
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
            Console.WriteLine("Прямокутник з висотою {0} та шириною {1}", height, width);
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
            Console.WriteLine("Коло з радіусом {0}", radius);
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
            Console.WriteLine("Трикутник з такими сторонами:\n  - перша сторона {0} одиниць\n  - друга сторона {1} одиниць\n  - третя сторона {2} одиниць", firstSide, secondSide, thirdSide);
        }
    }
}
