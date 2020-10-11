using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePope.Lib.Models
{
    /// <summary>
    /// NotifyPropertyChanged의 연결을 위한 Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class NotifyFamilyAttribute : Attribute
    {
        public string[] ParentPropertyNames { get; set; }

        public NotifyFamilyAttribute(params string[] parentPropertyNames)
        {
            this.ParentPropertyNames = parentPropertyNames;
        }
    }
}
