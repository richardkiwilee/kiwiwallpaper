   M S B A M L   `   `   `  ����H  Dkiwiwallpaper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:kiwiwallpaperkiwiwallpaper  5   	       kiwiwallpaper.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:kiwiwallpaper     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ Kiwi Wallpaper��5	   	   $	��400��6    $	��600��6-   .��5
      � $��-6,0,0,0q�6    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      $
��200* �6   �� 5      $
��100* �6    � RowDefinitions 5   
   �� 5      $��0* �6   �� 5      $
��341* �6   �� 5      $	��30* �6   .+�5   
   �� -   5         ��Name$ 	SearchBox��5      $��0��6&   $��1q�63   $��10,0,0,0q�6G   $
��Left=�6Y   $��95��6u   $��1��6�   $��2��6�    ^� ToolTip$ Please input keywords��6�    ^� InitialShowDelay$ 1��6�    ^� 	Placement$ 
MousePoint=�6�    J� RenderTransformOrigin$ 0.908,1.262&�6  .��6=  	 � 	Resources	 5         	HelpBrush
 j� TileMode �� Opacity j� Stretch j� 
AlignmentX !� Visual��%�   &	        !� 5      $

 None=�60   $	 0.5Q�6@   $
 None=�6N   $
 Left=�6]    5      �� 5      $��Italic$�6$   $��Search��67   5      5      .��6!   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      P� 5        P� Property � �� P� Value 62   Z� . �5!      ��  �� Property � �� �� Value# [  6;   5"      P� 5#       � ��$  ��62   . �5$      ��  � ��# [  6;   5%      5'      .��5(      5)      �� 5*   
   -   5        $��load from file��5*      
����������#4682B4$��110,0,185,0q�6R   $��1��6g   $��2��6w   5+      �� 5,   
   -   5        $��load from web��5,      
����������#4682B4$��
220,0,75,0q�6R   $��1��6f   $��2��6v   5-      �� 5.   
   -   5        $��Confirm��5.      
����������#4682B4$��2��6K   $��2��6[   5/      �� 50   
   $��1��6   $��1��6'   67   �� 51   
   $��2��6   $��1��6'   67   52      53      