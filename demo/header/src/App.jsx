import React from "react";
import ReactDOM from "react-dom";
import { BrowserRouter as Router, Switch, Route, Link, withRouter } from "react-router-dom";
import { Provider } from "react-redux";
import Header from "./Header";

import "team-shell/BaseStyles";
import store from "team-shell/Store";

const HeaderStandalone = () => (
  <Provider store={store}>
    <Router>
      <Header  />
    </Router>
  </Provider>
);

ReactDOM.render(<HeaderStandalone />, document.getElementById("app"));

