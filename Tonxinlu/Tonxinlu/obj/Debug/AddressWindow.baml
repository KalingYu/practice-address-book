   M S B A M L   `   `   `  ����C  ?Tonxinlu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TonxinluTonxinlu  5   	       Tonxinlu.AddressWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Tonxinlu     5   	     � Title$  AddressWindow��5   	   $	��700��6   $	��900��6,   .��5	      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��300 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $	��600 �6   .+�5   
   �� -   5         ��Name$ 	textBlock��5       �� Padding$ 10q�6'   $��0��64   $��Stretch=�6A   $��24(�6_    �� TextAlignment$ Center=�6m   $
��Wrap=�6�   $��我的通讯录��6�   $	��Top=�6�   ���	#FF03A9F4
�������$��3��6�   $��0,0,0,0q�6�   � 5   
   $��0��6   $��3��6    $��2��64   $��Stretch=�6A   $��Stretch=�6_   $��0q�6{    5      �� 5      .+�5        � -   5          �Name$ frame��5         � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��
0,0,0,-0.2q�6a   5#      �� 5$   
   -   5         ��Name$ btn_Add��5$      $��添加联系人��67   $��1��6G   $��Stretch=�6T   $��0,0,0,0q�6r   $	��Top=�6�   $��50��6�   $��24(�6�   ���	#FFCCCCCC
�������$��0q�6�   �� 5%   
   -   5        $ 
btn_Browse��5%      $��1��6;   $��浏览或编辑��6H   $��Stretch=�6X   $	��Top=�6w   $��50��6�   $��24(�6�   ���	#FFCCCCCC
�������$��1��6�   $��0q�6�   $��2��6�   $��0q�6�   �� 5&   
   -   5        $ 
btn_Search��5&      $��搜索联系人��6;   $��Stretch=�6K   $	��Top=�6j   $��50��6�   $��24(�6�   ���	#FFCCCCCC
�������$��2��6�   $��0q�6�   $��1��6�   $��0q�6�   5(      5+      