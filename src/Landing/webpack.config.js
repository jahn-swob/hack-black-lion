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
        test: /\.jpe?g$|\.gif$|\.png$|\.PNG$|\.svg$|\.woff(2)?$|\.ttf$|\.eot$/,
        loader: 'file-loader',
        options: {
          name: '[name].[ext]'
        }  
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
      name: "landing",
      filename: "remoteEntry.js",
      remotes: {
        "team-shell": "shell@https://localhost:3000/remoteEntry.js",
        "team-landing": "landing@https://localhost:3001/remoteEntry.js",
        "team-checkout": "checkout@https://localhost:3002/remoteEntry.js",
        "team-footers": "footers@https://localhost:3004/remoteEntry.js",
        "team-productdetail": "productdetail@https://localhost:3009/remoteEntry.js"
      },
      exposes: {
        "./Landing": "./app/federated/Landing",
        "./MockedProducts": "./app/federated/mocks/products",
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
