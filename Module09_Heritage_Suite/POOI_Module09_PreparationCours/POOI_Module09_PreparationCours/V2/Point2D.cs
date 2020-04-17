namespace POOI_Module09_PreparationCours.V2
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return $"Point2D(X: {this.X}, Y: {this.Y})";
        }
    }
}