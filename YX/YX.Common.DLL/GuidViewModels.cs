using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YX.Common.DLL
{
    class GuidViewModels
    {
        #region 获取Guid值
        public string Guid()
        {
            string guid = System.Guid.NewGuid().ToString();
            string[] id=guid.Split('-');
            string ID = "";
            for (int i = 0; i < id.Length; i++) { ID += id[i]; }
                return ID;
        }
        #endregion
    }
}
