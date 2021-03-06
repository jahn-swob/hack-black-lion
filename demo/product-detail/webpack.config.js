const HtmlWebPackPlugin = require("html-webpack-plugin");
const ModuleFederationPlugin = require("webpack/lib/container/ModuleFederationPlugin");

const deps = require("./package.json").dependencies;
module.exports = {
  output: {
    publicPath: "http://localhost:3009/",
  },

  resolve: {
    extensions: [".jsx", ".js", ".json"],
  },

  devServer: {
    port: 3009,
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
        loader: 'url-loader',
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
      name: "productdetail",
      filename: "remoteEntry.js",
      remotes: {
        "team-shell": "shell@http://localhost:3000/remoteEntry.js",
        "team-landing": "landing@http://localhost:3001/remoteEntry.js",
        "team-checkout": "checkout@http://localhost:3002/remoteEntry.js",
        "team-productdetail": "productdetail@http://localhost:3009/remoteEntry.js"
      },
      exposes: {
        "./ProductDetail": "./src/federated/ProductDetail",
        "./ViewProductDetailButton": "./src/federated/ViewProductDetailButton",
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
      template: "./src/index.html",
    }),
  ],
};
