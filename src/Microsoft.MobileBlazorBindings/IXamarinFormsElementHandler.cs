// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.MobileBlazorBindings.Core;
using XF = Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings
{
    public interface IXamarinFormsElementHandler : IElementHandler
    {
        XF.Element ElementControl { get; }
    }
}
