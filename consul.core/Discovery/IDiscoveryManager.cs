using System;

namespace consul.core.Discovery
{
    public interface IDiscoveryManager
    {
        Uri FindUriAsync(); 
    }
}
