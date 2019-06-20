using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Elu_application.Service
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}