using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Classes
{
    internal abstract class Shape
    {
        private double _length;
        private double _width;
        private double _height;
        private double _radius;
        private double _square;
        private double _perimeter;
        private const double _pi = Math.PI;
        private string[] _recordToArr = new string[5];


        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public double Square { get; set; }
        public double Perimeter { get; set; }


        //public double Length { get { return _length; } set { value = _length; } }
        //public double Width { get { return _width; } set { value = _width; } }
        //public double Height { get { return _height; } set { value = _height; } }
        //public double Radius { get { return _radius; } set { value = _radius; } }
        //public double Square { get { return _square; } set { value = _square; } }
        //public double Perimeter { get { return _perimeter; } set { value = _perimeter; } }
        public double Pi { get { return _pi; } }
        public string[] RecordToArr { get { return _recordToArr; } set { value = _recordToArr; } }



        
        public abstract void GetSquare();
        public abstract void GetPerimeter();


    }
}
