   M S B A M L   `   `   `  ����G  CZombiesRound, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ZombiesRoundZombiesRound  5   	       ZombiesRound.BlackOps4   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ZombiesRound     5   	     � WindowStartupLocation$  Manual=�5   	    � Left$	 500��5	   	   
 � Top$	 300��6    � Title$ 	BlackOps4��5
   	   $	��450��6   $	��800��6(   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��80* �6   �� 5      $	��22* �6   �� 5      $	��80* �6   �� 5      $	��47* �6   �� 5      $	��67* �6   �� 5      $
��496* �6   .+�5   
   �� -   5        $��tc_BO4��5      $
��Left=�6$   $	��445��6?   $	��Top=�6L   $	��792��6d   $��	0,-26,0,0q�6p   $��6��6�   .@�5      �� $��Map Selection��6   .��5      � $��
-11,0,-8,0q�6   ��5      �� 5       �� ImageSource$I CC:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4 maps\bo4.jpg��6%    j� Stretch$ UniformToFill=�6w   .+�5      �� -   5         ��Name$ 	Alpha_btn��5   @   
�������$��Alpha��60   
������ $��10,0,618,366q�6l   $��0q�6�   5      �� 5      -   5        $ Ancient_btn��5   G   
�������$��Anicent Evil��60   
������ $��10,51,618,315q�6u   $��0q�6�   5      �� 5       -   5        $ IX_btn��5    =   
�������$��IX��60   
������ $��10,102,618,269q�6f   $��0q�6~   5"      �� 5#      -   5        $ voy_btn��5#   L   
�������$��Voyage of despair��60   
������ $��10,324,618,53q�6v   $��0q�6�   5$      �� 5%      -   5        $ 	Blood_btn��5%   @   
�������$��Blood��60   
������ $��10,236,618,137q�6l   $��0q�6�   5'      �� 5(      -   5        $ Call_btn��5(   H   
�������$��Tag der toten��60   
������ $��10,280,618,93q�6s   $��0q�6�   5)      �� 5*      -   5        $ 	Class_btn��5*   E   
�������$��
Classified��60   
������ $��10,192,618,181q�6q   $��0q�6�   5,      �� 5-      -	   5        $ Dead_btn��5-   L   
�������$��Dead of the Night��60   
������ $��10,148,618,225q�6w   $��0q�6�   5/      50      51      �� 52      $��Alpha��6   .��53      � $��-8,0,0,0q�6   ��54      �� 55      $I CC:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4 maps\AO1.jpg��6%   $ UniformToFill=�6w    57      �� 58      $	��25* �6+   �� 59      $
��442* �6+   �� 5:      $
��319* �6+   .+�5<      �� -
   5         ��Name$ 
listRounds��5<      $
��Left=�63   $	��277��6N   $��	10,61,0,0q�6[   $	��Top=�6n   $	��190��6�   $��1��6�   �� 5=      -   5        $��	myTextBox��5=      $
��Left=�6/   $��32��6J   $��
10,343,0,0q�6V   	 �� TextWrapping$
	 Wrap=�6j   $��TextBox��6~   $	��Top=�6�   $	��190��6�   $��1��6�   �� 5>      $��Alpha��6   
�������$��1��6?   $
��Left=�6O   $��	10,30,0,0q�6j   $	��Top=�6}   �� 5?      -   5        $��	Add Round��5?      $
��Left=�61   $��211,343,0,0q�6L   $	��Top=�6a   $	��158��6y   $��32��6�   $��1��6�   �� 5@      -   5        $ RemoveA_btn��5@      $��Remove Round��63   $
��Left=�6J   $��211,306,0,0q�6e   $	��Top=�6z   $	��158��6�   $��32��6�   $��1��6�   �� 5B      -   5        
������ $��0q�5B   6   $��2��6J   $��206,10,10,307q�6Z   .��5C      �� .+�5D      �� $@��:C:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4.png��6$   5E      5F      5G      5H      �� 5I      $��Anicent��6   .��5J      � $��-7,-4,-13,0q�6    5K      �� 5L      $
��201* �6+   �� 5M      $	��52* �6+   �� 5N      $
��553* �6+   ��5P      �� 5Q      $H BC:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4 maps\ae.jpg��6%   $ UniformToFill=�6v   .+�5W      �� $��Anicent��6   
�������$
��Left=�6A   $��	10,30,0,0q�6\   $	��Top=�6o   �� 5X      -   5        $��
myTextBoxA��5X      $
��Left=�60   $��32��6K   $��
10,343,0,0q�6W   $
	 Wrap=�6k   $��TextBox��6   $	��Top=�6�   $	��190��6�   �� 5Y      -   5        $ 
AddRoundAN��5Y      $��	Add Round��62   $
��Left=�6F   $��
10,343,0,0q�6a   $	��Top=�6u   $	��158��6�   $��32��6�   $��2��6�   $��1��6�   �� 5Z      -   5        $ RemoveAN_btn��5Z      $��Remove Round��64   $
��Left=�6K   $��
10,306,0,0q�6f   $	��Top=�6z   $	��158��6�   $��32��6�   $��2��6�   $��1��6�   �� 5[      -   5        $ HomeA��5[      
������ $��0q�6G   $��386.667,10,16,0q�6\   $	��Top=�6u   $	��150��6�   $	��100��6�   $��2��6�   .��5\      �� .+�5]      �� $@��:C:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4.png��6$   $��78��6h   $	��103��6t   5^      5_      �� 5b      -   5        $ listAnicent��5b      $
��Left=�64   $	��277��6O   $��	10,61,0,0q�6\   $	��Top=�6o   $	��190��6�   6�   5c      5d      �� 5e      $��IX��6   .��5f      � ��5g      �� 5h      $H BC:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4 maps\IX.jpg��6%   $ UniformToFill=�6v   .+�5k      �� $��IX��6   
�������$��1��6<   $
��Left=�6L   $��	10,30,0,0q�6g   $	��Top=�6z   �� 5l      -   5        $��
myTextBoxI��5l      $
��Left=�60   $��32��6K   $��
10,343,0,0q�6W   $
	 Wrap=�6k   $��TextBox��6   $	��Top=�6�   $	��190��6�   $��1��6�   �� 5m      -   5        $ 
AddRoundIX��5m      $��	Add Round��62   $
��Left=�6F   $��211,343,0,0q�6a   $	��Top=�6v   $	��158��6�   $��32��6�   $��1��6�   �� 5n      -   5        $ listIX��5n      $
��Left=�6/   $	��277��6J   $��	10,61,0,0q�6W   $	��Top=�6j   $	��190��6�   $��1��6�   �� 5o      -   5        $ RemoveIX_btn��5o      $��Remove Round��64   $
��Left=�6K   $��211,306,0,0q�6f   $	��Top=�6{   $	��158��6�   $��32��6�   6�   �� 5p      -   5        $ HomeIX��5p      
������ $��0q�6H   $��583,301,36,-24q�6]   $	��Top=�6u   $	��140��6�   .��5q      �� .+�5r      �� $@��:C:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4.png��6$   $	��118��6h   $	��117��6u   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   z�5s   "   V� 5t   &   .~�5u   *   �� �� 5v   *   �� 5w   *    �� Angle$ 0.719Q�6:   T� 5x   *   5y   '   5{      5|      5}      5~      5      �� 5�      $��Voyage��6   .��5�      � ��5�      �� 5�      $I CC:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4 maps\voy.jpg��6%   $ UniformToFill=�6w   .+�5�      �� $��Voyage��6   
�������$��1��6@   $
��Left=�6P   $��	10,30,0,0q�6k   $	��Top=�6~   �� 5�      -   5        $��
mytextboxV��5�      $
��Left=�60   $��32��6K   $��
10,343,0,0q�6W   $
	 Wrap=�6k   $��TextBox��6   $	��Top=�6�   $	��190��6�   $��1��6�   �� 5�      -   5        $ 	AddRoundV��5�      $��	Add Round��61   $
��Left=�6E   $��211,343,0,0q�6`   $	��Top=�6u   $	��158��6�   $��32��6�   $��1��6�   �� 5�      -   5        $ listV��5�      $
��Left=�6.   $	��277��6I   $��	10,61,0,0q�6V   $	��Top=�6i   $	��190��6�   $��1��6�   �� 5�      -   5        $ RemoveV_btn��5�      $��Remove Round��63   $
��Left=�6J   $��211,306,0,0q�6e   $	��Top=�6z   $	��158��6�   $��32��6�   6�   �� 5�      -   5        $ HomeV��5�      
������ $��0q�6G   $��626,10,10,0q�6\   $	��Top=�6q   $	��150��6�   $	��100��6�   .��5�      �� .+�5�      �� $@��:C:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4.png��6$   $��78��6h   $	��103��6t   5�      5�      5�      5�      �� 5�      $��Blood of the dead��6   .��5�      � ��5�      �� 5�      $K EC:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4 maps\blood.jpg��6%   $ UniformToFill=�6y   .+�5�      �� $��Blood��6   
�������$��1��6?   $
��Left=�6O   $��	10,30,0,0q�6j   $	��Top=�6}   �� 5�      -   5        $��
mytextboxB��5�      $
��Left=�60   $��32��6K   $��
10,343,0,0q�6W   $
	 Wrap=�6k   $��TextBox��6   $	��Top=�6�   $	��190��6�   $��1��6�   �� 5�      -   5        $ 	AddRoundB��5�      $��	Add Round��61   $
