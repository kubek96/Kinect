   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   I EKinectKeyboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics'Microsoft.Samples.Kinect.ControlsBasics 5   	      KinectKeyboard.MainWindow   5      HControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   \ XMicrosoft.Kinect.Toolkit.Controls, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OMicrosoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=null2k(http://schemas.microsoft.com/kinect/2013   5   	   Clocal5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics   5   	     � Title$  
MainWindow��5   	    � WindowState$ 	Maximized=�6    � 	Resources 5         ChevronGeometry  	ChevronUp �� Stretch
 �� Top �� FallbackValue �� Path �� RelativeSource �� AncestorType? 9Microsoft.Samples.Kinect.ControlsBasics.KinectHoverButton	 J� RenderTransformOrigin
 �� Angle  ChevronRight  ChevronDown  ChevronLeft  KinectHoverButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value " KinectHoverButtonScrollUpStyle �� BasedOn % !KinectHoverButtonScrollRightStyle $  KinectHoverButtonScrollDownStyle $	  KinectHoverButtonScrollLeftStyle��%�  &	       &	 �    7   &	 Y   7   &	 .   7   &	    7   &	 �    &	 �    7  7  &	 ?    7  7  &	 �    7  7  &		 �    7  7  B�5	   
   miF1M150.001,146.9932L126.565,169.3822L126.565,153.5962L150.001,130.6182L173.435,153.5962L173.435,169.3822z�5      F� 5   
   $��48��6!   $��48��6-   $ Uniform=�68   $ 0��6J   8��  ��5      �� $ Black��$ 
Foreground� �� "  $	 0.5,0.5&�5   M   z�5      �� 5      $
 0Q�6"   5      F� 5   
   $��48��6$   $��48��60   $ Uniform=�6;   $ 0��6M   8��  ��5      �� $ Black��$ 
Foreground� �� "  $	 0.5,0.5&�5   M   z�5      �� 5      $
 90Q�6"   5      F� 5   
   $��48��6#   $��48��6/   $ Uniform=�6:   $ 0��6L   8��  ��5!      �� $ Black��$ 
Foreground� �� "  $	 0.5,0.5&�5"   M   z�5#      �� 5$      $	
 180Q�6"   5&      F� 5(   
   $��48��6#   $��48��6/   $ Uniform=�6:   $ 0��6L   8��  ��5*      �� $ Black��$ 
Foreground� �� "  $	 0.5,0.5&�5+   M   z�5,      �� 5-      $	
 270Q�6"   5/      �� 51   
   "  6/   .�52      ��  � ��
 �����6+   �� 53       � ��
 �����6,   �� 54       � ��$ 0q�60   6<   �� 55       � ��
 �����6;   �� 56       � �� 57      �� 58      "  6&   .R�59      � $��Stretch=�6   $��Stretch=�6=   #��z��6Y   #��z��6�   #��z��6�   .+�5:      �� #��z��6%   #��z��6Y   ._�5;   "   �� $��Stretch=�63   $��Stretch=�6Q   #��z��6m   6�   5<      5=      5>      5@       5A      P� 5B       � {� .  . �5C      ��  � ��
 �����63   �� 5D       � ��
 �����64   �� 5E       � ��
 ���� 6I   5F      P� 5G       �@ IsHandPointerOver . . �5H      ��  � �� �#5A5B5B63   �� 5I       � ��
 �����63   5J      5L      �� 5N   
   "  67   8   .�5O      ��  � ��8  6(   5P      �� 5R   
   "  6:   8   .�5S      ��  � ��8  6(   5T      �� 5V   
   "  69   8   .�5W      ��  � ��8  6(   5X      �� 5Z   
   "  69   8   .�5[      ��  � ��8  6(   5\      5]      .��5_      �  � RowDefinitions 5`   
   �� 5a      $	��120 �6   �� 5b      $��90 �6   �� 5c      $��* �6   �� 5d      $��50 �6   .+�5g   
   � $��0��6   .+�5h      8  2Microsoft.Kinect.Toolkit.Controls.KinectUserViewer  $	��100��6b   $��Center=�6o   $	��Top=�6�   4  .Microsoft.Kinect.Toolkit.Controls.KinectRegion   KinectRegion 6!   ��  �� ElementName$ kinectRegion��6�   4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  5i      -   5        $��sensorChooserUi��5i   [   $��Center=�6&   $	��Top=�6C   6[   5j      � 5l   
   $��1��6   .+�5m      �� $��36(�6.   ��6   �� *Text+6.   5n        5p   
   -   5          Name$ kinectRegion��5p   &   $��2��6   .��5q      � -   5         �Name$ kinectRegionGrid��5q      .+�5r      � $��	100,0,0,0q�6   .+�5s      �� ��6#   �� *QwertyButtons+��5u      �� 5v      .R�5w   "   �  � ColumnDefinitions 5x   &   �� 5y   *   �� 5z   *   �� 5{   *   �� 5|   *   �� 5}   *   �� 5~   *   �� 5   *   �� 5�   *   �� 5�   *   �� 5�   *    5�   &   �� 5�   *   �� 5�   *   �� 5�   *   5�   #   5�      ��5�      �� 5�      .�5�   "   ��  � �� 6=   �� *Row+�� 5�   "    � �� 6@   �� *Column+5�      ��5�      �� 5�      .R�5�   "   8  2Microsoft.Kinect.Toolkit.Controls.KinectTileButton  -   5        $��	0,0,10,10q�5�   5   $��24(�6H   ��6V   �� *Color+.��5�   &   �� ��60   �� *ButtonLabel+5�   #   5�      5�      5�      5�      5�      5�      5�      