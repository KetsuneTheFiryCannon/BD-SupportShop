   M S B A M L   `   `   `  ����>  :PBD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PBDPBD  5   	       PBD.SupportWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:PBD     5   	     � Title$  SupportWindow��5   	   $	��450��6   $	��800��6,    � WindowStartupLocation$ CenterScreen=�68   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SupportList��5   #   $��1��6      SelectionMode$ Single=�68      AutoGenerateColumns$ False��6O      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! ФИО сотрудника��5         Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 5      1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5      �� *Expr2+5        5      $ ФИО клиента��5      $	 130 5      	 5      �� *Expr3+5        5      $+ %Номер тех. поддержки��5      $	 139 5      	 5      �� *Number+5      5!      � 5$   
   $��0��6   
������� 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      �� 5+      
 � RowDefinitions
 5-      �� 5.      �� 5/      $��25 �6    �� 50      �� 51      $��25 �6    �� 52      �� 53      $��25 �6    �� 54      $��50 �6    .+�57      �� $��Сотрудник��6   $��Center=�6)   $��Center=�6F   $��0��6a   $��2��6q   $��0��6�   $��24(�6�   �� 58      -   5         ��Name$ 
EmployeeCB��58      $��0��6+   $��3��6;   $��1��6O   �� 59      $��Клиент��6   $��Center=�6&   $��Center=�6C   $��3��6^   $��3��6n   $��0��6�   $��24(�6�   �� 5:      -   5        $ ClientCB��5:      $��3��6)   $��3��69   $��1��6M   �� 5;      $��
Номер��6   $��Center=�6%   $��Center=�6B   $��0��6]   $��3��6m   $��2��6�   $��24(�6�   �� 5<      -   5         ��Name$ Number��5<      $��0��6&   $��3��66   $��3��6J   �� 5>      -   5         ��Name$ 
SupportAdd��5>      $��0��6)   $��6��69   $��Создать��6_   
�������6q   �� 5?      -   5        $ 
SupportUpd��5?      $��1��6)   $��6��69   $��Изменить��6_   
�������6r   �� 5@      -   5        $ 
SupportDel��5@      $��2��6)   $��6��69   $��Удалить��6_   
�������6q   �� 5A      -   5        $ SupportNext��5A      $��3��6*   $��6��6:   $��
Далее��6a   
�������6q   �� 5B      -	   5        $ SupportFind��5B      $��4��6*   $��6��6:   $��
Найти��6a   
�������6q   �� 5C      -
   5        $ SupportBack��5C      $��5��6*   $��6��6:   $��
Назад��6a   
�������6q   5D      5E      5F      