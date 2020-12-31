// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BootstrapBlazorTest.Shared.Pages
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Test1 : ComponentBase, IDisposable
    {
        private ElementReference TableElement { get; set; }

        private int CurrentRowIndex { get; set; }

        private JSInterop<Test1> Interop { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        /// <summary>
        /// OnAfterRenderAsync
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                Interop = new JSInterop<Test1>(JSRuntime);
                await Interop.Invoke(this, TableElement, "table_test", nameof(Update));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        [JSInvokable]
        public void Update(int index)
        {
            CurrentRowIndex = index;
        }

        private void UpdatePage()
        {

        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                Interop?.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
