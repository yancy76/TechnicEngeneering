﻿#pragma checksum "..\..\..\..\Views\Windows\BaseWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C19C50484869FB9D0017A1C3BB23694B8F9F00BD8C14ACB6E732FDCAD5C67D23"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoEngeneering.Views.Windows;
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


namespace AutoEngeneering.Views.Windows {
    
    
    /// <summary>
    /// BaseWindow
    /// </summary>
    public partial class BaseWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Views\Windows\BaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\Windows\BaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UsersButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\Windows\BaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EmployeesButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\Windows\BaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MaterialsButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\Windows\BaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ComponentsButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\Windows\BaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DevicesTypesButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\Windows\BaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameBox;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoEngeneering;component/views/windows/basewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Windows\BaseWindow.xaml"
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
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Views\Windows\BaseWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UsersButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Views\Windows\BaseWindow.xaml"
            this.UsersButton.Click += new System.Windows.RoutedEventHandler(this.UsersButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EmployeesButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Views\Windows\BaseWindow.xaml"
            this.EmployeesButton.Click += new System.Windows.RoutedEventHandler(this.EmployeesButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MaterialsButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Views\Windows\BaseWindow.xaml"
            this.MaterialsButton.Click += new System.Windows.RoutedEventHandler(this.MaterialsButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ComponentsButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Views\Windows\BaseWindow.xaml"
            this.ComponentsButton.Click += new System.Windows.RoutedEventHandler(this.ComponentsButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DevicesTypesButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Views\Windows\BaseWindow.xaml"
            this.DevicesTypesButton.Click += new System.Windows.RoutedEventHandler(this.DevicesTypesButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FrameBox = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

