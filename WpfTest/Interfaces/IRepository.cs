using System.Collections.Generic;
using System.Threading.Tasks;
using WpfTest.Data;

namespace WpfTest.Interfaces;

public interface IRepository
{
    Task<IEnumerable<Entity>> Get();
}