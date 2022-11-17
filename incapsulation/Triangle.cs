namespace encapsulation
{
    public class Triangle:Square
    {
        
        public int High { get; set; }
        public int Osnov { get; set; }
        public override double GetArea() => High * Osnov / 2;

        public Triangle(int high, int osnov)
        {
            High = high;
            Osnov = osnov;
            GetArea();
        }
    }
}
