﻿#pragma checksum "..\..\..\..\..\WPF\Controls\NodeControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E017560163B40B7352D70073FA385B00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using System.Windows.Forms.Integration;
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
using VisLab.WPF;


namespace VisLab.WPF {
    
    
    /// <summary>
    /// NodeControl
    /// </summary>
    public partial class NodeControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 8 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisLab.WPF.NodeControl nodeCtrl;
        
        #line default
        #line hidden
        
        
        #line 303 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        
        #line 304 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander expander;
        
        #line default
        #line hidden
        
        
        #line 306 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid2;
        
        #line default
        #line hidden
        
        
        #line 311 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl1;
        
        #line default
        #line hidden
        
        
        #line 312 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl2;
        
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
            System.Uri resourceLocater = new System.Uri("/VisLab;component/wpf/controls/nodecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
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
            this.nodeCtrl = ((VisLab.WPF.NodeControl)(target));
            return;
            case 4:
            this.border = ((System.Windows.Controls.Border)(target));
            
            #line 303 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
            this.border.MouseLeave += new System.Windows.Input.MouseEventHandler(this.border_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.expander = ((System.Windows.Controls.Expander)(target));
            
            #line 305 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
            this.expander.Collapsed += new System.Windows.RoutedEventHandler(this.expander_Collapsed);
            
            #line default
            #line hidden
            
            #line 305 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
            this.expander.Expanded += new System.Windows.RoutedEventHandler(this.expander_Expanded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.grid2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.lbl1 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lbl2 = ((System.Windows.Controls.Label)(target));
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
            case 2:
            
            #line 208 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ellipse_MouseUp);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 210 "..\..\..\..\..\WPF\Controls\NodeControl.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ellipse_MouseUp);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

