   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  
MainWindow??5   	   $	??450??5	   	   $	??800??5
   	    ? 	Resources 5         ListBoxItemTemplate1 ? ColumnDefinitions ?? CornerRadius??%@  &	        ?? 5   
   .R?5      ?  5      ?? 5      $
??auto ?6'   ?? 5      .+?5      ?? 
???????$??20??5      $??20??5      $ 10??5      $??3q?5      
???p?5      ?? 5      $??1??5      $??10, 0, 0, 0q?5      ??5      ?? 5      5      5      5      .??5      ? $??Center=?6   $??Center=?5        5!   
   ?? 5"      ?? 5#      ?? 5$      ?? 5%      ?? 5&       ? RowDefinitions 5(   
   ?? 5)      $
??auto ?6   ?? 5*      ?? 5+      $
??auto ?6   ?? 5,      $
??auto ?6   .+?5.   
   ?? $	??< 3??6   $??0??5/      $??15, 0q?50      $??3??52      ??51      ?? *DecrementCommand+52      ?? 53   
   $	??< 1??6   $??1??54      $??15, 0q?55      $??1??57      $??15, 0, 0, 0q?58      ??56      ?? *DecrementCommand+58      ?? 59   
   $??2??5:      $??30, 0q?5;      ??59      ?? *	Counter+5;      ?? 5<   
   $	??> 1??6   $??3??5=      $??15, 0q?5>      $??1??5@      $??0, 0, 15, 0q?5A      ??5?      ?? *IncrementCommand+5A      ?? 5B   
   $	??> 3??6   $??4??5C      $??15, 0q?5D      $??3??5F      ??5E      ?? *IncrementCommand+5F      ?? 5G   
   #???   6   $??1??5H      $??5??5I      $??0, 20, 0, 0q?5J      ??5K      ?? *Items+ ?? SelectedItem 5L      ?? *SelectedItem+5M      ?? 5N   
   $??2??6   $??2??5O      $!??Выбранный эл-т:??5P      ?? 5Q   
   $??2??6   $??3??5R      $??2??5S      ??5T      ?? *SelectedItem+? 5U   
   $??3??6   $??5??5V       5W      ?? 5X      ?? 5Y      $
??auto ?6#   .+?5[      ?? ??6   ?? *
AppendText+ ?? UpdateSourceTrigger$ PropertyChanged=??? 5\      $??+??6   $??1??5]      $??10, 0, 0, 0q?5^      $
??4, 0q?5_      ??5`      ?? *
AddCommand+5a      5b      5c      