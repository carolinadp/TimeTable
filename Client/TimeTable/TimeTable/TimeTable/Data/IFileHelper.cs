using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTable.Data
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
