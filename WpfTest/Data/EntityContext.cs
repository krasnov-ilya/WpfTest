using System;
using System.Collections.Generic;

namespace WpfTest.Data;

public class EntityContext
{
    public readonly IEnumerable<Entity> Entities;

    public EntityContext()
    {
        Entities = CreateEntities();
    }

    private static IEnumerable<Entity> CreateEntities()
    {
        var result = new List<Entity>();
        
        for (var i = 0; i < 100; i++)
        {
            result.Add(new Entity
            {
                Name = $"Name_{i}",
                Address = i % 5 == 0 ? string.Empty : $"Address_{i}",
                Email = $"name{i}@gmail.com",
                IsCompany = GetRandomBool()
            });
        }

        return result;
    }

    private static bool GetRandomBool()
    {
        var random = new Random();
        return random.Next(2) == 1;
    }
}