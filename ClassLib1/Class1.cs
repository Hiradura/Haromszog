using System.Threading.Channels;

namespace ClassLib1
{
    public class Class1
    {
        public double SideA;
        public double SideB;
        public double SideC;

        public Class1(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalcPerimeter()
        {
            return SideA + SideB + SideC / 2;
        }

        public double CalcArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override string? ToString()
        {
            return $"{CalcArea}, {CalcPerimeter}";
        }
    }
}