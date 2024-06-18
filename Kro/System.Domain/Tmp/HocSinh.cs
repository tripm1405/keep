namespace System.Domain.Tmp;

public class HocSinh
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int LopId { get; set; }
    
    public Lop Lop { get; set; }
}