**************************************************
private void SomeFunction()
{
	...
}

private int SomeFunction()
{
	...
	someObject.AnotherFunction();
	...
}
**************************************************

**************************************************
private async Task SomeFunctionAsync()
{
	...
	await someObject.AnotherFunctionAsync();
	...
}

private async Task<int> SomeFunctionAsync()
{
	int someVariable;
	...
	await someObject.AnotherFunctionAsync();
	...
	return someVariable;
}
**************************************************

**************************************************
*** Bad Practice *********************************
**************************************************
private async Task SomeFunctionAsync()
{
	await Task.Run(() => {
		...
	});
}
**************************************************

**************************************************
*** Bad Practice *********************************
**************************************************
private void SomeFunction()
{
	...
	var result = someObject.AnotherFunctionAsync().Result;
	...
}
**************************************************
