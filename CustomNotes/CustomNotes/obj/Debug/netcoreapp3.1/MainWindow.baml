   M S B A M L   `   `   `  ����F  BCustomNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CustomNotesCustomNotes  5   	       CustomNotes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:CustomNotes  5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6      CaptionHeight$ 0Q�6/      CornerRadius$ 6��6A    � DataContext 5      &    CustomNotes.ApplicationViewModel  5   
   .��5      � ��5   
   �� 5       �� ImageSource$ darkpaper2.jpg��6   	 j� Stretch$	 UniformToFill=�66   
 � ColumnDefinitions
 5   
   �� 5      -   5         ��Name$ SideMenu��5   ?   ��6   �� *SideMenuWidth+6?   �� 5      $��* �6   .+�5   
   ]� $��1��6   .+�5      7  1MaterialDesignThemes.Wpf.Transitions.Transitioner  !   AutoApplyTransitionOrigins$
 True��6P    �� SelectedIndex 6*   �� *CurrentPage+.@�5          CustomNotes.LoginView     CustomNotes.RegisterView  5!      !   CustomNotes.NewCashDiffView  5"          CustomNotes.CustomNoteView  5#         CustomNotes.SeachView  5$      	   CustomNotes.LandingView	  5%      5&      5'      �� 5(   
    �� Orientation$ Vertical=�6   .+�5)      �� $��Napi Eltérés��6   ��6,   �� *NewCashDiff+�� 5*      $��Egyéni��6   ��6&   �� *	NewCustom+�� 5+      $��Keres��6   ��6%   �� *Search+5,      �� 5-   
   -   5        $��Kilép��5-      $��Bottom=�66   5.      5/      