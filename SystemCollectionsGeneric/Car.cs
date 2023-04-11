public class Car : IComparable<Car>
{
    public Car(int carId, int height, int length, int width, string color)
    {
        CarId = carId;
        Height = height;
        Length = length;
        Width = width;
        Color = color;
    }

    public int CarId { get; private set; }
    public int Height { get; private set; }
    public int Length { get; private set; }
    public int Width { get; private set; }
    public string Color { get; private set; }

    public override string ToString()
    {
        return $"{this.GetType()}(CardId={CarId}, Height={Height}, Length={Length}, Width={Width}, Color={Color})";
    }
    public int CompareTo(Car? other)
    {
        if (other is not null)
        {
            if (this.Height.CompareTo(other.Height) != 0)
            {
                return this.Height.CompareTo(other.Height);
            }
            else if (this.Length.CompareTo(other.Length) != 0)
            {
                return this.Length.CompareTo(other.Length);
            }
            else if (this.Width.CompareTo(other.Width) != 0)
            {
                return this.Width.CompareTo(other.Width);
            }
            else
            {
                return this.Color.CompareTo(other.Color);
            }
        }
        else
        {
            return -1;
        }
    }
    public bool Equals(Car? other)
    {
        if (other is null)
            return false;
        return this.CarId.Equals(other.CarId);
    }
}
