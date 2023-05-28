using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using WpfTest.Data;
using WpfTest.Interfaces;

namespace WpfTest.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private readonly IRepository _repository;
    
    public MainWindowViewModel()
    {
        _repository = new Repository();
        GetEntities();
    }

    public ObservableCollection<Entity> Entities { get; set; } = new ();

    private async Task GetEntities()
    {
        var entities = await _repository.Get();
        foreach (var entity in entities)
        {
            Entities.Add(entity);
        }
    }
}