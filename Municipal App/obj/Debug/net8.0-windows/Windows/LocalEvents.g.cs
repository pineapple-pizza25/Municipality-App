﻿#pragma checksum "..\..\..\..\Windows\LocalEvents.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CFC479E3BC20CFB6858317FE15D40EF1E42C486B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Municipal_App.Windows;
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


namespace Municipal_App.Windows {
    
    
    /// <summary>
    /// LocalEvents
    /// </summary>
    public partial class LocalEvents : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\Windows\LocalEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Windows\LocalEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\LocalEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFilterCategory;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Windows\LocalEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCategory;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Windows\LocalEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spEvents;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Windows\LocalEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spEventDetails;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Windows\LocalEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Windows\LocalEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Municipal App;component/windows/localevents.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\LocalEvents.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Windows\LocalEvents.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnFilterCategory = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Windows\LocalEvents.xaml"
            this.btnFilterCategory.Click += new System.Windows.RoutedEventHandler(this.btnFilterCategory_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.spEvents = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.spEventDetails = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\Windows\LocalEvents.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\Windows\LocalEvents.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.btnClear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

