using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfcdashboard.Model
{
    public class MenuItems
    {
        public string MenuName { get; set; }
        public string MenuImage { get; set; }
    }

    public class HomeItems
    {
        public string HomeName { get; set; }
        public string HomeImage { get; set; }
    }

    public class ReportItems
    {
        public string ReportName { get; set; }
        public string ReportImage { get; set; }
    }

    public class ConnectionItems
    {
        public string ConnectionName { get; set; }
        public string ConnectionImage { get; set; }
    }

    public class DataItems
    {
        public string DataName { get; set; }
        public string DataImage { get; set; }
    }
    
    public class SettingsItems
    {
        public string SettingsName { get; set; }
        public string SettingsImage { get; set; }
    }

    public class FileItems
    {
        public string FileName { get; set; }
        public string FileImage { get; set; }
    }
}
