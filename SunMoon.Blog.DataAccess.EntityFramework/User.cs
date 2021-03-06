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
    
    public partial class User
    {
        public User()
        {
            this.Albums = new HashSet<Album>();
            this.Circles = new HashSet<Circle>();
            this.Comments = new HashSet<Comment>();
            this.Friends = new HashSet<Friend>();
            this.Friends1 = new HashSet<Friend>();
            this.Images = new HashSet<Image>();
            this.Messages = new HashSet<Message>();
            this.Messages1 = new HashSet<Message>();
            this.Topics = new HashSet<Topic>();
        }
    
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNamePy { get; set; }
        public string LastNamePy { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string Mail { get; set; }
        public string Passwrod { get; set; }
        public string QQ { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Sex { get; set; }
        public Nullable<System.Guid> GroupId { get; set; }
        public string RegisterIp { get; set; }
    
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Circle> Circles { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Friend> Friends { get; set; }
        public virtual ICollection<Friend> Friends1 { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Message> Messages1 { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}
