using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace сoursework.Data.Interfaces
{
    public interface IHierarchicalMenuItem
    {
        List<IMenuItem> GetMenuItems();
        string GetTitle();
        string GetHref();
    }
}
