   M S B A M L   `   `   `  ����J  FAutoEngeneering, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:AutoEngeneering.Views.Windows.Editors%AutoEngeneering.Views.Windows.Editors  5   	   :    4AutoEngeneering.Views.Windows.Editors.EmployeeEditor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:AutoEngeneering.Views.Windows.Editors     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Редактор��5   	   $	��550��6   $	��400��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      .+�5   
   �� $+��%Редактор сотрудника��6   $��Center=�6/   $��Center=�6J   $��24(�6g   $��2��6u   �� 5   
   $��Имя��6   $��1��6   $��20(�6,   �� 5   
   -   5         ��Name$ FirstNameBox��5      $��1��6(   $��1��65   �� 5   
   $��Фамилия��6   $��2��6#   $��20(�60   �� 5   
   -   5        $ LastName��5      $��2��6$   $��1��61   �� 5   
   $��Отчество��6   $��3��6$   $��20(�61   �� 5    
   -   5        $ 
MiddleName��5       $��3��6&   $��1��63   �� 5"   
   $��Должность��6   $��4��6%   $��20(�62   �� 5#   
   -   5         ��Name$ PositionBox��5#      $��4��6(   $��1��65   .@�5$      �� $ ��Администратор��6   
 � Tag$ 1��63   �� 5%      $��Инженер��6   $ 2��6-   5&      �� 5(   
   -   5         ��Name$ 
saveButton��5(      $��Сохранить��6%   $��5��69   $��2��6F   6Z   5)      5*      