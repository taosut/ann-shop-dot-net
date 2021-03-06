﻿using ann_shop_server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ann_shop_server.Services
{
    public class FlutterBlockProductService : Service<FlutterBlockProductService>
    {
        /// <summary>
        /// Lấy danh sách block product cho trang home
        /// </summary>
        /// <returns></returns>
        public List<FlutterBlockProductModel> getHomeBlocks()
        {
            var blockProducts = new List<FlutterBlockProductModel>();

            #region Bao lì xì tết
            var block1 = FlutterCategoryService.Instance.createCategoryBlockProduct("bao-li-xi-tet");
            if (block1 != null)
            {
                blockProducts.Add(new FlutterBlockProductModel()
                {
                    //banner = new FlutterBannerModel() {
                    //    action = "category",
                    //    name = "Bao lì xì tết",
                    //    actionValue = "bao-li-xi-tet",
                    //    image = "https://khohangsiann.com/wp-content/uploads/si-bao-li-xi-2020.png",
                    //    createdDate = DateTime.Now
                    //},
                    category = block1
                });
            }
            #endregion

            #region Váy đầm
            var block2 = FlutterCategoryService.Instance.createCategoryBlockProduct("vay-dam");
            if (block2 != null)
            {
                blockProducts.Add(new FlutterBlockProductModel()
                {
                    //banner = new FlutterBannerModel()
                    //{
                    //    action = "category",
                    //    name = "Váy đầm",
                    //    actionValue = "vay-dam",
                    //    image = "https://khohangsiann.com/wp-content/uploads/si-bao-li-xi-2020.png",
                    //    createdDate = DateTime.Now
                    //},
                    category = block2
                });
            }
            #endregion

            #region Đồ bộ nữ
            var block3 = FlutterCategoryService.Instance.createCategoryBlockProduct("do-bo-nu");
            if (block3 != null)
            {
                blockProducts.Add(new FlutterBlockProductModel()
                {
                    //banner = new FlutterBannerModel()
                    //{
                    //    action = "category",
                    //    name = "Đồ bộ nữ",
                    //    actionValue = "do-bo-nu",
                    //    image = "https://khohangsiann.com/wp-content/uploads/si-bao-li-xi-2020.png",
                    //    createdDate = DateTime.Now
                    //},
                    category = block3
                });
            }
            #endregion

            #region Áo dài cách tân
            var block4 = FlutterCategoryService.Instance.createCategoryBlockProduct("ao-dai-cach-tan");
            if (block4 != null)
            {
                blockProducts.Add(new FlutterBlockProductModel()
                {
                    //banner = new FlutterBannerModel()
                    //{
                    //    action = "category",
                    //    name = "Áo dài cách tân",
                    //    actionValue = "ao-dai-cach-tan",
                    //    image = "https://khohangsiann.com/wp-content/uploads/si-bao-li-xi-2020.png",
                    //    createdDate = DateTime.Now
                    //},
                    category = block4
                });
            }
            #endregion

            #region Áo thung nữ - Sơ mi nữ
            var block5 = FlutterCategoryService.Instance.createCategoryBySlugs(
                "Áo thung nữ - Sơ mi nữ",
                new List<string>() { "ao-thun-nu", "ao-so-mi-nu" }
            );
            blockProducts.Add(new FlutterBlockProductModel()
            {
                //banner = new FlutterBannerModel()
                //{
                //    action = "category",
                //    name = "Áo thung nữ - Sơ mi nữ",
                //    actionValue = "ao-thun-nu",
                //    image = "https://khohangsiann.com/wp-content/uploads/si-bao-li-xi-2020.png",
                //    createdDate = DateTime.Now
                //},
                category = block5
            });
            #endregion

            #region Áo khoác nữ
            var block6 = FlutterCategoryService.Instance.createCategoryBlockProduct("ao-khoac-nu");
            if (block6 != null)
            {
                blockProducts.Add(new FlutterBlockProductModel()
                {
                    //banner = new FlutterBannerModel()
                    //{
                    //    action = "category",
                    //    name = "Áo khoác nữ",
                    //    actionValue = "ao-khoac-nu",
                    //    image = "https://khohangsiann.com/wp-content/uploads/si-bao-li-xi-2020.png",
                    //    createdDate = DateTime.Now
                    //},
                    category = block6
                });
            }
            #endregion

            #region Quần nữ - Đồ lót nữ
            var block7 = FlutterCategoryService.Instance.createCategoryBySlugs(
                "Quần nữ - Đồ lót nữ",
                new List<string>() { "quan-nu", "do-lot-nu" }
            );
            blockProducts.Add(new FlutterBlockProductModel()
            {
                //banner = new FlutterBannerModel()
                //{
                //    action = "category",
                //    name = "Quần nữ - Đồ lót nữ",
                //    actionValue = "quan-nu",
                //    image = "https://khohangsiann.com/wp-content/uploads/si-bao-li-xi-2020.png",
                //    createdDate = DateTime.Now
                //},
                category = block7
            });
            #endregion

            #region Áo thung nam
            var block8 = FlutterCategoryService.Instance.createCategoryBlockProduct("ao-thun-nam");
            if (block8 != null)
            {
                blockProducts.Add(new FlutterBlockProductModel()
                {
                    //banner = new FlutterBannerModel()
                    //{
                    //    action = "category",
                    //    name = "Áo thung nam",
                    //    actionValue = "ao-thun-nam",
                    //    image = "https://khohangsiann.com/wp-content/uploads/si-bao-li-xi-2020.png",
                    //    createdDate = DateTime.Now
                    //},
                    category = block8
                });
            }
            #endregion

            #region Quần nam - Quần lót nam
            var block9 = FlutterCategoryService.Instance.createCategoryBySlugs(
                "Quần nam - Quần lót nam",
                new List<string>() { "quan-nam", "quan-lot-nam" }
            );
            blockProducts.Add(new FlutterBlockProductModel()
            {
                //banner = new FlutterBannerModel()
                //{
                //    action = "category",
                //    name = "Quần nam - Quần lót nam",
                //    actionValue = "quan-nam",
                //    image = "https://khohangsiann.com/wp-content/uploads/si-bao-li-xi-2020.png",
                //    createdDate = DateTime.Now
                //},
                category = block9
            });
            #endregion

            return blockProducts;
        }
    }
}