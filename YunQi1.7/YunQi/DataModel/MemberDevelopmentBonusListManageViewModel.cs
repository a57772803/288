﻿using System.Collections.Generic;

namespace DataModel
{
    public class MemberDevelopmentBonusListManageViewModel
    {
        public List<MemberDevelopmentBonusListViewModel> listMemberDevelopmentBonusListViewModel { get; set; }
        public int CurrentPage { get; set; }   // 目前頁
        public int TotalPages { get; set; }    // 總頁數
        public int PageCount { get; set; }     // 分頁頁碼連結總數
        public int StartPage { get; set; }     // 分頁頁碼起始值
        public int LinkType { get; set; }
        public string Url { get; set; }
        public string AClass { get; set; }     // 超連結Class
        public int Parameters { get; set; }
        public long BonusListCount { get; set; }   //測試用
    }
}