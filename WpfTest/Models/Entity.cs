using DevExpress.Mvvm;

namespace WpfTest.Models;

public class Entity : BindableBase
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public bool IsCompany { get; set; }
}