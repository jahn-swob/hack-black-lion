
import React from "react";
import ReactDOM from "react-dom";
import { BrowserRouter as Router, Switch, Route, Link, withRouter } from "react-router-dom";
import "./styles/index.css";

const Landing = React.lazy(() => import("team-landing/Landing"));
const Checkout = React.lazy(() => import("team-checkout/Checkout"));
const Cart = React.lazy(() => import("team-checkout/Cart"));
const Search = React.lazy(() => import("search/search"));

const NavLinks = ({location}) => {
  return (
    <div className="links">
      <a href="/">
        Products
      </a>
      <a href="/checkout" >
        Checkout
      </a>
    </div>
  )
}

const LinksWrapper = withRouter(NavLinks)

const Header = () => {
  return (
    <header>
      <nav>
        <h2>Black Lion e-commerce</h2>
        <LinksWrapper />
        <div className="ecommerce-nav">
          
          <p>Search</p>
          <React.Suspense fallback={<div />}>
            <Cart />
          </React.Suspense>
        </div>
      </nav>
    </header>
)}

export default Header;
