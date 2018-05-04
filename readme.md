https://www.youtube.com/watch?v=J4J3ZcXRN_E
Windows Forms tutorial - C#

Purpose: resize all widget elements on the form, by simply listening for mouse event and keyboard events. Like how i expect all forms in all applications to always work. Default font of 8 pt is too squinty by far for my tastes.

[//]: # (Status: some keyboard input success, next is iterating all elements to change their sizes in a correct fashion.)

### Topics

- Visual Studio windows hiding locations.
- Delegates
- KeyEventHandler delegate
- MouseWheel delegate.
- [Capture keyboard and mouse](https://stackoverflow.com/questions/22155512/c-sharp-wpf-capture-keyboard-and-mouse).


### Gotchas

- WPF replaced WinForms. 

- Diagnostic Window - not visible. 
	- Checked a few menus to activate it:
	1. View > Other Windows > nope.
	1. Debug > Windows > nope. (while form not running)
	1. Debug > Windows > still nope. (while form running -- much more choices, but still nope.)
	- resolution: TBD. (also, doesn't matter.)

- attempted combination [MS Guide example of Delegates](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates) with [this code snippet](https://social.msdn.microsoft.com/Forums/vstudio/en-US/cf884a91-c135-447d-b16b-214d2d9e9972/capture-all-keyboard-input-regardless-of-what-control-has-focus?forum=wpf) resulted in the error message: `System.ArgumentException: 'Handler type is mismatched.'` 
	- reason being that the MS Guide was showcasing the entire delegate concept, which involves a pair of functions. I was not appropriately combining in my first attempt, which fueled all the lessons.

	- what I needed to do was discover the first method of delegate type KeyEventArgs existed, which I had not seen yet from these two disparate examples I had quickly assembled.
	- and second, I needed to realize I was supposed to implement my own method of matching signature to the first method. i may refer to this as  "overriding method" or "extending method".
	- the guide refers to **wrapping** when bridging these two levels.
	
- mousewheel delegates work differently, seemingly.

- `using static System.Windows.UIElement;` -- not sure why wasn't necessary for `MouseWheel += MouseWheelDelegate;` to work, somehow the scope of this class "knew" this.


### Observations
- Delegates
	1. The invocation of `System.Windows.RegisterClassHandler(...)` accepts a type of `Delegate` as the third parameter.
	1. That third paramater example takes an input of type `new KeyEventHandler(keyUp)` and invokes a developer-custom method signature of `keyUp(object sender, KeyEventArgs e)`, to compile & execute successfully.
	1. Changing either paramater of the dev. meth. breaks typing, preventing compilation and thus execution obviously.
	1. **Navigating to definition** (`F12`) shows that matching signature, appearing that delegates are designed to overriden. 

```
namespace System.Windows.Input
{
    public delegate void KeyEventHandler(object sender, KeyEventArgs e);
}
```
	- summary: One essentially passes in a method of matching signature, which will be eventually called. Precisely how TBD. 

