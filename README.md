# Razor support for bridge.net

## Usage

1) Add nuget package (currently on myget https://www.myget.org/F/bridge-razor/api/v2 )
2) Create .cshtml files
3) use `RazorEngine.ExecuteViewToStringAsync("/Views/YourView.cshtml", model)`


See simple example [here](https://github.com/kekekeks/Bridge.Razor.Example).


## How it works

Your .cshtml files get transpiled to .cs before Bridge.Net does its magic. You can find intermediate files in `bin/$(Configuration)/Bridge.Razor`
