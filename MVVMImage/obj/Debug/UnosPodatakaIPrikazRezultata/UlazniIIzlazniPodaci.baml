   M S B A M L   `   `   `  ����D  @MVVMImage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:MVVMImage.UnosPodatakaIPrikazRezultata&MVVMImage.UnosPodatakaIPrikazRezultata  5   	   {Bclr-namespace:MVVMImage.UnosPodatakaIPrikazRezultata.UnosIPrikazVM4MVVMImage.UnosPodatakaIPrikazRezultata.UnosIPrikazVM  5   	   A    ;MVVMImage.UnosPodatakaIPrikazRezultata.UlazniIIzlazniPodaci   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:MVVMImage.UnosPodatakaIPrikazRezultata     5   	   Ulocal1Bclr-namespace:MVVMImage.UnosPodatakaIPrikazRezultata.UnosIPrikazVM     5   	     � Title$  UlazniIIzlazniPodaci��5	   	   $	��450��6&   $	��800��63    � 	Resources 5
      O   IMVVMImage.UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel   unosIPrikazViewModel��%   &	          5   
   6&   5      .��5      � -   5         �Name$ PrikazirealneVrednosti��5      .+�5   
   �� -   5         ��Name$ TeorijskiProtok1_TXB��5      $
��Left=�60   $��23��6K   $��
617,40,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��120��6�   ��6�   �� *'%PodaciZaKrivuMain.TeorijskiProtokText+ �� Source# [  �� 5   
   -   5         ��Name$ TeorijskiProtok1_LBL��5      $1��+Teorijski protok na osnovu Sistemske krive ��6.   $
��Left=�6d   $��
512,13,0,0q�6   $	��Top=�6�   $	��254��6�   $��27��6�   �� 5   
   -   5        $ TeorijskSnaga1_LBL��5      $0��*Teorijska snaga na osnovu Sistemske krive ��6,   $
��Left=�6a   $��
512,75,0,0q�6|   $	��Top=�6�   $	��254��6�   $��27��6�   �� 5   
   -   5        $ TeorijskaSnaga1_TXB��5      $
��Left=�6/   $��23��6J   $��619,107,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   ��6�   �� *&$PodaciZaKrivuMain.TeorijskaSnagaText+# [  �� 5   
   -   5        $ RadniBrojObrtaja_LBL��5      $$��Radni broj obrtaja ventilatora��6.   $
��Left=�6W   $��
26,103,0,0q�6r   $	��Top=�6�   $	��169��6�   $��27��6�   �� 5   
   -   5        $ RadniBrojObrtaja_TXB��5      $
��Left=�60   $��23��6K   $��
26,135,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   ��6�   �� *.,PodaciZaKrivuMain.BrojObrtajaVentilatoraText+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�# [  �� 5   
   -   5        $ IzmerenaSnaga_LBL��5      $��Izmerena snaga��6+   $
��Left=�6D   $��
26,219,0,0q�6_   $	��Top=�6s   $	��136��6�   $��27��6�   �� 5   
   -	   5        $ IzmerenProtok_LBL��5      $��Izmereni protok��6+   $
��Left=�6E   $��
26,164,0,0q�6`   $	��Top=�6t   $	��159��6�   $��27��6�   �� 5   
   -
   5        $ IzmerenaSnaga_TXB��5      $
��Left=�6-   $��23��6H   $��
26,258,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   ��6�   �� *%#PodaciZaKrivuMain.IzmerenaSnagaText+$ TwoWay=�$ PropertyChanged=�# [  �� 5   
   -   5        $ IzmereniProtok_TXB��5      $
