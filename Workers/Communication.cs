using System;
using System.Threading;
using System.Threading.Tasks;
using static H6_Site.GlobalObjects;
namespace H6_Site
{
    public class Communication
    {
        public int Value;

        public async Task SendValues(int count, CancellationToken token)
        {
            Value = count;

            LocalSVCRunning = await "api_calls".ContactLocalSVC(Value.ToString());

            OnCommunicateChangeAsync?.Invoke(token);
        }

        public event Func<CancellationToken, Task> OnCommunicateChangeAsync;
    }
}
