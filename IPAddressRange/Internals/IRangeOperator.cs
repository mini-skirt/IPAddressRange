using System.Collections.Generic;
using System.Net;

namespace MiniSkirt.IPAddressRange.Internals
{
    internal interface IRangeOperator : ICollection<IPAddress>
    {
        bool Contains(IPAddressRange range);
    }
}
