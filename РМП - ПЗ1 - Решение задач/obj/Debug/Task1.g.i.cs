﻿#pragma checksum "..\..\Task1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2163E536EA7CDC909D92655FBF27AF6DB8810C95054717D0BC70BED4885C0A5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using РМП___ПЗ1___Решение_задач;


namespace РМП___ПЗ1___Решение_задач {
    
    
    /// <summary>
    /// Task1
    /// </summary>
    public partial class Task1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Task1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_TextTask;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Task1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_Task1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Task1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Input;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Task1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_Input;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Task1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Start;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Task1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_TextResult;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Task1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Close;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Task1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Result;
        
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
            System.Uri resourceLocater = new System.Uri("/РМП - ПЗ1 - Решение задач;component/task1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Task1.xaml"
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
            this.lb_TextTask = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lb_Task1 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.tb_Input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lb_Input = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btn_Start = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Task1.xaml"
            this.btn_Start.Click += new System.Windows.RoutedEventHandler(this.btn_Start_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lb_TextResult = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btn_Close = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Task1.xaml"
            this.btn_Close.Click += new System.Windows.RoutedEventHandler(this.btn_Close_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tb_Result = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