��Left=�6E   $��211,343,0,0q�6`   $	��Top=�6u   $	��158��6�   $��32��6�   $��1��6�   �� 5�      -    5        $ listB��5�      $
��Left=�6.   $	��277��6I   $��	10,61,0,0q�6V   $	��Top=�6i   $	��190��6�   $��1��6�   �� 5�      -!   5        $ RemoveB_btn��5�      $��Remove Round��63   $
��Left=�6J   $��211,306,0,0q�6e   $	��Top=�6z   $	��158��6�   $��32��6�   6�   �� 5�      -"   5        $ HomeB��5�      
������ $��0q�6G   $��626,10,10,0q�6\   $	��Top=�6q   $	��150��6�   $	��100��6�   .��5�      �� .+�5�      �� $@��:C:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4.png��6$   $��78��6h   $	��103��6t   5�      5�      5�      5�      �� 5�      $��
Classified��6   .��5�      � ��5�      �� 5�      $K EC:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4 maps\class.jpg��6%   $ UniformToFill=�6y   .+�5�      �� $��Class��6   
�������$
��Left=�6?   $��	10,30,0,0q�6Z   $	��Top=�6m   �� 5�      -#   5        $��
mytextboxC��5�      $
��Left=�60   $��32��6K   $��
10,343,0,0q�6W   $
	 Wrap=�6k   $��TextBox��6   $	��Top=�6�   $	��190��6�   $��1��6�   �� 5�      -$   5        $ 	AddRoundC��5�      $��	Add Round��61   $
��Left=�6E   $��211,343,0,0q�6`   $	��Top=�6u   $	��158��6�   $��32��6�   $��1��6�   �� 5�      -%   5        $ listC��5�      $
��Left=�6.   $	��277��6I   $��	10,61,0,0q�6V   $	��Top=�6i   $	��190��6�   $��1��6�   �� 5�      -&   5        $ RemoveC_btn��5�      $��Remove Round��63   $
��Left=�6J   $��211,306,0,0q�6e   $	��Top=�6z   $	��158��6�   $��32��6�   6�   �� 5�      -'   5        $ HomeC��5�      
������ $��0q�6G   $��626,10,10,0q�6\   $	��Top=�6q   $	��150��6�   $	��100��6�   .��5�      �� .+�5�      �� $@��:C:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4.png��6$   $��78��6h   $	��103��6t   5�      5�      5�      5�      �� 5�      $��Dead of the night��6   .��5�      �  5�      �� 5�      $	��77* �6+   �� 5�      $
��316* �6+   ��5�      �� 5�      $J DC:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4 maps\dead.jpg��6%   $ UniformToFill=�6x   .+�5�      �� $
��Dead��6   
�������$
��Left=�6>   $��	10,30,0,0q�6Y   $	��Top=�6l   �� 5�      -(   5        $��
mytextboxD��5�      $
��Left=�60   $��32��6K   $��
10,343,0,0q�6W   $
	 Wrap=�6k   $��TextBox��6   $	��Top=�6�   $	��190��6�   $��2��6�   �� 5�      -)   5        $ 	AddRoundD��5�      $��	Add Round��61   $
