
import React from "react";
import ReactDOM from "react-dom";
import { BrowserRouter as Router, Switch, Route, Link, withRouter } from "react-router-dom";
import "./styles/index.css";

const Cart = React.lazy(() => import("team-checkout/Cart"));
const Search = React.lazy(() => import("team-search/Search"));

const NavLinks = ({location}) => {
  return (
    <div className="nav-links">
      <Link to="/">
        Products
      </Link>
      { location.pathname !== '/checkout' && (
      <Link to="/checkout" >
        Checkout
      </Link>
      )}
    </div>
  )
}

const LinksWrapper = withRouter(NavLinks)

const Header = () => {
  return (
    <header>
      <nav>
        <h1>Black Lion</h1>
        <LinksWrapper />
        <div className="ecommerce-nav">
          <React.Suspense fallback={<div/>}>
            <Search />
          </React.Suspense>
          <React.Suspense fallback={<div />}>
            <Cart />
          </React.Suspense>
        </div>
      </nav>
    </header>
)}

export default Header;
