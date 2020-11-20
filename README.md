![.NET Core](https://github.com/aimenux/UpperLowerCliDemo/workflows/.NET%20Core/badge.svg)
# UpperLowerCliDemo
```
Playing with net core global tools
```
> In this demo, i m building a dummy global cli tool upperizing or lowerizing input characters
>
> The tool is based on one main command with two options :
> - Use option `-u` to upperize input characters
> - Use option `-l` to lowerize input characters
>
> In order to run the demo, type the following commands in your favorite terminal : 
> - `App.exe -u "InputCharacters"`
> - `App.exe -l "InputCharacters"`
>
> To install, run, uninstall global tool from a local source path, type commands :
> - `dotnet tool install -g --add-source ./app/cli-tools upperlower-cli`
> - `upperlower-cli -u "InputCharacters"`
> - `dotnet tool uninstall upperlower-cli -g`

**`Tools`** : vs19, net core 3.1