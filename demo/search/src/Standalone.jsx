import React from "react";
import { connect } from "react-redux";
import 'team-shell/BaseStyles';
import "./styles/index.css";

import { products } from 'team-landing/MockedProducts'

import Search from "./federated/Search";

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