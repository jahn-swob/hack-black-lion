import React from "react";
import ReactDOM from "react-dom";
import { Provider } from "react-redux";
import "./styles/index.css";
import store from "team-shell/Store";
import CheckoutFooter from "./federated/CheckoutFooter";

const FootersStandalone = () => (
  <Provider store={store}>
    <CheckoutFooter  />
  </Provider>
);

ReactDOM.render(<FootersStandalone />, document.getElementById("footer-app"));



