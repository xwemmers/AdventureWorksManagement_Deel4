   M S B A M L   `   `   `  ����S  OAdventureWorksManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:AdventureWorksManagementAdventureWorksManagement  5   	   )    #AdventureWorksManagement.EditWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:AdventureWorksManagement     5   	     � Title$  
EditWindow��5   	   $
��1000��6   $	��850��6*   $	��700��6:   $	��500��6F   .��5	      �  � DataContext 6   �� *CurrentProduct+ � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � 	Resources 5    
    �� 
TargetType �� Property �� Value(  "System.Windows.Controls.DatePicker��%  '��       '�� �     '��     '  w    �� 5!      " ��6   .�5"      ��  � ��$ Center=�66   �� 5#       � ��$ Right=�68   �� 5$       � ��$ 10q�6+   5%      �� 5&      " ��6   .�5'      ��  � ��$ 30��6+   �� 5(       � ��$ Center=�6=   5)      �� 5*      " ��6   .�5+      ��  � ��$ 30��6+   �� 5,       � ��$ Center=�6=   5-      �� 5.      "  6   .�5/      ��  � ��$ 30��6+   �� 50       � ��$ Center=�6=   51      52      .+�54   
   �� .��6   
Product ID6   �� 55   
   $��1��6   .��6   Name6#   �� 56   
   $��2��6   .��6   Product Number6-   �� 57   
   $��3��6   .��6   Color6$   �� 58   
   $��4��6   .��6   Standard Cost6,   �� 59   
   $��5��6   .��6   
List Price6)   �� 5:   
   $��6��6   .��6   Size6#   �� 5;   
   $��7��6   .��6   Weight6%   �� 5<   
   $��8��6   .��6   Product Category ID62   �� 5=   
   $��9��6   .��6   Product Model ID6/   �� 5>   
   $��10��6   .��6   Sell Start Date6/   �� 5?   
   $��11��6   .��6   Sell End Date6-   �� 5@   
   $��12��6   .��6   Discontinued Date61   �� 5B   
   $��1��6    �� 
IsReadOnly . ��6"   �� *	ProductID+6Q   �� 5C   
   $��1��6   $��1��6"   ��6/   �� *Name+6G   �� 5D   
   $��1��6   $��2��6"    . ��6/   �� *ProductNumber+6b   �� 5F   
   -   5        $��	cbxColors��5F   0   $��1��6   $��3��6#   	 �� SelectedItem	 6A   �� *Color+6b   �� 5G   
   $��1��6   $��4��6"   ��6/   �� *StandardCost+6O   �� 5H   
   $��1��6   $��5��6"   ��6/   �� *	ListPrice+6L   �� 5I   
   $��1��6   $��6��6"   ��6/   �� *Size+6G   �� 5J   
   $��1��6   $��7��6"   ��6/   �� *Weight+6I   �� 5K   
   -   5        $��cbxSubcategories��5K   0   $��1��6   $��8��6#   
 �� DisplayMemberPath$

 Name��6�    �� SelectedValuePath$ ProductCategoryID��6�    �� SelectedValue 6H   �� *ProductCategoryID+��6t   �� *Subcategories+6�   �� 5L   
   $��1��6   $��9��6"   ��6/   �� *ProductModelID+6Q     5M   
   $��1��6   $��10��6%      SelectedDate 63   �� *SellStartDate+6\     5N   
   $��1��6   $��11��6%    63   �� *SellEndDate+6Z     5O   
   $��1��6   $��12��6%    63   �� *DiscontinuedDate+6_   � 5Q   
   $��1��6   $��13��6    5R      �� 5S      �� 5T       5V      ��%U   '��       �� 5W      " ��6   .�5X      ��  � ��$ 20,20q�6/   5Y      5Z      .+�5[      �� -   5        .��5[   ,   	Opslaan65   �� 5\      -   5        $��1��5\      .��6:   	Annuleren6E   5]      5^      5_      