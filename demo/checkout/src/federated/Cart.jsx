import React from "react";
import ReactDOM from "react-dom";
import { connect } from "react-redux";
import { Link } from "react-router-dom";
import "./../styles/index.css";

const Cart = ({ items}) => {
  const status = items.length ? '$' + items.reduce((a, b) => a + b.price, 0) : 'EMPTY'
  if(status !== 'EMPTY'){
    return (
      <div className="cartWrapper">
        <Link to="/checkout" >
          <button className={`checkoutButton checkoutLink ${!items.length && 'disabled'}`}>CHECKOUT {status}</button>
        </Link>
        
      </div>
    )
  }else{
    return(
      <div className="cartWrapper">
        <p>Your cart is empty</p>
      </div>
    )
  }
};

const mapStateToPros = state => ({
  items: state.items
})

export default connect(mapStateToPros)(Cart);