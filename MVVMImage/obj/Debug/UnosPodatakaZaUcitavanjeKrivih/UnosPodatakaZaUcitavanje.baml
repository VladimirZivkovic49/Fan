   M S B A M L   `   `   `  ����D  @MVVMImage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Qclr-namespace:MVVMImage.UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVMCMVVMImage.UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   G    AMVVMImage.UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanje   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   dlocal1Qclr-namespace:MVVMImage.UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	     � Title$  UnosPodatakaZaUcitavanje��5	   	   $	��450��6*   $	��800��67    � 	Resources 5      k   eMVVMImage.UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel %  !unosPodatakaZaUcitavanjeViewModel��%   &	          5   
   63   5      .��5      � .+�5   
   �� -   5         ��Name$ UnesiPodatkeZaKrivu��5      $��Unesi podatke za krivu��6.   $
��Left=�6O   $��
649,35,0,0q�6j   $	��Top=�6~   $	��133��6�   $��26��6�   ��6�   �� *PodaciZaKrivuUnesi+ �� Source# [  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$! DtGr_BrojObrtajaVentilatora��5      $
��Left=�68   $	��109��6S   $��
44,225,0,0q�6`   $	��Top=�6t   $	��111��6�      AutoGenerateColumns .     
IsReadOnly . ��6�   �� *VentilatorObrtajiKolekcija+# [   �� SelectedIndex 64  �� *'%PpodaciZaKrivu.BrOobrtajaSelektedIdex+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Obrtajiventilatora��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5      �� *ObrtajiVentilatora+.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ MouseLeftButtonDown��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6	  0System.Windows.Interactivity.InvokeCommandAction	   	  Command 6,   �� *" selektovatiVrstuBrObrtajaCommand+5      5!      �� 5$   
   -   5         ��Name$ BrojTacaka_Combx��5$      $
��Left=�6-   $��
249,86,0,0q�6H   $	��Top=�6\   $	��120��6t    �� 
IsEditable .  �� Text 6�   �� *-+PpodaciZaKrivu.BrojTacakaZaUnosPodatakaText+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�# [  .@�5%      �� $��8��6   �� 5&      $��9��6   �� 5'      $��10��6   �� 5(      $�� ��6   5*      �� 5+   
   -   5         ��Name$" txbx_BrojObrtaja_Ventilatora��5+      $
��Left=�68   $��23��6S   $��
249,38,0,0q�6_    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��120��6�   ��6�   �� *+)PpodaciZaKrivu.BrojObrtajaVentilatoraText+$ TwoWay=�$ PropertyChanged=�# [  �� 5,   
   -   5         ��Name$ lbl_BrojObtajaUnos��5,      $$��Unesi broj ventilatora obrtaja��6,   $
��Left=�6U   $��	31,35,0,0q�6p   $	��Top=�6�   �� 5-   
   -   5        $# lbl_UnosBrojaTacakaUcitavanje��5-      $+��%Unesi broj tacaka za ucitavanje krive��67   $
��Left=�6g   $��	31,82,0,0q�6�   $	��Top=�6�   �� 5.   
   -   5        $  btn_ucitavanjeBrojaObrtaja��5.      $��Ucitaj broj obrtaja ��65   $
��Left=�6T   $��
411,38,0,0q�6o   $	��Top=�6�   $	��107��6�   $��23��6�   ��6�   �� *BrojObrtajaVentilatoraUnesi+# [  �� 5/   
   -   5        $ btn_DeliteRow��5/      $��Izbrisi broj obrtaja��6(   $
��Left=�6G   $��209,225,0,0q�6b   $	��Top=�6w   $	��115��6�   $��32��6�   ��6�   �� *IzbrisiBrojObrtaja+# [  53      54      