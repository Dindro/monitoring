﻿#pragma checksum "..\..\NumericUpDown.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1D37FC21DC83AA388EA6A3943CC1A679"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MONITORING;
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


namespace MONITORING {
    
    
    /// <summary>
    /// NumericUpDown
    /// </summary>
    public partial class NumericUpDown : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\NumericUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxValue;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\NumericUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Increase;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\NumericUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Decrease;
        
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
            System.Uri resourceLocater = new System.Uri("/MONITORING;component/numericupdown.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NumericUpDown.xaml"
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
            this.TextBoxValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\NumericUpDown.xaml"
            this.TextBoxValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.value_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 20 "..\..\NumericUpDown.xaml"
            this.TextBoxValue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.value_TextChanged);
            
            #line default
            #line hidden
            
            #line 20 "..\..\NumericUpDown.xaml"
            this.TextBoxValue.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.value_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Increase = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\NumericUpDown.xaml"
            this.Increase.Click += new System.Windows.RoutedEventHandler(this.Increase_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Decrease = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\NumericUpDown.xaml"
            this.Decrease.Click += new System.Windows.RoutedEventHandler(this.Decrease_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
