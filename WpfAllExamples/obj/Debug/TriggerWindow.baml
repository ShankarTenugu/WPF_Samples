   M S B A M L   `   `   `  ����I  EWpfAllExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfAllExamplesWpfAllExamples  5   	   "    WpfAllExamples.TriggerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfAllExamples     5   	     � Title$  TriggerWindow��5   	   $	��300��6   $	��300��6,    � 	Resources 5	         myStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%  &	        �� 5
   
   " ��6    .�5      ��  � ��
 ��  �6:   �� 5       � ��$ Button��6(   69    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 �  ��6A   �� 5       � ��$ Trigger��60   6B   5      5      5      .��5      � .+�5   
   �� $	��100��6   $��50��6   
�������#��[  6<   6_   �� 5   
   .+�5      �� -   5         ��Name$ 	chkboxRed��5      $��Red Check Box��6*   $��20q�6B   6P   �� 5      -   5        $��txtBlock��5      $��Center=�6(   $��Event trigger��6C   $��24(�6X   $��20)�6f   ��5      �� 5       5      �� 5      	 �� Binding	 6*   �� 
 �� ElementName$
 	chkboxRed�� �� Path$ 	IsChecked� �� Value True6d   .a�5   "   ��  � ��
 �  ��6W   �� 5   "    �@�Cursor$
 Hand��6E   6T   5       5"      5$      5%      5&      5'      