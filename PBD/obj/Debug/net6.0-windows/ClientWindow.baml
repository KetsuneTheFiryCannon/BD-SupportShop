   M S B A M L   `   `   `  ����>  :PBD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PBDPBD  5   	       PBD.ClientWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:PBD     5   	     � Title$  ClientWindow��5   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
ClientList��5   #   $��1��6      SelectionMode$ Single=�67      AutoGenerateColumns$ False��6N      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��5         Width5  /System.Windows.Controls.DataGridLengthConverter$	 133 5      1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5      �� *	Firstname+5        5      $ Имя��5      $	 133 5      	 5      �� *
Secondname+5        5      $ Отчество��5      $	 133 5      	 5      �� *	Thirdname+5      5"      � 5$   
   $��0��6   
������� 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      
 � RowDefinitions
 5,      �� 5-      �� 5.      $��25 �6    �� 5/      �� 50      $��25 �6    �� 51      �� 52      $��25 �6    �� 53      $��50 �6    .+�56      �� $��Фамилия��6   $��Center=�6'   $��Center=�6D   $��0��6_   $��5��6o   $��0��6�   $��36(�6�   �� 57      -   5         ��Name$ 	Firstname��57      $��1��6)   $��3��69   $��1��6M   �� 58      $��Имя��6   $��Center=�6#   $��Center=�6@   $��0��6[   $��5��6k   $��2��6   $��36(�6�   �� 59      -   5        $ 
Secondname��59      $��1��6*   $��3��6:   $��3��6N   �� 5:      $��Отчество��6   $��Center=�6(   $��Center=�6E   $��0��6`   $��5��6p   $��4��6�   $��36(�6�   �� 5;      -   5        $ 	Thirdname��5;      $��1��6)   $��3��69   $��5��6M   �� 5<      -   5         ��Name$ 	ClientAdd��5<      $��0��6(   $��6��68   $��Создать��6]   
�������6o   �� 5=      -   5        $ 	ClientUpd��5=      $��1��6(   $��6��68   $��Изменить��6]   
�������6p   �� 5>      -   5        $ 	ClientDel��5>      $��2��6(   $��6��68   $��Удалить��6]   
�������6o   �� 5?      -   5        $ 
ClientNext��5?      $��3��6)   $��6��69   $��
Далее��6_   
�������6o   �� 5@      -	   5        $ 
ClientFind��5@      $��4��6)   $��6��69   $��
Найти��6_   
�������6o   �� 5A      -
   5        $ 
ClientBack��5A      $��4��6)   $��5��69   $��
Назад��6_   
�������6o   5B      5C      5D      