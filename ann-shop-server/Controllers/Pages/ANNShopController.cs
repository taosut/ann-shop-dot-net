﻿using ann_shop_server.Models;
using ann_shop_server.Services.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ann_shop_server.Controllers
{
    [RoutePrefix("api/v1/home")]
    public class ANNShopController : ApiController
    {
        private HomeService _service;

        public ANNShopController()
        {
            _service = HomeService.Instance;
        }

        /// <summary>
        /// Lấy sản phẩm theo slug category
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="pagingParameterModel"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("category/{*slug}")]
        public IHttpActionResult GetProducts(string slug, [FromUri]PagingParameterModel pagingParameterModel)
        {
            var pagination = new PaginationMetadataModel()
            {
                currentPage = pagingParameterModel.pageNumber,
                pageSize = pagingParameterModel.pageSize
            };
            var products = _service.getProducts(slug, ref pagination);

            if (products == null)
                return NotFound();

            // Setting Header
            HttpContext.Current.Response.Headers.Add("Access-Control-Expose-Headers", "X-Paging-Headers");
            HttpContext.Current.Response.Headers.Add("X-Paging-Headers", JsonConvert.SerializeObject(pagination));

            // Returing List of product Collections
            return Ok<List<HomeProductModel>>(products);
        }
    }
}