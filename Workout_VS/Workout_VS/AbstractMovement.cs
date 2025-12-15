using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_VS
{
    internal abstract class AbstractMovement : IMovement
    {
        public abstract int Speed { get; set; }

        public abstract void Move();
    }
}
