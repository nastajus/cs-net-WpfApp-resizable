https://www.youtube.com/watch?v=J4J3ZcXRN_E
Windows Forms tutorial - C#


### Info

- Delegates - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates


### Gotchas

- WPF replaced WinForms. 

- Diagnostic Window - not visible. 
	- Checked a few menus to activate it:
	1. View > Other Windows > nope.
	1. Debug > Windows > nope. (while form not running)
	1. Debug > Windows > still nope. (while form running -- much more choices, but still nope.)
	- resolution: TBD. (also, doesn't matter.)

- attempted combination MS Tutorial example of Delegates with [this code snippet](https://social.msdn.microsoft.com/Forums/vstudio/en-US/cf884a91-c135-447d-b16b-214d2d9e9972/capture-all-keyboard-input-regardless-of-what-control-has-focus?forum=wpf) resulted in the error message: `System.ArgumentException: 'Handler type is mismatched.'`