��Left=�6.   $��23��6I   $��
26,196,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   ��6�   �� *%#PodaciZaKrivuMain.IzmerenProtokText+$ TwoWay=�$ PropertyChanged=�# [  �� 5   
   -   5        	 ��Name$(	 "IzracunajEfikasnostventilatora_BTN��5      $&�� Izračunaj efikanost ventilatora��6=   $
��Left=�6g   $��267,111,0,0q�6�   $	��Top=�6�   $	��174��6�   $��30��6  ��6�   �� *IzracunajEfikasnost+# [  6  �� 5   
   -   5        $( "OdstupanjeIzmerenogProtoka_AM3_LBL��5      $B��<Odstupanje izmerenog protoka
 od teotrijske vrednosti u Am3��6<   $
��Left=�6�   $��513,231,0,0q�6�   $	��Top=�6�   $	��226��6�   $��40��6�   �� 5   
   -   5        $ OdstupanjeProtok_AM3_TXB��5      $
��Left=�64   $��21��6O   $��542,289,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $��79��6�   ��6�   �� *1/PodaciZaKrivuMain.OdstupanjeIzmernogProtokaText+# [  �� 5   
   -   5        $# OdstupanjeProtok_Procenat_TXB��5      $
��Left=�69   $��23��6T   $��670,287,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $��67��6�   ��6�   �� *97PodaciZaKrivuMain.OdstupanjeIzmernogProtokaProcenatText+# [  �� 5    
   -   5        $$ OdstupanjeIzmereneSnage_kW_LBL��5       $J��DOdstupanje izmerene snage ventilatora 
od teotrijske vrednosti u kW��68   $
��Left=�6�   $��513,315,0,0q�6�   $	��Top=�6�   $	��238��6�   $��45��6�   �� 5!   
   -   5        $ OdstupanjeSnaga_KW_TXB��5!      $
��Left=�62   $��35��6M   $��564,365,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��102��6�   ��6�   �� *.,PodaciZaKrivuMain.OdstupanjeIzmerneSnageText+# [  �� 5"   
   -   5        $" OdstupanjeSnaga_Procenat_TXB��5"      $
��Left=�68   $��35��6S   $��684,365,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $��82��6�   ��6�   �� *64PodaciZaKrivuMain.OdstupanjeIzmerneSnageProcenatText+# [  �� 5#   
   -   5        $! TeorijskTotalniPritisak_LBL��5#      $=��7Teorijski totalni pritisak na
 osnovu Sistemske krive ��65   $
��Left=�6   $��512,139,0,0q�6�   $	��Top=�6�   $	��254��6�   $��43��6�   �� 5$   
   -   5        $" TeorijskaTotalniPritisak_TXB��5$      $
��Left=�68   $��23��6S   $��619,187,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��120��6�   ��6�   �� *)'PodaciZaKrivuMain.TeorijskiPritisakText+# [  �� 5%   
   -   5        $ IzmerenIzlazniP_LBL��5%      $$��Izmereni izlazni pritisak mbar��6-   $
��Left=�6V   $��
26,336,0,0q�6q   $	��Top=�6�   $	��169��6�   $��27��6�   �� 5&   
   -   5        $ IzmerenUlazniP_LBL��5&      $#��Izmereni ulazni pritisak mbar��6,   $
��Left=�6T   $��
26,281,0,0q�6o   $	��Top=�6�   $	��169��6�   $��27��6�   �� 5'   
   -   5        $! IzmereniIzlazniPritisak_TXB��5'      $
��Left=�67   $��20��6R   $��
26,368,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $	��108��6�   ��6�   �� *.,PodaciZaKrivuMain.IzmerenIzlazniPritisakText+$ TwoWay=�$ PropertyChanged=�# [  �� 5(   
   -   5        $  IzmereniUlazniPritisak_TXB��5(      $
��Left=�66   $��23��6Q   $��
26,308,0,0q�6]   $
 Wrap=�6q   $	��Top=�6�   $	��120��6�   ��6�   �� *-+PodaciZaKrivuMain.IzmerenUlazniPritisakText+$ TwoWay=�$ PropertyChanged=�# [  �� 5)   
   -   5        $ TeorijskaEfikasnost_LBL��5)      $;��5Efikasnost ventilatora na osnovu teorijskih vrednosti��61   $
��Left=�6q   $��201,146,0,0q�6�   $	��Top=�6�   $	��306��6�   $
��Bold"�6�   ���	#FF2B2222���	#FF15C12D���	#FFC115156  �� 5*   
   -   5        $ EfikasnostMerenje_LBL��5*      $:��4Efikasnost ventilatora na osnovu izmerenih vrednosti��6/   $
��Left=�6n   $��201,240,0,0q�6�   $	��Top=�6�   $	��306��6�   ���	#FF2B2222���	#FF0DF0DB���	#FFC11515$
��Bold"�6  $��Palatino Linotype)�6  �� 5+   
   -   5        $ TeorijskaEfikasnost_TXB��5+      $
��Left=�63   $��23��6N   $��232,194,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��150��6�   $
��Bold"�6�   ��6�   �� *+)PodaciZaKrivuMain.TeorijskaEfikasnostText+# [  �� 5,   
   -   5        $ IzmerenaEfikasnost_TXB��5,      $
��Left=�62   $��23��6M   $��232,294,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   $
��Bold"�6�   ��6�   �� *,*PodaciZaKrivuMain.IzracunataEfikasnostText+# [  �� 5-   
   -   5        $ lbl_IzabraniVentilator��5-      $��Izabrani ventilator��60   $
��Left=�6N   $��
217,15,0,0q�6i   $	��Top=�6}   �� 5.   
   -   5        $ txbx_IzabraniVentilator��5.      $
��Left=�63   $��23��6N   $��
327,19,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   ��6�   �� *PodaciMainVm+# [  �� 5/   
   -   5        $	 btn_IzvozUExcel��5/      $��Izvoz U Excel��6*   $
��Left=�6B   $��	10,19,0,0q�6]   $	��Top=�6p   $	��120��6�   $��44��6�   ��6�   �� *IzveziUExcel+# [  �� 50   
   -    5        $	 btn_PrikazDijagrama��50      $��Prikaz dijagrama��6.   $
��Left=�6I   $��	10,68,0,0q�6d   $	��Top=�6w   $	��120��6�   $��35��6�   ��6�   �� *prikazDijagramaCommand+# [  52      53      