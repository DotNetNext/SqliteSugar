using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqliteSugar;
using WebTest.TestLib;
using WebTest.Dao;
using SqliteSugar;
namespace WebTest.Demos
{
    /// <summary>
    /// 设置序列化后的JSON格式
    /// </summary>
    public partial class SerializerDateFormat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlSugarClient db = SugarDao.GetInstance())
            {
                db.SerializerDateFormat = "yyyy-mm/dd";
                var jsonStr = db.Queryable<InsertTest>().OrderBy("id").Take(1).ToJson();
                var jsonStr2 = db.Sqlable().From<InsertTest>("t").SelectToPageList<InsertTest>("*","id",1,1);//取第一条
                var jsonStr3 = db.SqlQueryJson("select   * from InsertTest limit 0,1 ");
            }
        }
    }
}