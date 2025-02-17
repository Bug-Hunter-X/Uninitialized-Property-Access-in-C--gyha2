# Uninitialized Property Access in C#

This example demonstrates a common, yet subtle, error in C#: accessing a property before ensuring it has been initialized.  In this case, if the `MyProperty` is not set before calling `MyMethod()`, a `NullReferenceException` will be thrown.  This often happens in complex class structures or when dealing with optional parameters and property defaults.