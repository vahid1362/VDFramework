using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDFramework.Core.Data
{
  public  class DataSettings
    {

        public DataSettings()
        {
            DataConnectionString = "Server=.;Database=VDFramework;Trusted_Connection=True;";
        }
        public string DataConnectionString { get; set; }
    }
}
