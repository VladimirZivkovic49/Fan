   M S B A M L   `   `   `  ����D  @MVVMImage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MVVMImage.SkaliranjeMVVMImage.Skaliranje  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   *    $MVVMImage.Skaliranje.SkaliranjeWidow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:MVVMImage.Skaliranje     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	     � Title$  SkaliranjeWidow��5
   	   $	��450��6!   $	��800��6.    � DataContext 5      4   .MVVMImage.Skaliranje.SkaliranjeWindowViewModel  5   
   .��5      � $
��Left=�6   $	��790��6&    � ColumnDefinitions 5   
   �� 5      $	��610 �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6    � RowDefinitions 5       �� 5!      $��80 �6    �� 5"      $
��Auto �6    .+�5%      �� -   5         ��Name$ Skaliraj��5%   (   $��0��6   $��Skaliraj��6:   $
��Left=�6M   $��5,3,0,0q�6h   $	��Top=�6y   $	��107��6�   $��30��6�   ��6�   �� *skalirajCommand+�� 5&      -   5         ��Name$ 
Xagib_TXBL��5&   %   $��0��6   $
��Left=�69   $��
125,22,0,0q�6T   $
��Wrap=�6h   $��aX��6|   $	��Top=�6�   �� 5'      -   5        $ XOdsecak_TXBL��5'   %   $��0��6   $
��Left=�6<   $��
125,54,0,0q�6W   $
��Wrap=�6k   $��bX��6   $	��Top=�6�   �� 5(      -   5        $ YNagib_TXBL��5(   %   $��0��6   $
��Left=�6:   $��
280,22,0,0q�6U   $
��Wrap=�6i   $��aY��6}   $	��Top=�6�   �� 5)      -   5        $ YOdsecak_TXBL��5)   %   $��0��6   $
��Left=�6<   $��
280,54,0,0q�6W   $
��Wrap=�6k   $��bY��6   $	��Top=�6�   �� 5*      -   5        $ YPowNagib_TXBL��5*   %   $��0��6   $
��Left=�6=   $��
435,22,0,0q�6X   $
��Wrap=�6l   $��aYPow��6�   $	��Top=�6�   �� 5+      -   5        $ YPowOdsecak_TXBL��5+   %   $��0��6   $
��Left=�6?   $��
435,54,0,0q�6Z   $
��Wrap=�6n   $��bYPow��6�   $	��Top=�6�   �� 5-      -   5         ��Name$ Nagib_X_TXB��5-   $   $��0��6   $
��Left=�69   $��23��6T   $��
145,20,0,0q�6`    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��120��6�   ��6�   �� * PrikazKoeficijenata.XNagibText+�� 5.      -	   5        $ Odsecak_X_TXB��5.   $   $��0��6   $
��Left=�6;   $��23��6V   $��
145,50,0,0q�6b   $
 Wrap=�6v   $	��Top=�6�   $	��120��6�   ��6�   �� *" PrikazKoeficijenata.XOdsecakText+�� 5/      -
   5        $ Nagib_Y_TXB��5/   $   $��0��6   $
