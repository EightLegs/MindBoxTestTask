using System;

namespace FigureLib
{
    public abstract class Figure
    {
        private string _figureName;
        //Once a figure is created you can`t change it`s shape, so the property FigureName is read-only
        public string FigureName { get => _figureName; /*set => _figureName = value;*/ }
        public Figure(string figureName)
        {
            _figureName = figureName;
        }
        public abstract double CalculateSquare();
        protected abstract bool CheckInputArgs();
    }
}
