﻿#pragma checksum "..\..\..\..\..\Views\Windows\Editors\ComponentEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5858FFF6A106326E5920864DF9CEC2839961AF96E13A341DC54759338AFEB4C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoEngeneering.Views.Windows.Editors;
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


namespace AutoEngeneering.Views.Windows.Editors {
    
    
    /// <summary>
    /// ComponentEditor
    /// </summary>
    public partial class ComponentEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\Views\Windows\Editors\ComponentEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Views\Windows\Editors\ComponentEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VolumeBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Views\Windows\Editors\ComponentEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MaterialBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Views\Windows\Editors\ComponentEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TechnicBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\Views\Windows\Editors\ComponentEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoEngeneering;component/views/windows/editors/componenteditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Windows\Editors\ComponentEditor.xaml"
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
            this.TitleBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.VolumeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MaterialBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.TechnicBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\Views\Windows\Editors\ComponentEditor.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.saveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

