#pragma checksum "..\..\..\ClientWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8B24A4D7A95771CA2546D6DB5F2DAC9965A2033B"
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
    /// ClientWindow
    /// </summary>
    public partial class ClientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ClientList;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Firstname;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Secondname;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Thirdname;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientAdd;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientUpd;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientDel;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientNext;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientFind;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientBack;
        
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
            System.Uri resourceLocater = new System.Uri("/PBD;component/clientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ClientWindow.xaml"
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
            this.ClientList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Firstname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Secondname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Thirdname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ClientAdd = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\ClientWindow.xaml"
            this.ClientAdd.Click += new System.Windows.RoutedEventHandler(this.ClientAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ClientUpd = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\ClientWindow.xaml"
            this.ClientUpd.Click += new System.Windows.RoutedEventHandler(this.ClientUpd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ClientDel = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\ClientWindow.xaml"
            this.ClientDel.Click += new System.Windows.RoutedEventHandler(this.ClientDel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ClientNext = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\ClientWindow.xaml"
            this.ClientNext.Click += new System.Windows.RoutedEventHandler(this.ClientNext_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ClientFind = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\ClientWindow.xaml"
            this.ClientFind.Click += new System.Windows.RoutedEventHandler(this.ClientFind_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ClientBack = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\ClientWindow.xaml"
            this.ClientBack.Click += new System.Windows.RoutedEventHandler(this.ClientBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

