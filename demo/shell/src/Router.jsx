import React from "react";
import ReactDOM from "react-dom";
import { BrowserRouter as Router, Switch, Route, Link, withRouter } from "react-router-dom";

const Landing = React.lazy(() => import("team-landing/Landing"));
const Checkout = React.lazy(() => import("team-checkout/Checkout"));
const Cart = React.lazy(() => import("team-checkout/Cart"));
const ProductDetail = React.lazy(() => import("team-productdetail/ProductDetail"));
const Header = React.lazy(() => import("team-header/Header"));
const Footer = React.lazy(() => import("team-footers/ProductFooter"));
const CheckoutFooter = React.lazy(() => import("team-footers/CheckoutFooter"));

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
const ProductDetailRoute = () => (
  <React.Suspense fallback={<div />}>
    <ProductDetail />
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
          <React.Suspense fallback={<div />}>
            <CheckoutFooter />
          </React.Suspense>
        </Route>
        <Route path="/checkout">
          <CheckoutRoute />
        </Route>
      </Switch>
      <React.Suspense fallback={<div />}>
        <Footer />
      </React.Suspense>
  </Router>)}

export default Routes;
