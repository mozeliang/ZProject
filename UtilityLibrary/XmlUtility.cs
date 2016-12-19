using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Web;

/****************
 * 描述：xml文档操作相关方法
 * 作者：mo
 * 创建时间：2015-09-06
 * 修改时间：2015-09-06
 ****************/

namespace UtilityLibrary
{
    /// <summary>
    /// xml文档操作相关方法
    /// </summary>
    public class XmlUtility
    {
        public string test() {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(HttpContext.Current.Server.MapPath("~/App_Data/test.xml"));

            return "";
        }
    }
}
