﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Configs;
using Util.Ui.Material.Cards.Renders;
using Util.Ui.Renders;
using Util.Ui.TagHelpers;

namespace Util.Ui.Material.Cards.TagHelpers {
    /// <summary>
    /// 卡片内容
    /// </summary>
    [HtmlTargetElement( "util-card-content" )]
    public class CardContentTagHelper : TagHelperBase {
        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new CardContentRender( new Config( context ) );
        }
    }
}