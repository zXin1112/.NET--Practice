using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net_MvcPractice.Classes
{
    public static class HtmlExtensions
    {
        /// <summary>
        /// 扩展方法 自定义标签Submit
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MvcHtmlString Submit(this HtmlHelper htmlHelper,string value)
        {
            var builder = new TagBuilder("input");//创建以input开头的新标签
            builder.MergeAttribute("type", "submit");
            builder.MergeAttribute("value", value);//添加属性
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));//返回创建的标签
        }
    }
}