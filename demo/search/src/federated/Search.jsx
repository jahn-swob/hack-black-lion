import React from "react";
import { connect } from "react-redux";
import "./../styles/index.css";

const Search = ({items}) => {
  return (
    <div className="checkoutPage">
      <h2>Search</h2>
      <input
        placeholder="Search products..."
        type="text"
        value="testing testing 123..." />
    </div>
  )
};

const mapStateToPros = state => ({
  items: state.items
})

export default connect(mapStateToPros)(Search);