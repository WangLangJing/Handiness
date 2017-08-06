﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
[assembly: SuppressIldasm]

namespace Handiness.CodeBuild
{
    /*-------------------------------------------------------------------------
 * 版权所有：王浪静
 * 作者：王浪静
 * 联系方式：932444208@qq.com
 * 创建时间： 2017/7/17 17:29:22
 * 版本号：v1.0
 * .NET 版本：4.0
 * 本类主要用途描述：提供一系列的说明型文本资源
 *  -------------------------------------------------------------------------*/
    internal class TextResources
    {
        /// <summary>
        /// 生成代码的默认命名空间
        /// </summary>
        public const String DefaultNameSpace = "Handiness";
        public const String DeserializationTypeMappingFailedPattern = "在反序列化 {0} 中的类型映射信息时失败";
        /// <summary>
        /// 类型映射信息文件的名称格式
        /// </summary>
        public const String TypeMappingFileNamePattern = "{0}.mc";
        /// <summary>
        /// 目前在代码模板中识别并可替换的占位符名称集合
        /// </summary>
        public static HashSet<String> ValidPlaceholderName { get; } = new HashSet<String>
        {
            "classname",//类名
            "namespace",//命名空间
            "fieldname",//字段名
            "propertyname",//属性名
             "columnexplain",//列描述
             "mappingtype"//列类型映射
        };


      
    }
}
