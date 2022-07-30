# Fable Firefox Extension Sample


## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 5.0 or higher
* [node.js](https://nodejs.org)
* An F# editor like Visual Studio, Visual Studio Code with [Ionide](http://ionide.io/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

## Building and testing the extension

* Install dependencies: `npm install`
* Build the extension project: `npm run-script build`
* Load the extension as a [temporary addon](https://extensionworkshop.com/documentation/develop/temporary-installation-in-firefox/).

Any modification you do to the F# code will be reflected in the web page after saving.

> Note: check the "scripts" section in `package.json` to see the commands triggered by the steps above.

## Bundling for release

Run the following command to compile and bundle up all your F# code into one Javascript file: `npm run build`. The compiled output ends up in the `public` folder under the name `bundle.js`.

## Project structure

### npm

JS dependencies are declared in `package.json`, while `package-lock.json` is a lock file automatically generated.

### Webpack

[Webpack](https://webpack.js.org) is a JS bundler with extensions, like a static dev server that enables hot reloading on code changes. Configuration for Webpack is defined in the `webpack.config.js` file. Note this sample only includes basic Webpack configuration for development mode, if you want to see a more comprehensive configuration check the [Fable webpack-config-template](https://github.com/fable-compiler/webpack-config-template/blob/master/webpack.config.js).

## Notes

### Browser Extension Structure

* Webpack controls the structure of output files. Check [entry point](https://webpack.js.org/concepts/entry-points/) and [output](https://webpack.js.org/concepts/output/) in webpack documentation for detailed information.

* manifest.json is not included in the template. Check Mozilla docs for how to create one.

### Eval Issues

* Webpack's [Devtools](https://webpack.js.org/configuration/devtool/) generates evals by default which is is not allowed by firefox's addon policy. Specify "source-map" to generate source map instead of evals.