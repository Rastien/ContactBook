   M S B A M L   `   `   `  ����G  CWPF Contacts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_Contacts.ViewsWPF_Contacts.Views  5      $    WPF_Contacts.Views.DetailsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WPF_Contacts.Views     5      .��5	      �   � RowDefinitions  5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      $	��100 �6#   .+�5      �� $��0��6   $
��Left=�6)   $��5q�5      .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Center=�6!   .+�5      �� $��Center=�5       $��24(�5       ��5       �� *SelectedContact.Name+ �� FallbackValue$
 NULL��5       5      �� 5       $��isFavourite��6   5!      � 5#      $	��125��6   $	��125��6$   .+�5$      �� $	��125��6   $	��125��6)   ��5%      �� *SelectedContact.ImagePath+   DefaultContactImage# [   �� TargetNullValue# [  �� 5)        MenuIconButtons#��[ 6     GloomyPurple#��[ 6F   $��Bottom=�5*      $��Right=�5+      
���   �$��DemiBold"�5-      .��63   Browse5/      52      53      �� 55      $��1��6   $��Bottom=�6)   $ 
Horizontal=�6D   .+�56      �� #��[ 6     MaximumBlueGreen#��[ 6B   $��90��57      $��40��6    $��5q�6,   ��58      �� 59      $ 
Horizontal=�6%   .+�5:      �� $4��./WPF Contacts;component/Resources/saveIcon.png��6$   �� 5;      $
��Bold"�6$   .��66   Save6<   5<      5>      5?      5@      �� 5C   
   $��1��6   $��5q�6"   .+�5D      �� .+�5E      ��   DetailBorder#��[ 6   ._�5F      �� $
��Bold"�6   ���	#FFF5F7F9$��Phone��6E   5G      �� 5I      .+�5K      ��   DetailLabel#��[ 6   $
��Home��6A   �� 5L        ContentLabel#��[ 6   ��6B   �� *!SelectedContact.PhoneNumbers[0]+$
 Null���� 5O      #��[ 6   $
��Cell��6A   �� 5P      #��[ 6   ��6B   �� *!SelectedContact.PhoneNumbers[1]+$
 Null��5Q      5R      5S      �� 5V   
   $��2��6   $��5q�6"   .+�5W      �� .+�5X      �� #��[ 6   ._�5Y      �� $
��Bold"�6   ���	#FFF5F7F9$��Emails��6E   5Z      �� 5\      .+�5^      �� #��[ 6   $��Personal��6A   �� 5_      #��[ 6   ��6B   �� *SelectedContact.Emails[0]+$
 Null���� 5b      #��[ 6   $
��Work��6A   �� 5c      #��[ 6   ��6B   �� *SelectedContact.Emails[1]+$
 Null��5d      5e      5f      �� 5i   
   $��3��6   $��5q�6"   .+�5j      �� .+�5k      �� #��[ 6   ._�5l      �� $
��Bold"�6   ���	#FFF5F7F9$��	Locations��6E   5m      �� 5o      .+�5q      �� #��[ 6   $
��Home��6A   �� 5r      #��[ 6   ��6B   �� *SelectedContact.Locations[0]+$
 Null���� 5u      #��[ 6   $
��Cell��6A   �� 5v      #��[ 6   ��6B   �� *SelectedContact.Locations[1]+$
 Null��5w      5x      5y      5{      5|      