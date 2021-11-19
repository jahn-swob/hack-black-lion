import React from "react";
import { connect } from "react-redux";
import 'team-shell/BaseStyles';
import "./styles/index.css";


import Search from "./federated/Search";
import { products } from 'team-landing/MockedProducts';

const Standalone = () => {
  return (
    <div className="site">
      <div className="checkoutPage">
        <Search />
      </div>
    </div>
  )
};

const mapStateToPros = state => ({
  items: state.items
})

export default connect(mapStateToPros, { "search": "search" })(Standalone);