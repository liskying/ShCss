using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jovland.ViewModel;
using Newtonsoft.Json;

namespace Jovland.Controllers
{
    public class ProductsController : Controller
    {

        private static IList<ProductModel> _productCategoryTypes = new List<ProductModel>();
        private static IList<ProductDetail> _productTypeDetails = new List<ProductDetail>();

        /// <summary>
        /// 产品首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// 获取产品分类产品型号列表
        /// </summary>
        /// <param name="categoryType"></param>
        /// <returns></returns>
        public string GetProductList(string categoryType, int pgIndex = 1, int pgSize = 20)
        {
            var objRet = new ProductModelReturn
            {
                Message = "ok",
                PageIndex = pgIndex
            };

            InitProductInfo();
            objRet.Data = _productCategoryTypes.Where(p => p.Category.ToLower() == categoryType);
            return JsonConvert.SerializeObject(objRet);
        }


        /// <summary>
        /// 获取指定产品型号产品列表
        /// </summary>
        /// <param name="categoryType">产品类别</param>
        /// <param name="productTypeId">产品类型ID</param>
        /// <param name="pgIndex">页索引</param>
        /// <param name="pgSize">页大小</param>
        /// <returns></returns>
        public string GetProductDetailList(string categoryType, Guid? productTypeId , int pgIndex = 1, int pgSize = 20)
        {
            var objRet = new ProductDetailReturn
            {
                Message = "ok",
                PageIndex = pgIndex
            };
            productTypeId = productTypeId.HasValue ? productTypeId.Value : Guid.Empty;
            InitProductInfo();
            objRet.ProductType = _productCategoryTypes.FirstOrDefault(p => p.Category.ToLower() == categoryType);
            objRet.Data = _productTypeDetails.Where(p => p.Category == categoryType);
            return JsonConvert.SerializeObject(objRet);
        }

        private void InitProductInfo()
        {
            InitProductCategoryTypes();
            InitPoductTypeDetails();
        }

        private void InitProductCategoryTypes()
        {
            if (_productCategoryTypes != null && _productCategoryTypes.Any()) return;
            if (_productCategoryTypes == null) _productCategoryTypes = new List<ProductModel>();

            var rdn = new Random();

            #region  rs
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_24.jpg",
                Url2 = "/Content/images/portfolio/portfolio_02.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_25.jpg",
                Url2 = "/Content/images/portfolio/portfolio_03.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_26.jpg",
                Url2 = "/Content/images/portfolio/portfolio_04.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_27.jpg",
                Url2 = "/Content/images/portfolio/portfolio_05.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_29.jpg",
                Url2 = "/Content/images/portfolio/portfolio_07.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_30.jpg",
                Url2 = "/Content/images/portfolio/portfolio_08.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_24.jpg",
                Url2 = "/Content/images/portfolio/portfolio_08.jpg",
            });

            _productCategoryTypes.Add(new ProductModel
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_25.jpg",
                Url2 = "/Content/images/portfolio/portfolio_09.jpg",
            });
            #endregion

            #region  lep
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_25.jpg",
                Url2 = "/Content/images/portfolio/portfolio_03.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_26.jpg",
                Url2 = "/Content/images/portfolio/portfolio_04.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_28.jpg",
                Url2 = "/Content/images/portfolio/portfolio_06.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_29.jpg",
                Url2 = "/Content/images/portfolio/portfolio_07.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_30.jpg",
                Url2 = "/Content/images/portfolio/portfolio_08.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_31.jpg",
                Url2 = "/Content/images/portfolio/portfolio_09.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_31.jpg",
                Url2 = "/Content/images/portfolio/portfolio_09.jpg",
            });
            #endregion

            #region  sat
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_31.jpg",
                Url2 = "/Content/images/portfolio/portfolio_09.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_31.jpg",
                Url2 = "/Content/images/portfolio/portfolio_09.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_31.jpg",
                Url2 = "/Content/images/portfolio/portfolio_09.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_32.jpg",
                Url2 = "/Content/images/portfolio/portfolio_10.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_33.jpg",
                Url2 = "/Content/images/portfolio/portfolio_01.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_34.jpg",
                Url2 = "/Content/images/portfolio/portfolio_02.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_35.jpg",
                Url2 = "/Content/images/portfolio/portfolio_03.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_35.jpg",
                Url2 = "/Content/images/portfolio/portfolio_03.jpg",
            });
            #endregion

            #region  lc
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lc",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_36.jpg",
                Url2 = "/Content/images/portfolio/portfolio_04.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lc",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_37.jpg",
                Url2 = "/Content/images/portfolio/portfolio_05.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lc",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_38.jpg",
                Url2 = "/Content/images/portfolio/portfolio_06.jpg",
            });
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "lc",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_23.jpg",
                Url2 = "/Content/images/portfolio/portfolio_07.jpg",
            });
            #endregion

            #region  fc
            _productCategoryTypes.Add(new ProductModel
            {
                Category = "fc",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_24.jpg",
                Url2 = "/Content/images/portfolio/portfolio_08.jpg",
            });

            _productCategoryTypes.Add(new ProductModel
            {
                Category = "fc",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_25.jpg",
                Url2 = "/Content/images/portfolio/portfolio_09.jpg",
            });

            _productCategoryTypes.Add(new ProductModel
            {
                Category = "fc",
                ProductId = Guid.NewGuid(),
                Title = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                Url1 = "/Content/images/portfolio/portfolio_10.jpg",
                Url2 = "/Content/images/portfolio/portfolio_06.jpg",
            });

            #endregion;

        }

        private void InitPoductTypeDetails()
        {
            if (_productTypeDetails != null && _productTypeDetails.Any()) return;
            if (_productTypeDetails == null) _productTypeDetails = new List<ProductDetail>();

            var rdn = new Random();

            #region  rs
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_02.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_03.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_04.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_05.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_07.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_08.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_08.jpg",
                ProductCount = 5
            });

            _productTypeDetails.Add(new ProductDetail
            {
                Category = "rs",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_09.jpg",
                ProductCount = 5
            });
            #endregion

            #region  lep
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_03.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_04.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_06.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_07.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_08.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_09.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lep",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_09.jpg",
                ProductCount = 5
            });
            #endregion

            #region  sat
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_09.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_09.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_09.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_10.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_01.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_02.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_03.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "sat",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_03.jpg",
                ProductCount = 5
            });
            #endregion

            #region  lc
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lc",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_04.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lc",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_05.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lc",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_06.jpg",
                ProductCount = 5
            });
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "lc",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_07.jpg",
                ProductCount = 5
            });
            #endregion

            #region  fc
            _productTypeDetails.Add(new ProductDetail
            {
                Category = "fc",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_08.jpg",
                ProductCount = 5
            });

            _productTypeDetails.Add(new ProductDetail
            {
                Category = "fc",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_09.jpg",
                ProductCount = 5
            });

            _productTypeDetails.Add(new ProductDetail
            {
                Category = "fc",
                ProductId = Guid.NewGuid(),
                ProductName = string.Format("Product.No.{0}", rdn.Next(1000, 10000)),
                AttachUrl = "/Content/images/portfolio/portfolio_06.jpg",
                ProductCount = 5
            });

            #endregion;
        }

    }
}
