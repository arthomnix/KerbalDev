# KerbalDev for Rider

Rider plugin for Kerbal Space Program 2 mod development.

Currently adds a project template for SpaceWarp mods, based on [munix's SpaceWarp .NET template](https://github.com/jan-bures/SpaceWarp.Template)
(this needs a plugin as Rider currently does not support custom project template parameters).

## Installation
Download the latest plugin file from Releases (`ReSharperPlugin.KerbalDev-x.x.x.zip`).

In Rider, go to Settings > Plugins, click the gear icon, click Install Plugin from Disk and select the zip file.

## Usage
In the New Solution window, a new SpaceWarp 0.4 Mod template should appear.
Fill out the parameters - **everything except Description and Source URL are required**; there is no validation due to limitations of Rider but if you omit the required parameters your project will be broken!
It is recommended that you enable the "Put project and solution in the same directory" option, otherwise your readme/license etc. will not be in the root of the solution.