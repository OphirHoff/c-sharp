   M S B A M L   `   `   `  ����B  >PongWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PongWPFPongWPF  5   	   e aPresentationFramework.AeroLite, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35kNclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroLiteMicrosoft.Windows.Themes 5   	       PongWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:PongWPF     5   	   aThemesNclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroLite     5   	   -   5          �Name$  window��5   g    � Title$ Pong By Ophirrrr��5	   	   $	��450��6"   $	��800��6/   .��5
      � -   5        $
|�True��5
       � ColumnDefinitions 5   
   �� 5      $	��53* �6   �� 5      $
��747* �6   .+�5   
   �� -   5         ��Name$ 
right_Tile��5      $
��Left=�6(   $	��110��6C   $��694,160,0,0q�6P   
���   �$	��Top=�6t   $��15��6�   $��4��6�   $��1��6�   �� 5   
   -   5        $ 	left_Tile��5      $
��Left=�6'   $	��110��6B   
���   �$	��Top=�6^   $��16��6v   $��4��6�   $��	0,160,0,0q�6�   $��1��6�   A� 5   
   -   5         A�Name$
 ball��5      $
��Left=�6    $��24��6;   
���   �$	��Top=�6V   $��24��6n   $��18��6y   $��323,203,0,0q�6�   $��1��6�   �� 5   
   -   5         ��Name$ WinLabel��5      $�� ��6"   $
��Left=�6-   $��76��6H   $��
192,47,0,0q�6T   $	��Top=�6h   $	��310��6�   $��48(�6�   $��
UltraLight"�6�   $y�Hidden=�6�   $��1��6�   �� 5   
   -   5        $ 
startLabel��5      $��Press Enter to Start��6$   $
��Left=�6C   $��87��6^   $��
139,36,0,0q�6j   $	��Top=�6~   $	��392��6�   $��48(�6�   $��
UltraLight"�6�   $��1��6�   �� 5   
   -   5        $ 
player1Lbl��5      $��player 1��6$   $
��Left=�67   $	��Top=�6R   $��38��6j   $��82��6v   $��20(�6�   $��40,9,0,0q�6�   $��Yu Gothic UI Semilight)�6�   $��2��6�   �� 5   
   -	   5        $ 
player2Lbl��5      $��player 2��6$   $
��Left=�67   $��	627,9,0,0q�6R   $	��Top=�6e   $��38��6}   $��82��6�   $��20(�6�   $��Yu Gothic UI Semilight)�6�   $��1��6�   �� 5   
   -
   5        $ 	partition��5      $��1��6'   $
��Left=�67   $	��415��6R   $��	332,8,0,0q�6_   
���   �$	��Top=�6�   $��6��6�   $��4��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ slider��5      $��1��6!   $
��Left=�61   $��24��6L   $��311,123,0,0q�6X   $	��Top=�6m   $��48��6�    � Value$ 5Q�6�   �� 5   
   -   5        $ PCpick��5      $��1��6    $��Vs. PC��60   $
��Left=�6A   $��34��6\   $��253,118,0,0q�6h   $	��Top=�6}   $��53��6�   $��15(�6�   �� 5   
   -   5        $ 
friendPick��5      $��1��6$   $��
Vs. Friend��64   $
��Left=�6I   $��34��6d   $��364,118,0,0q�6p   $	��Top=�6�   $��78��6�   $��15(�6�   5      5      