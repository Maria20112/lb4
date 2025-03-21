using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    /// <summary>
    /// Интерфейс Прототип
    /// </summary>
    public interface ICreature
    {
        ICreature Clone();
    }
}
