   M S B A M L   `   `   `  ����Q  Mlecture 5 intro to wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:lecture_5_intro_to_wpflecture_5_intro_to_wpf  5   	   '    !lecture_5_intro_to_wpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:lecture_5_intro_to_wpf     5   	     � Title$  
MainWindow��5   	   $��523.6��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ 	btnIfElse��5
      $��Button��6$   $
��Left=�65   $��	21,19,0,0q�6P   $	��Top=�6c   $	��119��6{   $��51��6�   6�   �� 5   
   -   5        $��lblIfElseResult��5      $��Label��6'   $
��Left=�67   $��
161,32,0,0q�6R   $	��Top=�6f   $	��303��6~   �� 5   
   -   5         ��Name$ lblIf��5      $��Label��6   $
��Left=�6/   $��
161,82,0,0q�6J   $	��Top=�6^   $	��303��6v   �� 5   
   -   5        $ lblIfElseTwo��5      $��Label��6&   $
��Left=�66   $��161,129,0,0q�6Q   $	��Top=�6f   $	��303��6~   �� 5   
   -   5        $ btnSum��5      $��sum number 1 and 2��6!   $
��Left=�6>   $��
21,181,0,0q�6Y   $	��Top=�6m   $	��119��6�   $��54��6�   6�   �� 5   
   -   5         ��Name$ 	txtinput1��5      $
��Left=�6%   $��23��6@   $��161,190,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $��number 1��6u   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ 	txtinput2��5      $
��Left=�6%   $��23��6@   $��305,190,0,0q�6L   $
 Wrap=�6a   $��number 2��6u   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ 	txtoutput��5      $
��Left=�6%   $��23��6@   $��452,190,0,0q�6L   $
 Wrap=�6a   $��result��6u   $	��Top=�6�   $	��120��6�   �� 5   
   -	   5        $��lblFullNumber��5      $��Label��6%   $
��Left=�65   $��161,229,0,0q�6P   $	��Top=�6e   �� 5   
   -
   5        $ lblRoundedNumber��5      $��Label��6*   $
��Left=�6:   $��161,260,0,0q�6U   $	��Top=�6j   �� 5   
   -   5         ��Name$ 
lstResults��5      $
��Left=�6&   $	��166��6A   $��
10,304,0,0q�6N   $	��Top=�6b   $	��372��6z   �� 5   
   -   5        $ lstResultsBottomUp��5      $
��Left=�6.   $	��166��6I   $��401,304,0,0q�6V   $	��Top=�6k   $	��372��6�   5      5      