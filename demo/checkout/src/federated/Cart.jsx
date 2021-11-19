import React, { useState } from "react";
import ReactDOM from "react-dom";
import { connect } from "react-redux";
import { Link } from "react-router-dom";
import "./../styles/index.css";

const ProductDetail = React.lazy(() => import("team-productdetail/ProductDetail"));

const Cart = ({ items}) => {
  const [toggle, setToggle] = useState('');
  const toggleCart = () => {
    if(toggle === ''){
      setToggle('opened')
    }
    else{
      setToggle('')
    }
  }

  const status = items.length ? '$' + items.reduce((a, b) => a + b.price, 0) : 'EMPTY'
    return (
      <>
      <div className="cartWrapper">
       
          <button className={`checkoutButton checkoutLink`} onClick={toggleCart}>
            <img src="https://cdn-icons-png.flaticon.com/512/3144/3144456.png" className="cart-icon"/>
            <span className={ items.length > 0 ? "content-count" : 'no-content'}>{ items.length }</span>
          </button>
        
      </div>
      <div className={`cart-drawer ${toggle}`}>
         <h1>Cart</h1>
         <button className="close-cart" onClick={toggleCart}>X</button>
         <div className="cart-product-list">
           {
             items.length > 0 ? <>{(items.map((item, index) => {
              return (
                <div className="single-product" key={item.name+index}>
                  <h3>{item.name}</h3>
                  <span>{item.price}</span>
                 </div>
                )
            }))} 
            <h2>Total: {items.reduce((a, b) => (a + b.price), 0)}</h2><br/><Link to="/checkout" >
            <button className={`checkoutButton`}>GO TO CHECKOUT</button></Link></> : 'Your cart is empty'
           }
         </div>
      </div>
      </>
    )
};

const mapStateToPros = state => ({
  items: state.items
})

export default connect(mapStateToPros)(Cart);