using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteEngine.Interface
{
    public interface IComponent
    {
        /// <summary>
        /// Gets or sets the ID of this Component
        /// </summary>
        uint ID { get; set; }
        /// <summary>
        /// Gets or sets the ID of the Entity that this Component is a part of
        /// </summary>
        uint EntityID { get; set; }
    }
}
