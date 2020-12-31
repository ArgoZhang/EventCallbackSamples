// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using System;

namespace BootstrapBlazorTest.Shared.Pages
{
    class RowClickEvent
    {
        public delegate void RowClickEventHandler();

        /// <summary>
        /// 
        /// </summary>
        public void Reset()
        {
            if(ResetActive != null)
            {
                ResetActive();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public event RowClickEventHandler ResetActive;
    }
}
