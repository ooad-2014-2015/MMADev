﻿#pragma checksum "..\..\KoZnaZnaTeski.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "841D775627A110293DF77ACF471C41E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace Igrica {
    
    
    /// <summary>
    /// KoZnaZnaTeski
    /// </summary>
    public partial class KoZnaZnaTeski : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\KoZnaZnaTeski.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pitanje;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\KoZnaZnaTeski.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prviOdg;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\KoZnaZnaTeski.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button drugiOdg;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\KoZnaZnaTeski.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button treciOdg;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\KoZnaZnaTeski.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cetvrtiOdg;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\KoZnaZnaTeski.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sljedecePitanje;
        
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
            System.Uri resourceLocater = new System.Uri("/Igrica;component/koznaznateski.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KoZnaZnaTeski.xaml"
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
            
            #line 4 "..\..\KoZnaZnaTeski.xaml"
            ((Igrica.KoZnaZnaTeski)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pitanje = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.prviOdg = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\KoZnaZnaTeski.xaml"
            this.prviOdg.Click += new System.Windows.RoutedEventHandler(this.prviOdg_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.drugiOdg = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\KoZnaZnaTeski.xaml"
            this.drugiOdg.Click += new System.Windows.RoutedEventHandler(this.drugiOdg_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.treciOdg = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\KoZnaZnaTeski.xaml"
            this.treciOdg.Click += new System.Windows.RoutedEventHandler(this.treciOdg_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cetvrtiOdg = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\KoZnaZnaTeski.xaml"
            this.cetvrtiOdg.Click += new System.Windows.RoutedEventHandler(this.cetvrtiOdg_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.sljedecePitanje = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\KoZnaZnaTeski.xaml"
            this.sljedecePitanje.Click += new System.Windows.RoutedEventHandler(this.sljedecePitanje_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

