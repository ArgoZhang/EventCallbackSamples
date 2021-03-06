﻿using BootstrapBlazor.Components;
using System.Collections.Generic;

namespace BootstrapBlazorTest.Shared.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MainLayout
    {
        private bool UseTabSet { get; set; } = true;

        private bool IsOpen { get; set; }

        private bool IsFixedHeader { get; set; } = true;

        private bool IsFixedFooter { get; set; } = true;

        private bool IsFullSide { get; set; } = true;

        private bool ShowFooter { get; set; } = true;

        private List<MenuItem> Menus { get; set; }

        /// <summary>
        /// OnInitialized 方法
        /// </summary>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            // TODO: 菜单获取可以通过数据库获取，此处为示例直接拼装的菜单集合
            Menus = GetIconSideMenuItems();
        }

        private List<MenuItem> GetIconSideMenuItems() => new List<MenuItem>
        {
            new MenuItem() { Text = "返回组件库", Icon = "fa fa-fw fa-home", Url = "https://www.blazor.zone/components" },
            new MenuItem() { Text = "Index", Icon = "fa fa-fw fa-fa", Url = "" },
            new MenuItem() { Text = "Counter", Icon = "fa fa-fw fa-check-square-o", Url = "counter" },
            new MenuItem() { Text = "FetchData", Icon = "fa fa-fw fa-database", Url = "fetchdata" },
            new MenuItem() { Text = "Test1", Icon = "fa fa-fw fa-fa", Url = "test1" },
            new MenuItem() { Text = "Test2", Icon = "fa fa-fw fa-fa", Url = "test2" },
            new MenuItem() { Text = "Test3", Icon = "fa fa-fw fa-fa", Url = "test3" },
            new MenuItem() { Text = "Test4", Icon = "fa fa-fw fa-fa", Url = "test4" },
            new MenuItem() { Text = "Test5", Icon = "fa fa-fw fa-fa", Url = "test5" }
        };
    }
}
