// Updated by XamlIntelliSenseFileGenerator 07.12.2021 11:06:48
#pragma checksum "..\..\..\Window\EditPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB23F09785541B2155547C8784F5C30C0F9E589AA6C2E1605DE4341BED04D82F"
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
using WPF_SQL.Pages;


namespace WPF_SQL
{


    /// <summary>
    /// EditPage
    /// </summary>
    public partial class EditPage : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 19 "..\..\..\Window\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBOXName;

#line default
#line hidden


#line 22 "..\..\..\Window\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBOXSurname;

#line default
#line hidden


#line 25 "..\..\..\Window\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBOXSeсondname;

#line default
#line hidden


#line 28 "..\..\..\Window\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBgender;

#line default
#line hidden


#line 31 "..\..\..\Window\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bchange;

#line default
#line hidden


#line 32 "..\..\..\Window\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lback;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_SQL;component/window/editpage.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Window\EditPage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.TBOXName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.TBOXSurname = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.TBOXSeсondname = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.CBgender = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 5:
                    this.Bchange = ((System.Windows.Controls.Button)(target));

#line 31 "..\..\..\Window\EditPage.xaml"
                    this.Bchange.Click += new System.Windows.RoutedEventHandler(this.Bchange_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.Lback = ((System.Windows.Controls.Label)(target));

#line 32 "..\..\..\Window\EditPage.xaml"
                    this.Lback.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Lback_MouseLeftButtonUp);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}
