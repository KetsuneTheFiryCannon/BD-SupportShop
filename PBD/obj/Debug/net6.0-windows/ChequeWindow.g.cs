#pragma checksum "..\..\..\ChequeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F787EA09E60CA9403E172A987E19A6F5AD5BFB49"
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
    /// ChequeWindow
    /// </summary>
    public partial class ChequeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\ChequeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ChequeList;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\ChequeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Numbercb;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\ChequeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\ChequeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChequeAdd;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\ChequeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChequeUpd;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\ChequeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChequeDel;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\ChequeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChequeNext;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\ChequeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChequeFind;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\ChequeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChequeBack;
        
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
            System.Uri resourceLocater = new System.Uri("/PBD;component/chequewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChequeWindow.xaml"
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
            this.ChequeList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Numbercb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ChequeAdd = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\ChequeWindow.xaml"
            this.ChequeAdd.Click += new System.Windows.RoutedEventHandler(this.ChequeAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ChequeUpd = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\ChequeWindow.xaml"
            this.ChequeUpd.Click += new System.Windows.RoutedEventHandler(this.ChequeUpd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ChequeDel = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\ChequeWindow.xaml"
            this.ChequeDel.Click += new System.Windows.RoutedEventHandler(this.ChequeDel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ChequeNext = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\ChequeWindow.xaml"
            this.ChequeNext.Click += new System.Windows.RoutedEventHandler(this.ChequeNext_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ChequeFind = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\ChequeWindow.xaml"
            this.ChequeFind.Click += new System.Windows.RoutedEventHandler(this.ChequeFind_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ChequeBack = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\ChequeWindow.xaml"
            this.ChequeBack.Click += new System.Windows.RoutedEventHandler(this.ChequeBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