��Left=�69   $��23��6T   $��
300,20,0,0q�6`   $
 Wrap=�6t   $	��Top=�6�   $	��120��6�   ��6�   �� * PrikazKoeficijenata.YNagibText+�� 50      -   5        $ Odsecak_Y_TXB��50   $   $��0��6   $
��Left=�6;   $��23��6V   $��
300,50,0,0q�6b   $
 Wrap=�6v   $	��Top=�6�   $	��120��6�   ��6�   �� *" PrikazKoeficijenata.YOdsecakText+�� 51      -   5        $ Nagib_PowY_TXB��51   $   $��0��6   $
��Left=�6<   $��23��6W   $��
475,20,0,0q�6c   $
 Wrap=�6w   $	��Top=�6�   $	��120��6�   ��6�   �� *#!PrikazKoeficijenata.YPowNagibText+�� 52      -   5        $ Odsecak_PowY_TXB��52   $   $��0��6   $
��Left=�6>   $��23��6Y   $��
475,50,0,0q�6e   $
 Wrap=�6y   $	��Top=�6�   $	��120��6�   ��6�   �� *%#PrikazKoeficijenata.YPowOdsecakText+�� 53      -   5        $ chbx_ProveraSkaliranja��53   "   $��0��6   $��Provera skaliranja��6B   $
��Left=�6_   $��5,38,0,0q�6z   $	��Top=�6�   $	��107��6�   $��37��6�   ��6�   �� *PrikaziProveruSkaliranja+6�   �� 57      -   5         ��Name$ stpn_Dijagram��57      $��1��60   $	��340��6=   $��Bottom=�6J   $	��600��6e   $
��Left=�6q   
������ $��0,0,0,0q�58   0   .+�59      �� -   5        	 ��Name$	 Slicka��59      $��Stretch=�6)   $��Stretch=�6G   $	��339��6c   ��6q   �� *	putanja+
 �� Mode$
 OneWay=�.  (System.Windows.Interactivity.Interaction   Triggers 5;      /  )System.Windows.Interactivity.EventTrigger  5<         	EventName$ MouseLeftButtonDown��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5>      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *PozicijaMouse+   CommandParameter 6S   ��  �� ElementName$ Slicka��5A      5F      5I      � 5K   
   -   5         �Name$ UserControlContainerPotok��5K      $��1��63   $��0,2,1,10q�6C   
������y�6m   �� *visability.gridVisability+.+�5L      	� -   5         	�Name$ rdb_PowerRadio_Tacka_X1��5L      $��Prva tacka X��6;   $
��Left=�6R   $	��Top=�6n   $��99��6�   $��	50,40,0,0q�6�   ��6�   �� *radioButtonClickCommand+ d� 	IsChecked 6�   �� *Check.Check1+	� 5M      -   5        $ rdb_PowerRadio_Tacka_X2��5M      $��Druga tacka X��6;   $
��Left=�6S   $	��Top=�6o   $��99��6�   $��
50,134,0,0q�6�   ��6�   �� *radioButtonClickCommand+ 6�   �� *Check.Check2+	� 5N      -   5        $ rdb_PowerRadio_Tacka_Y1��5N      $��Prva tacka Y��6;   $
��Left=�6R   $	��Top=�6n   $��99��6�   $��
50,225,0,0q�6�   ��6�   �� *radioButtonClickCommand+ 6�   �� *Check.Check3+	� 5O      -   5        $ rdb_PowerRadio_Tacka_Y2��5O      $��Druga tacka Y��6;   $
��Left=�6S   $
��Top =�6o   $��
50,314,0,0q�6�   ��6�   �� *radioButtonClickCommand+ 6�   �� *Check.Check4+�� 5P      -   5         ��Name$ Protok_Pritisak_UC_Name��5P      $��Ose Protok i Pritisak��65   $
��Left=�6U   $	��Top=�6p   $��33,0,0,0q�6�   �� 5S      -   5        $ KoordinataX��5S      $
��Xosa��6)   $
��Left=�68   $	��Top=�6S   $��0,60,0,0q�6k   �� 5T      -   5        $ Kursor_X��5T      $��Xkurs��6&   $
��Left=�66   $	��Top=�6Q   $��0,85,0,0q�6i   �� 5U      -   5        $ KoordinataY��5U      $
��Yosa��6)   $
��Left=�68   $	��Top=�6S   $��27��6k   $��	0,245,0,0q�6w   �� 5V      -   5        $ Kursor_Y��5V      $��Ykurs��6&   $
��Left=�66   $	��Top=�6Q   $��	0,270,0,0q�6i   �� 5W      -   5        $ KoordinataX_2��5W      $
��Xosa��6+   $
��Left=�6:   $��	0,156,0,0q�6U   $	��Top=�6h   �� 5X      -   5        $ KoordinataY_2��5X      $
��Yosa��6+   $
��Left=�6:   $��	0,334,0,0q�6U   $	��Top=�6h   $��27��6�   �� 5Y      -   5        $ 
Kursor_X_2��5Y      $��Xkurs��6(   $
��Left=�68   $��	0,182,0,0q�6S   $	��Top=�6f   �� 5Z      -   5        $ 
Kursor_Y_2��5Z      $��Ykurs��6(   $
��Left=�68   $��	0,359,0,0q�6S   $	��Top=�6f   �� 5\      -   5        $ ShowX_Zad_1��5\      $��Center=�6-   $��23��6J   $
 Wrap=�6V   $	��Top=�6k   $	��116��6�   $��
49,60,13,0q�6�   ��6�   �� *TxBxPopuna.XPrviZadati+$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5]      -    5        $ ShowXMouse_Pos_1��5]      $
��Left=�62   $��23��6M   $
 Wrap=�6Z   $	��Top=�6o   $	��115��6�   $��	49,88,0,0q�6�   ��6�   �� *TxBxPopuna.XPrviKursor+$
 TwoWay=�$ PropertyChanged=��� 5^      -!   5        $ ShowX_Zad_2��5^      $
��Left=�6-   $��23��6H   $
 Wrap=�6T   $	��Top=�6i   $	��115��6�   $��
50,154,0,0q�6�   ��6�   �� *TxBxPopuna.XDrugiZadati+$
 TwoWay=�$ PropertyChanged=��� 5_      -"   5        $ ShowXMouse_Pos_2��5_      $
��Left=�62   $��23��6M   $
 Wrap=�6Y   $	��Top=�6m   $	��115��6�   $��
50,182,0,0q�6�   ��6�   �� *TxBxPopuna.XDrugiKursor+$
 TwoWay=�$ PropertyChanged=��� 5`      -#   5        $ ShowY_Zad_1��5`      $
