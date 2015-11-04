using System;
using System.Collections.Generic;

namespace Jovland.ViewModel
{
    /// <summary>
    /// 返回的产品信息
    /// </summary>
    public class ProductModel
    {
        /// <summary>
        /// 图片编码
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// 小图
        /// </summary>
        public string Url1 { get; set; }
        /// <summary>
        /// 大图
        /// </summary>
        public string Url2 { get; set; }
        /// <summary>
        /// 图片名
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 图片类别
        /// </summary>
        public string Category { get; set; }
    }

    /// <summary>
    /// 封装返回的产品信息
    /// </summary>
    public class ProductModelReturn
    {
        public IEnumerable<ProductModel> Data { get; set; }
        public string Message { get; set; }
        public int PageIndex { get; set; }

        public ProductModelReturn()
        {
            Data = new List<ProductModel>();
        }

    }



    /// <summary>
    /// 封装返回的产品信息
    /// </summary>
    public class ProductDetailReturn
    {
        /// <summary>
        /// 产品明细列表
        /// </summary>
        public IEnumerable<ProductDetail> Data { get; set; }
        /// <summary>
        /// 产品型号
        /// </summary>
        public ProductModel ProductType { get; set; }
        public string Message { get; set; }
        public int PageIndex { get; set; }

        public ProductDetailReturn()
        {
            Data = new List<ProductDetail>();
        }

    }


    /// <summary>
    /// 产品明细
    /// </summary>
    public class ProductDetail
    {
        /// <summary>
        /// 产品附件URL
        /// </summary>
        public string AttachUrl { get; set; }
        /// <summary>
        /// 产品名
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 产品类别
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 产品库存
        /// </summary>
        public int ProductCount { get; set; }

        /// <summary>
        /// 产品明细ID
        /// </summary>
        public Guid ProductId { get; set; }
    }

}