using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Runtime.Validation;

namespace Mpa.Tasks.Dto
{
    public class CreateTaskInput

    {
        public virtual int? AssignedPersonId { get; set; }

        [Required(ErrorMessage = "描述必填")]
        [AllowHtml]
        public virtual string Description { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual int State { get; set; }
    }
}
