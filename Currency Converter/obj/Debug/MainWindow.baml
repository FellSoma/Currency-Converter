   M S B A M L   `   `   `  ����M  ICurrency Converter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Currency_ConverterCurrency_Converter  5   	   #    Currency_Converter.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Currency_Converter     5   	     � Title$  Currency Converter��5   	   $	��300��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   $	��700��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��34* �6   �� 5      $	��45* �6   �� 5      $
��205* �6    � ColumnDefinitions 5   
   �� 5      $
��319* �6   �� 5      $	��49* �6   �� 5      $
��332* �6   .+�5   
   �� -   5         ��Name$ inputCurrency��5       $��0��5      $��DemiBold"�5      $��2��5      $	��160��5      $	��Top=�5      $��	10,10,0,0q�5      $��20(�5!      ���#cfcfcf5#      �� 5%   
   -   5        $ 
conclusion��5*      $��2��5&      $��2��5'      $	��160��5(      $��20(�5)       �� 
IsReadOnly . $��DemiBold"�5,      $	��Top=�5-      $��	0,10,10,0q�5.      ���#cfcfcf5/      �� 51   
   -   5         ��Name$ cbFirstCurrency��55      $��	10,11,0,9q�52      $��70��53      $��0��54      $��1��56      $
��Left=�57      58      �� 5:   
   $��17(�5;      $��DemiBold"�5<      $��0��5=      $��1��5>      $��Center=�5?      $��90,0,0,0q�5@      $��У меня есть��5A      $��22��6    �� 5D   
   -   5        $ cbSecondCurrency��5G      $��	10,11,0,9q�5E      $��70��5F      $��2��5I      $��1��5J      $
��Left=�5K      �� 5M   
   $��17(�5N      $��DemiBold"�5O      $��2��5P      $��1��5Q      $��Center=�5R      $��90,0,0,0q�5S      $#��Хочу преобрести��5T      $��22��6$   �� 5V   
   $��20(�5W      $��DemiBold"�5X      $��3��5Y      $��Center=�5Z      $��Center=�5[      $,��&Конвертер валют banki.ru��5\      $��26��5]      $	��250��5^      �� 5`   
   -   5        $	��⇆��5a      $��30(�5b      
������ 
������ $��1��5e      $��2��5f      $��4,0,4,0q�5g      $��Center=�5h      $��44��5i      5j      5k      5l      