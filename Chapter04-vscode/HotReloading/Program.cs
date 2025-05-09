/* Visual Studio: run the app, change the message, click Hot Reload.
* VS Code: run the app using dotnet watch, change the message. */

while (true)
{
    WriteLine("Goodbye, Hot Reload!");
    await Task.Delay(2000);
}