// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

var path = require("path");

module.exports = {
    mode: "development",
    entry: {
        PopUp: "./src/PopUp.fs.js",
        Background: "./src/Background.fs.js",
        Content: "./src/Content.fs.js"
    },
    output: {
        path: path.join(__dirname, "./public"),
        filename: "[name].bundle.js",
    },
    devtool:"source-map",
    module: {
    }
}
