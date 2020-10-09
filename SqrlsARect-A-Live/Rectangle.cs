using System;
using System.Collections.Generic;
using System.Text;

namespace SqrlsARect_A_Live
{
    class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int CalculateArea()
        {

            return Height * Width;

        }
    }

    class Square : Rectangle
    {



    }

    class SquareSquare : Rectangle
    {

        public override int Height
        {

            get { return base.Height; }
            set { base.Height = base.Width = value; }

        }

        public override int Width
        {

            get { return base.Height; }
            set { base.Height = base.Width = value; }

        }

    }

}
