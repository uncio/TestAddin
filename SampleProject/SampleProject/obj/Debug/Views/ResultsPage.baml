   M S B A M L   `   `   `  ????H  DSampleProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SampleProject.ViewsSampleProject.Views  5      C&clr-namespace:SampleProject.PropertiesSampleProject.Properties  5      O,clr-namespace:SampleProject.Views.ConvertersSampleProject.Views.Converters  5      %    SampleProject.Views.ResultsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:SampleProject.Views     5      7prop&clr-namespace:SampleProject.Properties     5      =conv,clr-namespace:SampleProject.Views.Converters     5        ? 	Resources  5
      >  8SampleProject.Views.Converters.BoolToVisibilityConverter   BoolToVisibilityConverter:  4SampleProject.Views.Converters.ColorToBrushConverter  ColorToBrushConverter??%:   &	        &	        5   
   6)     5   
   6%   5      .??5      ?  ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      .+?5   
   ?? $??2??6   (   "SampleProject.Properties.Resources   TextFinalProperties#??Z 5       $??Center=?5!      $??Center=?5"      ?? 5$   
   $??1??6   $??0??5%          TextForegroundFillPattern#??Z 5&      $??5 0 0 0q?5'      $
??Left=?5(      $??Center=?5)      y?5*      ??  ?? Path$* $Configuration.FillPatternNameChecked? ?? 	Converter# [  ?? 5+   
   $??1??6   $??1??5,      $??Center=?5-      $??Center=?5.      ??5/      ?? $# SPOverridesVM.FillPatternName?y?50      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 52   
   $??2??6   $??0??53         TextForegroundFillColor#??Z 54      $??5 0 0 0q?55      $
??Left=?56      $??Center=?57      y?58      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 59   
   -   5         ??Name$
 test??5D      $??2??59      $??1??5:      
???????$??2q?5<      $	??130??5=      $??20??5>      $??Center=?5@      $??Center=?5A      ??5?      ?? $$ SPOverridesVM.FillPatternColor?# [ y?5B      ?? $* $Configuration.FillPatternNameChecked?# [  5D      ?? 5F   
   $??3??6   $??0??5G       	   TextForegroundFillVisible#??Z	 5H      $??5 0 0 0q?5I      $
??Left=?5J      $??Center=?5K      y?5L      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5M   
   $??3??6   $??1??5N      $??Center=?5O      $??Center=?5P      ??5Q      ?? $" SPOverridesVM.FillVisibility?y?5R      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5T   
   $??4??6   $??0??5U      
   TextLinePatternName#??Z
 5V      $??5 0 0 0q?5W      $
??Left=?5X      $??Center=?5Y      y?5Z      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5[   
   $??4??6   $??1??5\      $??Center=?5]      $??Center=?5^      ??5_      ?? $# SPOverridesVM.LinePatternName?y?5`      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5b   
   $??5??6   $??0??5c         TextLinePatternColor#??Z 5d      $??5 0 0 0q?5e      $
??Left=?5f      $??Center=?5g      y?5h      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5i   
   $??5??6   $??1??5j      
???????$??2q?5l      $	??130??5m      $??20??5n      $??Center=?5p      $??Center=?5q      ??5o      ?? $ SPOverridesVM.LinesColor?# [ y?5r      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5t   
   $??6??6   $??0??5u         TextLinePatternThickness#??Z 5v      $??5 0 0 0q?5w      $
??Left=?5x      $??Center=?5y      y?5z      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5{   
   $??6??6   $??1??5|      $??Center=?5}      $??Center=?5~      ??5      ?? $" SPOverridesVM.ThicknessLines?y?5?      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5?   
   $??7??6   $??0??5?         TextIsHalftone#??Z 5?      $??5 0 0 0q?5?      $
??Left=?5?      $??Center=?5?      y?5?      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5?   
   $??7??6   $??1??5?      $??Center=?5?      $??Center=?5?      ??5?      ?? $ SPOverridesVM.Halftone?y?5?      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5?   
   $??8??6   $??0??5?         TextTransparency#??Z 5?      $??5 0 0 0q?5?      $
??Left=?5?      $??Center=?5?      y?5?      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5?   
   $??8??6   $??1??5?      $??Center=?5?      $??Center=?5?      ??5?      ?? $  SPOverridesVM.Transparency?y?5?      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5?   
   -   5        $??9??5?      $??0??5?         Back#??Z 5?      $
??Left=?5?      $??Center=?5?      $	??130??5?      $??	15 0 15 0q?5?      y?5?      ?? $* $Configuration.FillPatternNameChecked?# [  ?? 5?   
   $??9??6   $??1??5?         SelectNewElement#??Z 5?      $??Right=?5?      $??Center=?5?      $	??130??5?      $??0 0 15 0q?5?      ??5?      ?? *SelectElementCommand+y?5?      ?? $* $Configuration.FillPatternNameChecked?# [  5?      5?      