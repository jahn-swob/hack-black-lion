import React from "react";
import ReactDOM from "react-dom";
import { Provider } from "react-redux";
import { BrowserRouter as Router } from "react-router-dom";
import "./styles/index.css";
import CheckoutFooter from "./federated/CheckoutFooter";
import ProductFooter from "./federated/ProductFooter";
import store from "team-shell/Store";

// const FootersStandalone = () => (
//     <div>
//         <CheckoutFooter  />
//         <hr />
//         <ProductFooter  />
//     </div>
// );

const FootersStandalone = () => (
  <Provider store={store}>
    <Router>
        <CheckoutFooter  />
    </Router>
  </Provider>
);

ReactDOM.render(<FootersStandalone />, document.getElementById("footer-app"));



