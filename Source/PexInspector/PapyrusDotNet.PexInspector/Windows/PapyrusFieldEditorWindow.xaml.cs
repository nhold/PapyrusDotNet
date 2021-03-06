﻿//     This file is part of PapyrusDotNet.
// 
//     PapyrusDotNet is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     PapyrusDotNet is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with PapyrusDotNet.  If not, see <http://www.gnu.org/licenses/>.
//  
//     Copyright 2016, Karl Patrik Johansson, zerratar@gmail.com

#region

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PapyrusDotNet.PexInspector.ViewModels;

#endregion

namespace PapyrusDotNet.PexInspector.Windows
{
    /// <summary>
    ///     Interaction logic for PapyrusParameterAndVariableEditorWindow.xaml
    /// </summary>
    public partial class PapyrusFieldEditorWindow : Window
    {
        public PapyrusFieldEditorWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var vm = DataContext;
            var varEdit = vm as PapyrusVariableEditorViewModel;
            if (varEdit != null)
            {
                varEdit.SelectedTypeName = typeRef.Text;
            }
            var parEdit = vm as PapyrusParameterEditorViewModel;
            if (parEdit != null)
            {
                parEdit.SelectedTypeName = typeRef.Text;
            }
        }

        private void UIElement_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Return) DialogResult = true;
        }
    }
}