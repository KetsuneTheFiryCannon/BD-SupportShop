   M S B A M L   `   `   `  ����>  :PBD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PBDPBD  5   	       PBD.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:PBD     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ JobList��5   #   $��1��6      SelectionMode$ Single=�64      AutoGenerateColumns$ False��6K      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Doljnost��5         Width5  /System.Windows.Controls.DataGridLengthConverter$	 195 5      1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5      �� *Name+5        5      $ Oklad��5      $	 195 5      	 5      �� *Salary+5      5      � 5   
   $��0��6   
������� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      
 � RowDefinitions
 5'      �� 5(      �� 5)      $��25 �6    �� 5*      �� 5+      $��25 �6    �� 5,      �� 5-      �� 5.      $��50 �6    .+�51      �� $)��#Название должность��6   $��Center=�62   $��Center=�6O   $��0��6j   $��5��6z   $��0��6�   $��36(�6�   �� 52      -   5         ��Name$ JobName��52      $��1��6'   $��3��67   $��1��6K   �� 53      $��
Оклад��6   $��Center=�6%   $��Center=�6B   $��0��6]   $��5��6m   $��2��6�   $��36(�6�   �� 54      -   5        $ 	JobSalary��54      $��1��6)   $��3��69   $��3��6M   �� 55      -   5         ��Name$ JobAdd��55      $��0��6%   $��6��65   $��Создать��6W   
�������6i   �� 56      -   5        $ JobUpd��56      $��1��6%   $��6��65   $��Изменить��6W   
�������6j   �� 57      -   5        $ JobDel��57      $��2��6%   $��6��65   $��Удалить��6W   
�������6i   �� 58      -   5        $ JobNext��58      $��3��6&   $��6��66   $��
Далее��6Y   
�������6i   �� 59      -   5        $ JobFind��59      $��4��6&   $��6��66   $��
Найти��6Y   
�������6i   5:      5;      5<      