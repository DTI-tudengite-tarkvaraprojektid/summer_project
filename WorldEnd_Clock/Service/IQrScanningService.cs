using System.Threading.Tasks;

namespace WorldEnd_Clock.Service
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}