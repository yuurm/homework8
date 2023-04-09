namespace Library.figures.@abstract
{
    public interface IAreaPerimeter
    {
        public double Area { get; }
        public double Perimeter { get; }
    }

    public interface ITitle
    {
        public string GetTitle();
    }

    public interface IFigure : IAreaPerimeter, ITitle
    {
        public FigureType FigureType { get; }
        public int FigureId { get; }
    }


    public enum FigureType
    {
        Circle, 
        Triangle, 
        Square,
        Cube
    }

    public enum FigureColor
    {
        Black,
        White
    }

    

   
    
}