﻿#pragma checksum "..\..\..\Pages\YcetnPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E638250135B3CBB7E262E0F07EE3B98C98FB2480CC546E98CC29C9EC74D29215"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MDK0101.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace MDK0101.Pages {
    
    
    /// <summary>
    /// YcetnPage
    /// </summary>
    public partial class YcetnPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView YcetnLV;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelBtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefrBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filtTxb;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PoiskTxb;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sort;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExcelBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\YcetnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PdfBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MDK0101;component/pages/ycetnpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\YcetnPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\Pages\YcetnPage.xaml"
            ((MDK0101.Pages.YcetnPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.YcetnLV = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Pages\YcetnPage.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\YcetnPage.xaml"
            this.DelBtn.Click += new System.Windows.RoutedEventHandler(this.DelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RefrBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Pages\YcetnPage.xaml"
            this.RefrBtn.Click += new System.Windows.RoutedEventHandler(this.RefrBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.filtTxb = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Pages\YcetnPage.xaml"
            this.filtTxb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.filtTxb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PoiskTxb = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\Pages\YcetnPage.xaml"
            this.PoiskTxb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PoiskTxb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\YcetnPage.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.sort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\Pages\YcetnPage.xaml"
            this.sort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ExcelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Pages\YcetnPage.xaml"
            this.ExcelBtn.Click += new System.Windows.RoutedEventHandler(this.ExcelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.PdfBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\YcetnPage.xaml"
            this.PdfBtn.Click += new System.Windows.RoutedEventHandler(this.PdfBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 25 "..\..\..\Pages\YcetnPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
