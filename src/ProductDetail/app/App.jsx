import React from "react";
import ReactDOM from "react-dom";
import { Provider } from "react-redux";
import "team-shell/BaseStyles";
import "./styles/index.css";

import store from "team-shell/Store";
import ProductDetail from "./federated/ProductDetail";

const ProductDetailStandalone = () => (
  <Provider store={store}>
    <ProductDetail  />
  </Provider>
);

ReactDOM.render(<ProductDetailStandalone />, document.getElementById("product-detail-app"));



