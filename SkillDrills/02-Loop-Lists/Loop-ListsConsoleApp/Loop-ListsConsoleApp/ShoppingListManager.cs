using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_ListsConsoleApp;

public  class ShoppingListManager
{
    private readonly List<string> _items = new();

    public bool AddItem(string item)
    {
        if (string.IsNullOrWhiteSpace(item)) return false;
        if (_items.Contains(item, StringComparer.OrdinalIgnoreCase)) return false;

        _items.Add(item.Trim());
        return true;
    }

    public  bool RemoveItem(string item)
    {
        return _items.Remove(item.Trim());
    }

    public List<string> GetItems()
    {
        return _items.OrderBy(x => x).ToList();
    }

    public void ClearList() => _items.Clear();
}

