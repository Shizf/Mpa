using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpa.Tasks.Dto
{
    public class UpdateTaskInput
    {
        public virtual int? AssignedPersonId { get; set; }

        public virtual string Description { get; set; }

        public virtual int State { get; set; }
    }
}
