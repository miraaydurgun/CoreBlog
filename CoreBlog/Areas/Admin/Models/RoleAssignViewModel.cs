﻿namespace CoreBlog.Areas.Admin.Models
{
    public class RoleAssignViewModel
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        public bool Exists { get; set; } //bu kullanıcı bu rolü içeriyor mu veya bu rol bu kullanıcıda var mı? 
    }
}
