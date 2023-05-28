using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WpfTest.Interfaces;

namespace WpfTest.Data;

public class Repository : IRepository
{
    private readonly EntityContext _context;
    
    public Repository()
    {
        _context = new EntityContext();
    }

    public async Task<IEnumerable<Entity>> Get()
    {
        await Task.Delay(5000);
        return _context.Entities.ToList();
    }
}