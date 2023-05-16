using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de User
/// </summary>
namespace Model
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Phone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int Age { get; set; }


    }
}