��Left=�6,   $��23��6G   $
 Wrap=�6S   $	��Top=�6g   $	��115��6   $��
50,245,0,0q�6�   ��6�   �� *TxBxPopuna.YPrviZadati+$
 TwoWay=�$ PropertyChanged=��� 5a      -$   5        $ ShowYMouse_Pos_1��5a      $
��Left=�61   $��23��6L   $
 Wrap=�6X   $	��Top=�6m   $	��115��6�   $��
49,273,0,0q�6�   ��6�   �� *TxBxPopuna.YPrviKursor+$
 TwoWay=�$ PropertyChanged=��� 5b      -%   5        $ ShowY_Zad_2��5b      $
��Left=�6,   $��23��6G   $
 Wrap=�6T   $	��Top=�6h   $	��115��6�   $��
49,334,0,0q�6�   ��6�   �� *TxBxPopuna.YDrugiZadati+$
 TwoWay=�$ PropertyChanged=��� 5c      -&   5        $ ShowYMouse_Pos_2��5c      $
��Left=�61   $��23��6L   $
 Wrap=�6Y   $	��Top=�6m   $	��115��6�   $��
50,362,0,0q�6�   ��6�   �� *TxBxPopuna.YDrugiKursor+$
 TwoWay=�$ PropertyChanged=�5f      � 5g   
   -'   5        $ UserControlContainerPower��5g      $��1��6   $��0,2,2,2q�6C   $	��415��6T   
������y�6y   �� *visability.gridVisabilityPow+.+�5j      	� -(   5        $  rdb_PowerRadio_Tacka_PowY1��5j      $��Prva tacka Y��6>   $
��Left=�6U   $	��Top=�6q    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��99��6�   $��	39,46,0,0q�6�   ��6�   �� *radioButtonClickCommand+ 6�   �� *Check.Check5+	� 5k      -)   5        $  rdb_PowerRadio_Tacka_PowY2��5k      $��Druga tacka Y��6>   $
��Left=�6V   $
��Top =�6r   $��
39,174,0,0q�6�   ��6�   �� *radioButtonClickCommand+ 6�   �� *Check.Check6+�� 5l      -*   5        $ Power_UC_Name��5l      $��	Osa Power��6+   $
��Left=�6?   $	��Top=�6Z   $��52,0,0,0q�6r   �� 5m      -+   5        $ KoordinataYPow��5m      $
��Yosa��6,   $
��Left=�6;   $	��Top=�6V   $��27��6n   $��0,62,0,0q�6z   �� 5n      -,   5        $ Kursor_YPow��5n      $��Ykurs��6)   $
��Left=�69   $	��Top=�6T   $��1,89,0,0q�6l   �� 5o      --   5        $ KoordinataYPow_2��5o      $
��Yosa��6.   $
��Left=�6=   $��	0,190,0,0q�6X   $	��Top=�6k   $��27��6�   �� 5p      -.   5        $ Kursor_YPow_2��5p      $��Ykurs��6+   $
��Left=�6;   $��	1,217,0,0q�6V   $	��Top=�6i   �� 5r      -/   5        $ ShowY_PowZad_1��5r      $
��Left=�6/   $��23��6J   $
 Wrap=�6V   $	��Top=�6j   $	��115��6�   $��	45,66,0,0q�6�   ��6�   �� *TxBxPopuna.YPowPrviZadati+$
 TwoWay=�$ PropertyChanged=��� 5s      -0   5        $ ShowYMouse_PowPos_1��5s      $
