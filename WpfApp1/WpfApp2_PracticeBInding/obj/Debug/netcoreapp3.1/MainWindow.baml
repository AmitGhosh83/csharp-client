   M S B A M L   `   `   `  ����R  NWpfApp2_PracticeBInding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WpfApp2_PracticeBIndingWpfApp2_PracticeBInding  5   	   (    "WpfApp2_PracticeBInding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:WpfApp2_PracticeBInding     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ uxContainer��5
      .+�5      �� $��Center=�6    �� Padding$ 10q�65   $
��Bold"�6B   
Enter Name6a   �� 5      -   5         ��Name$ uxName��5      $��20��6&   $	��500��62   ��5      ��  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��.��6s   5      �� 5      -   5         ��Name$ uxNameError��5      $��Center=�5      ��5      �� $ 	NameError�$ PropertyChanged=�5      �� 5      $��Center=�6   $ 10q�65   $
��Bold"�6B   Enter Password6e   �� 5      -   5        $ 
uxPassword��5      $��20��6*   $	��500��66   ��5      �� *
Password+$ PropertyChanged=�$
 True��.��6q   5      �� 5      -   5        $ uxPasswordError��5      $��Center=�5      ��5      �� *PasswordError+$ PropertyChanged=�5      �� 5      -   5         ��Name$ uxSubmit��5   ,   $��20��6   $��50��6!   .��6U   Submit6]   �� 5      -   5        	 ��Name$	 uxList��5      $��50q�6'   
 �� View
 5      �� 5      .P�5      �� $��	User Name��6S    �� Width$	 100��6f    �� DisplayMemberBinding 6)   �� *
UserName+6f   �� 5       $��Password��6W   $	 100��6i    6)   �� *UserPassword+6i   5!      5#      5$      5%      5&      