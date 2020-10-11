using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using BluePope.Lib.Models;

namespace BluePope.WinApp1.Models
{
    public class EmployModel : ModelBase
    {
        public string EmpNo { get => GetValue<string>(); set => SetValue(value); }
        public string HangulName { get => GetValue<string>(); set => SetValue(value); }

        [NotifyFamily("EmpNo", "HangulName")]
        public string FullName { get => $"{EmpNo}번 {HangulName}"; }

        public static BindingList<EmployModel> GetList()
        {
            var list = new BindingList<EmployModel>();
            #region dapper 또는 ef를 통해 가져오게 되면 class형태로 가져오기 편리
            list.Add(new EmployModel() { EmpNo = "1", HangulName = "홍길동" });
            list.Add(new EmployModel() { EmpNo = "2", HangulName = "둘리" });
            #endregion

            return list;
        }
    }
}