��Left=�6E   $��
57,343,0,0q�6`   $	��Top=�6t   $	��158��6�   $��32��6�   $��1��6�   �� 5�      -*   5        $ listD��5�      $
��Left=�6.   $	��277��6I   $��	10,61,0,0q�6V   $	��Top=�6i   $	��190��6�   $��2��6�   �� 5�      -+   5        $ RemoveD_btn��5�      $��Remove Round��63   $
��Left=�6J   $��
57,306,0,0q�6e   $	��Top=�6y   $	��158��6�   $��32��6�   $��1��6�   �� 5�      -,   5        $ HomeD��5�      
������ $��0q�6G   $��472,10,10,0q�6\   $	��Top=�6q   $	��150��6�   $	��100��6�   $��1��6�   .��5�      �� .+�5�      �� $@��:C:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4.png��6$   $��78��6h   $	��103��6t   5�      5�      5�      5�      �� 5�      $	��tag��6   .��5�      � ��5�      �� 5�      $I CC:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4 maps\tag.png��6%   $ UniformToFill=�6w   .+�5�      �� $	��tag��6   
�������$��1��6=   $
��Left=�6M   $��	10,30,0,0q�6h   $	��Top=�6{   �� 5�      --   5        $��
mytextboxT��5�      $
��Left=�60   $��32��6K   $��
10,343,0,0q�6W   $
	 Wrap=�6k   $��TextBox��6   $	��Top=�6�   $	��190��6�   $��2��6�   �� 5�      -.   5        $ 	AddRoundT��5�      $��	Add Round��61   $
��Left=�6E   $��205,343,0,0q�6`   $	��Top=�6u   $	��158��6�   $��32��6�   6�   �� 5�      -/   5        $ listT��5�      $
��Left=�6.   $	��277��6I   $��	10,61,0,0q�6V   $	��Top=�6i   $	��190��6�   $��2��6�   �� 5�      -0   5        $ RemoveT_btn��5�      $��Remove Round��63   $
��Left=�6J   $��205,306,0,0q�6e   $	��Top=�6z   $	��158��6�   $��32��6�   6�   �� 5�      -1   5        $ HomeT��5�      
������ $��0q�6G   $��472,10,10,0q�6\   $	��Top=�6q   $	��150��6�   $	��100��6�   $��1��6�   .��5�      �� .+�5�      �� $@��:C:\Users\Ollie\Desktop\Work\Zombies Project\Assets\BO4.png��6$   $��78��6h   $	��103��6t   5�      5�      5�      5�      5�      5�      5�      