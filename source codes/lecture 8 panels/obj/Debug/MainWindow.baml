   M S B A M L   `   `   `  ����K  Glecture 8 panels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:lecture_8_panelslecture_8_panels  5   	   !    lecture_8_panels.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:lecture_8_panels     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $	��400��60   $��	10,10,0,0q�6=   $	��Top=�6P   $	��774��6h   .@�5      �� -   5         ��Name$
 tab1��5      $��Write To File��6$   .��5      � ���	#FFE5E5E5.+�5      �� -   5         ��Name$ btnWrite��5      $��Write��6/   $
��Left=�6?   $��
193,28,0,0q�6Z   $	��Top=�6n   $	��112��6�   $��49��6�   6�   �� 5      -   5         ��Name$ 
cmbNumbers��5      $
��Left=�63   $��	19,28,0,0q�6N   $	��Top=�6a   $	��139��6y   $��61��6�   5      5      �� 5      -   5        $
 tab2��5      $��Read From File��6$   .��5      � ���	#FFE5E5E5.+�5      �� -   5         ��Name$ listBoxItems��5      $
��Left=�64   $	��284��6O   $��	10,22,0,0q�6\   $	��Top=�6o   $	��362��6�   �� 5      -   5        $ btnRead��5      $��Read From File��6.   $
��Left=�6G   $��
409,22,0,0q�6b   $	��Top=�6v   $	��122��6�   $��75��6�   6�   �� 5      -   5         ��Name$ chkReverseSort��5      $��Reverse Sort Enabled��67   $
��Left=�6V   $��409,120,0,0q�6q   $	��Top=�6�   $	��172��6�   5      5      �� 5      -   5        $
 tab3��5      $��Random Write To File��6$   .��5      � ���	#FFE5E5E5.+�5      �� -	   5        $ btnRandomWrite��5      $��Random Write��65   $
��Left=�6L   $��	10,10,0,0q�6g   $	��Top=�6z   $	��112��6�   $��50��6�   6�   �� 5      -
   5        $ lstBoxRandomItems��5      $
��Left=�69   $	��286��6T   $��
161,10,0,0q�6a   $	��Top=�6u   $	��314��6�   5      5      �� 5      -   5        $
 tab4��5      $��Tab 4��6$   .��5      � ���	#FFE5E5E5.+�5       �� -   5        $ btnRandomWrite2��5       $��Random Write��66   $
��Left=�6M   $��	10,10,0,0q�6h   $	��Top=�6{   $	��112��6�   $��50��6�   6�   �� 5!      -   5        $ lstBoxRandomItems2��5!      $
��Left=�6:   $	��286��6U   $��
161,10,0,0q�6b   $	��Top=�6v   $	��314��6�   5"      5#      5$      5&      5'      