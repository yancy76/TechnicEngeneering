   M S B A M L   `   `   `  ����J  FAutoEngeneering, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:AutoEngeneering.Views.Windows.Editors%AutoEngeneering.Views.Windows.Editors  5   	   >    8AutoEngeneering.Views.Windows.Editors.TechnicTypesEditor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:AutoEngeneering.Views.Windows.Editors     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Редактор��5      $	��150��6   $	��400��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      .+�5   
   �� $#��Редактор детали��6   $��Center=�6+   $��Center=�6F   $��24(�6c   $��2��6q   �� 5   
   $��Название��6   $��1��6$   $��20(�61   �� 5   
   -   5         ��Name$ TitleBox��5      $��1��6$   $��1��61   �� 5   
   -   5         ��Name$ 
saveButton��5      $��Сохранить��6%   $��5��69   $��2��6F   6Z   5      5      