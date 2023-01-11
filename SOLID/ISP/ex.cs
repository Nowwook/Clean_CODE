public interface IProduct
{
    int ID { get; set; }
    double Weight { get; set; }
    int Stock { get; set; }
    int Inseam { get; set; }
    int WaistSize { get; set; }
}

public class Jeans : IProduct
{
    public int ID { get; set; }
    public double Weight { get; set; }
    public int Stock { get; set; }
    public int Inseam { get; set; }
    public int WaistSize { get; set; }
}

public class BaseballCap : IProduct
{
    public int ID { get; set; }
    public double Weight { get; set; }
    public int Stock { get; set; }
    public int Inseam { get; set; }
    public int WaistSize { get; set; }
    public int HatSize { get; set; }
}

public interface IProduct
{
    int ID { get; set; }
    double Weight { get; set; }
    int Stock { get; set; }
}

public interface IPants
{
    public int Inseam { get; set; }
    public int WaistSize { get; set; }
}

public class Jeans : IProduct, IPants
{
    public int ID { get; set; }
    public double Weight { get; set; }
    public int Stock { get; set; }
    public int Inseam { get; set; }
    public int WaistSize { get; set; }
}

public class BaseballCap : IProduct, IHat
{
    public int ID { get; set; }
    public double Weight { get; set; }
    public int Stock { get; set; }
    public int HatSize { get; set; }
}
public interface IHat
{
    public int HatSize { get; set; }
}
