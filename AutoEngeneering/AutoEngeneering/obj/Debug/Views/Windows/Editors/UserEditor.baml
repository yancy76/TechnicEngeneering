   M S B A M L   `   `   `  ����J  FAutoEngeneering, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:AutoEngeneering.Views.Windows.Editors%AutoEngeneering.Views.Windows.Editors  5   	   6    0AutoEngeneering.Views.Windows.Editors.UserEditor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:AutoEngeneering.Views.Windows.Editors     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Редактор��5   	   $	��450��6   $	��400��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      .+�5   
   �� $/��)Редактор пользователя��6   $��Center=�61   $��Center=�6L   $��24(�6i   $��2��6w   �� 5   
   $��
Логин��6   $��1��6!   $��20(�6.   �� 5   
   -   5         ��Name$ LoginBox��5      $��1��6$   $��1��61   �� 5   
   $��Пароль��6   $��2��6"   $��20(�6/   �� 5   
   -   5        $ PasswordBox��5      $��2��6'   $��1��64   �� 5   
   $��Сотрудник��6   $��3��6%   $��20(�62   �� 5   
   -   5         ��Name$ EmployeeBox��5      $��3��6(   $��1��65    �� SelectedValuePath$ id��6E   �� 5!   
   -   5         ��Name$ 
saveButton��5!      $��Сохранить��6%   $��4��69   $��2��6F   6Z   5"      5#      