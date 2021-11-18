import React from "react";
import ReactDOM from "react-dom";
import { Provider } from "react-redux";
import "team-shell/BaseStyles";
import "./styles/index.css";

import CheckoutFooter from "./federated/CheckoutFooter";
import store from "team-shell/Store";

const CheckOutFooterStandalone = () => (
  <Provider store={store}>
    <CheckoutFooter  />
  </Provider>
);

ReactDOM.render(<CheckOutFooterStandalone />, document.getElementById("landing-app"));