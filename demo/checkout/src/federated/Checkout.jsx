import React from "react";
import { connect } from "react-redux";
import { Link } from "react-router-dom"
import "./../styles/index.css";

const Checkout = ({items}) => {
  return (
    <div className="checkoutPage">
      <h2>Checkout</h2>
      <div className="checkoutList">
      {
      items.length > 0 ? (items.map((item, index) => {
        return (
          <div className="checkoutProduct" key={item.name + index}>
            <div className="checkoutTitle">{item.name}</div>
        <div className="checkoutDescription">{item.description}</div>
            <div className="checkoutPrice">${item.price}</div>
          </div>
          )
      }) ) : ( <div className="empty-checkout"><p>Your car is empty</p><Link to='/'>Start Shopping</Link></div>) 
      }
      { items.length > 0 && <div className="checkoutTotal">{items.reduce((a, b) => (a + b.price), 0)}</div> }
      </div>
    </div>
  )
};

const mapStateToPros = state => ({
  items: state.items
})

export default connect(mapStateToPros)(Checkout);