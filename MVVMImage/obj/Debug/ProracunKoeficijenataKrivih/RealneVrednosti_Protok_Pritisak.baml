   M S B A M L   `   `   `  ����D  @MVVMImage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MVVMImage	MVVMImage  5   	   ]3clr-namespace:MVVMImage.ProracunKoeficijenataKrivih%MVVMImage.ProracunKoeficijenataKrivih  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   /    )MVVMImage.RealneVrednosti_Protok_Pritisak   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MVVMImage     5   	   Flocal13clr-namespace:MVVMImage.ProracunKoeficijenataKrivih     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	     � Title$%  RealneVrednosti_Protok_Pritisak��5
   	   $	��450��61   $	��800��6>    � 	Resources 5      E   ?MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihViewModel   unosTacakaKrivihViewModel��%   &	          5   
   6+   5      .��5      � $
��Left=�6   $	��790��6&    � ColumnDefinitions 5   
   �� 5      $	��610 �6   �� 5      $
��Auto �6   .+�5   
   � -   5         �Name$ grd_PregledUcitavanja��5      $��0��6.    � RowDefinitions 5      �� 5      $��80 �6    �� 5       $
��Auto �6    5'      � 5)   
   -   5        $ grd_Dijagram��5)      $��1��6&   .+�5*      �� -   5         ��Name$ LeftMoseClick��5*   6   $��0��6   $��1��6)   $	��340��6M   $��600                     ��6Z   $��Bottom=�5+      $
��Left=�62   
������ .+�5-      �� -   5         ��Name$ Slicka��5-      $��Stretch=�6)   $��Stretch=�6G   $	��339��6c   ��6p   �� *putanjaUnos+ �� Source# [  .  (System.Windows.Interactivity.Interaction   Triggers 5.      /  )System.Windows.Interactivity.EventTrigger  5/      	   	EventName$	 MouseLeftButtonDown��6%   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 50      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *PozicijaMouseUnos+   CommandParameter 6W   ��  �� ElementName$ Slicka��  51       60   �� *radioButonCommand+52      54      57      � 59   
   -   5        $ grd_zaKomande��59      $��1��6&   $	��406��66   $	��Top=�6C   $��10,3,-178,0q�6[   .+�5:      �� -   5         ��Name$ ObradaRezultata��5:   "   $��0��6   $��Obradi
 rezultate��6;   $��Center=�6`   $��76��6}   $��84,10,10,350q�6�   ��6�   �� *ObradiRezultate+# [  6�   	� 5;      -   5         	�Name$ 
TotalP_RDB��5;   (   $��0��6   $��Krive Protok-Totalni P��6<   $
��Left=�6]   $	��Top=�6y   $��
10,140,0,0q�6�  ��6�   �� *RadioButtonSelektuj+# [   d� 	IsChecked 6�   �� *)'kriterijumiSelekcije.Radio_ProtokTotall+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�# [  6�  	� 5<      -   5        $ StaticP_RDB��5<   7   $��0��6   $��0��6*   $��Krive Protok-Statički P��6L   $
��Left=�6n   $	��Top=�6�   $��
10,160,0,0q�6�  ��6�   �� *RadioButtonSelektuj+# [   6�   �� **(kriterijumiSelekcije.Radio_ProtokStaticl+$ TwoWay=�$ PropertyChanged=�# [  6�  	� 5=      -	   5        $ 	Snaga_RDB��5=   7   $��0��6   $��0��6*   $��Krive Protok-Snaga��6J   $
��Left=�6g   $	��Top=�6�   $��
10,180,0,0q�6�  ��6�   �� *RadioButtonSelektuj+# [   6�   �� *)'kriterijumiSelekcije.Radio_ProtokPowerl+$ TwoWay=�$ PropertyChanged=�# [  6�  5A      �� 5C   
   -
   5         ��Name$ KrivaPoRedu��5C      $"��Kriva za učitavanje po redu��6&   $	��170��6L   $��48��6X   $��0,3,0,0q�6d   $	��Top=�6u   $
��Left=�6�   �� 5D   
   -   5        $ BrojObrtajaPoRedu��5D      $��Broj obrtaja ventilatora��6,   $	��160��6P   $��48��6\   $��226,3,245,368q�6h   �� 5E   
   -   5        $ BrojRedTackeUpis��5E      $��Redni broj tačke za upis��6+   $	��160��6O   $��48��6[   $��449,3,22,378q�6g   �� 5F   
   -   5         ��Name$ txBl_krivaIme��5F      $
��Left=�6+   $��	21,56,0,0q�6F   $
��Wrap=�6Y   $	��Top=�6m   $
��Bold"�6�   $��25��6  ��6�   �� *)'UcitavanjePracenje.ImeKriveZaUcitavanje+$ TwoWay=�$ PropertyChanged=�6  �� 5G   
   -   5        $ txBl_BrojeviObrtaja��5G      $
��Left=�61   $��
226,56,0,0q�6L   $
��Wrap=�6`   $	��Top=�6t   $	��109��6�   $
��Bold"�6
  $��25��6  ��6�   �� *1/UcitavanjePracenje.BrojObrtajaKriveZaUcitavanje+$ TwoWay=�$ PropertyChanged=�6  �� 5H   
   -   5        $ txBl_TackaPoRedu��5H      $
��Left=�6.   $��
478,56,0,0q�6I   $
��Wrap=�6]   $	��Top=�6q   $	��109��6�   $
��Bold"�6  ���	#FFFDFAFA���	#FFF90D0D$��25��6C  ��6�   �� *-+UcitavanjePracenje.RedniBrojTackeUcitavanja+$ TwoWay=�$ PropertyChanged=�6C  5K      5L      