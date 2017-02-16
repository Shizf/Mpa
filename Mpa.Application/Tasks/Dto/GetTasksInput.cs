using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpa.Tasks.Dto
{
    public class GetTasksInput
    {
        public virtual int? AssignedPersonId { get; set; }

        public virtual int State { get; set; }
    }
}
