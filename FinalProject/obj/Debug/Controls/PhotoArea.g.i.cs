﻿#pragma checksum "C:\Users\vic\Documents\Visual Studio 2010\Projects\GPS(1)\GPS\Controls\PhotoArea.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D9B1DCDFB8916AD3BF96FB9BBE6B85E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace GPS.Controls {
    
    
    public partial class PhotoArea : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image currentPhoto;
        
        internal System.Windows.Controls.Border txtConvertingMessageWrapper;
        
        internal System.Windows.Controls.TextBlock txtConvertingMessage;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/GPS;component/Controls/PhotoArea.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.currentPhoto = ((System.Windows.Controls.Image)(this.FindName("currentPhoto")));
            this.txtConvertingMessageWrapper = ((System.Windows.Controls.Border)(this.FindName("txtConvertingMessageWrapper")));
            this.txtConvertingMessage = ((System.Windows.Controls.TextBlock)(this.FindName("txtConvertingMessage")));
        }
    }
}
