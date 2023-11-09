namespace GenericsAndMethodChaining;

public class Car<T1, T2>
{
    public string Company { get; set; }
    public string Model { get; set; }
    
    public T1 Year { get; set; }
    public T2 Engine { get; set; }
    
}