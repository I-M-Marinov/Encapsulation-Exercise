using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P1.ClassBoxData
{
    public class Box
    {
        private const string PropertyValueExceptionMessage = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double heigth;

        public Box(double length, double width, double heigth)
        {
            Length = length;
            Width = width;
            Height = heigth;

        }

        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExceptionMessage, "Length"));
                }

                length = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExceptionMessage, "Width"));
                }

                width = value;
            }
        }

        public double Height
        {
            get => heigth;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExceptionMessage, "Height"));
                }

                heigth = value;
            }
        }

        public double SurfaceArea()
            => 2 * Length * Width + LateralSurfaceArea();

        public double LateralSurfaceArea()
        => 2 * Length * Height + 2 * Width * Height;

        public double Volume()
        => Length * Width * Height;
    }
    


}
