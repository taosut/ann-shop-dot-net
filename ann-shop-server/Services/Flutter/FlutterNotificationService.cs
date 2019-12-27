﻿using ann_shop_server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ann_shop_server.Services
{
    public class FlutterNotificationService: Service<FlutterNotificationService>
    {
        #region  Hard code Test
        /// <summary>
        /// Thông báo đổi hàng cuối năm
        /// </summary>
        /// <returns></returns>
        private NotificationModel getNotification1()
        {
            var summary = String.Empty;
            summary += "😻 Nói thẳng luôn, chỉ có ANN mới dám làm điều này!\n";
            summary += "🌼🌸🌺 Bên kho em nhận đổi trả hàng đến ngày nghỉ tết luôn (15h ngày 21/1/2020) và qua Tết vẫn nhận đổi trả hàng của năm nay luôn nhé mọi người!\n";
            summary += "👉 Mọi năm thì tháng cuối năm ANN không nhận đổi trả hàng và qua năm mới không nhận đổi hàng của năm cũ. Nhưng năm nay ANN 'chơi lớn' thật rồi... ông giáo ạ, à không quý khách ạ! 😜";

            var content = new StringBuilder();
            content.AppendLine("<p style='text-align: center;'><img alt='Đổi hàng cuối năm' src='/uploads/doi-hang-cuoi-nam/doi-hang-cuoi-nam-2.png'></p>");
            content.AppendLine("<p> 😻 Nói thẳng luôn, chỉ có ANN mới dám làm điều này!</p>");
            content.AppendLine("<p> 🌼🌸🌺 Bên kho em nhận đổi trả hàng đến ngày nghỉ tết luôn (15h ngày 21/1/2020) và qua Tết vẫn nhận đổi trả hàng của năm nay luôn nhé mọi người!</p>");
            content.AppendLine("<p> 👉 Mọi năm thì tháng cuối năm ANN không nhận đổi trả hàng và qua năm mới không nhận đổi hàng của năm cũ. Nhưng năm nay ANN 'chơi lớn' thật rồi... ông giáo ạ, à không quý khách ạ! 😜</p><p ☘ Vẫn là quy định đổi hàng trong 30 ngày kể từ ngày mua hàng (bao gồm ngày nghĩ tết).</p><p 🤝 ANN đã chấp nhận 'chơi lớn' với khách hàng rồi thì mọi người vui lòng 'chơi đẹp' giúp bên em nha! Hàng gì bán chậm hoặc bị lỗi thì tranh thủ đổi càng sớm càng tốt, chứ đừng 'ngâm' quá hạn là bên em không nhận được đâu á!</p>");
            content.AppendLine("<p> 🏵️🌻🌺 Chúc mọi người một mùa Tết bán hàng đắt 'mệt xỉu', và năm mới 'tiền tài danh vọng' điều có đủ hết nha!</p>");

            return new NotificationModel()
            {
                kind = "notification",
                title = "Thông báo đổi hàng cuối năm",
                slug = "doi-hang-cuoi-nam",
                avatar = "/uploads/doi-hang-cuoi-nam/doi-hang-cuoi-nam-3.png",
                summary = summary,
                content = content.ToString(),
                createdDate = DateTime.Now
            };
        }

        /// <summary>
        /// Thông báo thời gian làm việc
        /// </summary>
        /// <returns></returns>
        private NotificationModel getNotification2()
        {
            var summary = String.Empty;
            summary += "Chúng tôi xin thông báo thời gian làm việc để có thể phục vụ khách hàng tốt hơn";


            return new NotificationModel()
            {
                kind = "news",
                title = "Thông báo thời gian làm việc",
                slug = "doi-hang-cuoi-nam",
                avatar = "https://khohangsiann.com/wp-content/uploads/thoi-gian-lam-viec-tet-small.png",
                summary = summary,
                content = summary,
                createdDate = DateTime.Now
            };
        }

        /// <summary>
        /// Thông báo thời gian làm việc
        /// </summary>
        /// <returns></returns>
        private NotificationModel getNotification3()
        {
            var summary = String.Empty;
            summary += "Nhằm cảm ơn sụ ủng hộ và quan tâm khách hàng với công ty chúng tôi.\n";
            summary += "Nay công ty ANN xin đưa ra một loạt các chương trình khuyên mãi siêu khủng.\n";
            summary += "Nào cùng click vào để xem các chương trình khuyến mãi nè!.\n";


            return new NotificationModel()
            {
                kind = "promotion",
                title = "Thông báo khuyến mãi tri ân khách hàng",
                slug = "thoi-gian-lam-viec",
                avatar = "https://ann.com.vn/wp-content/uploads/quan-ao-tet-2020.jpg",
                summary = summary,
                content = summary,
                createdDate = DateTime.Now
            };
        }
        #endregion

        public List<FlutterBannerModel> getHomeNotification()
        {
            var result = new List<FlutterBannerModel>();

            // Thông báo đổi hàng cuối năm
            var notification1 = getNotification1();
            result.Add(new FlutterBannerModel()
            {
                action = "category",
                category = notification1.kind,
                name = notification1.title,
                actionValue = notification1.slug,
                image = notification1.avatar,
                message = notification1.summary,
                createdDate = notification1.createdDate
            });

            // Thông báo thời gian làm việc
            var notification2 = getNotification2();
            result.Add(new FlutterBannerModel()
            {
                action = "category",
                category = notification2.kind,
                name = notification2.title,
                actionValue = notification2.slug,
                image = notification2.avatar,
                message = notification2.summary,
                createdDate = notification2.createdDate
            });

            // Thông báo khuyến mãi tri ân khách hàng
            var notification3 = getNotification3();
            result.Add(new FlutterBannerModel()
            {
                action = "category",
                category = notification3.kind,
                name = notification3.title,
                actionValue = notification3.slug,
                image = notification3.avatar,
                message = notification3.summary,
                createdDate = notification3.createdDate
            });

            return result;
        }

        public List<FlutterNotificationCardModel> getNotifications(FlutterNotificationFilterModel filter, ref PaginationMetadataModel pagination)
        {
            var data = new List<NotificationModel>()
            {
                getNotification1(),
                getNotification2(),
                getNotification3()
            }
            .Select(x => new FlutterNotificationCardModel()
            {
                kind = x.kind,
                title = x.title,
                slug = x.slug,
                avatar = x.avatar,
                summary = x.summary,
                createdDate = x.createdDate
            })
            .ToList();

            // Lọc theo thể lại thông báo
            if (!String.IsNullOrEmpty(filter.kind))
            {
                data = data.Where(x => x.kind.Trim().ToLower() == filter.kind.Trim().ToLower()).ToList();
            }

            // Lọc theo slug thông báo
            if (!String.IsNullOrEmpty(filter.slug))
            {
                data = data.Where(x => x.slug == filter.slug).ToList();
            }

            // Lấy tổng số record sản phẩm
            pagination.totalCount = data.Count();

            // Calculating Totalpage by Dividing (No of Records / Pagesize)
            pagination.totalPages = (int)Math.Ceiling(pagination.totalCount / (double)pagination.pageSize);

            var result = data
                .Skip((pagination.currentPage - 1) * pagination.pageSize)
                .Take(pagination.pageSize)
                .ToList();

            // if CurrentPage is greater than 1 means it has previousPage
            pagination.previousPage = pagination.currentPage > 1 ? "Yes" : "No";

            // if TotalPages is greater than CurrentPage means it has nextPage
            pagination.nextPage = pagination.currentPage < pagination.totalPages ? "Yes" : "No";

            return result;
        }


        public FlutterNotificationModel getNotificationBySlug (string slug)
        {
            if (String.IsNullOrEmpty(slug))
                return null;

            var data = new List<NotificationModel>()
            {
                getNotification1(),
                getNotification2(),
                getNotification3()
            }
            .Select(x => new FlutterNotificationModel()
            {
                title = x.title,
                slug = x.slug,
                content = x.content,
                createdDate = x.createdDate
            })
            .ToList();

            return data.Where(x => x.slug == slug).FirstOrDefault();
        }
    }
}