namespace GestureRecognition.DAL.Models
{
    public class Gesture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Compactness { get; set; }
        public double Px { get; set; }
        public double Py { get; set; }
    }
}
