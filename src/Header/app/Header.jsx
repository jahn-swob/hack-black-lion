
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
let imageName = require('./logo.png');

const Header = () => {
  return (
    <header>
      
      <nav>
      <div className="ecommerce-nav">
          <React.Suspense fallback={<div/>}>
            <Search />
          </React.Suspense>
        </div>
        <Link to='/'>
          <img src={ imageName.default } className="header-logo" alt="logo" /><br/>
          <span>By black lion</span>
        </Link>
        <div className="cart-nav">
          <React.Suspense fallback={<div />}>
            <Cart />
          </React.Suspense>
        </div>
      </nav>
    </header>
)}

export default Header;
