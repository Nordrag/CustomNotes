   M S B A M L   `   `   `  ����F  BCustomNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CustomNotesCustomNotes  5           CustomNotes.CustomNoteView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      %localclr-namespace:CustomNotes  5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0��6,   $��10 0 0 0q�6<   .+�5      �� $ 
Horizontal=�6   $��10 0 0 0q�62   .+�5      �� $
��Cím��6   ���	#FF2196F3$
��Bold"�6=   $��Bottom=�6O   $��16(�6j   �� 5      $��10 0 0 0q�6D   $	��200��6V   ���	#FF2196F3$
��Bold"�6y   ���	#FF2196F3��6   �� *Custom.CustomModel.Title+6�   5      �� 5      $ Vertical=�6   $��0 20 0 0q�60   .+�5      �� $��Leírás��6   ���	#FF2196F3$
��Bold"�6@   $��Bottom=�6R   $��16(�6m   �� 5      $	��350��6J   $	��300��6W    �� TextWrapping$
 Wrap=�6f    �� AcceptsReturn$
 True��6z    �� 
AcceptsTab$
 True��6�   $��1q�6�   ���	#FF2196F3$
��Bold"�6�   ���	#FF2196F3$��16(�6�   ��6   �� * Custom.CustomModel.Description+6�   5      5      �� 5   
   $��1��6   $ Vertical=�6%   .+�5      �� $ 
Horizontal=�6   $��Center=�62   $��0 20 0 0q�6O   .+�5      �� $��
Relevancia��6   ���	#FF2196F3$
��Bold"�6D   $��Bottom=�6V   $��16(�6q   �� 5      ���	#FF2196F3���	#FF2196F3$��10 0 0 0q�6J   
������ ��6u   �� *Custom.RelevanceList+ �� SelectedItem 6�   �� *Custom.CustomModel.Relevance+5      �� 5      $ 
Horizontal=�6   $��Center=�62   $��0 20 0 0q�6O   .+�5      �� $��Címke��6   ���	#FF2196F3$
��Bold"�6?   $��Bottom=�6Q   $��16(�6l   �� 5       ���	#FF2196F3���	#FF2196F3$��10 0 0 0q�6J   
������ ��6u   �� *Custom.TagList+ 6�   �� *Custom.CustomModel.Tag+5!      �� 5"      $ Vertical=�6   $��Center=�60   $��0 30 0 0q�6M   .+�5#      �� $��vagy egyéni címke��6   ���	#FF2196F3$
��Bold"�6K   $��Bottom=�6]   $��16(�6x   �� 5$      ���	#FF2196F3$
��Bold"�61   $��Bottom=�6C   $��16(�6^   ���	#FF2196F3��6�   �� *Custom.CustomModel.CustomTag+5%      �� 5&      $��Lezár��6   $	��100��6%   $	��100��61   $��0 30 0 0q�6>   5'      5(      5)      