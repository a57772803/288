﻿using System;
using System.Collections.Generic;

namespace DataModel
{
    public class MemberOrderListManageViewModel
    {
        public List<OrderListViewModel> listOrderListViewModel { get; set; }
        public int CurrentPage { get; set; }   // 目前頁
        public int TotalPages { get; set; }    // 總頁數
        public int PageCount { get; set; }     // 分頁頁碼連結總數
        public int StartPage { get; set; }     // 分頁頁碼起始值
        public int LinkType { get; set; }
        public string Url { get; set; }
        public string AClass { get; set; }     // 超連結Class
        public string OrderId { get; set; }
        public Byte OrderStateId { get; set; }
        public string Product { get; set; }
        public DateTime? sDate { get; set; }
        public DateTime? eDate { get; set; }
        //public SortedList<string, object> Parameters { get; set; }          // 查訽參數
        //public List<MemberLevelsViewModel> listMemberLevelsViewModel { get; set; }  // 會員層級資料

        //20181225 ---棋
        public int id { get; set; }
    }
}