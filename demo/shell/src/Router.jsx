

import React from "react";
import ReactDOM from "react-dom";
import { BrowserRouter as Router, Switch, Route, Link, withRouter } from "react-router-dom";

const Landing = React.lazy(() => import("team-landing/Landing"));
const Checkout = React.lazy(() => import("team-checkout/Checkout"));
const Cart = React.lazy(() => import("team-checkout/Cart"));
const Header = React.lazy(() => import("header/Header"));

const LandingRoute = () => (
  <React.Suspense fallback={<div />}>
    <Landing />
  </React.Suspense>
);
const CheckoutRoute = () => (
  <React.Suspense fallback={<div />}>
    <Checkout />
  </React.Suspense>
);

const Routes = () => {
  return (
  <Router>
      <React.Suspense fallback={<div />}>
        <Header />
      </React.Suspense>
      <Switch>
        <Route path="/" exact>
          <LandingRoute />
        </Route>
        <Route path="/checkout">
          <CheckoutRoute />
        </Route>
      </Switch>
  </Router>)}

export default Routes;
