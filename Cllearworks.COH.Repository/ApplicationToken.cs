//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cllearworks.COH.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicationToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public System.DateTime Expiration { get; set; }
        public Nullable<int> FKApplication { get; set; }
    
        public virtual Application Application { get; set; }
    }
}
