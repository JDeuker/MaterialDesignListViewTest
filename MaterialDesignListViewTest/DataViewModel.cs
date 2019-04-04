using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesignListViewTest
{
    class DataViewModel
    {
        public string Name { get; set; }
        public string GroupName { get; set; }

        public DataViewModel(string name, string groupName)
        {
            Name = name;
            GroupName = groupName;
        }
    }
}
