﻿#pragma checksum "c:\users\sojit\onedrive\documents\visual studio 2015\Projects\SportsQuiz\SportsQuiz\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A28197660F57BDF9EBAD41D8446CF313"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportsQuiz
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.contentPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "C:\Users\sojit\OneDrive\Documents\Visual Studio 2015\Projects\SportsQuiz\SportsQuiz\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.newQuestion_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.getNewQuestion = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.inputPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.inputPanel2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.greetingOutput = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.loveoption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.option3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "C:\Users\sojit\OneDrive\Documents\Visual Studio 2015\Projects\SportsQuiz\SportsQuiz\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.option3).Click += this.option_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.option4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "C:\Users\sojit\OneDrive\Documents\Visual Studio 2015\Projects\SportsQuiz\SportsQuiz\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.option4).Click += this.option_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.option1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "C:\Users\sojit\OneDrive\Documents\Visual Studio 2015\Projects\SportsQuiz\SportsQuiz\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.option1).Click += this.option_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.option2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "C:\Users\sojit\OneDrive\Documents\Visual Studio 2015\Projects\SportsQuiz\SportsQuiz\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.option2).Click += this.option_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

