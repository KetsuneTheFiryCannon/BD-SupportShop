   M S B A M L   `   `   `  ����>  :PBD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PBDPBD  5   	       PBD.ChequeWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:PBD     5   	     � Title$  ChequeWindow��5   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
ChequeList��5   #   $��1��6      SelectionMode$ Single=�67      AutoGenerateColumns$ False��6N      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Цена��5         Width5  /System.Windows.Controls.DataGridLengthConverter$	 199 5      1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5      �� *Price+5        5      $+ %Номер тех. поддержки��5      $	 199 5      	 5      �� *Number+5      5      � 5   
   $��0��6   
������� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      
 � RowDefinitions
 5(      �� 5)      �� 5*      $��25 �6    �� 5+      �� 5,      $��25 �6    �� 5-      �� 5.      $��25 �6    �� 5/      $��50 �6    .+�52      �� $��
Номер��6   $��Center=�6%   $��Center=�6B   $��3��6]   $��3��6m   $��0��6�   $��24(�6�   �� 53      -   5         ��Name$ Numbercb��53      $��3��6)   $��3��69   $��1��6M   �� 54      $��Цена��6   $��Center=�6$   $��Center=�6A   $��0��6\   $��3��6l   $��0��6�   $��24(�6�   �� 55      -   5         ��Name$ Price��55      $��0��6%   $��3��65   $��1��6I   �� 57      -   5         ��Name$ 	ChequeAdd��57      $��0��6(   $��6��68   $��Создать��6]   
�������6o   �� 58      -   5        $ 	ChequeUpd��58      $��1��6(   $��6��68   $��Изменить��6]   
�������6p   �� 59      -   5        $ 	ChequeDel��59      $��2��6(   $��6��68   $��Удалить��6]   
�������6o   �� 5:      -   5        $ 
ChequeNext��5:      $��3��6)   $��6��69   $��
Далее��6_   
�������6o   �� 5;      -   5        $ 
ChequeFind��5;      $��4��6)   $��6��69   $��
Найти��6_   
�������6o   �� 5<      -	   5        $ 
ChequeBack��5<      $��5��6)   $��6��69   $��
Назад��6_   
�������6o   5=      5>      5?      