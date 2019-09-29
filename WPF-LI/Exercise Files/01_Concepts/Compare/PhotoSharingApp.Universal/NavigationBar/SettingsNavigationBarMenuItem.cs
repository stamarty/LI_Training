﻿//-----------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// 
//  The MIT License (MIT)
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//  ---------------------------------------------------------------------------------

using System;
using PhotoSharingApp.Universal.Views;
using Windows.UI.Xaml.Controls;

namespace PhotoSharingApp.Universal.NavigationBar
{
    /// <summary>
    /// Navigation bar menu item that navigates to the
    /// <see cref="SettingsPage" />.
    /// </summary>
    public class SettingsNavigationBarMenuItem : NavigationBarMenuItemBase, INavigationBarMenuItem
    {
        /// <summary>
        /// Gets the type of the destination page.
        /// </summary>
        public Type DestPage
        {
            get { return typeof(SettingsPage); }
        }

        /// <summary>
        /// Gets the title displayed in the navigation bar.
        /// </summary>
        public string Label
        {
            get { return "Settings"; }
        }

        /// <summary>
        /// Gets the positions of the current item in the navigation bar.
        /// </summary>
        public override NavigationBarItemPosition Position
        {
            get { return NavigationBarItemPosition.Bottom; }
        }

        /// <summary>
        /// Gets the symbol that is displayed in the navigation bar.
        /// </summary>
        public override Symbol Symbol
        {
            get { return Symbol.Setting; }
        }
    }
}