using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class AssayDetail
    {
        public AssayDetail()
        {
            this.AssayResults = new List<AssayResult>();
        }

        public int Id { get; set; }
        public string AssayNumber { get; set; }
        public Nullable<int> SampleDetailId { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateTime { get; set; }
        public virtual AssayMaster AssayMaster { get; set; }
        public virtual SampleDetail SampleDetail { get; set; }
        public virtual ICollection<AssayResult> AssayResults { get; set; }
    }
}
