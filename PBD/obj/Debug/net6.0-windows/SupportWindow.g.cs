﻿#pragma checksum "..\..\..\SupportWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ED9401170D04EF9481F745CFCF0485E9F2A1605E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PBD;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PBD {
    
    
    /// <summary>
    /// SupportWindow
    /// </summary>
    public partial class SupportWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SupportList;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EmployeeCB;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClientCB;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Number;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SupportAdd;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SupportUpd;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SupportDel;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SupportNext;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SupportFind;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\SupportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SupportBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PBD;component/supportwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SupportWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SupportList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.EmployeeCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ClientCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Number = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SupportAdd = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\SupportWindow.xaml"
            this.SupportAdd.Click += new System.Windows.RoutedEventHandler(this.SupportAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SupportUpd = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\SupportWindow.xaml"
            this.SupportUpd.Click += new System.Windows.RoutedEventHandler(this.SupportUpd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SupportDel = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\SupportWindow.xaml"
            this.SupportDel.Click += new System.Windows.RoutedEventHandler(this.SupportDel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SupportNext = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\SupportWindow.xaml"
            this.SupportNext.Click += new System.Windows.RoutedEventHandler(this.SupportNext_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SupportFind = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\SupportWindow.xaml"
            this.SupportFind.Click += new System.Windows.RoutedEventHandler(this.SupportFind_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SupportBack = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\SupportWindow.xaml"
            this.SupportBack.Click += new System.Windows.RoutedEventHandler(this.SupportBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
