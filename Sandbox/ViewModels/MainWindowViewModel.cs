using System;
using System.Collections.Generic;

namespace Sandbox.ViewModels
{
  internal class MainWindowViewModel : ViewModelBase
  {
    public MainWindowViewModel()
    {
      Items = new List<Item>
        {
          new Item(),
          new ItemWithTime {Time = DateTime.Now}
        };
    }

    public IEnumerable<Item> Items { get; private set; }
    public Item SelectedItem { get; set; }
  }

  internal class Item
  {
  }

  internal class ItemWithTime : Item
  {
    public DateTime Time { get; set; }
  }
}