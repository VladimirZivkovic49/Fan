   M S B A M L   `   `   `  ����D  @MVVMImage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:MVVMImage.ProracunKoeficijenataKrivih%MVVMImage.ProracunKoeficijenataKrivih  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   7    1MVVMImage.ProracunKoeficijenataKrivih.ProzorProba   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:MVVMImage.ProracunKoeficijenataKrivih     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	     � Title$  ProzorProba��5
   	   $	��450��6   $	��800��6*   .��5   
   � $
��Left=�6   $	��790��6*    � ColumnDefinitions 5      �� 5      $	��610 �6"   �� 5      $
��Auto �6"   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��80 �6    �� 5      $
��Auto �6    .+�5      �� -   5         ��Name$ btn_Skaliraj��5   2   $��0��6   $��0��6%   $��Skaliraj��6H   $��
0,0,531,32q�6[   	� 5      -   5         	�Name$ 
TotalP_RDB��5   7   $��0��6   $��0��6*   $��Krive Protok-Totalni P��6K   $
��Left=�6l   $	��Top=�6�   $��	25,62,0,0q�6�   	� 5      -   5        $ 	Snaga_RDB��5   7   $��0��6   $��0��6*   $��Krive Protok-Snaga��6J   $
��Left=�6g   $	��Top=�6�   $��
392,62,0,0q�6�   	� 5      -   5        $ StaticP_RDB��5   7   $��0��6   $��0��6*   $��Krive Protok-Statički P��6L   $
��Left=�6n   $	��Top=�6�   $��
208,62,0,0q�6�   �� 5      -   5         ��Name$ stpn_Dijagram��5   9   $��0��6   $��1��6*   $	��340��6Q   $��Bottom=�6^   $	��600��6y   $
��Left=�6�   
������ $��0,0,0,0q�5   0   .+�5       �� -   5         ��Name$ Slicka��5       $��Stretch=�6)   $��Stretch=�6G   $	��339��6c   .  (System.Windows.Interactivity.Interaction   Triggers 5"      /  )System.Windows.Interactivity.EventTrigger  5#         	EventName$ MouseLeftButtonDown��6%   .  (System.Windows.Interactivity.TriggerBase	   Actions.	 5%      6  0System.Windows.Interactivity.InvokeCommandAction  
   Command
 60   �� *PozicijaMouse+   CommandParameter 6S   ��  �� ElementName$ Slicka��5(      5-      54      58      59      