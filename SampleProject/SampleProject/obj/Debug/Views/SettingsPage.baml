   M S B A M L   `   `   `  ????H  DSampleProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SampleProject.ViewsSampleProject.Views  5      C&clr-namespace:SampleProject.PropertiesSampleProject.Properties  5      &     SampleProject.Views.SettingsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:SampleProject.Views     5      7prop&clr-namespace:SampleProject.Properties     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5       ? ColumnDefinitions 5   
   ?? 5      $??5* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??2??6   (   "SampleProject.Properties.Resources   TextOverrideProperties#??Z 5      $??Center=?5      $??Center=?5      ?? 5   
   $??1??6   $??0??5           TextForegroundFillPattern#??Z 5!      $??5 0 0 0q?5"      $
??Left=?5#      $??Center=?5$      ?? 5%   
   $??1??6   $??1??5&      $??Center=?5'      $??Center=?5(       d? 	IsChecked 5)      ??  ?? Path$* $Configuration.FillPatternNameChecked??? 5+   
   $??2??6   $??0??5,         TextForegroundFillColor#??Z 5-      $??5 0 0 0q?5.      $
??Left=?5/      $??Center=?50      ?? 51   
   $??2??6   $??1??52      $??Center=?53      $??Center=?54       55      ?? $+ %Configuration.FillPatternColorChecked??? 57   
   $??3??6   $??0??58          TextForegroundFillVisible#??Z 59      $??5 0 0 0q?5:      $
??Left=?5;      $??Center=?5<      ?? 5=   
   $??3??6   $??1??5>      $??Center=?5?      $??Center=?5@       5A      ?? $0 *Configuration.FillPatternVisibilityChecked??? 5C   
   $??4??6   $??0??5D         TextLinePatternName#??Z 5E      $??5 0 0 0q?5F      $
??Left=?5G      $??Center=?5H      ?? 5I   
   $??4??6   $??1??5J      $??Center=?5K      $??Center=?5L       5M      ?? $* $Configuration.LinePatternNameChecked??? 5O   
   $??5??6   $??0??5P      	   TextLinePatternColor#??Z	 5Q      $??5 0 0 0q?5R      $
??Left=?5S      $??Center=?5T      ?? 5U   
   $??5??6   $??1??5V      $??Center=?5W      $??Center=?5X       5Y      ?? $+ %Configuration.LinePatternColorChecked??? 5[   
   $??6??6   $??0??5\      
   TextLinePatternThickness#??Z
 5]      $??5 0 0 0q?5^      $
??Left=?5_      $??Center=?5`      ?? 5a   
   $??6??6   $??1??5b      $??Center=?5c      $??Center=?5d       5e      ?? $( "Configuration.LineThicknessChecked??? 5g   
   $??7??6   $??0??5h         TextIsHalftone#??Z 5i      $??5 0 0 0q?5j      $
??Left=?5k      $??Center=?5l      ?? 5m   
   $??7??6   $??1??5n      $??Center=?5o      $??Center=?5p       5q      ?? $% Configuration.IsHalftoneChecked??? 5s   
   $??8??6   $??0??5t         TextTransparency#??Z 5u      $??5 0 0 0q?5v      $
??Left=?5w      $??Center=?5x      ?? 5y   
   $??8??6   $??1??5z      $??Center=?5{      $??Center=?5|       5}      ?? $' !Configuration.TransparencyChecked??? 5   
   -   5        $??9??5      $??2??5?         SelectElement#??Z 5?      $??Right=?5?      $??Center=?5?      $	??100??5?      $??0 0 15 0q?5?      ??5?      ?? *SelectElementCommand+5?      5?      5?      