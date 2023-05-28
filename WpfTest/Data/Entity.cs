using DevExpress.Mvvm;

namespace WpfTest.Data;

public class Entity : BindableBase
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool IsCompany { get; set; }
}