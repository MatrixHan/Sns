//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SunMoon.Blog.DataAccess.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Friend
    {
        public string FriendID { get; set; }
        public string Self { get; set; }
        public Nullable<System.Guid> CircleID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    
        public virtual Circle Circle { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