��Left=�64   $��23��6O   $
 Wrap=�6[   $	��Top=�6p   $	��115��6�   $��	45,94,0,0q�6�   ��6�   �� *TxBxPopuna.YPowPrviKursor+$
 TwoWay=�$ PropertyChanged=��� 5t      -1   5        $ ShowY_PowZad_2��5t      $
��Left=�6/   $��23��6J   $
 Wrap=�6W   $	��Top=�6k   $	��115��6�   $��
45,194,0,0q�6�   ��6�   �� *TxBxPopuna.YPowDrugiZadati+$
 TwoWay=�$ PropertyChanged=��� 5u      -2   5        $ ShowYMouse_PowPos_2��5u      $
��Left=�64   $��23��6O   $
 Wrap=�6\   $	��Top=�6p   $	��115��6�   $��
45,222,0,0q�6�   ��6�   �� *TxBxPopuna.YPowDrugiKursor+$
 TwoWay=�$ PropertyChanged=��� 5w      -3   5        $ lbl_YPritMax��5w      $��	Yprit Max��6*   $
��Left=�6>   $��	1,300,0,0q�6Y   $	��Top=�6l   $��27��6�   �� 5x      -4   5        $ lbl_YPowMax��5x      $��
Ypower Max��6)   $
��Left=�6>   $��	0,332,0,0q�6Y   $	��Top=�6l   $��27��6�   �� 5y      -5   5        $ txbx_YPritMax��5y      $
��Left=�6.   $��23��6I   $
 Wrap=�6V   $	��Top=�6j   $��82��6�   $��
78,300,0,0q�6�   ��6�   �� *TxBxPopuna.YPritMax+$
 TwoWay=�$ PropertyChanged=��� 5z      -6   5        $ txbx_YPpwMax��5z      $
��Left=�6-   $��23��6H   $
 Wrap=�6U   $	��Top=�6i   $��82��6�   $��
78,332,0,0q�6�   ��6�   �� *TxBxPopuna.YPowMax+$
 TwoWay=�$ PropertyChanged=��� 5{      -7   5        $ lbl_XprotokMax��5{      $��Xprotok Max��6,   $
��Left=�6B   $��	1,268,0,0q�6]   $	��Top=�6p   $��27��6�   �� 5|      -8   5        $ txbx_XprotokMax��5|      $
��Left=�60   $��23��6K   $
 Wrap=�6X   $	��Top=�6l   $��82��6�   $��
78,268,0,0q�6�   ��6�   �� *TxBxPopuna.XProtMax+$
 TwoWay=�$ PropertyChanged=�5~      � 5   
   -9   5        $ SkaliranjeProvera��5      $��1��6   $��0,2,2,2q�6;   $	��415��6L   
����� �y�6t   �� *,*visability.gridVisabilityProveraSkaliranja+.+�5�      	� -:   5        $ rdb_ProtokOsaProvera��5�      $��Osa "Protok"��68   $
��Left=�6Y   $	��Top=�6u   $ 0.5,0.5&�6�   $��99��6�   $��	22,39,0,0q�6�   ��6�   �� *radioButtonClickCommand+ 6�   �� *Check.Check7+	� 5�      -;   5        $ rdb_StaticOsaProvera��5�      $��Osa "Static"��68   $
��Left=�6Y   $
��Top =�6u   $��
22,132,0,0q�6�   ��6�   �� *radioButtonClickCommand+ 6�   �� *Check.Check8+	� 5�      -<   5        $ rdb_PowerOsaProvera��5�      $��Osa "Power"��67   $
��Left=�6W   $
��Top =�6s   $��
22,236,0,0q�6�   ��6�   �� *radioButtonClickCommand+ 6�   �� *Check.Check9+�� 5�      -=   5        $ txbx_OsaProtokVrednost��5�      $
��Left=�67   $��23��6R   $
 Wrap=�6^   $	��Top=�6r   $	��115��6�   $��	45,59,0,0q�6�   ��6�   �� *TxBxPopuna.ProtokOsaProvera+$
 TwoWay=�$ PropertyChanged=��� 5�      ->   5        $ txbx_OsaStaticVrednost��5�      $
��Left=�67   $��23��6R   $
 Wrap=�6^   $	��Top=�6r   $	��115��6�   $��
45,152,0,0q�6�   ��6�   �� *TxBxPopuna.StaticPOsaProvera+$
 TwoWay=�$ PropertyChanged=��� 5�      -?   5        $ txbx_OsaPowerVrednost��5�      $
��Left=�66   $��23��6Q   $
 Wrap=�6]   $	��Top=�6q   $	��115��6�   $��
45,256,0,0q�6�   ��6�   �� *TxBxPopuna.PowerOsaProvera+$
 TwoWay=�$ PropertyChanged=��� 5�      -@   5        $ btn_ZatvoriSkaliranje��5�      $��Zatvori skaliranje��64   $
��Left=�6Q   $��
45,341,0,0q�6l   $	��Top=�6�   $	��102��6�   ��6�   �� *ZatvoriSkaliranjeCommand+5�      5�      5�      