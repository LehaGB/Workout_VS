using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_VS
{
    interface IMovement
    {
        int Speed { get; set; }
        void Move();
    }
}
