using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050358.Models
{
    public partial class LTQLDBContex : DbContext
    {
        public LTQLDBContex()
            : base("name=LTQLDBContex")
        {
        }
        public virtual DbSet<LopHoc358> LopHoc358s { get; set; }
        public virtual DbSet<THQSinhVien358> THQSinhVien358s { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
    }
}
