using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteEngine.Interface.Components
{
    public class BaseComponent : IComponent
    {
        #region IComponent Implementation
        public uint ID { get; set; }
        public uint EntityID { get; set; }
        #endregion
    }
}
