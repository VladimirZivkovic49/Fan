   M S B A M L   `   `   `  ����D  @MVVMImage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MVVMImage.UnosNoviVentilatorMVVMImage.UnosNoviVentilator  5   	   ;    5MVVMImage.UnosNoviVentilator.UnosNoviVentilatorPodaci   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:MVVMImage.UnosNoviVentilator     5   	     � Title$  UnosNoviVentilatorPodaci��5   	   $	��450��6*   $	��800��67    � 	Resources 5
      ?   9MVVMImage.UnosNoviVentilator.UnesiNoviVentilatorViewModel    unesiNoviVentilatorViewModel��%   &	          5   
   6-   5      .��5      � .+�5   
   �� -   5         ��Name$ lbl_ImeVentilatora��5      $��Ime ventilatora��6,   $
��Left=�6F   $��	38,55,0,0q�6a   $	��Top=�6t   �� 5   
   -   5        $ lbl_TehnoloskaOznaka��5      $��Tehnoloska oznaka��6.   $
��Left=�6J   $��
35,100,0,0q�6e   $	��Top=�6y   �� 5   
   -   5        $ lbl_LokacijaUPogonu��5      $��Lokacija u pogonu��6-   $
��Left=�6I   $��
38,136,0,0q�6d   $	��Top=�6x   �� 5   
   -   5        $ lbl_Proizvodjac��5      $��Proizvodjac��6)   $
��Left=�6?   $��
38,176,0,0q�6Z   $	��Top=�6n   �� 5   
   -   5         ��Name$ txb_ImeVentilatora��5      $
��Left=�6.   $��23��6I   $��
169,59,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��172��6�   ��6�   �� *)'PodaciVentilatorText.ImeVentilatoraText+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� Source# [  �� 5   
   -   5        $ txb_TehnoloskaOznaka��5      $
��Left=�60   $��23��6K   $��169,103,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��172��6�   ��6�   �� *+)PodaciVentilatorText.TehnoloskaOznakaText+# [  �� 5   
   -   5        $ txb_LokacijaUPogonu��5      $
��Left=�6/   $��23��6J   $��169,139,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��172��6�   ��6�   �� **(PodaciVentilatorText.LokacijaUPogonuText+# [  �� 5   
   -   5        $ txb_Proizvodjac��5      $
��Left=�6+   $��23��6F   $��169,179,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��172��6�   ��6�   �� *&$PodaciVentilatorText.ProizvodjacText+# [  �� 5   
   -	   5         ��Name$! btn_NapraviNoviFolderiZapis��5      $��Napravi Novi Zapis��66   $
��Left=�6S   $��
660,10,0,0q�6n   $	��Top=�6�   $	��122��6�   $��45��6�   ��6�   �� *#!unesiPodatkeNoviVentilatorCommand+# [  �� 5   
   -
   5        $ btn_IzmeniSliku��5      $��Izmeni sliku��6*   $
��Left=�6A   $��
660,77,0,0q�6\   $	��Top=�6p   $	��122��6�   $��43��6�   ��6�   �� *izmeniSlikuCommand+# [  6�   5      5      