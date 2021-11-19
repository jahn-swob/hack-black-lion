const path = require('path');
const HtmlWebPackPlugin = require("html-webpack-plugin");
const ModuleFederationPlugin = require("webpack/lib/container/ModuleFederationPlugin");

const deps = require("./package.json").dependencies;
module.exports = {
  entry: "./app/index.js",
  output: {
    path: path.resolve(__dirname, "wwwroot")
  },

  resolve: {
    extensions: [".jsx", ".js", ".json"],
  },

  devServer: {
    port: 3002,
  },

  module: {
    rules: [
      {
        test: /\.m?js/,
        type: "javascript/auto",
        resolve: {
          fullySpecified: false,
        },
      },
      {
        test: /\.css$/i,
        use: ["style-loader", "css-loader"],
      },
      {
        test: /\.(js|jsx)$/,
        exclude: /node_modules/,
        use: {
          loader: "babel-loader",
        },
      },
    ],
  },

  plugins: [
    new ModuleFederationPlugin({
      name: "checkout",
      filename: "remoteEntry.js",
      remotes: {
        "team-shell": "shell@https://localhost:3000/remoteEntry.js",
        "team-landing": "landing@https://localhost:3001/remoteEntry.js",
        "team-footers": "footers@https://localhost:3004/remoteEntry.js"
      },
      exposes: {
        "./Checkout": "./app/federated/Checkout",
        "./BuyButton": "./app/federated/BuyButton",
        "./Cart": "./app/federated/Cart",
      },
      shared: {
        ...deps,
        react: {
          singleton: true,
          requiredVersion: deps.react,
        },
        "react-dom": {
          singleton: true,
          requiredVersion: deps["react-dom"],
        },
      },
    }),
    new HtmlWebPackPlugin({
      template: "./app/index.html",
    }),
  ],
};
