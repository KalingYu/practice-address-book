   M S B A M L   `   `   `  ����C  ?Tonxinlu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TonxinluTonxinlu  5           Tonxinlu.BrowseAndEditPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Tonxinlu     5        N� Title$  BrowseAndEditPage��5	      .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGrid��5   r      RowHeaderWidth$ 0Q�6,      CanUserAddRows .     AutoGenerateColumns .  $��	1,0,134,2q�6�   $��0q�6�   $��16(�6�   ��6   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .     Header$ 编号��68      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *id+  5       .  $ 姓名��68   $ * 6D    6N   �� *name+  5       .  $ 性别��68   $ * 6D    6N   �� *sex+  5       .  $ 电话��68   $ * 6D    6N   �� *phone+  5       .  $ 邮箱��68   $ * 6D    6N   �� *email+  5      $ 地址��6%   $ * 61    6;   �� *	address+5      �� 5   
   -   5        	 ��Name$	 button��5      $��更新通讯录��66   $
��Left=�6F   $��	773,2,0,0q�6a   $	��Top=�6t   $��82��6�   ���	#FF0288D1
�������$��26��6�   $��0q�6�   �� 5   
   -   5        
 ��Name$
 	resultBox��5      $
��Left=�6'   $��775,130,0,0q�6B   $
��Wrap=�6W   $	��Top=�6k   ���	#FFE51212$��10.667(�6�   �� 5   
   -   5         ��Name$ label��5      $��删除，输入编号��6   $
��Left=�61   $��
767,41,0,0q�6L   $	��Top=�6`   $��95��6x   �� 5   
   -   5         ��Name$ 	deleteBox��5      $��1q�6%   $
��Left=�61   $��23��6L   $��
772,67,0,0q�6X    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $��82��6�   $��14.667(�6�   �� 5   
   -   5        $	 button_Copy��5      $��确认删除��6;   $
��Left=�6J   $��
772,95,0,0q�6e   $	��Top=�6y   $��82��6�   ���	#FF0288D1
�������$��26��6�   $��0q�6�   5      5      